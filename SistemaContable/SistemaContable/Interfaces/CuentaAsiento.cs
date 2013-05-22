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
    public partial class CuentaAsiento : Form
    {
        List<Partida> listaPartidas;

        public CuentaAsiento(int numeroAsiento, string compania)
        {

            InitializeComponent();
            
            listaPartidas = LogicaAsientos.obtenerPartidas(numeroAsiento, compania);
            foreach (Partida partida in listaPartidas)
            {
                this.dtGrdVwCuentas.Rows.Add();
                int numFila = dtGrdVwCuentas.Rows.Count - 1;
                this.dtGrdVwCuentas["Cuenta", numFila].Value = partida.Cuenta;
                this.dtGrdVwCuentas["Moneda", numFila].Value = partida.Moneda;
                this.dtGrdVwCuentas["Debe", numFila].Value = partida.Debe;
                this.dtGrdVwCuentas["Haber", numFila].Value = partida.Haber;
                this.dtGrdVwCuentas["DebeLocal", numFila].Value = partida.DebeLocal;
                this.dtGrdVwCuentas["HaberLocal", numFila].Value = partida.HaberLocal;
                this.dtGrdVwCuentas["DebeSistema", numFila].Value = partida.DebeSistema;
                this.dtGrdVwCuentas["HaberSistema", numFila].Value = partida.HaberSistema;
            }
        }

        private void bttnRegresar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
