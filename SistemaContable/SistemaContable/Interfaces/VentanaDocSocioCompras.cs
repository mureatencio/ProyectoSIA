using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BibliotecasComunes;
using SistemaContable.Logica;

namespace SistemaContable.Interfaces
{
    public partial class VentanaDocSocioCompras : Form
    {
        string empresa, codigosocio;
        List<Compra> listadocumentos = new List<Compra>();
        public VentanaDocSocioCompras(string empresa, string codigosocio)
        {
            this.empresa = empresa;
            this.codigosocio = codigosocio;
            InitializeComponent();
            CargarDatagrid();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dtgrdDocumentosSocioCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 9)
                {
                    int numeroDocumento = Int32.Parse(this.dtgrdDocumentosSocioCompras[0, e.RowIndex].Value.ToString());
                    Compra compraDoc = listadocumentos.Find(s => s.Consecutivo == numeroDocumento);
                    VentanaVerDocsSociosCompras ventanadetallescompras = new VentanaVerDocsSociosCompras(compraDoc);
                    ventanadetallescompras.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al cargar la información de la factura.");
            }
        }

        private void CargarDatagrid()
        {
            try
            {
                listadocumentos = LogicaCompras.obtenerFacturasCompraPendientes(empresa, codigosocio);
                for (int i = 0; i < listadocumentos.Count; i++)
                {
                    if (i < listadocumentos.Count)
                    {
                        dtgrdDocumentosSocioCompras.Rows.Add();
                    }
                    dtgrdDocumentosSocioCompras[0, i].Value = listadocumentos[i].Consecutivo.ToString();
                    dtgrdDocumentosSocioCompras[1, i].Value = listadocumentos[i].Fecha.ToString();
                    dtgrdDocumentosSocioCompras[2, i].Value = listadocumentos[i].TipoCompra;
                    dtgrdDocumentosSocioCompras[3, i].Value = listadocumentos[i].Proveedor.Nombre;
                    dtgrdDocumentosSocioCompras[4, i].Value = listadocumentos[i].Proyecto.Nombre;
                    dtgrdDocumentosSocioCompras[5, i].Value = listadocumentos[i].Moneda.Codigo;
                    dtgrdDocumentosSocioCompras[6, i].Value = listadocumentos[i].Total.ToString();
                    dtgrdDocumentosSocioCompras[7, i].Value = listadocumentos[i].Impuesto.ToString();
                    dtgrdDocumentosSocioCompras[8, i].Value = listadocumentos[i].TotalJunto.ToString();
                }
                dtgrdDocumentosSocioCompras.Refresh();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo Cargar la informcación");
            }
        }
    }
}
