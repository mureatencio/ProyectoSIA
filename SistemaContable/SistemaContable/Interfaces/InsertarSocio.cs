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
    public partial class InsertarSocio : Form
    {
        List<Cuenta> cuentas;
        string empresa;
        public InsertarSocio(string empresa)
        {
            this.empresa = empresa;
            InitializeComponent();
            CargarCuentas();
            CargarMonedas();
            CargarTiposocios();
        }

        private void CargarCuentas()
        {
            try
            {
                cuentas = new List<Cuenta>();
                cuentas = LogicaCuentas.cargarCuentasDisponiblesAsiento(empresa);
                for (int i = 0; i < cuentas.Count; i++)
                {
                    cmbCuenta.Items.Add(cuentas[i].Nombre);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarMonedas()
        {
            try
            {
                List<Moneda> monedas = new List<Moneda>();
                monedas = LogicaMonedas.obtenerMonedas();
                for (int i = 0; i < monedas.Count; i++)
                {
                    cmbMoneda.Items.Add(monedas[i].Codigo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarTiposocios()
        {
            try
            {
                List<string> tipossocios = new List<string>();
                tipossocios = LogicaSocios.obtenerTiposSocios();
                for (int i = 0; i < tipossocios.Count; i++)
                {
                    cmbTiposocio.Items.Add(tipossocios[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarsocio_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Equals(""))
            {
                MessageBox.Show("Lo siento debe insertar el código del nuevo socio");
            }
            if(txtNombresocio.Text.Equals(""))
            {
                MessageBox.Show("Lo siento debe insertar el nombre del nuevo socio");
            }
            if (txtCondicionpago.Text.Equals(""))
            {
                MessageBox.Show("Lo siento debe insertar la condición de pago del nuevo socio");
            }
            if (txtLimite.Text.Equals(""))
            {
                MessageBox.Show("Lo siento debe insertar el límite de crédito del nuevo socio");
            }
            if (cmbCuenta.SelectedItem.Equals(""))
            {
                MessageBox.Show("Lo siento debe escoger una cuenta asociada al nuevo socio");
            }
            if (cmbMoneda.SelectedItem.Equals(""))
            {
                MessageBox.Show("Lo siento debe escoger la moneda del nuevo socio");
            }
            if (cmbTiposocio.SelectedItem.Equals(""))
            {
                MessageBox.Show("Lo siento debe el tipo de socio del nuevo socio");
            }
            try
            {
                Cuenta cuenta = cuentas.Find(s => s.Nombre.Equals(cmbCuenta.SelectedItem.ToString()));
                LogicaSocios.insertarSocio(empresa, cmbMoneda.SelectedItem.ToString(), cuenta.ID, cmbTiposocio.SelectedItem.ToString(), txtCodigo.Text, txtNombresocio.Text, double.Parse(txtLimite.Text), Int32.Parse(txtCondicionpago.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo ingresar el socio");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
