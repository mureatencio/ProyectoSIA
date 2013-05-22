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
    public partial class CatalogoCuentas : Form
    {
        private string Empresa;
        List<Cuenta> cuentas;
        public CatalogoCuentas(string empresa)
        {
            this.Empresa = empresa;
            InitializeComponent();
            this.cmbMoneda.Enabled = false;
            CargarCuentas();
            LlenadoMonedas();
            LlenadoNiveles();
            LlenadoTipoCuentas();
        }

        private void chckMonedaUnica_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chckMonedaUnica.Checked)
            {
                this.cmbMoneda.Enabled = true;
            }
            else 
            {
                this.cmbMoneda.Enabled = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5) 
            {
                string nombrecuenta = this.dtCuentas[1,e.RowIndex].Value.ToString();
                vntEditarCuenta vtneditar = new vntEditarCuenta(Empresa, cuentas, nombrecuenta);
                vtneditar.ShowDialog();
                dtCuentas.Rows.Clear();
                CargarCuentas();
            }
            else if (e.ColumnIndex == 6) 
            {
                string nombrecuenta = this.dtCuentas[1, e.RowIndex].Value.ToString();
                int idcuenta = 0;
                for (int i = 0; i < cuentas.Count; i++)
                {
                    if (nombrecuenta.Equals(cuentas[i].Nombre))
                    {
                        idcuenta = cuentas[i].ID;
                        break;
                    }
                }
                try
                {
                    LogicaCuentas.eliminarCuenta(idcuenta);
                    this.dtCuentas.Rows.Remove(this.dtCuentas.Rows[e.RowIndex]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //LLamada a la logica para cancelar la cuenta validando que no tenga transacciones
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.txtNumeroCuenta.Text.Equals(""))
            {
                MessageBox.Show("Error ingresar Número de Cuenta");
            }
            else if(this.txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Error ingresar Nombre de Cuenta");
            }
            else if(this.cmbNivel.Text.Equals(""))
            {
                MessageBox.Show("Error ingresar el Nivel de la Cuenta");
            }
            else if (this.cmbPadre.Text.Equals("") && !cmbNivel.Text.Equals("1"))
            {
                MessageBox.Show("Error ingresar el Padre de la Cuenta");
            }
            else if (this.cmbMoneda.Text.Equals("") && !chckMonedaUnica.Checked)
            {
                MessageBox.Show("Error ingresar la Moneda de la Cuenta");
            }
            else if (this.cmbTipoCuenta.Text.Equals(""))
            {
                MessageBox.Show("Error ingresar el Tipo de la Cuenta");
            }
            else
            {
                bool titulo = chckTitulo.Checked;
                try
                {
                    if (!chckMonedaUnica.Checked)
                    {
                        LogicaCuentas.insertarCuentas(Empresa, txtNombre.Text, txtNombreInternacional.Text, txtNumeroCuenta.Text, titulo, "MULT", Int32.Parse(cmbPadre.SelectedValue.ToString()));
                    }
                    else
                    {
                        LogicaCuentas.insertarCuentas(Empresa, txtNombre.Text, txtNombreInternacional.Text, txtNumeroCuenta.Text, titulo, cmbMoneda.SelectedValue.ToString(), Int32.Parse(cmbPadre.SelectedValue.ToString()));
                    }
                    txtNombre.Clear();
                    txtNombreInternacional.Clear();
                    txtNumeroCuenta.Clear();
                    cmbPadre.DataSource = new List<Moneda>();
                    cmbMoneda.DataSource = new List<Cuenta>();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                dtCuentas.Rows.Clear();
                CargarCuentas();
                MessageBox.Show("La cuenta fue agregada con éxito!");

            }
        } 

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            if (this.cmbTipoCuenta.Text.Equals(""))
            {
                MessageBox.Show("Error ingresar el Tipo de la Cuenta");
            }
            else if (this.cmbMonedaFiltro.Text.Equals(""))
            {
                MessageBox.Show("Error ingresar la Moneda de la Cuenta");
            }
            else if (this.cmbNivel.Text.Equals(""))
            {
                MessageBox.Show("Error ingresar el Nivel de la Cuenta");
            }
            else 
            {
                String nivel, moneda, tipocuenta;
                nivel = this.cmbNivel.SelectedItem.ToString();
                moneda = this.cmbMonedaFiltro.SelectedValue.ToString();
                tipocuenta = this.cmbTipoCuenta.SelectedItem.ToString();
                try
                {
                    List<Cuenta> padres = LogicaCuentas.obtenerPadres(Empresa, nivel, moneda, tipocuenta);
                    cmbPadre.DisplayMember = "Nombre";
                    cmbPadre.ValueMember = "ID";
                    cmbPadre.DataSource = padres;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void LlenadoNiveles()
        {
            for (int i = 2; i <= 5; i++)
            {
                this.cmbNivel.Items.Add(i.ToString());
            }
        }
        private void LlenadoMonedas()
        {
            try
            {
                List<Moneda> monedas = LogicaMonedas.obtenerMonedas();
                cmbMonedaFiltro.DataSource = monedas;
                cmbMonedaFiltro.DisplayMember = "Nombre";
                cmbMonedaFiltro.ValueMember = "Codigo";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LlenadoTipoCuentas()
        {
            try
            {
                List<String> tipoCuentas = LogicaCuentas.obtenerTipoCuentas();
                for (int i = 0; i < tipoCuentas.Count(); i++)
                {
                    this.cmbTipoCuenta.Items.Add(tipoCuentas[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CargarCuentas()
        {
            try
            {
                cuentas = LogicaCuentas.obtenerCuentas(Empresa);
                for (int i = 0; i < cuentas.Count; i++)
                {
                    if (i < cuentas.Count)
                    {
                        dtCuentas.Rows.Add();
                    }
                    dtCuentas[0, i].Value = cuentas[i].CodigoCuenta.ToString();
                    dtCuentas[1, i].Value = cuentas[i].Nombre.ToString();
                    dtCuentas[2, i].Value = cuentas[i].SaldoSistema.ToString();
                    dtCuentas[3, i].Value = cuentas[i].SaldoLocal.ToString();
                    dtCuentas[4, i].Value = cuentas[i].Moneda.Codigo.ToString();
                }
                dtCuentas.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmbPadre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbPadre.SelectedValue != null)
            {
                List<Moneda> listaMonedas = new List<Moneda>();
                string idCuenta = this.cmbPadre.SelectedValue.ToString();
                listaMonedas = LogicaMonedas.obtenerMonedasCuenta(Int32.Parse(idCuenta));
                this.cmbMoneda.DataSource = listaMonedas;
                this.cmbMoneda.DisplayMember = "Nombre";
                this.cmbMoneda.ValueMember = "Codigo";
            }
        }

        private void bttnAceptar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
