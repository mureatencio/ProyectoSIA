using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SistemaContable.Logica;

namespace SistemaContable.Interfaces
{
    public partial class CrearProyectos : Form
    {
        string empresa;
        public CrearProyectos(string empresa)
        {
            this.empresa = empresa;
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreproyecto.Text.Equals(""))
                {
                    MessageBox.Show("Debe ingresar el nombre del proyecto");
                }
                else if (txtCodigoproyecto.Text.Equals(""))
                {
                    MessageBox.Show("Debe ingresar el código del proyecto");
                }
                else if (rchtxtDescripcion.Text.Equals(""))
                {
                    MessageBox.Show("Debe escribir una descripción del proyecto");
                }
                else
                {
                    LogicaProyectos.insertarProyecto(empresa, txtNombreproyecto.Text, txtCodigoproyecto.Text, rchtxtDescripcion.Text);
                    MessageBox.Show("Proyecto creado con éxito!.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo crear el nuevo Proyecto");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
