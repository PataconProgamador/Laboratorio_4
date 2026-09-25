namespace MySql
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            txtBusqueda = new TextBox();
            lblBusqueda = new Label();
            lblFolio = new Label();
            lblNombre = new Label();
            lblPrecio = new Label();
            lblCantidad = new Label();
            dgvProductos = new DataGridView();
            Folio = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            txtFolio = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            imageList1 = new ImageList(components);
            lblImagen = new Label();
            pictureBox1 = new PictureBox();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnLimpiar = new Button();
            btnBorrar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(txtBusqueda);
            panel1.Controls.Add(lblBusqueda);
            panel1.Location = new Point(32, 140);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(527, 65);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.buscar;
            pictureBox2.Location = new Point(321, 20);
            pictureBox2.Margin = new Padding(2, 1, 2, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(123, 25);
            txtBusqueda.Margin = new Padding(2, 1, 2, 1);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(176, 23);
            txtBusqueda.TabIndex = 1;
            txtBusqueda.TextChanged += txtBusqueda_textChanged;
            // 
            // lblBusqueda
            // 
            lblBusqueda.AutoSize = true;
            lblBusqueda.Location = new Point(33, 25);
            lblBusqueda.Margin = new Padding(2, 0, 2, 0);
            lblBusqueda.Name = "lblBusqueda";
            lblBusqueda.Size = new Size(59, 15);
            lblBusqueda.TabIndex = 0;
            lblBusqueda.Text = "Búsqueda";
            // 
            // lblFolio
            // 
            lblFolio.AutoSize = true;
            lblFolio.Location = new Point(32, 32);
            lblFolio.Margin = new Padding(2, 0, 2, 0);
            lblFolio.Name = "lblFolio";
            lblFolio.Size = new Size(33, 15);
            lblFolio.TabIndex = 1;
            lblFolio.Text = "Folio";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(32, 58);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(32, 86);
            lblPrecio.Margin = new Padding(2, 0, 2, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(31, 110);
            lblCantidad.Margin = new Padding(2, 0, 2, 0);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "Cantidad";
            // 
            // dgvProductos
            // 
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { Folio, Nombre, Precio, Cantidad });
            dgvProductos.Location = new Point(74, 224);
            dgvProductos.Margin = new Padding(2, 1, 2, 1);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 50;
            dgvProductos.Size = new Size(423, 104);
            dgvProductos.TabIndex = 5;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // Folio
            // 
            Folio.HeaderText = "Folio";
            Folio.MinimumWidth = 10;
            Folio.Name = "Folio";
            Folio.Width = 200;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 10;
            Nombre.Name = "Nombre";
            Nombre.Width = 200;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 10;
            Precio.Name = "Precio";
            Precio.Width = 200;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 10;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 200;
            // 
            // txtFolio
            // 
            txtFolio.Location = new Point(105, 29);
            txtFolio.Margin = new Padding(2, 1, 2, 1);
            txtFolio.Name = "txtFolio";
            txtFolio.Size = new Size(139, 23);
            txtFolio.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(105, 54);
            txtNombre.Margin = new Padding(2, 1, 2, 1);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(139, 23);
            txtNombre.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(105, 79);
            txtPrecio.Margin = new Padding(2, 1, 2, 1);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(139, 23);
            txtPrecio.TabIndex = 8;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(104, 104);
            txtCantidad.Margin = new Padding(2, 1, 2, 1);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(141, 23);
            txtCantidad.TabIndex = 9;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "goma-de-borrar.png");
            imageList1.Images.SetKeyName(1, "eliminar.png");
            imageList1.Images.SetKeyName(2, "boton-editar.png");
            imageList1.Images.SetKeyName(3, "disquete.png");
            // 
            // lblImagen
            // 
            lblImagen.AutoSize = true;
            lblImagen.Location = new Point(315, 22);
            lblImagen.Margin = new Padding(2, 0, 2, 0);
            lblImagen.Name = "lblImagen";
            lblImagen.Size = new Size(50, 15);
            lblImagen.TabIndex = 10;
            lblImagen.Text = "Imagen:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.galeria_de_imagenes;
            pictureBox1.Location = new Point(415, 22);
            pictureBox1.Margin = new Padding(2, 1, 2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.ImageIndex = 3;
            btnGuardar.ImageList = imageList1;
            btnGuardar.Location = new Point(52, 349);
            btnGuardar.Margin = new Padding(2, 1, 2, 1);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(77, 23);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guadar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.ImageIndex = 2;
            btnModificar.ImageList = imageList1;
            btnModificar.Location = new Point(163, 349);
            btnModificar.Margin = new Padding(2, 1, 2, 1);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(81, 23);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "Modificar";
            btnModificar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.ImageIndex = 0;
            btnLimpiar.ImageList = imageList1;
            btnLimpiar.Location = new Point(278, 349);
            btnLimpiar.Margin = new Padding(2, 1, 2, 1);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(81, 23);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.ImageIndex = 1;
            btnBorrar.ImageList = imageList1;
            btnBorrar.Location = new Point(400, 349);
            btnBorrar.Margin = new Padding(2, 1, 2, 1);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(81, 23);
            btnBorrar.TabIndex = 15;
            btnBorrar.Text = "Borrar";
            btnBorrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 393);
            Controls.Add(btnBorrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(pictureBox1);
            Controls.Add(lblImagen);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(txtFolio);
            Controls.Add(dgvProductos);
            Controls.Add(lblCantidad);
            Controls.Add(lblPrecio);
            Controls.Add(lblNombre);
            Controls.Add(lblFolio);
            Controls.Add(panel1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblFolio;
        private Label lblNombre;
        private Label lblBusqueda;
        private Label lblPrecio;
        private Label lblCantidad;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Folio;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private TextBox txtFolio;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtCantidad;
        private TextBox txtBusqueda;
        private ImageList imageList1;
        private Label lblImagen;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnLimpiar;
        private Button btnBorrar;
        private DataGridView dgvProductos;
    }
}
