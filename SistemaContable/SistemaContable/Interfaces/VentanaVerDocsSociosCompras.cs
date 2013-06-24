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
    public partial class VentanaVerDocsSociosCompras : Form
    {
        public VentanaVerDocsSociosCompras(Compra compra)
        {
            InitializeComponent();
            CargarDatgridDetalles(compra.Servicios);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void CargarDatgridDetalles(List<ServicioCompra> servicioscompras)
        {
            for (int i = 0; i < servicioscompras.Count; i++)
            {
                if (i < servicioscompras.Count)
                {
                    dtgrdDetallesCompras.Rows.Add();
                }
                dtgrdDetallesCompras[0, i].Value = servicioscompras[i].Nombre;
                dtgrdDetallesCompras[1, i].Value = servicioscompras[i].Descripcion;
                dtgrdDetallesCompras[2, i].Value = servicioscompras[i].Cantidad.ToString();
                dtgrdDetallesCompras[3, i].Value = servicioscompras[i].Precio.ToString();
                dtgrdDetallesCompras[4, i].Value = servicioscompras[i].Total.ToString();
                dtgrdDetallesCompras[5, i].Value = servicioscompras[i].Impuesto.ToString();
                dtgrdDetallesCompras[6, i].Value = servicioscompras[i].TotalImpuesto.ToString();
            }
            dtgrdDetallesCompras.Refresh();
        }
    }
}
