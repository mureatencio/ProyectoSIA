using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BibliotecasComunes;

namespace SistemaContable.Interfaces
{
    public partial class VerDocumento : Form
    {
        public VerDocumento(Compra compra)
        {
            InitializeComponent();
            CargarDatgrid(compra.Servicios);
        }

        public void CargarDatgrid(List<ServicioCompra> servicioscompras)
        {
            for (int i = 0; i < servicioscompras.Count; i++)
            {
                if (i < servicioscompras.Count)
                {
                    dtgrdDetalles.Rows.Add();
                }
                dtgrdDetalles[0, i].Value = servicioscompras[i].Nombre;
                dtgrdDetalles[1, i].Value = servicioscompras[i].Descripcion;
                dtgrdDetalles[2, i].Value = servicioscompras[i].Cantidad.ToString();
                dtgrdDetalles[3, i].Value = servicioscompras[i].Precio.ToString();
                dtgrdDetalles[4, i].Value = servicioscompras[i].Total.ToString();
                dtgrdDetalles[5, i].Value = servicioscompras[i].Impuesto.ToString();
                dtgrdDetalles[6, i].Value = servicioscompras[i].TotalImpuesto.ToString();
            }
            dtgrdDetalles.Refresh();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
