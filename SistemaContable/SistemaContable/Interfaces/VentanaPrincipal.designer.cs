namespace SistemaContable.Interfaces
{
    partial class VentanaPrincipal
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
            this.menuVentanaPrincipal = new System.Windows.Forms.MenuStrip();
            this.cuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearAsientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAsientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cierresContablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBalanceDeComprobaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoDeResultadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarNuevoSocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verSocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarServicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblF = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.documentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
=======
            this.proyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verProyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
>>>>>>> origin/Compras-y-ventas
            this.menuVentanaPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuVentanaPrincipal
            // 
            this.menuVentanaPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentasToolStripMenuItem,
            this.asientosToolStripMenuItem,
            this.cierresContablesToolStripMenuItem,
            this.reportesToolStripMenuItem,
<<<<<<< HEAD
            this.sociosToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.serviciosToolStripMenuItem,
            this.documentosToolStripMenuItem});
=======
            this.proyectosToolStripMenuItem,
            this.sociosToolStripMenuItem,
            this.serviciosToolStripMenuItem,
            this.documentosToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.configuraciónToolStripMenuItem});
>>>>>>> origin/Compras-y-ventas
            this.menuVentanaPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuVentanaPrincipal.Name = "menuVentanaPrincipal";
            this.menuVentanaPrincipal.Size = new System.Drawing.Size(768, 24);
            this.menuVentanaPrincipal.TabIndex = 0;
            this.menuVentanaPrincipal.Text = "menuStrip1";
            // 
            // cuentasToolStripMenuItem
            // 
            this.cuentasToolStripMenuItem.Name = "cuentasToolStripMenuItem";
            this.cuentasToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.cuentasToolStripMenuItem.Text = "Cuentas";
            this.cuentasToolStripMenuItem.Click += new System.EventHandler(this.cuentasToolStripMenuItem_Click);
            // 
            // asientosToolStripMenuItem
            // 
            this.asientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearAsientoToolStripMenuItem,
            this.verAsientosToolStripMenuItem});
            this.asientosToolStripMenuItem.Name = "asientosToolStripMenuItem";
            this.asientosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.asientosToolStripMenuItem.Text = "Asientos";
            // 
            // crearAsientoToolStripMenuItem
            // 
            this.crearAsientoToolStripMenuItem.Name = "crearAsientoToolStripMenuItem";
            this.crearAsientoToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.crearAsientoToolStripMenuItem.Text = "Crear Asiento";
            this.crearAsientoToolStripMenuItem.Click += new System.EventHandler(this.crearAsientoToolStripMenuItem_Click);
            // 
            // verAsientosToolStripMenuItem
            // 
            this.verAsientosToolStripMenuItem.Name = "verAsientosToolStripMenuItem";
            this.verAsientosToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.verAsientosToolStripMenuItem.Text = "Ver Asientos";
            this.verAsientosToolStripMenuItem.Click += new System.EventHandler(this.verAsientosToolStripMenuItem_Click);
            // 
            // cierresContablesToolStripMenuItem
            // 
            this.cierresContablesToolStripMenuItem.Name = "cierresContablesToolStripMenuItem";
            this.cierresContablesToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.cierresContablesToolStripMenuItem.Text = "Cierre Contable";
            this.cierresContablesToolStripMenuItem.Click += new System.EventHandler(this.cierresContablesToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBalanceDeComprobaciónToolStripMenuItem,
            this.estadoDeResultadosToolStripMenuItem,
            this.balanceGeneralToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // aBalanceDeComprobaciónToolStripMenuItem
            // 
            this.aBalanceDeComprobaciónToolStripMenuItem.Name = "aBalanceDeComprobaciónToolStripMenuItem";
            this.aBalanceDeComprobaciónToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.aBalanceDeComprobaciónToolStripMenuItem.Text = "Balance de comprobación";
            this.aBalanceDeComprobaciónToolStripMenuItem.Click += new System.EventHandler(this.aBalanceDeComprobaciónToolStripMenuItem_Click);
            // 
            // estadoDeResultadosToolStripMenuItem
            // 
            this.estadoDeResultadosToolStripMenuItem.Name = "estadoDeResultadosToolStripMenuItem";
            this.estadoDeResultadosToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.estadoDeResultadosToolStripMenuItem.Text = "Estado de resultados";
            this.estadoDeResultadosToolStripMenuItem.Click += new System.EventHandler(this.estadoDeResultadosToolStripMenuItem_Click);
            // 
            // balanceGeneralToolStripMenuItem
            // 
            this.balanceGeneralToolStripMenuItem.Name = "balanceGeneralToolStripMenuItem";
            this.balanceGeneralToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.balanceGeneralToolStripMenuItem.Text = "Balance general";
            this.balanceGeneralToolStripMenuItem.Click += new System.EventHandler(this.balanceGeneralToolStripMenuItem_Click);
            // 
            // sociosToolStripMenuItem
            // 
            this.sociosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarNuevoSocioToolStripMenuItem,
            this.verSocioToolStripMenuItem});
            this.sociosToolStripMenuItem.Name = "sociosToolStripMenuItem";
            this.sociosToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.sociosToolStripMenuItem.Text = "Socios";
            // 
            // ingresarNuevoSocioToolStripMenuItem
            // 
            this.ingresarNuevoSocioToolStripMenuItem.Name = "ingresarNuevoSocioToolStripMenuItem";
            this.ingresarNuevoSocioToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ingresarNuevoSocioToolStripMenuItem.Text = "Ingresar Nuevo Socio";
            this.ingresarNuevoSocioToolStripMenuItem.Click += new System.EventHandler(this.ingresarNuevoSocioToolStripMenuItem_Click);
            // 
            // verSocioToolStripMenuItem
            // 
            this.verSocioToolStripMenuItem.Name = "verSocioToolStripMenuItem";
            this.verSocioToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.verSocioToolStripMenuItem.Text = "Ver Socio";
            this.verSocioToolStripMenuItem.Click += new System.EventHandler(this.verSocioToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            this.configuraciónToolStripMenuItem.Click += new System.EventHandler(this.configuraciónToolStripMenuItem_Click);
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarServicioToolStripMenuItem});
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.serviciosToolStripMenuItem.Text = "Servicios";
            // 
            // agregarServicioToolStripMenuItem
            // 
            this.agregarServicioToolStripMenuItem.Name = "agregarServicioToolStripMenuItem";
            this.agregarServicioToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.agregarServicioToolStripMenuItem.Text = "Agregar Servicio";
            this.agregarServicioToolStripMenuItem.Click += new System.EventHandler(this.agregarServicioToolStripMenuItem_Click);
            // 
            // documentosToolStripMenuItem
            // 
            this.documentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearDocumentoToolStripMenuItem});
            this.documentosToolStripMenuItem.Name = "documentosToolStripMenuItem";
            this.documentosToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.documentosToolStripMenuItem.Text = "Ventas";
            // 
            // crearDocumentoToolStripMenuItem
            // 
            this.crearDocumentoToolStripMenuItem.Name = "crearDocumentoToolStripMenuItem";
            this.crearDocumentoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.crearDocumentoToolStripMenuItem.Text = "Nueva Venta";
            this.crearDocumentoToolStripMenuItem.Click += new System.EventHandler(this.crearDocumentoToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaCompraToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // nuevaCompraToolStripMenuItem
            // 
            this.nuevaCompraToolStripMenuItem.Name = "nuevaCompraToolStripMenuItem";
            this.nuevaCompraToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.nuevaCompraToolStripMenuItem.Text = "Nueva Compra";
            this.nuevaCompraToolStripMenuItem.Click += new System.EventHandler(this.nuevaCompraToolStripMenuItem_Click);
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Location = new System.Drawing.Point(369, 48);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(101, 23);
            this.lblEmpresa.TabIndex = 4;
            this.lblEmpresa.Text = "Empresa: ";
            // 
            // logoBox
            // 
            this.logoBox.Location = new System.Drawing.Point(12, 48);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(315, 212);
            this.logoBox.TabIndex = 5;
            this.logoBox.TabStop = false;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(369, 80);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(158, 23);
            this.lblCedula.TabIndex = 6;
            this.lblCedula.Text = "Cédula Jurídica: ";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(369, 112);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(96, 23);
            this.lblTel.TabIndex = 8;
            this.lblTel.Text = "Teléfono: ";
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF.Location = new System.Drawing.Point(369, 145);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(54, 23);
            this.lblF.TabIndex = 10;
            this.lblF.Text = "Fax: ";
            // 
            // documentosToolStripMenuItem
            // 
<<<<<<< HEAD
            this.documentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearDocumentoToolStripMenuItem});
            this.documentosToolStripMenuItem.Name = "documentosToolStripMenuItem";
            this.documentosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.documentosToolStripMenuItem.Text = "Documentos";
            // 
            // crearDocumentoToolStripMenuItem
            // 
            this.crearDocumentoToolStripMenuItem.Name = "crearDocumentoToolStripMenuItem";
            this.crearDocumentoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.crearDocumentoToolStripMenuItem.Text = "Crear Documento";
            this.crearDocumentoToolStripMenuItem.Click += new System.EventHandler(this.crearDocumentoToolStripMenuItem_Click);
=======
            this.proyectosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearProyectoToolStripMenuItem,
            this.verProyectosToolStripMenuItem});
            this.proyectosToolStripMenuItem.Name = "proyectosToolStripMenuItem";
            this.proyectosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.proyectosToolStripMenuItem.Text = "Proyectos";
            // 
            // crearProyectoToolStripMenuItem
            // 
            this.crearProyectoToolStripMenuItem.Name = "crearProyectoToolStripMenuItem";
            this.crearProyectoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.crearProyectoToolStripMenuItem.Text = "Agregar Proyecto";
            this.crearProyectoToolStripMenuItem.Click += new System.EventHandler(this.crearProyectoToolStripMenuItem_Click);
            // 
            // verProyectosToolStripMenuItem
            // 
            this.verProyectosToolStripMenuItem.Name = "verProyectosToolStripMenuItem";
            this.verProyectosToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.verProyectosToolStripMenuItem.Text = "Ver Proyectos";
            this.verProyectosToolStripMenuItem.Click += new System.EventHandler(this.verProyectosToolStripMenuItem_Click);
>>>>>>> origin/Compras-y-ventas
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 272);
            this.Controls.Add(this.lblF);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.menuVentanaPrincipal);
            this.Name = "VentanaPrincipal";
            this.Text = "Ventana Principal";
            this.menuVentanaPrincipal.ResumeLayout(false);
            this.menuVentanaPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuVentanaPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cierresContablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBalanceDeComprobaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoDeResultadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balanceGeneralToolStripMenuItem;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.ToolStripMenuItem crearAsientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verAsientosToolStripMenuItem;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.ToolStripMenuItem sociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarNuevoSocioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verSocioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarServicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearDocumentoToolStripMenuItem;
<<<<<<< HEAD
=======
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearProyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verProyectosToolStripMenuItem;
>>>>>>> origin/Compras-y-ventas
    }
}