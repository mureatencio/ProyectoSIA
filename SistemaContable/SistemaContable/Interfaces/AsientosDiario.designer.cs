namespace SistemaContable.Interfaces
{
    partial class AsientosDiario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ButtonCancelar = new System.Windows.Forms.Button();
            this.ButtonGuardarSeguir = new System.Windows.Forms.Button();
            this.DataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.DataGridViewAsiento = new System.Windows.Forms.DataGridView();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Haber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtNumAsiento = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.ButtonGuardarCerrar = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.pnlCuentas = new System.Windows.Forms.Panel();
            this.bttnAgregar = new System.Windows.Forms.Button();
            this.cmbMoneda = new System.Windows.Forms.ComboBox();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.cmbCuenta = new System.Windows.Forms.ComboBox();
            this.lblCuenta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAsiento)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.pnlCuentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonCancelar
            // 
            this.ButtonCancelar.Location = new System.Drawing.Point(622, 326);
            this.ButtonCancelar.Name = "ButtonCancelar";
            this.ButtonCancelar.Size = new System.Drawing.Size(98, 23);
            this.ButtonCancelar.TabIndex = 25;
            this.ButtonCancelar.Text = "Volver";
            this.ButtonCancelar.UseVisualStyleBackColor = true;
            this.ButtonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // ButtonGuardarSeguir
            // 
            this.ButtonGuardarSeguir.Location = new System.Drawing.Point(414, 326);
            this.ButtonGuardarSeguir.Name = "ButtonGuardarSeguir";
            this.ButtonGuardarSeguir.Size = new System.Drawing.Size(98, 23);
            this.ButtonGuardarSeguir.TabIndex = 23;
            this.ButtonGuardarSeguir.Text = "Guardar y seguir";
            this.ButtonGuardarSeguir.UseVisualStyleBackColor = true;
            this.ButtonGuardarSeguir.Click += new System.EventHandler(this.ButtonGuardarSeguir_Click);
            // 
            // DataGridViewImageColumn1
            // 
            this.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1";
            this.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DataGridViewAsiento
            // 
            this.DataGridViewAsiento.AllowUserToAddRows = false;
            this.DataGridViewAsiento.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewAsiento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewAsiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewAsiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cuenta,
            this.Moneda,
            this.Debe,
            this.Haber,
            this.Eliminar});
            this.DataGridViewAsiento.Location = new System.Drawing.Point(25, 19);
            this.DataGridViewAsiento.Name = "DataGridViewAsiento";
            this.DataGridViewAsiento.Size = new System.Drawing.Size(695, 295);
            this.DataGridViewAsiento.TabIndex = 0;
            this.DataGridViewAsiento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewAsiento_CellClick);
            this.DataGridViewAsiento.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewAsiento_CellEndEdit);
            // 
            // Cuenta
            // 
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.Width = 225;
            // 
            // Moneda
            // 
            this.Moneda.HeaderText = "Moneda";
            this.Moneda.Name = "Moneda";
            this.Moneda.Width = 125;
            // 
            // Debe
            // 
            this.Debe.HeaderText = "Debe";
            this.Debe.Name = "Debe";
            // 
            // Haber
            // 
            this.Haber.HeaderText = "Haber";
            this.Haber.Name = "Haber";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            // 
            // txtNumAsiento
            // 
            this.txtNumAsiento.Enabled = false;
            this.txtNumAsiento.Location = new System.Drawing.Point(58, 17);
            this.txtNumAsiento.Name = "txtNumAsiento";
            this.txtNumAsiento.Size = new System.Drawing.Size(73, 20);
            this.txtNumAsiento.TabIndex = 6;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(7, 44);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(0, 13);
            this.Label5.TabIndex = 4;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(7, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(45, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Asiento:";
            // 
            // ButtonGuardarCerrar
            // 
            this.ButtonGuardarCerrar.Location = new System.Drawing.Point(518, 326);
            this.ButtonGuardarCerrar.Name = "ButtonGuardarCerrar";
            this.ButtonGuardarCerrar.Size = new System.Drawing.Size(98, 23);
            this.ButtonGuardarCerrar.TabIndex = 24;
            this.ButtonGuardarCerrar.Text = "Guardar y cerrar";
            this.ButtonGuardarCerrar.UseVisualStyleBackColor = true;
            this.ButtonGuardarCerrar.Click += new System.EventHandler(this.ButtonGuardarCerrar_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.DataGridViewAsiento);
            this.GroupBox2.Controls.Add(this.ButtonCancelar);
            this.GroupBox2.Controls.Add(this.ButtonGuardarSeguir);
            this.GroupBox2.Controls.Add(this.ButtonGuardarCerrar);
            this.GroupBox2.Location = new System.Drawing.Point(12, 144);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(747, 356);
            this.GroupBox2.TabIndex = 17;
            this.GroupBox2.TabStop = false;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtDetalle);
            this.GroupBox1.Controls.Add(this.lblDetalle);
            this.GroupBox1.Controls.Add(this.txtNumAsiento);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(747, 56);
            this.GroupBox1.TabIndex = 16;
            this.GroupBox1.TabStop = false;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(220, 17);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(500, 20);
            this.txtDetalle.TabIndex = 9;
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(171, 20);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(43, 13);
            this.lblDetalle.TabIndex = 8;
            this.lblDetalle.Text = "Detalle:";
            // 
            // pnlCuentas
            // 
            this.pnlCuentas.Controls.Add(this.bttnAgregar);
            this.pnlCuentas.Controls.Add(this.cmbMoneda);
            this.pnlCuentas.Controls.Add(this.lblMoneda);
            this.pnlCuentas.Controls.Add(this.cmbCuenta);
            this.pnlCuentas.Controls.Add(this.lblCuenta);
            this.pnlCuentas.Location = new System.Drawing.Point(12, 75);
            this.pnlCuentas.Name = "pnlCuentas";
            this.pnlCuentas.Size = new System.Drawing.Size(745, 63);
            this.pnlCuentas.TabIndex = 26;
            // 
            // bttnAgregar
            // 
            this.bttnAgregar.Location = new System.Drawing.Point(645, 18);
            this.bttnAgregar.Name = "bttnAgregar";
            this.bttnAgregar.Size = new System.Drawing.Size(75, 23);
            this.bttnAgregar.TabIndex = 4;
            this.bttnAgregar.Text = "Agregar";
            this.bttnAgregar.UseVisualStyleBackColor = true;
            this.bttnAgregar.Click += new System.EventHandler(this.bttnAgregar_Click);
            // 
            // cmbMoneda
            // 
            this.cmbMoneda.Enabled = false;
            this.cmbMoneda.FormattingEnabled = true;
            this.cmbMoneda.Location = new System.Drawing.Point(380, 20);
            this.cmbMoneda.Name = "cmbMoneda";
            this.cmbMoneda.Size = new System.Drawing.Size(206, 21);
            this.cmbMoneda.TabIndex = 3;
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Location = new System.Drawing.Point(330, 23);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(46, 13);
            this.lblMoneda.TabIndex = 2;
            this.lblMoneda.Text = "Moneda";
            // 
            // cmbCuenta
            // 
            this.cmbCuenta.FormattingEnabled = true;
            this.cmbCuenta.Location = new System.Drawing.Point(58, 20);
            this.cmbCuenta.Name = "cmbCuenta";
            this.cmbCuenta.Size = new System.Drawing.Size(232, 21);
            this.cmbCuenta.TabIndex = 1;
            this.cmbCuenta.SelectedValueChanged += new System.EventHandler(this.cmbCuenta_SelectedIndexChanged);
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Location = new System.Drawing.Point(10, 23);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(41, 13);
            this.lblCuenta.TabIndex = 0;
            this.lblCuenta.Text = "Cuenta";
            // 
            // AsientosDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 505);
            this.Controls.Add(this.pnlCuentas);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Name = "AsientosDiario";
            this.Text = "Ingreso de Asientos";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAsiento)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.pnlCuentas.ResumeLayout(false);
            this.pnlCuentas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button ButtonCancelar;
        internal System.Windows.Forms.Button ButtonGuardarSeguir;
        internal System.Windows.Forms.DataGridViewImageColumn DataGridViewImageColumn1;
        internal System.Windows.Forms.DataGridView DataGridViewAsiento;
        internal System.Windows.Forms.TextBox txtNumAsiento;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button ButtonGuardarCerrar;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Panel pnlCuentas;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Button bttnAgregar;
        private System.Windows.Forms.ComboBox cmbMoneda;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.ComboBox cmbCuenta;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Haber;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;


    }
}

