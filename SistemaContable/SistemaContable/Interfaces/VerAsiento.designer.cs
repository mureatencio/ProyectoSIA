namespace SistemaContable.Interfaces
{
    partial class VerAsiento
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
            this.dataGridViewResultadosFiltrar = new System.Windows.Forms.DataGridView();
            this.NumeroAsiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DebeLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HaberLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DebeSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HaberSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaContabilizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver = new System.Windows.Forms.DataGridViewImageColumn();
            this.Anular = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.bttnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultadosFiltrar)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewResultadosFiltrar
            // 
            this.dataGridViewResultadosFiltrar.AllowUserToAddRows = false;
            this.dataGridViewResultadosFiltrar.AllowUserToDeleteRows = false;
            this.dataGridViewResultadosFiltrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultadosFiltrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroAsiento,
            this.Detalle,
            this.DebeLocal,
            this.HaberLocal,
            this.DebeSistema,
            this.HaberSistema,
            this.FechaDocumento,
            this.FechaContabilizacion,
            this.Ver,
            this.Anular});
            this.dataGridViewResultadosFiltrar.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewResultadosFiltrar.Name = "dataGridViewResultadosFiltrar";
            this.dataGridViewResultadosFiltrar.Size = new System.Drawing.Size(985, 382);
            this.dataGridViewResultadosFiltrar.TabIndex = 1;
            this.dataGridViewResultadosFiltrar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResultadosFiltrar_CellContentClick);
            // 
            // NumeroAsiento
            // 
            this.NumeroAsiento.HeaderText = "Número Asiento";
            this.NumeroAsiento.Name = "NumeroAsiento";
            this.NumeroAsiento.ReadOnly = true;
            this.NumeroAsiento.Width = 70;
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            this.Detalle.Width = 200;
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
            // FechaDocumento
            // 
            this.FechaDocumento.HeaderText = "Fecha Documento";
            this.FechaDocumento.Name = "FechaDocumento";
            this.FechaDocumento.ReadOnly = true;
            // 
            // FechaContabilizacion
            // 
            this.FechaContabilizacion.HeaderText = "Fecha Contabilización";
            this.FechaContabilizacion.Name = "FechaContabilizacion";
            this.FechaContabilizacion.ReadOnly = true;
            // 
            // Ver
            // 
            this.Ver.HeaderText = "Ver";
            this.Ver.Name = "Ver";
            this.Ver.ReadOnly = true;
            this.Ver.Width = 30;
            // 
            // Anular
            // 
            this.Anular.HeaderText = "Anular";
            this.Anular.Name = "Anular";
            this.Anular.ReadOnly = true;
            this.Anular.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Anular.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Anular.Width = 40;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.bttnSalir);
            this.groupBox7.Controls.Add(this.dataGridViewResultadosFiltrar);
            this.groupBox7.Location = new System.Drawing.Point(7, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(997, 454);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Resultados";
            // 
            // bttnSalir
            // 
            this.bttnSalir.Location = new System.Drawing.Point(916, 425);
            this.bttnSalir.Name = "bttnSalir";
            this.bttnSalir.Size = new System.Drawing.Size(75, 23);
            this.bttnSalir.TabIndex = 2;
            this.bttnSalir.Text = "Volver";
            this.bttnSalir.UseVisualStyleBackColor = true;
            this.bttnSalir.Click += new System.EventHandler(this.bttnSalir_Click);
            // 
            // VerAsiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 478);
            this.Controls.Add(this.groupBox7);
            this.Name = "VerAsiento";
            this.Text = "Anular Asiento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultadosFiltrar)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewResultadosFiltrar;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button bttnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroAsiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn DebeLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn HaberLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn DebeSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn HaberSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaContabilizacion;
        private System.Windows.Forms.DataGridViewImageColumn Ver;
        private System.Windows.Forms.DataGridViewImageColumn Anular;
    }
}

