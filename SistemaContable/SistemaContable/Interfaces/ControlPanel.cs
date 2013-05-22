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
using SistemaContable.BaseDatos;
using System.Globalization;
using ClienteBancoCentral;

namespace SistemaContable.Interfaces
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
            List<string> empresas = LogicaEmpresas.obtenerNombreEmpresas();
            string[] nombres = new string[empresas.Count];
            for (int i = 0; i < empresas.Count; i++)
            {
                nombres[i] = empresas[i];
            }
            this.Moneda.HeaderText = "Moneda";
            this.Moneda.Items.AddRange(nombres);
            this.comboBoxEmpresaUsuario.Items.AddRange(nombres);
            this.comboBoxEmpresaManejoPeriodos.Items.AddRange(nombres);

            List<Moneda> monedas = AccesoMonedas.obtenerMonedas();
            string[] nombresMoneda = new string[monedas.Count];
            for (int i = 0; i < monedas.Count; i++)
            {
                nombresMoneda[i] = monedas[i].Nombre;
            }
            this.comboBoxMonedaSistemaEmpresa.Items.AddRange(nombresMoneda);
            this.comboBoxMonedaLocalEmpresa.Items.AddRange(nombresMoneda);
            comboBoxMonedaLocalEmpresa.SelectedIndex = 0;

            comboBoxPeriodoManejoPeriodos.Items.Clear();
            comboBoxPeriodoManejoPeriodos.Items.Add("2012-10-01 / 2012-10-31");
            comboBoxPeriodoManejoPeriodos.Items.Add("2012-11-01 / 2012-11-30");
            comboBoxPeriodoManejoPeriodos.Items.Add("2012-12-01 / 2013-12-31");
            comboBoxPeriodoManejoPeriodos.Items.Add("2013-01-01 / 2012-01-31");
            comboBoxPeriodoManejoPeriodos.Items.Add("2013-02-01 / 2013-02-28");
            comboBoxPeriodoManejoPeriodos.Items.Add("2013-03-01 / 2013-03-31");
            comboBoxPeriodoManejoPeriodos.Items.Add("2013-04-01 / 2013-04-30");
            comboBoxPeriodoManejoPeriodos.Items.Add("2013-05-01 / 2013-05-31");
            comboBoxPeriodoManejoPeriodos.Items.Add("2013-06-01 / 2013-06-30");
            comboBoxPeriodoManejoPeriodos.Items.Add("2013-07-01 / 2013-07-31 ");
            comboBoxPeriodoManejoPeriodos.Items.Add("2013-08-01 / 2013-08-31");
            comboBoxPeriodoManejoPeriodos.Items.Add("2013-09-01 / 2013-09-30");
            comboBoxPeriodoManejoPeriodos.SelectedIndex = 0;

            comboBoxEstadoManejoPeriodos.Items.Add("Abierto");
            comboBoxEstadoManejoPeriodos.Items.Add("Cerrado");
            comboBoxEstadoManejoPeriodos.Items.Add("Cerrado Excepto Ventas");
            comboBoxEstadoManejoPeriodos.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // abrir file dialog
            OpenFileDialog open = new OpenFileDialog();
            // agregarle filtros de imagenes
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // Mostrar imagenes
                pictureBox1.Image = new Bitmap(open.FileName);
                // mostrar el path de la imagen
                buttonExaminar.Text = open.FileName;
            } 
        }

        private void textBoxComprobarContrasena_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxNuevaContrasena.Text != this.textBoxComprobarContrasena.Text)
            {
                labelEstadoUsuario.Text = "Las contraseñas no coinciden";
                labelEstadoUsuario.ForeColor = System.Drawing.Color.Red;
                buttonCrearUsuario.Enabled = false;
            }
            else {
                labelEstadoUsuario.Text = "Las contraseñas coinciden";
                labelEstadoUsuario.ForeColor = System.Drawing.Color.Green;
                buttonCrearUsuario.Enabled = true;
            }
        }

        private void textBoxNuevaContrasena_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxNuevaContrasena.Text != this.textBoxComprobarContrasena.Text)
            {
                labelEstadoUsuario.Text = "Las contraseñas no coinciden";
                labelEstadoUsuario.ForeColor = System.Drawing.Color.Red;
                buttonCrearUsuario.Enabled = false;
            }
            else
            {
                labelEstadoUsuario.Text = "Las contraseñas coinciden";
                labelEstadoUsuario.ForeColor = System.Drawing.Color.DarkGreen;
                buttonCrearUsuario.Enabled = true;
            }
        }

        private void buttonCrearUsuario_Click(object sender, EventArgs e)
        {
            if (textBoxNombreUsuario.TextLength < 4 || textBoxNuevaContrasena.TextLength < 4)
            {
                labelEstadoUsuario.Text = "Contraseña o Usuario muy corto";
                labelEstadoUsuario.ForeColor = System.Drawing.Color.Red;
                buttonCrearUsuario.Enabled = false;
            }
            else {

                string nombre, contrasena, empresa;
                nombre = this.textBoxNombreUsuario.Text;
                contrasena = this.textBoxNuevaContrasena.Text;
                empresa = this.comboBoxEmpresaUsuario.SelectedItem.ToString();

                LogicaUsuarios.introducirUsuario(nombre, contrasena, empresa);
                
                MessageBox.Show("El usuario ha sido insertado", "Información", MessageBoxButtons.OK);
                textBoxNuevaContrasena.Text = "";
                textBoxNombreUsuario.Text = "";
                textBoxComprobarContrasena.Text = "";


            }
        }

        private void textBoxNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            if(textBoxNombreUsuario.Text.Length >= 4 &&
                textBoxNuevaContrasena.Text.Length >= 4 &&
                textBoxComprobarContrasena.Text.Length >= 4)
            {
                    buttonCrearUsuario.Enabled = true;
                    labelEstadoUsuario.Text = "";
                
            }
        }

        private void buttonCrearEmpresa_Click(object sender, EventArgs e)
        {
            // Stream usado como buffer
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            // Se guarda la imagen en el buffer
            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            // Se extraen los bytes del buffer para asignarlos como valor para el
            // parámetro.
          

            Empresa empresaNueva = new Empresa();
            empresaNueva.Nombre = textBoxNombreEmpresa.Text;
            empresaNueva.CedulaJuridica = Convert.ToInt64(textBoxCedulaJuridica.Text);
            empresaNueva.Telefono = Convert.ToInt64(textBoxTelefono.Text);
            empresaNueva.Fax = Convert.ToInt64(textBoxFax.Text);
            empresaNueva.MonedaLocal =  comboBoxMonedaLocalEmpresa.SelectedItem.ToString();
            empresaNueva.MonedaSistema =  comboBoxMonedaSistemaEmpresa.SelectedItem.ToString();
            empresaNueva.Imagen = ms.GetBuffer();
            LogicaEmpresas.introducirEmpresa(empresaNueva);

            MessageBox.Show("La empresa ha sido insertada", "Información", MessageBoxButtons.OK);
               
        }

        private void buttonGuardarPeriodo_Click(object sender, EventArgs e)
        {
            Periodo periodoNuevo = new Periodo();
            string nuevoEstado = this.comboBoxPeriodoManejoPeriodos.SelectedItem.ToString();
            string[] tokens = nuevoEstado.Split('/');
            periodoNuevo.TipoPeriodo = this.comboBoxEstadoManejoPeriodos.SelectedItem.ToString();
            string fecha = tokens[0];

            DateTimeFormatInfo dtfi = new DateTimeFormatInfo();
            dtfi.ShortDatePattern = "yyyy-MM-dd";
            dtfi.DateSeparator = "-";
            DateTime objDate = Convert.ToDateTime(fecha, dtfi);
            periodoNuevo.FechaInicio = objDate;

            periodoNuevo.NombreEmpresa = this.comboBoxEmpresaManejoPeriodos.SelectedItem.ToString();

            LogicaEmpresas.actualizarPeriodo(periodoNuevo);
            MessageBox.Show("El periodo ha sido actualizado", "Información", MessageBoxButtons.OK);
           
        }

        private void bttnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Llenado_ComboBox(List<Moneda> Monedas)
        {
            for (int i = 0; i < Monedas.Count - 1; i++)
            {
                DataGridViewAsiento.Rows.Add();
            }
            foreach (DataGridViewRow row in DataGridViewAsiento.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ColumnIndex == 0)
                    {
                        cell.Value = Monedas[row.Index].Nombre;
                    }
                    if (cell.ColumnIndex == 1)
                    {
                        cell.Value = Monedas[row.Index].Codigo;
                    }
                }
            }
        }

        private void DataGridViewAsiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)// si se presionó sobre la columna que contiene la X
            {
                Console.Write("por remover");
                if (e.RowIndex + 1 != this.DataGridViewAsiento.Rows.Count)//valida que no se intenta eliminar la fila creadora.
                {
                    this.DataGridViewAsiento.Rows.Remove(this.DataGridViewAsiento.Rows[e.RowIndex]);
                    Console.Write("removida");
                }
            }

        }

        private void ButtonGuardarCerrar_Click(object sender, EventArgs e)
        {
            DataTable datosMonedas = new DataTable();
            datosMonedas.Columns.Add("Nombre", typeof(string));
            datosMonedas.Columns.Add("TipoCambio", typeof(string));

            foreach (DataGridViewRow row in DataGridViewAsiento.Rows)
            {
                DataRow fila = datosMonedas.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ColumnIndex == 0 && cell.Value == null)
                    {
                        break;
                    }
                    if (cell.ColumnIndex == 0 && cell.Value != null)
                    {
                        fila[0] = (String)cell.Value;

                    }
                    if (cell.ColumnIndex == 1 && cell.Value != null)
                    {
                        fila[1] = (String)cell.Value;
                    }
                    if (cell.ColumnIndex == 1 && cell.Value == null)
                    {
                        fila[1] = "0";
                    }

                }
                datosMonedas.Rows.Add(fila);
            }
            datosMonedas.Rows.RemoveAt(datosMonedas.Rows.Count - 1);
            LogicaMonedas.ModificarTipoCambio(datosMonedas);
            MessageBox.Show("Se han almacenado los cambios",
                                                                "Información",
                                                                MessageBoxButtons.OK);
        }

        private void bttnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Moneda> listaMonedas = LogicaMonedas.obtenerMonedasWSBC();
                List<Moneda> listaMonedasCambio = ConexionBancoCentral.actualizarMonedasBC(listaMonedas);
                LogicaMonedas.PreModificarTipoCambio(listaMonedasCambio);
                MessageBox.Show("Tipos de cambio actualizados con éxito del Banco Central.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
