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
    public partial class MuestraSocios : Form
    {
        string empresa;
        public MuestraSocios(string empresa)
        {
            this.empresa = empresa;
            InitializeComponent();
            obtenerSocios();
        }

        private void obtenerSocios()
        {
            try
            {
                List<Socio> socios = new List<Socio>();
                socios = LogicaSocios.obtenerSocios(empresa);
                for (int i = 0; i < socios.Count; i++)
                {
                    this.dtgrdSocios.Rows.Add();
                    dtgrdSocios[0, i].Value = socios[i].Codigo;
                    dtgrdSocios[1, i].Value = socios[i].Nombre;
                    dtgrdSocios[2, i].Value = socios[i].TipoSocio;
                    dtgrdSocios[3, i].Value = socios[i].LimiteLocal.ToString();
                    dtgrdSocios[4, i].Value = socios[i].Cuenta.CodigoCuenta;
                    dtgrdSocios[5, i].Value = socios[i].Cuenta.SaldoLocal.ToString();
                    dtgrdSocios[6, i].Value = socios[i].Moneda.Codigo;
                    dtgrdSocios[7, i].Value = socios[i].CondicionPago.ToString();
                }
                dtgrdSocios.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo obtener los socios");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dtgrdSocios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                //string del codigo del socio
                string codigosocio = this.dtgrdSocios[0, e.RowIndex].Value.ToString();
                //LLamar a la ventana de mostrar documentos del socio
            }
        }


    }
}
