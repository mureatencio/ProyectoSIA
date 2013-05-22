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
    public partial class VerAsiento : Form
    {
        private string compania;
        private List<Asiento> listaAsientos;

        public VerAsiento(string Compania)
        {
            this.compania = Compania;

            InitializeComponent();
            cargarAsientos();
        }

        private void dataGridViewResultadosFiltrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)// si se presionó sobre la columna de visualizar asiento
            {
                if (e.RowIndex != this.dataGridViewResultadosFiltrar.Rows.Count)//valida que no se intenta anular la fila creadora.
                {
                    int numeroAsiento = Int32.Parse(this.dataGridViewResultadosFiltrar["NumeroAsiento", e.RowIndex].Value.ToString());

                    //logica a buscar las cuentas de la empresa
                    CuentaAsiento cuenta = new CuentaAsiento(numeroAsiento, compania);
                    cuenta.ShowDialog();
                }
            }
            else if (e.ColumnIndex == 9)// si se presionó sobre la columna que anula asientos
            { 
                DialogResult dialogConfirmarAnulacion = MessageBox.Show("Está seguro que desea anular este asiento, esta operación es irreversible", 
                                                                "Advertencia", 
                                                                MessageBoxButtons.YesNo);
                 if (dialogConfirmarAnulacion == DialogResult.Yes)
                 {
                     //instrucciones si se presionó yes
                     int numAsiento = Int32.Parse(this.dataGridViewResultadosFiltrar["NumeroAsiento",e.RowIndex].Value.ToString());
                     LogicaAsientos.anularAsiento(numAsiento, compania);

                     MessageBox.Show("Asiento anulado con éxito.");
                     this.dataGridViewResultadosFiltrar.Rows.Clear();
                     cargarAsientos();
                     //anular asiento
                 }
            }                       
        }

        private void bttnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cargarAsientos()
        {
            listaAsientos = LogicaAsientos.obtenerAsientos(compania);
            foreach (Asiento asiento in listaAsientos)
            {
                this.dataGridViewResultadosFiltrar.Rows.Add();
                int numFila = dataGridViewResultadosFiltrar.Rows.Count - 1;

                this.dataGridViewResultadosFiltrar["NumeroAsiento", numFila].Value = asiento.Codigo;
                this.dataGridViewResultadosFiltrar["Detalle", numFila].Value = asiento.Detalle;
                this.dataGridViewResultadosFiltrar["DebeLocal", numFila].Value = asiento.TotalDebeLocal;
                this.dataGridViewResultadosFiltrar["HaberLocal", numFila].Value = asiento.TotalHaberLocal;
                this.dataGridViewResultadosFiltrar["DebeSistema", numFila].Value = asiento.TotalDebeSistema;
                this.dataGridViewResultadosFiltrar["HaberSistema", numFila].Value = asiento.TotalHaberSistema;
                this.dataGridViewResultadosFiltrar["FechaDocumento", numFila].Value = asiento.FechaDocumento;
                this.dataGridViewResultadosFiltrar["FechaContabilizacion", numFila].Value = asiento.FechaContabilizacion;
            }
        }
    }
}
