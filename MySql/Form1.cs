
using System.Drawing.Imaging;
namespace MySql
{
    public partial class Form1 : Form
    {
        //Crea Producto para Guardar los datos.
        //private Producto myNuevoProducto = new Producto();
        int idProducto = 0;
        private List<Producto> listaProductos;
        private Dictionary<string, object> myProducto = new Dictionary<string, object>();
        public Form1()
        {
            InitializeComponent();
            listaProductos = new List<Producto>();
        }
        private void cargarProductos(string filtro = "")
        {
            dgvProductos.Rows.Clear();
            dgvProductos.Refresh();
            listaProductos = Conexion.GetProducto(filtro);
            //Recorrido de la Lista de Productos
            foreach (var prod in listaProductos)
            {
                Image img = null;
                if (prod.Imagen != null && prod.Imagen.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(prod.Imagen))
                    {
                        using (Bitmap bmp = new Bitmap(ms))
                        {
                            img = new Bitmap(bmp); // Esto clona la imagen y evita que falle
                        }
                    }
                }
                dgvProductos.Rows.Add(prod.Id, prod.Nombre, prod.Precio, prod.Cantidad, img);

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cargarProductos();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (datosCorrectos())
            {
                return; //No hacemos nada -  se define en este punto, puedes crear un punto de interrupción
            }

            CargarDatosProductos();

            if (Conexion.InsertSeguro("productos", myProducto))
            {
                MessageBox.Show("Producto guardado correctamente.");
                // Aquí refrescas el gird volviendo a consultar la base de datos
                cargarProductos();
            }//Fin del insertSeguro
        }

        private void CargarDatosProductos()
        {
            myProducto.Clear();
            myProducto["Cantidad"] = int.Parse(txtCantidad.Text.Trim());
            myProducto["Nombre"] = txtNombre.Text.Trim();
            myProducto["Precio"] = decimal.Parse(txtPrecio.Text.Trim());
            myProducto["Imagen"] = ImageToByteArray(pictureBox1.Image);
        }

        private byte[] ImageToByteArray(Image? image)
        {
            if (image == null)
                return null;
            using (MemoryStream ms = new MemoryStream())
            {
                //Guardamos la imagen en su formato original (RawFormat)
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private bool datosCorrectos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del producto es obligatorio.");
                return true;
            }
            if (txtPrecio.Text.Trim().Equals(""))
            {
                MessageBox.Show("El precio es obligatorio.");
                return true;
            }
            if (txtCantidad.Text.Trim().Equals(""))
            {
                MessageBox.Show("La cantidad es obligatoria.");
                return true;
            }
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio < 0)
            {
                MessageBox.Show("El precio debe ser un número válido y no negativo.");
                return true;
            }
            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad < 0)
            {
                MessageBox.Show("La cantidad debe ser un número entero válido y no negativo.");
                return true;
            }
            return false; // Todos los datos son correctos
        }



        private void txtBusqueda_textChanged(object sender, EventArgs e)
        {
            cargarProductos(txtBusqueda.Text.Trim());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Seleccionar imagen del producto";
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Carga la imagen seleccionada en el PictureBox y me ajusta su tamaño
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];
            idProducto = 0;
            idProducto = Convert.ToInt32(fila.Cells[0].Value);
            txtNombre.Text = fila.Cells[1].Value.ToString();
            txtPrecio.Text = fila.Cells[2].Value.ToString();
            txtCantidad.Text = fila.Cells[3].Value.ToString();

            btnGuardar.Enabled = false;
            btnModificar.Enabled = true;
        }
        private void ModificarDatosBD()
        {
            CargarDatosProductos();
            //Asegurar que mi arreglo tiene los datos
            //MessageBox.Show("el Nombre del Producto es: " + myProducto["Nombre"]);
            // Actualiza el producto donde el id_producto sea igual a 5


            MessageBox.Show("el id del producto e: " + idProducto);

            bool resultado = Conexion.UpdateSeguro("productos", myProducto, "id", idProducto);

            if (resultado)
            {
                Console.WriteLine("Actualización exitosa.");
            }
        }

        private void limpiarFormulario()
        {
            txtFolio.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            txtBusqueda.Text = "";
            pictureBox1.Image = null;
            idProducto = 0;

            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // Validar que exista una selección activa
            if (idProducto == 0)
            {
                MessageBox.Show("Por favor, selecciona un producto de la lista para eliminar.");
                return;
            }

            // Pedir confirmación al usuario antes de borrar
            DialogResult confirmacion = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar este producto?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {
                // Ejecutar la eliminación
                if (Conexion.DeleteSeguro("productos", "id", idProducto))
                {
                    MessageBox.Show("Producto eliminado correctamente.");
                    cargarProductos();      // Recargar la tabla
                    limpiarFormulario();    // Resetear formulario
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al intentar eliminar el producto.");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Validar que haya un producto seleccionado
            if (idProducto == 0)
            {
                MessageBox.Show("Por favor, selecciona un producto del listado para modificar.");
                return;
            }

            // Validar que los campos de texto no tengan errores
            if (datosCorrectos())
            {
                return;
            }

            // Cargar los datos actuales de las cajas de texto en la estructura del diccionario
            CargarDatosProductos();

            // Ejecutar la actualización en MySQL
            if (Conexion.UpdateSeguro("productos", myProducto, "id", idProducto))
            {
                MessageBox.Show("Producto actualizado correctamente.");
                cargarProductos();      // Recargar la tabla
                limpiarFormulario();    // Resetear formulario
            }
            else
            {
                MessageBox.Show("Ocurrió un error al intentar modificar el producto.");
            }
        }
    }
}