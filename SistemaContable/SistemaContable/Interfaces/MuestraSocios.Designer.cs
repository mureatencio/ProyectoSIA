namespace SistemaContable.Interfaces
{
    partial class MuestraSocios
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
            this.dtgrdSocios = new System.Windows.Forms.DataGridView();
            this.CódigoSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LimiteCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CondicionPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VerDocumentos = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdSocios)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrdSocios
            // 
            this.dtgrdSocios.AllowUserToAddRows = false;
            this.dtgrdSocios.AllowUserToDeleteRows = false;
            this.dtgrdSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdSocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CódigoSocio,
            this.NombreSocio,
            this.TipoSocio,
            this.LimiteCredito,
            this.CodigoCuenta,
            this.SaldoLocal,
            this.CodigoMoneda,
            this.CondicionPago,
            this.VerDocumentos});
            this.dtgrdSocios.Location = new System.Drawing.Point(5, 13);
            this.dtgrdSocios.Name = "dtgrdSocios";
            this.dtgrdSocios.ReadOnly = true;
            this.dtgrdSocios.Size = new System.Drawing.Size(651, 295);
            this.dtgrdSocios.TabIndex = 0;
            this.dtgrdSocios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdSocios_CellContentClick);
            // 
            // CódigoSocio
            // 
            this.CódigoSocio.HeaderText = "Código Socio";
            this.CódigoSocio.Name = "CódigoSocio";
            this.CódigoSocio.ReadOnly = true;
            // 
            // NombreSocio
            // 
            this.NombreSocio.HeaderText = "Nombre";
            this.NombreSocio.Name = "NombreSocio";
            this.NombreSocio.ReadOnly = true;
            // 
            // TipoSocio
            // 
            this.TipoSocio.HeaderText = "Tipo Socio";
            this.TipoSocio.Name = "TipoSocio";
            this.TipoSocio.ReadOnly = true;
            // 
            // LimiteCredito
            // 
            this.LimiteCredito.HeaderText = "Límite Crédito";
            this.LimiteCredito.Name = "LimiteCredito";
            this.LimiteCredito.ReadOnly = true;
            // 
            // CodigoCuenta
            // 
            this.CodigoCuenta.HeaderText = "Codigo Cuenta";
            this.CodigoCuenta.Name = "CodigoCuenta";
            this.CodigoCuenta.ReadOnly = true;
            // 
            // SaldoLocal
            // 
            this.SaldoLocal.HeaderText = "Saldo Local";
            this.SaldoLocal.Name = "SaldoLocal";
            this.SaldoLocal.ReadOnly = true;
            // 
            // CodigoMoneda
            // 
            this.CodigoMoneda.HeaderText = "Codigo Moneda";
            this.CodigoMoneda.Name = "CodigoMoneda";
            this.CodigoMoneda.ReadOnly = true;
            // 
            // CondicionPago
            // 
            this.CondicionPago.HeaderText = "Condición de Pago";
            this.CondicionPago.Name = "CondicionPago";
            this.CondicionPago.ReadOnly = true;
            // 
            // VerDocumentos
            // 
            this.VerDocumentos.HeaderText = "Ver Documentos";
            this.VerDocumentos.Name = "VerDocumentos";
            this.VerDocumentos.ReadOnly = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(571, 314);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // MuestraSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 349);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtgrdSocios);
            this.Name = "MuestraSocios";
            this.Text = "MustraSocios";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdSocios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrdSocios;
        private System.Windows.Forms.DataGridViewTextBoxColumn CódigoSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn LimiteCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn CondicionPago;
        private System.Windows.Forms.DataGridViewButtonColumn VerDocumentos;
        private System.Windows.Forms.Button btnSalir;
    }
}