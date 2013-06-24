namespace SistemaContable.Interfaces
{
    partial class Reportes
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
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.crstlRComprobacion = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.comboBoxPeriodoFin = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(595, 5);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(75, 23);
            this.btnGenerarReporte.TabIndex = 1;
            this.btnGenerarReporte.Text = "Generar";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // crstlRComprobacion
            // 
            this.crstlRComprobacion.ActiveViewIndex = -1;
            this.crstlRComprobacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crstlRComprobacion.Cursor = System.Windows.Forms.Cursors.Default;
            this.crstlRComprobacion.Location = new System.Drawing.Point(2, 39);
            this.crstlRComprobacion.Name = "crstlRComprobacion";
            this.crstlRComprobacion.Size = new System.Drawing.Size(916, 353);
            this.crstlRComprobacion.TabIndex = 5;
            this.crstlRComprobacion.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Location = new System.Drawing.Point(87, 12);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(146, 21);
            this.cmbPeriodo.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Periodo Inicio";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(843, 411);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 23;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // comboBoxPeriodoFin
            // 
            this.comboBoxPeriodoFin.FormattingEnabled = true;
            this.comboBoxPeriodoFin.Location = new System.Drawing.Point(318, 12);
            this.comboBoxPeriodoFin.Name = "comboBoxPeriodoFin";
            this.comboBoxPeriodoFin.Size = new System.Drawing.Size(146, 21);
            this.comboBoxPeriodoFin.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Periodo fin";
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 446);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxPeriodoFin);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPeriodo);
            this.Controls.Add(this.crstlRComprobacion);
            this.Controls.Add(this.btnGenerarReporte);
            this.Name = "Reportes";
            this.Text = "ReporteComprobación";
            this.Load += new System.EventHandler(this.ReporteComprobación_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarReporte;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crstlRComprobacion;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox comboBoxPeriodoFin;
        private System.Windows.Forms.Label label2;

    }
}