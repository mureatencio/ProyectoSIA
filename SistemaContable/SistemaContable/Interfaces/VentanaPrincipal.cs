using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SistemaContable.Logica;
using BibliotecasComunes;

namespace SistemaContable.Interfaces
{
    public partial class VentanaPrincipal : Form
    {
        string NombreEmpresa;
        Empresa Empresa;

        public VentanaPrincipal(string pNombreEmpresa)
        {
            InitializeComponent();
            this.NombreEmpresa = pNombreEmpresa;
            Empresa = Logica.LogicaEmpresas.informacionEmpresa(this.NombreEmpresa);
            this.lblEmpresa.Text += this.NombreEmpresa;
            this.lblCedula.Text += this.Empresa.CedulaJuridica;
            this.lblTel.Text += this.Empresa.Telefono;
            this.lblF.Text += this.Empresa.Fax;
            this.logoBox.Image = Image.FromFile("logo.jpg");
            this.logoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.logoBox.Refresh();
        }

        private void cuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogoCuentas ventanaCuentas = new CatalogoCuentas(this.NombreEmpresa);
            ventanaCuentas.ShowDialog();
        }

        private void cierresContablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogConfirmarAnulacion = MessageBox.Show("¿Está seguro que desea realizar el Cierre Contable?",
                                                                    "Advertencia",
                                                                    MessageBoxButtons.YesNo);
                if (dialogConfirmarAnulacion == DialogResult.Yes)
                {
                    LogicaCierre.ejecutarCierre(this.NombreEmpresa);
                    MessageBox.Show("Cierre Contable generado con éxito.");
                    ////////////Realizar cierre contable
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void aBalanceDeComprobaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Generar Reporte
            string Reporte = "BalanceComprobacion";
            Reportes reporteComprobacion = new Reportes(NombreEmpresa, Reporte);
            reporteComprobacion.ShowDialog();
        }

        private void estadoDeResultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Generar Reporte
            string Reporte = "EstadoResultados";
            ReportesERBG reporteComprobacion = new ReportesERBG(NombreEmpresa, Reporte);
            reporteComprobacion.ShowDialog();
        }

        private void balanceGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Generar Reporte
            string Reporte = "BalanceGeneral";
            ReportesERBG reporteComprobacion = new ReportesERBG(NombreEmpresa, Reporte);
            reporteComprobacion.ShowDialog();
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlPanel panelControl = new ControlPanel();
            panelControl.ShowDialog();
        }

        private void crearAsientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsientosDiario ventanaAsientos = new AsientosDiario(this.NombreEmpresa);
            ventanaAsientos.ShowDialog();
        }

        private void verAsientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerAsiento ventanaAsientos = new VerAsiento(this.NombreEmpresa);
            ventanaAsientos.ShowDialog();
        }

        private void ingresarNuevoSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertarSocio ventanaingresarsocios = new InsertarSocio(this.NombreEmpresa);
            ventanaingresarsocios.ShowDialog();
        }

        private void verSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuestraSocios ventanaversocios = new MuestraSocios(this.NombreEmpresa);
            ventanaversocios.ShowDialog();
        }

        private void agregarServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Servicios ventanaservicios = new Servicios(this.NombreEmpresa);
            ventanaservicios.ShowDialog();
        }

        private void crearDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
<<<<<<< HEAD
=======
        {
            Documentos ventanaDocumentos = new Documentos(this.NombreEmpresa);
            ventanaDocumentos.ShowDialog();
        }

        private void nuevaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compras ventanaCompra = new Compras(this.NombreEmpresa);
            ventanaCompra.ShowDialog();
        }

        private void crearProyectoToolStripMenuItem_Click(object sender, EventArgs e)
>>>>>>> origin/Compras-y-ventas
        {
            Documentos ventanaDocumentos = new Documentos(this.NombreEmpresa);
            ventanaDocumentos.ShowDialog();
        }
<<<<<<< HEAD
=======

        private void verProyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerProyectos ventanaVerProyectos = new VerProyectos(this.NombreEmpresa);
            ventanaVerProyectos.ShowDialog();
        }
>>>>>>> origin/Compras-y-ventas
    }
}
