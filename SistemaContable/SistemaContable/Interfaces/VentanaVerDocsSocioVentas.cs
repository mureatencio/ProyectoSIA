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
    public partial class VentanaVerDocsSocioVentas : Form
    {
        public VentanaVerDocsSocioVentas(Documento documentoventa)
        {
            InitializeComponent();
            CargarDatgridDetallesVentas(documentoventa.Servicios);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void CargarDatgridDetallesVentas(List<Linea> serviciosventas)
        {
            for (int i = 0; i < serviciosventas.Count; i++)
            {
                if (i < serviciosventas.Count)
                {
                    dtgrdDetallesVenta.Rows.Add();
                }
                dtgrdDetallesVenta[0, i].Value = serviciosventas[i].nombre;
                dtgrdDetallesVenta[1, i].Value = serviciosventas[i].Cantidad.ToString();
                dtgrdDetallesVenta[2, i].Value = serviciosventas[i].precio.ToString();
                dtgrdDetallesVenta[3, i].Value = serviciosventas[i].Total.ToString();
                dtgrdDetallesVenta[4, i].Value = serviciosventas[i].Impuesto.ToString();
                dtgrdDetallesVenta[5, i].Value = serviciosventas[i].TotalGeneral.ToString();
            }
            dtgrdDetallesVenta.Refresh();
        }
    }
}
