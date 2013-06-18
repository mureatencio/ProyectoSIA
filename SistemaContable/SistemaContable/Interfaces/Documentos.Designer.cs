namespace SistemaContable.Interfaces
{
    partial class Documentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTotalArticulos = new System.Windows.Forms.Label();
            this.labelTotalImpuesto = new System.Windows.Forms.Label();
            this.labelsj = new System.Windows.Forms.Label();
            this.dataGridViewDocumento = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImpuestos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotalLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSocio = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxProyecto = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.buttonAgregarArticulo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonAgregarProducto = new System.Windows.Forms.Button();
            this.textBoxComentarios = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.labelUnidad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPrecioProd = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxAgregarProducto = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocumento)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTotal);
            this.groupBox1.Controls.Add(this.labelTotalArticulos);
            this.groupBox1.Controls.Add(this.labelTotalImpuesto);
            this.groupBox1.Controls.Add(this.labelsj);
            this.groupBox1.Controls.Add(this.dataGridViewDocumento);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(21, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle artículos";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(468, 250);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(75, 13);
            this.labelTotal.TabIndex = 18;
            this.labelTotal.Text = "LABELTOTAL";
            // 
            // labelTotalArticulos
            // 
            this.labelTotalArticulos.AutoSize = true;
            this.labelTotalArticulos.Location = new System.Drawing.Point(468, 227);
            this.labelTotalArticulos.Name = "labelTotalArticulos";
            this.labelTotalArticulos.Size = new System.Drawing.Size(75, 13);
            this.labelTotalArticulos.TabIndex = 17;
            this.labelTotalArticulos.Text = "LABELTOTAL";
            // 
            // labelTotalImpuesto
            // 
            this.labelTotalImpuesto.AutoSize = true;
            this.labelTotalImpuesto.Location = new System.Drawing.Point(293, 227);
            this.labelTotalImpuesto.Name = "labelTotalImpuesto";
            this.labelTotalImpuesto.Size = new System.Drawing.Size(75, 13);
            this.labelTotalImpuesto.TabIndex = 16;
            this.labelTotalImpuesto.Text = "LABELTOTAL";
            this.labelTotalImpuesto.Click += new System.EventHandler(this.labelTotalImpuesto_Click);
            // 
            // labelsj
            // 
            this.labelsj.AutoSize = true;
            this.labelsj.Location = new System.Drawing.Point(377, 227);
            this.labelsj.Name = "labelsj";
            this.labelsj.Size = new System.Drawing.Size(78, 13);
            this.labelsj.TabIndex = 15;
            this.labelsj.Text = "Total artículos:";
            // 
            // dataGridViewDocumento
            // 
            this.dataGridViewDocumento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDocumento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnNombre,
            this.ColumnCantidad,
            this.ColumnPrecio,
            this.ColumnImpuestos,
            this.ColumnTotalLinea,
            this.ColumnEliminar});
            this.dataGridViewDocumento.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewDocumento.Name = "dataGridViewDocumento";
            this.dataGridViewDocumento.Size = new System.Drawing.Size(593, 194);
            this.dataGridViewDocumento.TabIndex = 0;
            this.dataGridViewDocumento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Codigo";
            this.ColumnCodigo.MaxInputLength = 20;
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            this.ColumnCodigo.Width = 50;
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.Name = "ColumnNombre";
            this.ColumnNombre.ReadOnly = true;
            // 
            // ColumnCantidad
            // 
            this.ColumnCantidad.HeaderText = "Cantidad";
            this.ColumnCantidad.MaxInputLength = 10;
            this.ColumnCantidad.Name = "ColumnCantidad";
            this.ColumnCantidad.Width = 50;
            // 
            // ColumnPrecio
            // 
            this.ColumnPrecio.HeaderText = "Precio";
            this.ColumnPrecio.Name = "ColumnPrecio";
            this.ColumnPrecio.ReadOnly = true;
            // 
            // ColumnImpuestos
            // 
            this.ColumnImpuestos.HeaderText = "Impuestos";
            this.ColumnImpuestos.Name = "ColumnImpuestos";
            this.ColumnImpuestos.ReadOnly = true;
            // 
            // ColumnTotalLinea
            // 
            this.ColumnTotalLinea.HeaderText = "Total";
            this.ColumnTotalLinea.Name = "ColumnTotalLinea";
            this.ColumnTotalLinea.ReadOnly = true;
            // 
            // ColumnEliminar
            // 
            this.ColumnEliminar.HeaderText = "Borrar";
            this.ColumnEliminar.Name = "ColumnEliminar";
            this.ColumnEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnEliminar.Width = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Impuestos:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total:";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(122, 12);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tipo de documento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Socio:";
            // 
            // comboBoxSocio
            // 
            this.comboBoxSocio.FormattingEnabled = true;
            this.comboBoxSocio.Location = new System.Drawing.Point(122, 41);
            this.comboBoxSocio.Name = "comboBoxSocio";
            this.comboBoxSocio.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSocio.TabIndex = 8;
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(317, 12);
            this.dateTimePickerFecha.MaxDate = new System.DateTime(2199, 11, 28, 0, 0, 0, 0);
            this.dateTimePickerFecha.MinDate = new System.DateTime(2013, 6, 17, 0, 0, 0, 0);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(191, 20);
            this.dateTimePickerFecha.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(259, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Proyecto:";
            // 
            // comboBoxProyecto
            // 
            this.comboBoxProyecto.FormattingEnabled = true;
            this.comboBoxProyecto.Location = new System.Drawing.Point(317, 41);
            this.comboBoxProyecto.Name = "comboBoxProyecto";
            this.comboBoxProyecto.Size = new System.Drawing.Size(113, 21);
            this.comboBoxProyecto.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Crear documento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cargar Orden de Venta...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(164, 386);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(79, 21);
            this.comboBox5.TabIndex = 17;
            // 
            // buttonAgregarArticulo
            // 
            this.buttonAgregarArticulo.Location = new System.Drawing.Point(466, 41);
            this.buttonAgregarArticulo.Name = "buttonAgregarArticulo";
            this.buttonAgregarArticulo.Size = new System.Drawing.Size(98, 23);
            this.buttonAgregarArticulo.TabIndex = 18;
            this.buttonAgregarArticulo.Text = "Agregar articulo";
            this.buttonAgregarArticulo.UseVisualStyleBackColor = true;
            this.buttonAgregarArticulo.Click += new System.EventHandler(this.buttonAgregarArticulo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.buttonAgregarProducto);
            this.groupBox2.Controls.Add(this.textBoxComentarios);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.labelUnidad);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.labelPrecioProd);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.labelNombre);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBoxDescripcion);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.comboBoxAgregarProducto);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(646, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 347);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar Producto";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(444, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonAgregarProducto
            // 
            this.buttonAgregarProducto.Location = new System.Drawing.Point(31, 285);
            this.buttonAgregarProducto.Name = "buttonAgregarProducto";
            this.buttonAgregarProducto.Size = new System.Drawing.Size(69, 23);
            this.buttonAgregarProducto.TabIndex = 30;
            this.buttonAgregarProducto.Text = "Agregar";
            this.buttonAgregarProducto.UseVisualStyleBackColor = true;
            this.buttonAgregarProducto.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBoxComentarios
            // 
            this.textBoxComentarios.Location = new System.Drawing.Point(87, 149);
            this.textBoxComentarios.Multiline = true;
            this.textBoxComentarios.Name = "textBoxComentarios";
            this.textBoxComentarios.ReadOnly = true;
            this.textBoxComentarios.Size = new System.Drawing.Size(176, 56);
            this.textBoxComentarios.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Comentarios:";
            // 
            // labelUnidad
            // 
            this.labelUnidad.AutoSize = true;
            this.labelUnidad.Location = new System.Drawing.Point(84, 237);
            this.labelUnidad.Name = "labelUnidad";
            this.labelUnidad.Size = new System.Drawing.Size(35, 13);
            this.labelUnidad.TabIndex = 27;
            this.labelUnidad.Text = "Horas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Unidad:";
            // 
            // labelPrecioProd
            // 
            this.labelPrecioProd.AutoSize = true;
            this.labelPrecioProd.Location = new System.Drawing.Point(84, 214);
            this.labelPrecioProd.Name = "labelPrecioProd";
            this.labelPrecioProd.Size = new System.Drawing.Size(59, 13);
            this.labelPrecioProd.TabIndex = 25;
            this.labelPrecioProd.Text = "PrecioProd";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Precio:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(84, 52);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(66, 13);
            this.labelNombre.TabIndex = 23;
            this.labelNombre.Text = "NombreProd";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Nombre:";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(87, 77);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.ReadOnly = true;
            this.textBoxDescripcion.Size = new System.Drawing.Size(176, 56);
            this.textBoxDescripcion.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Descripción:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(28, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Producto:";
            // 
            // comboBoxAgregarProducto
            // 
            this.comboBoxAgregarProducto.FormattingEnabled = true;
            this.comboBoxAgregarProducto.Location = new System.Drawing.Point(87, 21);
            this.comboBoxAgregarProducto.Name = "comboBoxAgregarProducto";
            this.comboBoxAgregarProducto.Size = new System.Drawing.Size(176, 21);
            this.comboBoxAgregarProducto.TabIndex = 18;
            this.comboBoxAgregarProducto.SelectedIndexChanged += new System.EventHandler(this.comboBoxAgregarProducto_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(149, 214);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 107);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Documentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 417);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonAgregarArticulo);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxProyecto);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSocio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.groupBox1);
            this.Name = "Documentos";
            this.Text = "Documentos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocumento)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSocio;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        public System.Windows.Forms.DataGridView dataGridViewDocumento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxProyecto;
        private System.Windows.Forms.Label labelsj;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTotalArticulos;
        private System.Windows.Forms.Label labelTotalImpuesto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImpuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotalLinea;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnEliminar;
        private System.Windows.Forms.Button buttonAgregarArticulo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonAgregarProducto;
        private System.Windows.Forms.TextBox textBoxComentarios;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelUnidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPrecioProd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxAgregarProducto;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}