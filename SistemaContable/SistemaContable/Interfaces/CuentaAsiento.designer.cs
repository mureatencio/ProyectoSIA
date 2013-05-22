namespace SistemaContable.Interfaces
{
    partial class CuentaAsiento
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
            this.dtGrdVwCuentas = new System.Windows.Forms.DataGridView();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Haber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DebeLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HaberLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DebeSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HaberSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrdVwCuentas
            // 
            this.dtGrdVwCuentas.AllowUserToAddRows = false;
            this.dtGrdVwCuentas.AllowUserToDeleteRows = false;
            this.dtGrdVwCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cuenta,
            this.Moneda,
            this.Debe,
            this.Haber,
            this.DebeLocal,
            this.HaberLocal,
            this.DebeSistema,
            this.HaberSistema});
            this.dtGrdVwCuentas.Location = new System.Drawing.Point(14, 12);
            this.dtGrdVwCuentas.Name = "dtGrdVwCuentas";
            this.dtGrdVwCuentas.ReadOnly = true;
            this.dtGrdVwCuentas.Size = new System.Drawing.Size(897, 377);
            this.dtGrdVwCuentas.TabIndex = 2;
            // 
            // Cuenta
            // 
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.ReadOnly = true;
            this.Cuenta.Width = 150;
            // 
            // Moneda
            // 
            this.Moneda.HeaderText = "Moneda";
            this.Moneda.Name = "Moneda";
            this.Moneda.ReadOnly = true;
            // 
            // Debe
            // 
            this.Debe.HeaderText = "Debe";
            this.Debe.Name = "Debe";
            this.Debe.ReadOnly = true;
            // 
            // Haber
            // 
            this.Haber.HeaderText = "Haber";
            this.Haber.Name = "Haber";
            this.Haber.ReadOnly = true;
            // 
            // DebeLocal
            // 
            this.DebeLocal.HeaderText = "Debe Local";
            this.DebeLocal.Name = "DebeLocal";
            this.DebeLocal.ReadOnly = true;
            // 
            // HaberLocal
            // 
            this.HaberLocal.HeaderText = "Haber Local";
            this.HaberLocal.Name = "HaberLocal";
            this.HaberLocal.ReadOnly = true;
            // 
            // DebeSistema
            // 
            this.DebeSistema.HeaderText = "Debe Sistema";
            this.DebeSistema.Name = "DebeSistema";
            this.DebeSistema.ReadOnly = true;
            // 
            // HaberSistema
            // 
            this.HaberSistema.HeaderText = "Haber Sistema";
            this.HaberSistema.Name = "HaberSistema";
            this.HaberSistema.ReadOnly = true;
            // 
            // bttnRegresar
            // 
            this.bttnRegresar.Location = new System.Drawing.Point(836, 395);
            this.bttnRegresar.Name = "bttnRegresar";
            this.bttnRegresar.Size = new System.Drawing.Size(75, 23);
            this.bttnRegresar.TabIndex = 3;
            this.bttnRegresar.Text = "Aceptar";
            this.bttnRegresar.UseVisualStyleBackColor = true;
            this.bttnRegresar.Click += new System.EventHandler(this.bttnRegresar_Click);
            // 
            // CuentaAsiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 423);
            this.Controls.Add(this.bttnRegresar);
            this.Controls.Add(this.dtGrdVwCuentas);
            this.Name = "CuentaAsiento";
            this.Text = "Cuentas del Asiento";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwCuentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrdVwCuentas;
        private System.Windows.Forms.Button bttnRegresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Haber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DebeLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn HaberLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn DebeSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn HaberSistema;
    }
}