namespace SistemaContable.Interfaces
{
    partial class CatalogoCuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogoCuentas));
            this.txtNumeroCuenta = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.chckTitulo = new System.Windows.Forms.CheckBox();
            this.lblPadre = new System.Windows.Forms.Label();
            this.cmbPadre = new System.Windows.Forms.ComboBox();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.cmbMonedaFiltro = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dtCuentas = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaldoSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaldoLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.colCancelar = new System.Windows.Forms.DataGridViewImageColumn();
            this.chckMonedaUnica = new System.Windows.Forms.CheckBox();
            this.lblNombreInternacional = new System.Windows.Forms.Label();
            this.txtNombreInternacional = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.cmbTipoCuenta = new System.Windows.Forms.ComboBox();
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMoneda = new System.Windows.Forms.ComboBox();
            this.bttnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtCuentas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.Location = new System.Drawing.Point(101, 95);
            this.txtNumeroCuenta.MaxLength = 3;
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.Size = new System.Drawing.Size(55, 20);
            this.txtNumeroCuenta.TabIndex = 2;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(51, 98);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(101, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(323, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(51, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(55, 81);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(31, 13);
            this.lblNivel.TabIndex = 13;
            this.lblNivel.Text = "Nivel";
            // 
            // cmbNivel
            // 
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.Location = new System.Drawing.Point(92, 78);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(121, 21);
            this.cmbNivel.TabIndex = 3;
            // 
            // chckTitulo
            // 
            this.chckTitulo.AutoSize = true;
            this.chckTitulo.Location = new System.Drawing.Point(184, 98);
            this.chckTitulo.Name = "chckTitulo";
            this.chckTitulo.Size = new System.Drawing.Size(54, 17);
            this.chckTitulo.TabIndex = 4;
            this.chckTitulo.Text = "Título";
            this.chckTitulo.UseVisualStyleBackColor = true;
            // 
            // lblPadre
            // 
            this.lblPadre.AutoSize = true;
            this.lblPadre.Location = new System.Drawing.Point(51, 136);
            this.lblPadre.Name = "lblPadre";
            this.lblPadre.Size = new System.Drawing.Size(35, 13);
            this.lblPadre.TabIndex = 12;
            this.lblPadre.Text = "Padre";
            // 
            // cmbPadre
            // 
            this.cmbPadre.FormattingEnabled = true;
            this.cmbPadre.Location = new System.Drawing.Point(101, 133);
            this.cmbPadre.Name = "cmbPadre";
            this.cmbPadre.Size = new System.Drawing.Size(323, 21);
            this.cmbPadre.TabIndex = 5;
            this.cmbPadre.SelectedIndexChanged += new System.EventHandler(this.cmbPadre_SelectedIndexChanged);
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Location = new System.Drawing.Point(40, 134);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(46, 13);
            this.lblMoneda.TabIndex = 11;
            this.lblMoneda.Text = "Moneda";
            // 
            // cmbMonedaFiltro
            // 
            this.cmbMonedaFiltro.FormattingEnabled = true;
            this.cmbMonedaFiltro.Location = new System.Drawing.Point(92, 131);
            this.cmbMonedaFiltro.Name = "cmbMonedaFiltro";
            this.cmbMonedaFiltro.Size = new System.Drawing.Size(121, 21);
            this.cmbMonedaFiltro.TabIndex = 7;
            this.cmbMonedaFiltro.Text = "None";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(349, 197);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dtCuentas
            // 
            this.dtCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colCuenta,
            this.colSaldoSistema,
            this.colSaldoLocal,
            this.colCodMoneda,
            this.colEditar,
            this.colCancelar});
            this.dtCuentas.Location = new System.Drawing.Point(30, 244);
            this.dtCuentas.Name = "dtCuentas";
            this.dtCuentas.Size = new System.Drawing.Size(644, 271);
            this.dtCuentas.TabIndex = 11;
            this.dtCuentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            // 
            // colCuenta
            // 
            this.colCuenta.HeaderText = "Cuenta";
            this.colCuenta.Name = "colCuenta";
            // 
            // colSaldoSistema
            // 
            this.colSaldoSistema.HeaderText = "Saldo(Sistema)";
            this.colSaldoSistema.Name = "colSaldoSistema";
            // 
            // colSaldoLocal
            // 
            this.colSaldoLocal.HeaderText = "Saldo (Local)";
            this.colSaldoLocal.Name = "colSaldoLocal";
            // 
            // colCodMoneda
            // 
            this.colCodMoneda.HeaderText = "Cod. Moneda";
            this.colCodMoneda.Name = "colCodMoneda";
            // 
            // colEditar
            // 
            this.colEditar.HeaderText = "Editar";
            this.colEditar.Image = ((System.Drawing.Image)(resources.GetObject("colEditar.Image")));
            this.colEditar.Name = "colEditar";
            this.colEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colEditar.Width = 50;
            // 
            // colCancelar
            // 
            this.colCancelar.HeaderText = "Cancelar";
            this.colCancelar.Image = ((System.Drawing.Image)(resources.GetObject("colCancelar.Image")));
            this.colCancelar.Name = "colCancelar";
            this.colCancelar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCancelar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colCancelar.Width = 50;
            // 
            // chckMonedaUnica
            // 
            this.chckMonedaUnica.AutoSize = true;
            this.chckMonedaUnica.Location = new System.Drawing.Point(287, 97);
            this.chckMonedaUnica.Name = "chckMonedaUnica";
            this.chckMonedaUnica.Size = new System.Drawing.Size(96, 17);
            this.chckMonedaUnica.TabIndex = 6;
            this.chckMonedaUnica.Text = "Moneda Única";
            this.chckMonedaUnica.UseVisualStyleBackColor = true;
            this.chckMonedaUnica.CheckedChanged += new System.EventHandler(this.chckMonedaUnica_CheckedChanged);
            // 
            // lblNombreInternacional
            // 
            this.lblNombreInternacional.AutoSize = true;
            this.lblNombreInternacional.Location = new System.Drawing.Point(51, 66);
            this.lblNombreInternacional.Name = "lblNombreInternacional";
            this.lblNombreInternacional.Size = new System.Drawing.Size(108, 13);
            this.lblNombreInternacional.TabIndex = 2;
            this.lblNombreInternacional.Text = "Nombre Internacional";
            // 
            // txtNombreInternacional
            // 
            this.txtNombreInternacional.Location = new System.Drawing.Point(165, 63);
            this.txtNombreInternacional.Name = "txtNombreInternacional";
            this.txtNombreInternacional.Size = new System.Drawing.Size(259, 20);
            this.txtNombreInternacional.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFiltro);
            this.groupBox1.Controls.Add(this.cmbTipoCuenta);
            this.groupBox1.Controls.Add(this.lblTipoCuenta);
            this.groupBox1.Controls.Add(this.lblMoneda);
            this.groupBox1.Controls.Add(this.cmbMonedaFiltro);
            this.groupBox1.Controls.Add(this.lblNivel);
            this.groupBox1.Controls.Add(this.cmbNivel);
            this.groupBox1.Location = new System.Drawing.Point(447, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 216);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(148, 175);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnFiltro.TabIndex = 16;
            this.btnFiltro.Text = "Filtrar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // cmbTipoCuenta
            // 
            this.cmbTipoCuenta.FormattingEnabled = true;
            this.cmbTipoCuenta.Location = new System.Drawing.Point(92, 20);
            this.cmbTipoCuenta.Name = "cmbTipoCuenta";
            this.cmbTipoCuenta.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoCuenta.TabIndex = 15;
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.AutoSize = true;
            this.lblTipoCuenta.Location = new System.Drawing.Point(6, 28);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(80, 13);
            this.lblTipoCuenta.TabIndex = 14;
            this.lblTipoCuenta.Text = "Tipo de Cuenta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Moneda";
            // 
            // cmbMoneda
            // 
            this.cmbMoneda.FormattingEnabled = true;
            this.cmbMoneda.Location = new System.Drawing.Point(101, 175);
            this.cmbMoneda.Name = "cmbMoneda";
            this.cmbMoneda.Size = new System.Drawing.Size(121, 21);
            this.cmbMoneda.TabIndex = 17;
            this.cmbMoneda.Text = "None";
            // 
            // bttnVolver
            // 
            this.bttnVolver.Location = new System.Drawing.Point(599, 527);
            this.bttnVolver.Name = "bttnVolver";
            this.bttnVolver.Size = new System.Drawing.Size(75, 23);
            this.bttnVolver.TabIndex = 18;
            this.bttnVolver.Text = "Volver";
            this.bttnVolver.UseVisualStyleBackColor = true;
            this.bttnVolver.Click += new System.EventHandler(this.bttnAceptar_Click);
            // 
            // CatalogoCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 562);
            this.Controls.Add(this.bttnVolver);
            this.Controls.Add(this.cmbMoneda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNombreInternacional);
            this.Controls.Add(this.lblNombreInternacional);
            this.Controls.Add(this.chckMonedaUnica);
            this.Controls.Add(this.dtCuentas);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbPadre);
            this.Controls.Add(this.lblPadre);
            this.Controls.Add(this.chckTitulo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtNumeroCuenta);
            this.Name = "CatalogoCuentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo Cuentas";
            ((System.ComponentModel.ISupportInitialize)(this.dtCuentas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblPadre;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.Label lblNombreInternacional;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNombreInternacional;
        private System.Windows.Forms.TextBox txtNumeroCuenta;
        private System.Windows.Forms.ComboBox cmbNivel;
        private System.Windows.Forms.CheckBox chckTitulo;
        private System.Windows.Forms.ComboBox cmbPadre;
        private System.Windows.Forms.CheckBox chckMonedaUnica;
        private System.Windows.Forms.ComboBox cmbMonedaFiltro;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dtCuentas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.ComboBox cmbTipoCuenta;
        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaldoSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaldoLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodMoneda;
        private System.Windows.Forms.DataGridViewImageColumn colEditar;
        private System.Windows.Forms.DataGridViewImageColumn colCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMoneda;
        private System.Windows.Forms.Button bttnVolver;
    }
}

