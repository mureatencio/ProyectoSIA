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
    public partial class Login : Form
    {
        public Login()
        {
            List<string> empresas = LogicaEmpresas.obtenerNombreEmpresas();
            InitializeComponent();
            string[] nombres = new string[empresas.Count];
            for (int i = 0; i < empresas.Count; i++)
            {
                nombres[i] = empresas[i];
            }
            this.comboBoxEmpresaLogin.Items.AddRange(nombres);
        }

        private void buttonIngresar_Click_1(object sender, EventArgs e)
        {
            if (this.textBoxUsuario.Text.Equals("") || this.textBoxContrasena.Text.Equals("") || this.comboBoxEmpresaLogin.Text.Equals(""))
            {
                MessageBox.Show("Llene todos los campos para continuar.");
            }
            else
            {
                string nombre, contrasena, empresa;
                nombre = this.textBoxUsuario.Text;
                contrasena = this.textBoxContrasena.Text;
                empresa = this.comboBoxEmpresaLogin.SelectedItem.ToString();

                //if (LogicaUsuarios.AutenticarUsuario(nombre, contrasena, empresa))
                //{
                    //                MessageBox.Show("Bienvenido", "Información", MessageBoxButtons.OK);
                    VentanaPrincipal vPrincipal = new VentanaPrincipal(empresa);
                    this.Hide();
                    vPrincipal.ShowDialog();
                    this.Dispose();
                //}
                //else
                //{
                //    MessageBox.Show("Error de nombre de usuario o contraseña.");
                //}
            }
        }
    }
}
