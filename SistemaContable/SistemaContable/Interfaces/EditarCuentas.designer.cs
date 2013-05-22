namespace SistemaContable
{
    partial class vntEditarCuenta
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
            this.txtNombreInternacional = new System.Windows.Forms.TextBox();
            this.lblNombreInternacional = new System.Windows.Forms.Label();
            this.chckMonedaUnica = new System.Windows.Forms.CheckBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.cmbPadre = new System.Windows.Forms.ComboBox();
            this.lblPadre = new System.Windows.Forms.Label();
            this.chckTitulo = new System.Windows.Forms.CheckBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNumeroCuenta = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFiltroEd = new System.Windows.Forms.Button();
            this.cmbTipoCuentaEd = new System.Windows.Forms.ComboBox();
            this.lblTipoCuentaEd = new System.Windows.Forms.Label();
            this.lblMonedaEd = new System.Windows.Forms.Label();
            this.cmbMonedaFiltroEd = new System.Windows.Forms.ComboBox();
            this.lblNivelEd = new System.Windows.Forms.Label();
            this.cmbNivelEd = new System.Windows.Forms.ComboBox();
            this.cmbMonedaEd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreInternacional
            // 
            this.txtNombreInternacional.Location = new System.Drawing.Point(132, 63);
            this.txtNombreInternacional.Name = "txtNombreInternacional";
            this.txtNombreInternacional.Size = new System.Drawing.Size(259, 20);
            this.txtNombreInternacional.TabIndex = 16;
            // 
            // lblNombreInternacional
            // 
            this.lblNombreInternacional.AutoSize = true;
            this.lblNombreInternacional.Location = new System.Drawing.Point(18, 66);
            this.lblNombreInternacional.Name = "lblNombreInternacional";
            this.lblNombreInternacional.Size = new System.Drawing.Size(108, 13);
            this.lblNombreInternacional.TabIndex = 19;
            this.lblNombreInternacional.Text = "Nombre Internacional";
            // 
            // chckMonedaUnica
            // 
            this.chckMonedaUnica.AutoSize = true;
            this.chckMonedaUnica.Location = new System.Drawing.Point(244, 98);
            this.chckMonedaUnica.Name = "chckMonedaUnica";
            this.chckMonedaUnica.Size = new System.Drawing.Size(96, 17);
            this.chckMonedaUnica.TabIndex = 23;
            this.chckMonedaUnica.Text = "Moneda Única";
            this.chckMonedaUnica.UseVisualStyleBackColor = true;
            this.chckMonedaUnica.CheckedChanged += new System.EventHandler(this.chckMonedaUnica_CheckedChanged);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(316, 197);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 26;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // cmbPadre
            // 
            this.cmbPadre.FormattingEnabled = true;
            this.cmbPadre.Location = new System.Drawing.Point(68, 133);
            this.cmbPadre.Name = "cmbPadre";
            this.cmbPadre.Size = new System.Drawing.Size(323, 21);
            this.cmbPadre.TabIndex = 22;
            this.cmbPadre.Text = "None";
            this.cmbPadre.SelectedIndexChanged += new System.EventHandler(this.cmbPadre_SelectedIndexChanged);
            // 
            // lblPadre
            // 
            this.lblPadre.AutoSize = true;
            this.lblPadre.Location = new System.Drawing.Point(18, 136);
            this.lblPadre.Name = "lblPadre";
            this.lblPadre.Size = new System.Drawing.Size(35, 13);
            this.lblPadre.TabIndex = 28;
            this.lblPadre.Text = "Padre";
            // 
            // chckTitulo
            // 
            this.chckTitulo.AutoSize = true;
            this.chckTitulo.Location = new System.Drawing.Point(143, 99);
            this.chckTitulo.Name = "chckTitulo";
            this.chckTitulo.Size = new System.Drawing.Size(54, 17);
            this.chckTitulo.TabIndex = 21;
            this.chckTitulo.Text = "Título";
            this.chckTitulo.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(18, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 30;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(68, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(323, 20);
            this.txtNombre.TabIndex = 15;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(18, 98);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 18;
            this.lblCodigo.Text = "Código";
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.Enabled = false;
            this.txtNumeroCuenta.Location = new System.Drawing.Point(68, 95);
            this.txtNumeroCuenta.MaxLength = 3;
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.Size = new System.Drawing.Size(55, 20);
            this.txtNumeroCuenta.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFiltroEd);
            this.groupBox1.Controls.Add(this.cmbTipoCuentaEd);
            this.groupBox1.Controls.Add(this.lblTipoCuentaEd);
            this.groupBox1.Controls.Add(this.lblMonedaEd);
            this.groupBox1.Controls.Add(this.cmbMonedaFiltroEd);
            this.groupBox1.Controls.Add(this.lblNivelEd);
            this.groupBox1.Controls.Add(this.cmbNivelEd);
            this.groupBox1.Location = new System.Drawing.Point(429, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 216);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnFiltroEd
            // 
            this.btnFiltroEd.Location = new System.Drawing.Point(148, 175);
            this.btnFiltroEd.Name = "btnFiltroEd";
            this.btnFiltroEd.Size = new System.Drawing.Size(75, 23);
            this.btnFiltroEd.TabIndex = 16;
            this.btnFiltroEd.Text = "Filtrar";
            this.btnFiltroEd.UseVisualStyleBackColor = true;
            this.btnFiltroEd.Click += new System.EventHandler(this.btnFiltroEd_Click);
            // 
            // cmbTipoCuentaEd
            // 
            this.cmbTipoCuentaEd.FormattingEnabled = true;
            this.cmbTipoCuentaEd.Location = new System.Drawing.Point(92, 20);
            this.cmbTipoCuentaEd.Name = "cmbTipoCuentaEd";
            this.cmbTipoCuentaEd.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoCuentaEd.TabIndex = 15;
            // 
            // lblTipoCuentaEd
            // 
            this.lblTipoCuentaEd.AutoSize = true;
            this.lblTipoCuentaEd.Location = new System.Drawing.Point(6, 28);
            this.lblTipoCuentaEd.Name = "lblTipoCuentaEd";
            this.lblTipoCuentaEd.Size = new System.Drawing.Size(80, 13);
            this.lblTipoCuentaEd.TabIndex = 14;
            this.lblTipoCuentaEd.Text = "Tipo de Cuenta";
            // 
            // lblMonedaEd
            // 
            this.lblMonedaEd.AutoSize = true;
            this.lblMonedaEd.Location = new System.Drawing.Point(40, 134);
            this.lblMonedaEd.Name = "lblMonedaEd";
            this.lblMonedaEd.Size = new System.Drawing.Size(46, 13);
            this.lblMonedaEd.TabIndex = 11;
            this.lblMonedaEd.Text = "Moneda";
            // 
            // cmbMonedaFiltroEd
            // 
            this.cmbMonedaFiltroEd.FormattingEnabled = true;
            this.cmbMonedaFiltroEd.Location = new System.Drawing.Point(92, 131);
            this.cmbMonedaFiltroEd.Name = "cmbMonedaFiltroEd";
            this.cmbMonedaFiltroEd.Size = new System.Drawing.Size(121, 21);
            this.cmbMonedaFiltroEd.TabIndex = 7;
            this.cmbMonedaFiltroEd.Text = "None";
            // 
            // lblNivelEd
            // 
            this.lblNivelEd.AutoSize = true;
            this.lblNivelEd.Location = new System.Drawing.Point(55, 81);
            this.lblNivelEd.Name = "lblNivelEd";
            this.lblNivelEd.Size = new System.Drawing.Size(31, 13);
            this.lblNivelEd.TabIndex = 13;
            this.lblNivelEd.Text = "Nivel";
            // 
            // cmbNivelEd
            // 
            this.cmbNivelEd.FormattingEnabled = true;
            this.cmbNivelEd.Location = new System.Drawing.Point(92, 78);
            this.cmbNivelEd.Name = "cmbNivelEd";
            this.cmbNivelEd.Size = new System.Drawing.Size(121, 21);
            this.cmbNivelEd.TabIndex = 3;
            // 
            // cmbMonedaEd
            // 
            this.cmbMonedaEd.FormattingEnabled = true;
            this.cmbMonedaEd.Location = new System.Drawing.Point(68, 170);
            this.cmbMonedaEd.Name = "cmbMonedaEd";
            this.cmbMonedaEd.Size = new System.Drawing.Size(121, 21);
            this.cmbMonedaEd.TabIndex = 32;
            this.cmbMonedaEd.Text = "None";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Moneda";
            // 
            // vntEditarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 249);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMonedaEd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNombreInternacional);
            this.Controls.Add(this.lblNombreInternacional);
            this.Controls.Add(this.chckMonedaUnica);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.cmbPadre);
            this.Controls.Add(this.lblPadre);
            this.Controls.Add(this.chckTitulo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtNumeroCuenta);
            this.Name = "vntEditarCuenta";
            this.Text = "Editar Cuenta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreInternacional;
        private System.Windows.Forms.Label lblNombreInternacional;
        private System.Windows.Forms.CheckBox chckMonedaUnica;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ComboBox cmbPadre;
        private System.Windows.Forms.Label lblPadre;
        private System.Windows.Forms.CheckBox chckTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNumeroCuenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFiltroEd;
        private System.Windows.Forms.ComboBox cmbTipoCuentaEd;
        private System.Windows.Forms.Label lblTipoCuentaEd;
        private System.Windows.Forms.Label lblMonedaEd;
        private System.Windows.Forms.ComboBox cmbMonedaFiltroEd;
        private System.Windows.Forms.Label lblNivelEd;
        private System.Windows.Forms.ComboBox cmbNivelEd;
        private System.Windows.Forms.ComboBox cmbMonedaEd;
        private System.Windows.Forms.Label label1;
    }
}