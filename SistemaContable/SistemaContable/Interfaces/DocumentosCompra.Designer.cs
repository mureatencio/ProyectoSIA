namespace SistemaContable.Interfaces
{
    partial class DocumentosCompra
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
            this.dtgrdDocumentos = new System.Windows.Forms.DataGridView();
            this.NumeroDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Socio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalImpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdDocumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrdDocumentos
            // 
            this.dtgrdDocumentos.AllowUserToAddRows = false;
            this.dtgrdDocumentos.AllowUserToDeleteRows = false;
            this.dtgrdDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdDocumentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroDoc,
            this.Fecha,
            this.TipoDocumento,
            this.Socio,
            this.Proyecto,
            this.Moneda,
            this.Total,
            this.Impuesto,
            this.TotalImpuesto,
            this.Ver,
            this.Seleccionar});
            this.dtgrdDocumentos.Location = new System.Drawing.Point(12, 12);
            this.dtgrdDocumentos.Name = "dtgrdDocumentos";
            this.dtgrdDocumentos.ReadOnly = true;
            this.dtgrdDocumentos.Size = new System.Drawing.Size(1004, 371);
            this.dtgrdDocumentos.TabIndex = 0;
            this.dtgrdDocumentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdDocumentos_CellContentClick);
            // 
            // NumeroDoc
            // 
            this.NumeroDoc.HeaderText = "Número Documento";
            this.NumeroDoc.Name = "NumeroDoc";
            this.NumeroDoc.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.HeaderText = "Tipo Documento";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            // 
            // Socio
            // 
            this.Socio.HeaderText = "Socio";
            this.Socio.Name = "Socio";
            this.Socio.ReadOnly = true;
            // 
            // Proyecto
            // 
            this.Proyecto.HeaderText = "Proyecto";
            this.Proyecto.Name = "Proyecto";
            this.Proyecto.ReadOnly = true;
            // 
            // Moneda
            // 
            this.Moneda.HeaderText = "Moneda";
            this.Moneda.Name = "Moneda";
            this.Moneda.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Impuesto
            // 
            this.Impuesto.HeaderText = "Impuesto";
            this.Impuesto.Name = "Impuesto";
            this.Impuesto.ReadOnly = true;
            // 
            // TotalImpuesto
            // 
            this.TotalImpuesto.HeaderText = "Total+Impuesto";
            this.TotalImpuesto.Name = "TotalImpuesto";
            this.TotalImpuesto.ReadOnly = true;
            // 
            // Ver
            // 
            this.Ver.HeaderText = "Ver";
            this.Ver.Name = "Ver";
            this.Ver.ReadOnly = true;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(941, 403);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 1;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // Documentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 436);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.dtgrdDocumentos);
            this.Name = "Documentos";
            this.Text = "Documentos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdDocumentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrdDocumentos;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Socio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalImpuesto;
        private System.Windows.Forms.DataGridViewButtonColumn Ver;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
    }
}