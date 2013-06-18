namespace SistemaContable.Interfaces
{
    partial class VerProyectos
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
            this.dtgrdProyectos = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.NombreProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdProyectos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrdProyectos
            // 
            this.dtgrdProyectos.AllowUserToAddRows = false;
            this.dtgrdProyectos.AllowUserToDeleteRows = false;
            this.dtgrdProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdProyectos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreProyecto,
            this.CodigoProyecto,
            this.Descripcion,
            this.Estado,
            this.FechaInicio});
            this.dtgrdProyectos.Location = new System.Drawing.Point(12, 22);
            this.dtgrdProyectos.Name = "dtgrdProyectos";
            this.dtgrdProyectos.ReadOnly = true;
            this.dtgrdProyectos.Size = new System.Drawing.Size(745, 310);
            this.dtgrdProyectos.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(682, 343);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // NombreProyecto
            // 
            this.NombreProyecto.HeaderText = "Nombre del Proyecto";
            this.NombreProyecto.Name = "NombreProyecto";
            this.NombreProyecto.ReadOnly = true;
            this.NombreProyecto.Width = 150;
            // 
            // CodigoProyecto
            // 
            this.CodigoProyecto.HeaderText = "Código del Proyecto";
            this.CodigoProyecto.Name = "CodigoProyecto";
            this.CodigoProyecto.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 250;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // FechaInicio
            // 
            this.FechaInicio.HeaderText = "Fecha Inicio";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            // 
            // VerProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 378);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtgrdProyectos);
            this.Name = "VerProyectos";
            this.Text = "VerProyectos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdProyectos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrdProyectos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
    }
}