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
    public partial class DocumentosCompra : Form
    {
        public Compra compra;
        string empresa, tipodocumento;
        List<Compra> listadocumentos = new List<Compra>();
        public DocumentosCompra(string empresa, string tipodocumento)
        {
            this.tipodocumento = tipodocumento;
            this.empresa = empresa;
            InitializeComponent();
            CargarDatagrid(tipodocumento);
        }

        private void CargarDatagrid(string tipodocumento)
        {
            try 
            {
                listadocumentos = LogicaCompras.obtenerDocumentoAnterior(empresa, tipodocumento);
                for (int i = 0; i < listadocumentos.Count; i++)
                {
                    if (i < listadocumentos.Count)
                    {
                        dtgrdDocumentos.Rows.Add();
                    }
                    dtgrdDocumentos[0, i].Value = listadocumentos[i].Consecutivo.ToString();
                    dtgrdDocumentos[1, i].Value = listadocumentos[i].Fecha.ToString();
                    dtgrdDocumentos[2, i].Value = listadocumentos[i].TipoCompra;
                    dtgrdDocumentos[3, i].Value = listadocumentos[i].Proveedor.Nombre;
                    dtgrdDocumentos[4, i].Value = listadocumentos[i].Proyecto.Nombre;
                    dtgrdDocumentos[5, i].Value = listadocumentos[i].Moneda.Codigo;
                    dtgrdDocumentos[6, i].Value = listadocumentos[i].Total.ToString();
                    dtgrdDocumentos[7, i].Value = listadocumentos[i].Impuesto.ToString();
                    dtgrdDocumentos[8, i].Value = listadocumentos[i].TotalJunto.ToString();
                }
                dtgrdDocumentos.Refresh();
            }
            catch(Exception e)
            {
                MessageBox.Show("No se pudo Cargar la informcación");
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Variables.Compra = null;
            this.Dispose();
        }

        private void dtgrdDocumentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                int numeroDocumento = Int32.Parse(this.dtgrdDocumentos[0, e.RowIndex].Value.ToString());
                Compra compraDoc = listadocumentos.Find(s => s.Consecutivo == numeroDocumento);

                VerDocumento verdoc = new VerDocumento(compraDoc);
                verdoc.ShowDialog();
            }
            if (e.ColumnIndex == 10)
            {
                int numeroDocumento = Int32.Parse(this.dtgrdDocumentos[0, e.RowIndex].Value.ToString());
                Compra compraDoc = listadocumentos.Find(s => s.Consecutivo == numeroDocumento);
                Variables.Compra = compraDoc;
                this.Dispose();
            }
        }
    }
}
