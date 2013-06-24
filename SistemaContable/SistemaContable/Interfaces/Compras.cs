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
using System.Data;

namespace SistemaContable.Interfaces
{
    public partial class Compras : Form
    {
        int NumeroFactura;
        string empresa;
        List<Socio> socios = new List<Socio>();
        List<Proyecto> proyectos = new List<Proyecto>();

        public Compras(string empresa)
        {
            this.empresa = empresa;
            InitializeComponent();
            LLenadoMonedas();
            LLenadoSocios();
            LLenadoTiposDocumentos();
            LLenadoProyecto();
        }

        private void LLenadoProyecto()
        {
            try
            {
                proyectos = LogicaProyectos.obtenerProyectosActivos(empresa);
                for (int i = 0; i < proyectos.Count; i++)
                {
                    cmbProyecto.Items.Add(proyectos[i].Nombre);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo obtener los Proyectos.");
            }
        }

        private void LLenadoSocios()
        {
            try
            {
                socios = LogicaSocios.obtenerSocios(empresa);
                for (int i = 0; i < socios.Count; i++)
                {
                    cmbSocios.Items.Add(socios[i].Nombre);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo obtener los socios.");
            }
        }

        private void LLenadoTiposDocumentos()
        {
            List<string> tiposdocs = new List<string>();
            try
            {
                tiposdocs = LogicaCompras.obtenerTipoCompras();
                for (int i = 0; i < tiposdocs.Count; i++)
                {
                    cmbTiposDocumentos.Items.Add(tiposdocs[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo obtener los tipos de Documentos.");
            }
        }

        private void LLenadoMonedas()
        {
            List<Moneda> monedas = new List<Moneda>();
            try 
            {
                monedas = LogicaMonedas.obtenerMonedas();
                for (int i = 0; i < monedas.Count; i++)
                {
                    cmbMonedas.Items.Add(monedas[i].Codigo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo obtener las Monedas.");
            }
        }

        private void dtgrdServicios_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int filaActual = dtgrdServicios.CurrentCell.RowIndex;

            if (this.dtgrdServicios.CurrentCell.ColumnIndex == 2 || this.dtgrdServicios.CurrentCell.ColumnIndex == 3)
            {
                if (this.dtgrdServicios["Cantidad", filaActual].Value != null && this.dtgrdServicios["Precio", filaActual].Value != null)
                {
                    int cantidad = Int32.Parse(this.dtgrdServicios["Cantidad", filaActual].Value.ToString());
                    double precio = Double.Parse(this.dtgrdServicios["Precio", filaActual].Value.ToString());
                    double total = cantidad * precio;

                    this.dtgrdServicios["TotalProducto", filaActual].Value = total.ToString();

                    double impuesto;
                    if (this.chckImpuesto.Checked)
                    {
                        impuesto = total * 0.13;
                    }
                    else
                    {
                        impuesto = 0;
                    }
                    this.dtgrdServicios["Impuesto", filaActual].Value = impuesto.ToString();
                    this.dtgrdServicios["PrecioJunto", filaActual].Value = (total+impuesto).ToString();
                }
                this.actualizarTotales();
            }
        }

        private void actualizarTotales()
        {
            double impuestoTotal = 0;
            double total = 0;
            for (int i = 0; i < dtgrdServicios.Rows.Count - 1; i++)
            {
                if (this.dtgrdServicios["TotalProducto", i].Value != null)
                {
                    double totalProducto = Double.Parse(this.dtgrdServicios["TotalProducto", i].Value.ToString());
                    total += totalProducto;
                    double impuesto = Double.Parse(this.dtgrdServicios["Impuesto", i].Value.ToString());
                    impuestoTotal += impuesto;
                }
            }
            this.txtTotal.Text = total.ToString();
            this.txtImpuesto.Text = impuestoTotal.ToString();
            this.txtTotalJunto.Text = (total + impuestoTotal).ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                Socio socioesc = socios.Find(s => s.Nombre.Equals(cmbSocios.SelectedItem.ToString()));
                Proyecto proyectoesc = proyectos.Find(a => a.Nombre.Equals(cmbProyecto.SelectedItem.ToString()));

                DataTable servicio = new DataTable();
                servicio.TableName = "@Cuentas";
                servicio.Columns.Add("Nombre", typeof(string));
                servicio.Columns.Add("Descripcion", typeof(string));
                servicio.Columns.Add("Cantidad", typeof(int));
                servicio.Columns.Add("Precio", typeof(double));
                servicio.Columns.Add("PrecioTotal", typeof(double));
                servicio.Columns.Add("Impuesto", typeof(double));
                servicio.Columns.Add("PrecioJunto", typeof(double));
                for(int i = 0; i < dtgrdServicios.Rows.Count - 1; i++)
                {
                    DataRow Fila = servicio.NewRow();
                    Fila["Nombre"] = dtgrdServicios["Nombre", i].Value;
                    Fila["Descripcion"] = dtgrdServicios["Descripcion", i].Value;
                    Fila["Cantidad"] = Int32.Parse(dtgrdServicios["Cantidad", i].Value.ToString());
                    Fila["Precio"] = double.Parse(dtgrdServicios["Precio", i].Value.ToString());
                    Fila["PrecioTotal"] = double.Parse(dtgrdServicios["TotalProducto", i].Value.ToString());
                    Fila["Impuesto"] = double.Parse(dtgrdServicios["Impuesto", i].Value.ToString());
                    Fila["PrecioJunto"] = double.Parse(dtgrdServicios["PrecioJunto", i].Value.ToString());
                    servicio.Rows.Add(Fila);
                }
                double total = Double.Parse(this.txtTotal.Text);
                double totalImpuesto = Double.Parse(this.txtImpuesto.Text);
                double totalJunto = Double.Parse(this.txtTotalJunto.Text);
                LogicaCompras.insertarCompra(empresa, socioesc.Codigo, proyectoesc.Codigo, cmbMonedas.SelectedItem.ToString(), cmbTiposDocumentos.SelectedItem.ToString(), total, totalImpuesto, totalJunto, servicio, this.dttmpckrFecha.Value, this.NumeroFactura);
                MessageBox.Show("La " + cmbTiposDocumentos.SelectedItem.ToString() + " se realizó exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo crear la orden.");
            }
        }

        private void chckImpuesto_CheckedChanged(object sender, EventArgs e)
        {
            double impuestoTotal = 0;
            double totalJunto = 0;
            for (int i = 0; i < dtgrdServicios.Rows.Count - 1; i++)
            {
                if (this.dtgrdServicios["Cantidad", i].Value != null && this.dtgrdServicios["Precio", i].Value != null)
                {
                    int cantidad = Int32.Parse(this.dtgrdServicios["Cantidad", i].Value.ToString());
                    double precio = Double.Parse(this.dtgrdServicios["Precio", i].Value.ToString());
                    double total = Double.Parse(this.dtgrdServicios["TotalProducto", i].Value.ToString());
                    double impuesto;
                    if (this.chckImpuesto.Checked)
                    {
                        impuesto = total * 0.13;
                        impuestoTotal += impuesto;
                    }
                    else
                    {
                        impuesto = 0;
                    }
                    totalJunto += impuesto + total;
                    this.dtgrdServicios["Impuesto", i].Value = impuesto.ToString();
                    this.dtgrdServicios["PrecioJunto", i].Value = (impuesto + total).ToString();
                }
            }
            this.txtImpuesto.Text = impuestoTotal.ToString();
            this.txtTotalJunto.Text = totalJunto.ToString();
        }

        private void bttnCargar_Click(object sender, EventArgs e)
        {
            if (!this.cmbTiposDocumentos.SelectedItem.ToString().Equals("Orden") && !this.cmbTiposDocumentos.SelectedItem.ToString().Equals(""))
            {
                //HACER LA FUNCIONALIDAD DE QUE EL MAE CARGUE LA INFO DE LA ORDEN O FACTURA AGREGADA
                DocumentosCompra documentos = new DocumentosCompra(empresa, cmbTiposDocumentos.SelectedItem.ToString());
                documentos.ShowDialog();
                if (Variables.Compra != null)
                {
                    cmbSocios.SelectedItem = Variables.Compra.Proveedor.Nombre;
                    cmbMonedas.SelectedItem = Variables.Compra.Moneda.Codigo;
                    cmbProyecto.SelectedItem = Variables.Compra.Proyecto.Nombre;
                    dttmpckrFecha.Value = Variables.Compra.Fecha;
                    if (cmbTiposDocumentos.SelectedItem.Equals("Factura"))
                    {
                        for (int i = 0; i < Variables.Compra.Servicios.Count; i++)
                        {
                            if (i < Variables.Compra.Servicios.Count)
                            {
                                dtgrdServicios.Rows.Add();
                            }
                            dtgrdServicios["Nombre", i].Value = Variables.Compra.Servicios[i].Nombre;
                            dtgrdServicios["Descripcion", i].Value = Variables.Compra.Servicios[i].Descripcion;
                            dtgrdServicios["Cantidad", i].Value = Variables.Compra.Servicios[i].Cantidad.ToString();
                            dtgrdServicios["Precio", i].Value = Variables.Compra.Servicios[i].Precio.ToString();
                            dtgrdServicios["TotalProducto", i].Value = Variables.Compra.Servicios[i].Total.ToString();
                            dtgrdServicios["Impuesto", i].Value = Variables.Compra.Servicios[i].Impuesto.ToString();
                            dtgrdServicios["PrecioJunto", i].Value = Variables.Compra.Servicios[i].TotalImpuesto.ToString();
                        }
                    }
                    else 
                    {
                        this.NumeroFactura = Variables.Compra.Consecutivo;
                        for (int i = 0; i < Variables.Compra.Servicios.Count; i++)
                        {
                            if (i < Variables.Compra.Servicios.Count)
                            {
                                dtgrdServicios.Rows.Add();
                            }
                            dtgrdServicios["Nombre", i].Value = Variables.Compra.Servicios[i].Nombre;
                            dtgrdServicios["Descripcion", i].Value = Variables.Compra.Servicios[i].Descripcion;
                            dtgrdServicios["Cantidad", i].Value = Variables.Compra.Servicios[i].Cantidad.ToString();
                            dtgrdServicios["Precio", i].Value = Variables.Compra.Servicios[i].Precio.ToString();
                            dtgrdServicios["TotalProducto", i].Value = 0;
                            dtgrdServicios["Impuesto", i].Value = 0;
                            dtgrdServicios["PrecioJunto", i].Value = 0;
                        }
                    }
                }
                Variables.Compra = null;
                this.actualizarTotales();
            }
        }
    }
}
