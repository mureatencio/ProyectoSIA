namespace SistemaContable.Interfaces
{
    partial class VentanaBalanceGeneral
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
            this.buttonVerEstadoResultados = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPeriodoFin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPeriodoInicio = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Rubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVerEstadoResultados
            // 
            this.buttonVerEstadoResultados.Location = new System.Drawing.Point(558, 38);
            this.buttonVerEstadoResultados.Name = "buttonVerEstadoResultados";
            this.buttonVerEstadoResultados.Size = new System.Drawing.Size(75, 23);
            this.buttonVerEstadoResultados.TabIndex = 10;
            this.buttonVerEstadoResultados.Text = "Ver";
            this.buttonVerEstadoResultados.UseVisualStyleBackColor = true;
            this.buttonVerEstadoResultados.Click += new System.EventHandler(this.buttonVerEstadoResultados_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Periodo Fin";
            // 
            // comboBoxPeriodoFin
            // 
            this.comboBoxPeriodoFin.FormattingEnabled = true;
            this.comboBoxPeriodoFin.Location = new System.Drawing.Point(318, 40);
            this.comboBoxPeriodoFin.Name = "comboBoxPeriodoFin";
            this.comboBoxPeriodoFin.Size = new System.Drawing.Size(234, 21);
            this.comboBoxPeriodoFin.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Periodo Inicio";
            // 
            // comboBoxPeriodoInicio
            // 
            this.comboBoxPeriodoInicio.FormattingEnabled = true;
            this.comboBoxPeriodoInicio.Location = new System.Drawing.Point(39, 40);
            this.comboBoxPeriodoInicio.Name = "comboBoxPeriodoInicio";
            this.comboBoxPeriodoInicio.Size = new System.Drawing.Size(238, 21);
            this.comboBoxPeriodoInicio.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rubro,
            this.Monto,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(39, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(594, 260);
            this.dataGridView1.TabIndex = 11;
            // 
            // Rubro
            // 
            this.Rubro.HeaderText = "Rubro";
            this.Rubro.Name = "Rubro";
            this.Rubro.Width = 250;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.Width = 150;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.Width = 150;
            // 
            // VentanaBalanceGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 364);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonVerEstadoResultados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxPeriodoFin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPeriodoInicio);
            this.Name = "VentanaBalanceGeneral";
            this.Text = "Balance General";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVerEstadoResultados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPeriodoFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPeriodoInicio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}