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
    public partial class VentanaDocsSociosVentas : Form
    {
        string empresa, codigosocio;
        List<Documento> listadocsVentas = new List<Documento>();
        public VentanaDocsSociosVentas(string empresa, string codigosocio)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                int numeroDocumento = Int32.Parse(this.dataGridView1[0, e.RowIndex].Value.ToString());
                Documento documentoventa = listadocsVentas.Find(s => s.ID == numeroDocumento);
                VentanaVerDocsSocioVentas ventanverDetalleventas = new VentanaVerDocsSocioVentas(documentoventa);
                ventanverDetalleventas.ShowDialog();
                //Llamar ventana detalle
            }
        }

        private void CargarDatagrid()
        {
            try
            {
                listadocsVentas = LogicaDocumento.obtenerFacturasVentaPendientes(empresa, codigosocio);
                for (int i = 0; i < listadocsVentas.Count; i++)
                {
                    if (i < listadocsVentas.Count)
                    {
                        dataGridView1.Rows.Add();
                    }
                    dataGridView1[0, i].Value = listadocsVentas[i].ID.ToString();
                    dataGridView1[1, i].Value = listadocsVentas[i].fechaContabilizacion.ToString();
                    dataGridView1[2, i].Value = listadocsVentas[i].tipo;
                    dataGridView1[3, i].Value = listadocsVentas[i].socio;
                    dataGridView1[4, i].Value = listadocsVentas[i].proyecto;
                    dataGridView1[5, i].Value = listadocsVentas[i].moneda;
                    dataGridView1[6, i].Value = listadocsVentas[i].total.ToString();
                    dataGridView1[7, i].Value = listadocsVentas[i].impuesto.ToString();
                    dataGridView1[8, i].Value = listadocsVentas[i].totalPrecio.ToString();
                }
                dataGridView1.Refresh();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo Cargar la informcación");
            }
        }
    }
}
