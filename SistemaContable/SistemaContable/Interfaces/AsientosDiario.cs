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
    public partial class AsientosDiario : Form
    {
        private string compania;

        private List<Cuenta> listaCuentas;
        private List<Moneda> listaMonedas;
        private DataTable cuentasAsiento;
        private int numAsiento;

        public AsientosDiario(string Compania)
        {
            this.compania = Compania;
            InitializeComponent();
            this.numAsiento = LogicaAsientos.obtenerNuevoNumeroAsiento(compania);
            this.txtNumAsiento.Text = this.numAsiento.ToString();

            this.listaCuentas = LogicaCuentas.cargarCuentasDisponiblesAsiento(compania);
            this.cmbCuenta.DisplayMember = "Nombre";
            this.cmbCuenta.ValueMember = "ID";
            this.cmbCuenta.SelectedText = "Nombre";
            this.cmbCuenta.DataSource = this.listaCuentas;

            this.cuentasAsiento = new DataTable();//Datatable que se enviará cuando se guarda el asiento                
            this.cuentasAsiento.TableName = "@Cuentas";
            this.cuentasAsiento.Columns.Add("IdCuenta", typeof(int));
            this.cuentasAsiento.Columns.Add("Debe", typeof(double));
            this.cuentasAsiento.Columns.Add("Haber", typeof(double));
            this.cuentasAsiento.Columns.Add("Moneda", typeof(string));
        }

        private void cmbCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbCuenta.SelectedValue != null)
            {
                string idCuenta = this.cmbCuenta.SelectedValue.ToString();
                this.listaMonedas = LogicaMonedas.obtenerMonedasCuenta(Int32.Parse(idCuenta));
                this.cmbMoneda.DataSource = this.listaMonedas;
                this.cmbMoneda.DisplayMember = "Nombre";
                this.cmbMoneda.ValueMember = "Codigo";
                this.cmbMoneda.Enabled = true;
            }
        }

        private void DataGridViewAsiento_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int filaActual = DataGridViewAsiento.CurrentCell.RowIndex;

            if (this.DataGridViewAsiento.CurrentCell.ColumnIndex == 2)
            {
                if (this.DataGridViewAsiento["Debe", filaActual].Value != null)
                {
                    this.cuentasAsiento.Rows[filaActual]["Debe"] = this.DataGridViewAsiento[2, filaActual].Value;

                    this.DataGridViewAsiento[3, filaActual].Value = 0;
                    this.cuentasAsiento.Rows[filaActual]["Haber"] = 0;
                }
                else
                {
                    this.DataGridViewAsiento["Debe", filaActual].Value = 0;
                    this.cuentasAsiento.Rows[filaActual]["Debe"] = 0;
                }
            }

            else if (this.DataGridViewAsiento.CurrentCell.ColumnIndex == 3)
            {
                if (this.DataGridViewAsiento["Haber", filaActual].Value != null)
                {
                    this.cuentasAsiento.Rows[filaActual]["Haber"] = this.DataGridViewAsiento["Haber", filaActual].Value;

                    this.DataGridViewAsiento[2, filaActual].Value = 0;
                    this.cuentasAsiento.Rows[filaActual]["Debe"] = 0;
                }
                else
                {
                    this.DataGridViewAsiento["Haber", filaActual].Value = 0;
                    this.cuentasAsiento.Rows[filaActual]["Haber"] = 0;
                }
            }
        }

        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            if (this.cmbCuenta.SelectedValue == null)
            {
                MessageBox.Show("Seleccione la cuenta para agrega asiento.");
            }
            else if (this.cmbMoneda.SelectedValue == null)
            {
                MessageBox.Show("Seleccione la moneda para agregar asiento.");
            }
            else
            {
                DataRow Fila = this.cuentasAsiento.NewRow();
                Fila["IdCuenta"] = this.cmbCuenta.SelectedValue;
                Fila["Debe"] = 0;
                Fila["Haber"] = 0;
                Fila["Moneda"] = this.cmbMoneda.SelectedValue;
                this.cuentasAsiento.Rows.Add(Fila);

                this.DataGridViewAsiento.Rows.Add();
                int numFila = DataGridViewAsiento.Rows.Count - 1;
                this.DataGridViewAsiento["Cuenta", numFila].Value = this.cmbCuenta.Text;
                this.DataGridViewAsiento["Moneda", numFila].Value = this.cmbMoneda.Text;
                this.DataGridViewAsiento["Debe", numFila].Value = 0;
                this.DataGridViewAsiento["Haber", numFila].Value = 0;
            }
        }   

        private void DataGridViewAsiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             if (e.ColumnIndex == 4)// si se presionó sobre la columna que contiene la X
            {
                if (e.RowIndex != this.DataGridViewAsiento.Rows.Count)//valida que no se intenta eliminar la fila creadora.
                {
                    this.DataGridViewAsiento.Rows.RemoveAt(e.RowIndex);
                    this.cuentasAsiento.Rows.RemoveAt(e.RowIndex);
                }
           }
        }

        private void ButtonGuardarSeguir_Click(object sender, EventArgs e)
        {
            if (this.cuentasAsiento.Rows.Count > 1)
            {
                try
                {
                    LogicaAsientos.crearAsiento(cuentasAsiento, compania, this.numAsiento, this.txtDetalle.Text);
                    MessageBox.Show("Asiento creado con éxito.");
                    this.cuentasAsiento.Clear();
                    this.DataGridViewAsiento.Rows.Clear();
                    this.numAsiento = LogicaAsientos.obtenerNuevoNumeroAsiento(compania);
                    this.txtDetalle.Text = "";
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else
            {
                MessageBox.Show("Ingrese al menos dos cuentas para realizar el asiento");
            }
        }

        private void ButtonGuardarCerrar_Click(object sender, EventArgs e)
        {
            if (this.cuentasAsiento.Rows.Count > 1)
            {
                try
                {
                    LogicaAsientos.crearAsiento(cuentasAsiento, compania, this.numAsiento, this.txtDetalle.Text);
                    MessageBox.Show("Asiento creado con éxito.");
                    this.cuentasAsiento.Clear();
                    this.DataGridViewAsiento.Rows.Clear();
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Ingrese al menos dos cuentas para realizar el asiento");
            }
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
