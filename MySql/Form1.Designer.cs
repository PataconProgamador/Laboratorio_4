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
            lblFolio = new Label();
            lblNombre = new Label();
            lblPrecio = new Label();
            lblCantidad = new Label();
            dataGridView1 = new DataGridView();
            Folio = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            txtFolio = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            lblBusqueda = new Label();
            txtBusqueda = new TextBox();
            imageList1 = new ImageList(components);
            lblImagen = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnLimpiar = new Button();
            btnBorrar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(txtBusqueda);
            panel1.Controls.Add(lblBusqueda);
            panel1.Location = new Point(59, 289);
            panel1.Name = "panel1";
            panel1.Size = new Size(978, 150);
            panel1.TabIndex = 0;
            // 
            // lblFolio
            // 
            lblFolio.AutoSize = true;
            lblFolio.Location = new Point(60, 68);
            lblFolio.Name = "lblFolio";
            lblFolio.Size = new Size(66, 32);
            lblFolio.TabIndex = 1;
            lblFolio.Text = "Folio";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(59, 123);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(102, 32);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(58, 172);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(79, 32);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(58, 218);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(109, 32);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "Cantidad";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Folio, Nombre, Precio, Cantidad });
            dataGridView1.Location = new Point(107, 485);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(886, 186);
            dataGridView1.TabIndex = 5;
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
            txtFolio.Location = new Point(195, 62);
            txtFolio.Name = "txtFolio";
            txtFolio.Size = new Size(254, 39);
            txtFolio.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(195, 123);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(254, 39);
            txtNombre.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(195, 172);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(255, 39);
            txtPrecio.TabIndex = 8;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(195, 218);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(258, 39);
            txtCantidad.TabIndex = 9;
            // 
            // lblBusqueda
            // 
            lblBusqueda.AutoSize = true;
            lblBusqueda.Location = new Point(62, 54);
            lblBusqueda.Name = "lblBusqueda";
            lblBusqueda.Size = new Size(119, 32);
            lblBusqueda.TabIndex = 0;
            lblBusqueda.Text = "Búsqueda";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(229, 54);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(324, 39);
            txtBusqueda.TabIndex = 1;
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
            lblImagen.Location = new Point(585, 48);
            lblImagen.Name = "lblImagen";
            lblImagen.Size = new Size(99, 32);
            lblImagen.TabIndex = 10;
            lblImagen.Text = "Imagen:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.galeria_de_imagenes;
            pictureBox1.Location = new Point(770, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.buscar;
            pictureBox2.Location = new Point(597, 42);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // btnGuardar
            // 
            btnGuardar.ImageIndex = 3;
            btnGuardar.ImageList = imageList1;
            btnGuardar.Location = new Point(97, 744);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(143, 49);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guadar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.ImageIndex = 2;
            btnModificar.ImageList = imageList1;
            btnModificar.Location = new Point(303, 744);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(150, 49);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "Modificar";
            btnModificar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.ImageIndex = 0;
            btnLimpiar.ImageList = imageList1;
            btnLimpiar.Location = new Point(517, 744);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(150, 49);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.ImageIndex = 1;
            btnBorrar.ImageList = imageList1;
            btnBorrar.Location = new Point(742, 744);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(150, 49);
            btnBorrar.TabIndex = 15;
            btnBorrar.Text = "Borrar";
            btnBorrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 838);
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
            Controls.Add(dataGridView1);
            Controls.Add(lblCantidad);
            Controls.Add(lblPrecio);
            Controls.Add(lblNombre);
            Controls.Add(lblFolio);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
    }
}
