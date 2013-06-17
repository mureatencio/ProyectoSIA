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
    public partial class VerProyectos : Form
    {
        string empresa;
        public VerProyectos(string empresa)
        {
            this.empresa = empresa;
            InitializeComponent();
            obtenerProyectos();
        }

        private void obtenerProyectos()
        {
            try
            {
                List<Proyecto> proyectos = new List<Proyecto>();
                proyectos = LogicaProyectos.obtenerProyectos(empresa);
                for (int i = 0; i < proyectos.Count; i++)
                {
                    this.dtgrdProyectos.Rows.Add();
                    dtgrdProyectos[0, i].Value = proyectos[i].Nombre;
                    dtgrdProyectos[1, i].Value = proyectos[i].Codigo;
                    dtgrdProyectos[2, i].Value = proyectos[i].Descripcion;
                    dtgrdProyectos[3, i].Value = proyectos[i].Estado;
                    dtgrdProyectos[4, i].Value = proyectos[i].FechaInicio.ToShortDateString();
                }
                dtgrdProyectos.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo obtener los proyectos.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
