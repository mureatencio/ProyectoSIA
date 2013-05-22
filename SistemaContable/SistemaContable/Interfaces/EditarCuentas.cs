using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SistemaContable.Logica;
using SistemaContable.Interfaces;
using BibliotecasComunes;

namespace SistemaContable
{
    public partial class vntEditarCuenta : Form
    {
        string Empresa;
        List<Cuenta> cuentas;
        string cuentaeditar;
        public vntEditarCuenta(string empresa, List<Cuenta> cuentas, string nombrecuentaeditar)
        {
            this.Empresa = empresa;
            this.cuentas = cuentas;
            this.cuentaeditar = nombrecuentaeditar;
            InitializeComponent();
            this.txtNombre.Text = nombrecuentaeditar;
            LlenadoMonedas();
            LlenadoNiveles();
            LlenadoTipoCuentas();
            LlenadoCodigo();
        }

        private void LlenadoCodigo()
        {
            string idcuenta = null;
                for (int i = 0; i < cuentas.Count; i++)
                {
                    if (cuentaeditar.Equals(cuentas[i].Nombre))
                    {
                        idcuenta = cuentas[i].CodigoCuenta;
                    }
                }
            this.txtNumeroCuenta.Text = idcuenta;
            this.txtNumeroCuenta.Enabled = false;
        }
      

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Error ingresar Nombre de Cuenta");
            }
            else if (this.cmbNivelEd.Text.Equals(""))
            {
                MessageBox.Show("Error ingresar el Nivel de la Cuenta");
            }
            else if (this.cmbPadre.Text.Equals("") && !cmbNivelEd.Text.Equals("1"))
            {
                MessageBox.Show("Error ingresar el Padre de la Cuenta");
            }
            else if (this.cmbMonedaEd.Text.Equals("") && !chckMonedaUnica.Checked)
            {
                MessageBox.Show("Error ingresar la Moneda de la Cuenta");
            }
            else if (this.cmbTipoCuentaEd.Text.Equals(""))
            {
                MessageBox.Show("Error ingresar el Tipo de la Cuenta");
            }
            else
            {
                int idcuenta = 0;
                for (int i = 0; i < cuentas.Count; i++)
                {
                    if (cuentaeditar.Equals(cuentas[i].Nombre))
                    {
                        idcuenta = cuentas[i].ID;
                    }
                }
                bool titulo;
                if (chckTitulo.Checked)
                {
                    titulo = true;
                }
                else
                {
                    titulo = false;
                }
                try
                {
                    LogicaCuentas.modificarCuentas(idcuenta, txtNombre.Text, txtNombreInternacional.Text, titulo, cmbMonedaEd.SelectedValue.ToString(), Int32.Parse(cmbPadre.SelectedValue.ToString()));
                    this.Dispose();
                    MessageBox.Show("La cuenta fue editada con éxito!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnFiltroEd_Click(object sender, EventArgs e)
        {
            if (this.cmbTipoCuentaEd.Text.Equals(""))
            {
                MessageBox.Show("Error ingresar el Tipo de la Cuenta");
            }
            else if (this.cmbMonedaFiltroEd.Text.Equals(""))
            {
                MessageBox.Show("Error ingresar la Moneda de la Cuenta");
            }
            else if (this.cmbNivelEd.Text.Equals("") && !this.cmbNivelEd.Text.Equals("1"))
            {
                MessageBox.Show("Error ingresar el Nivel de la Cuenta");
            }
            else
            {
                String nivel, moneda, tipocuenta;
                nivel = this.cmbNivelEd.SelectedItem.ToString();
                moneda = this.cmbMonedaFiltroEd.SelectedValue.ToString();
                tipocuenta = this.cmbTipoCuentaEd.SelectedItem.ToString();
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
                this.cmbNivelEd.Items.Add(i.ToString());
            }
        }
        private void LlenadoMonedas()
        {
            try
            {
                List<Moneda> monedas = LogicaMonedas.obtenerMonedas();
                cmbMonedaFiltroEd.DataSource = monedas;
                cmbMonedaFiltroEd.DisplayMember = "Nombre";
                cmbMonedaFiltroEd.ValueMember = "Codigo";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void LlenadoTipoCuentas()
        {
            try
            {
                List<String> tipoCuentas = LogicaCuentas.obtenerTipoCuentas();
                for (int i = 0; i < tipoCuentas.Count(); i++)
                {
                    this.cmbTipoCuentaEd.Items.Add(tipoCuentas[i]);
                }
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
                this.cmbMonedaEd.DataSource = listaMonedas;
                this.cmbMonedaEd.DisplayMember = "Nombre";
                this.cmbMonedaEd.ValueMember = "Codigo";
            }
        }

        private void chckMonedaUnica_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chckMonedaUnica.Checked)
            {
                this.cmbMonedaEd.Enabled = false;
            }
            else
            {
                this.cmbMonedaEd.Enabled = true;
            }
        }

        
    }
}
