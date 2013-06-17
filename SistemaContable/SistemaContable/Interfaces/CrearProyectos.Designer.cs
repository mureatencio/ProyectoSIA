namespace SistemaContable.Interfaces
{
    partial class CrearProyectos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rchtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigoproyecto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreproyecto = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rchtxtDescripcion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCodigoproyecto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombreproyecto);
            this.groupBox1.Location = new System.Drawing.Point(34, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 309);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Proyecto";
            // 
            // rchtxtDescripcion
            // 
            this.rchtxtDescripcion.Location = new System.Drawing.Point(103, 182);
            this.rchtxtDescripcion.Name = "rchtxtDescripcion";
            this.rchtxtDescripcion.Size = new System.Drawing.Size(272, 96);
            this.rchtxtDescripcion.TabIndex = 5;
            this.rchtxtDescripcion.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripción:";
            // 
            // txtCodigoproyecto
            // 
            this.txtCodigoproyecto.Location = new System.Drawing.Point(141, 120);
            this.txtCodigoproyecto.Name = "txtCodigoproyecto";
            this.txtCodigoproyecto.Size = new System.Drawing.Size(234, 20);
            this.txtCodigoproyecto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código del Proyecto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del Proyecto:";
            // 
            // txtNombreproyecto
            // 
            this.txtNombreproyecto.Location = new System.Drawing.Point(141, 52);
            this.txtNombreproyecto.Name = "txtNombreproyecto";
            this.txtNombreproyecto.Size = new System.Drawing.Size(234, 20);
            this.txtNombreproyecto.TabIndex = 0;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(308, 346);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 1;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(405, 346);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // CrearProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 381);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.groupBox1);
            this.Name = "CrearProyectos";
            this.Text = "CrearProyectos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rchtxtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigoproyecto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreproyecto;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnSalir;
    }
}