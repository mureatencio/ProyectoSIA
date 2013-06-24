<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using BibliotecasComunes;
using SistemaContable.Logica;

namespace SistemaContable.Interfaces
{
    public partial class Documentos : Form
    {
        //private List<Moneda> listaMonedas;
        private List<Servicio> listaServicio;
        private List<string> listaProductos;
        private List<string> listaProyectos;
        private List<string> listaSocios;
        private List<Image> listaImagenes;
        private List<string> listaFacturas;
        private List<string> listaOrdenes;
        private string[] listaTiposDocumento = {"Factura de clientes", "Orden de Venta", "Notas de credito venta"};
        private Servicio seleccionadoActual;
        public string codigoInserción;
        public string empresa;
        public Documentos(string empresa)
        {
            this.empresa = empresa;
            InitializeComponent();


            this.comboBoxFactura.Enabled = false;
            this.comboBoxOrden.Enabled = true;

            this.listaProductos = LogicaServicios.obtenerNombreServicios(empresa);
            this.comboBoxAgregarProducto.DisplayMember = "Nombre";
            this.comboBoxAgregarProducto.ValueMember = "ID";
            this.comboBoxAgregarProducto.SelectedText = "Nombre";
            this.comboBoxAgregarProducto.DataSource = this.listaProductos;

            this.listaFacturas = LogicaDocumento.obtenerNumeroFacturas(empresa);
            this.comboBoxFactura.DisplayMember = "Nombre";
            this.comboBoxFactura.ValueMember = "ID";
            this.comboBoxFactura.SelectedText = "Nombre";
            this.comboBoxFactura.DataSource = this.listaFacturas;

            this.listaOrdenes = LogicaDocumento.obtenerNumeroOrdenes(empresa);
            this.comboBoxOrden.DisplayMember = "Nombre";
            this.comboBoxOrden.ValueMember = "ID";
            this.comboBoxOrden.SelectedText = "Nombre";
            this.comboBoxOrden.DataSource = this.listaOrdenes;

            this.listaProyectos = LogicaProyectos.obtenerNombreProyectos(empresa);
            this.comboBoxProyecto.DisplayMember = "Nombre";
            this.comboBoxProyecto.ValueMember = "ID";
            this.comboBoxProyecto.SelectedText = "Nombre";
            this.comboBoxProyecto.DataSource = this.listaProyectos;

            string seleccionado = Convert.ToString(comboBoxAgregarProducto.SelectedItem);

            this.listaServicio = LogicaServicios.cargarServicios(seleccionado);
            seleccionadoActual = listaServicio[0];
            this.labelNombre.Text = seleccionadoActual.Nombre;
            this.labelCodigo.Text = seleccionadoActual.Codigo;
            this.textBoxDescripcion.Text = seleccionadoActual.Descripcion;
            this.textBoxComentarios.Text = seleccionadoActual.Comentario;
            this.labelPrecioProd.Text = Convert.ToString(seleccionadoActual.Precio);
            this.labelUnidad.Text = seleccionadoActual.Unidad;
           // this.listaImagenes = LogicaServicios.cargarImagenes(seleccionadoActual.Codigo, empresa);
            //this.pictureBox1.Image = listaImagenes[0];

            this.listaSocios = LogicaSocios.obtenerNombreSocios(empresa);
            this.comboBoxSocio.DisplayMember = "Nombre";
            this.comboBoxSocio.ValueMember = "ID";
            this.comboBoxSocio.SelectedText = "Nombre";
            this.comboBoxSocio.DataSource = this.listaSocios;

            this.comboBoxTipo.DisplayMember = "Nombre";
            this.comboBoxTipo.ValueMember = "ID";
            this.comboBoxTipo.SelectedText = "Nombre";
            this.comboBoxTipo.DataSource = this.listaTiposDocumento;
            
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void labelTotalImpuesto_Click(object sender, EventArgs e)
        {

        }

        private void buttonAgregarArticulo_Click(object sender, EventArgs e)
        {
            this.dataGridViewDocumento.Rows.Add();
            
        }



        private void comboBoxAgregarProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccionado = Convert.ToString(comboBoxAgregarProducto.SelectedItem);

            this.listaServicio = LogicaServicios.cargarServicios(seleccionado);
            seleccionadoActual = listaServicio[0];
            this.labelNombre.Text = seleccionadoActual.Nombre;
            this.labelCodigo.Text = seleccionadoActual.Codigo;
            this.textBoxDescripcion.Text = seleccionadoActual.Descripcion;
            this.textBoxComentarios.Text = seleccionadoActual.Comentario;
            this.labelPrecioProd.Text = Convert.ToString(seleccionadoActual.Precio);
            this.labelUnidad.Text = seleccionadoActual.Unidad; 
        }

        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {
            string[] fila = { labelCodigo.Text, labelNombre.Text, "0", labelPrecioProd.Text, "0", "0" };
            this.dataGridViewDocumento.Rows.Add(fila);
        }

        private void dataGridViewDocumento_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            
            if (dataGridViewDocumento.Rows.Count > 1)
            {
                int filaActual = e.RowIndex;
                if (e.ColumnIndex == 2)
                {
                    try
                    {
                        this.dataGridViewDocumento[5, filaActual].Value = Convert.ToString((Convert.ToDouble(this.dataGridViewDocumento[3, filaActual].Value) * Convert.ToDouble(this.dataGridViewDocumento[2, filaActual].Value)) + ((Convert.ToDouble(this.dataGridViewDocumento[3, filaActual].Value) * Convert.ToDouble(this.dataGridViewDocumento[2, filaActual].Value)) * 0.13));
                        this.dataGridViewDocumento[4, filaActual].Value = Convert.ToString((Convert.ToDouble(this.dataGridViewDocumento[3, filaActual].Value) * Convert.ToDouble(this.dataGridViewDocumento[2, filaActual].Value)) * 0.13);
                        double result = Convert.ToDouble(this.dataGridViewDocumento[2, filaActual].Value);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("La cantidad no es valida", "Información", MessageBoxButtons.OK);
                        this.dataGridViewDocumento[2, filaActual].Value = 0;
                    }   
                }

            }
            double totalGeneral = 0;
            double totalArticulos = 0;
            double totalImpuestos = 0;
            for (int i = 0; i < dataGridViewDocumento.Rows.Count; i++)
            {
                totalGeneral += (Convert.ToDouble(this.dataGridViewDocumento[5, i].Value));
                totalArticulos += (Convert.ToDouble(this.dataGridViewDocumento[3, i].Value) * Convert.ToDouble(this.dataGridViewDocumento[2, i].Value));
                totalImpuestos += (Convert.ToDouble(this.dataGridViewDocumento[4, i].Value));

            }
            this.labelTotal.Text = totalGeneral.ToString();
            this.labelTotalArticulos.Text = totalArticulos.ToString();
            this.labelTotalImpuesto.Text = totalImpuestos.ToString();

        }

        private void dataGridViewDocumento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            double totalGeneral=0;
            double totalArticulos = 0;
            double totalImpuestos = 0;
            for(int i=0; i<dataGridViewDocumento.Rows.Count; i++)
            {
                totalGeneral += (Convert.ToDouble(this.dataGridViewDocumento[5, i].Value));
                totalArticulos += (Convert.ToDouble(this.dataGridViewDocumento[3, i].Value) * Convert.ToDouble(this.dataGridViewDocumento[2, i].Value));
                totalImpuestos += (Convert.ToDouble(this.dataGridViewDocumento[4, i].Value));
            
            }
            this.labelTotal.Text = totalGeneral.ToString();
            this.labelTotalArticulos.Text = totalArticulos.ToString();
            this.labelTotalImpuesto.Text = totalImpuestos.ToString();
        }

        private void comboBoxProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSocio_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            if (comboBoxProyecto.SelectedValue == null || comboBoxSocio.SelectedValue == null)
            {
                MessageBox.Show("Los datos que intentan insertar están incorrectos", "Advertencia", MessageBoxButtons.OK);
           
            }
            else
                if (this.comboBoxTipo.SelectedValue.ToString() == "Factura de clientes" ||
                    this.comboBoxTipo.SelectedValue.ToString() == "Orden de Venta")
            {

                string nombreMonedaLocal = LogicaEmpresas.obtenerMonedaLocalEmpresa(empresa);
                Documento nuevoDocumento = new Documento();

                nuevoDocumento.tipo = this.comboBoxTipo.SelectedValue.ToString();
                nuevoDocumento.fechaContabilizacion = Convert.ToDateTime(this.dateTimePickerFecha.Value.ToString());
                nuevoDocumento.socio = this.comboBoxSocio.SelectedValue.ToString();
                nuevoDocumento.proyecto = this.comboBoxProyecto.SelectedValue.ToString();
                nuevoDocumento.impuesto = Convert.ToDouble(this.labelTotalImpuesto.Text);
                nuevoDocumento.totalPrecio = Convert.ToDouble(this.labelTotalArticulos.Text);
                nuevoDocumento.total = Convert.ToDouble(this.labelTotal.Text);
                nuevoDocumento.moneda = nombreMonedaLocal;

                int codigoUnico = LogicaDocumento.insertarDocumento(nuevoDocumento);

                Linea nuevaLinea = new Linea();
                for (int i = 0; i < dataGridViewDocumento.Rows.Count-1;i++ )
                {

                    nuevaLinea.articuloCodigo = Convert.ToString(this.dataGridViewDocumento[0, i].Value);
                    nuevaLinea.Cantidad = Convert.ToDouble(this.dataGridViewDocumento[2, i].Value);
                    nuevaLinea.Impuesto = Convert.ToDouble(this.dataGridViewDocumento[4, i].Value);
                    nuevaLinea.Total = Convert.ToDouble(this.dataGridViewDocumento[2, i].Value) * Convert.ToDouble(this.dataGridViewDocumento[3, i].Value);
                    nuevaLinea.TotalGeneral = Convert.ToDouble(this.dataGridViewDocumento[5, i].Value);
                    nuevaLinea.documento = codigoUnico;

                    LogicaDocumento.insertarLinea(nuevaLinea);

                }

                MessageBox.Show("La factura fue insertada con el número: " + codigoUnico.ToString(), "Información", MessageBoxButtons.OK);
            }
            else
                if (this.comboBoxTipo.SelectedValue.ToString() == "Notas de credito venta")
            {
                string nombreMonedaLocal = LogicaEmpresas.obtenerMonedaLocalEmpresa(empresa);
                Documento nuevoDocumento = new Documento();

                nuevoDocumento.tipo = this.comboBoxTipo.SelectedValue.ToString();
                nuevoDocumento.fechaContabilizacion = Convert.ToDateTime(this.dateTimePickerFecha.Value.ToString());
                nuevoDocumento.socio = this.comboBoxSocio.SelectedValue.ToString();
                nuevoDocumento.proyecto = this.comboBoxProyecto.SelectedValue.ToString();
                nuevoDocumento.impuesto = Convert.ToDouble(this.labelTotalImpuesto.Text);
                nuevoDocumento.totalPrecio = Convert.ToDouble(this.labelTotalArticulos.Text);
                nuevoDocumento.total = Convert.ToDouble(this.labelTotal.Text);
                nuevoDocumento.moneda = nombreMonedaLocal;
                int numeroFactura = Convert.ToInt16(comboBoxFactura.SelectedValue.ToString());

                int codigoUnico = LogicaDocumento.insertarNotaCredito(nuevoDocumento, numeroFactura );
                MessageBox.Show("La Nota de crédito fue insertada", "Información", MessageBoxButtons.OK);
          
            }

        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxTipo.SelectedValue.ToString() == "Notas de credito venta")
            {
                this.comboBoxFactura.Enabled = true;
                this.comboBoxProyecto.Enabled = false;
                this.comboBoxSocio.Enabled = false;
            }
            else 
            {

                this.comboBoxFactura.Enabled = false;
                this.comboBoxProyecto.Enabled = true;
                this.comboBoxSocio.Enabled = true;
            }
        }

        private void comboBoxFactura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCargarOrden_Click(object sender, EventArgs e)
        {
            if (comboBoxOrden.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Debe seleccionar una orden de venta válida", "Advertencia", MessageBoxButtons.OK);
            }
            else 
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea cargar esta orden de venta?", "Advertencia", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int codigoUnico = LogicaDocumento.tramitarOrdenVenta(Convert.ToInt32(this.comboBoxOrden.SelectedValue.ToString()),
                                                                    Convert.ToDateTime(this.dateTimePickerFecha.Value.ToString()),
                                                                    LogicaEmpresas.obtenerMonedaLocalEmpresa(empresa),empresa);
                    MessageBox.Show("Se ha generado la factura a partir de la orden", "Información", MessageBoxButtons.OK); 
                }
                

            }
        }


    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using BibliotecasComunes;
using SistemaContable.Logica;

namespace SistemaContable.Interfaces
{
    public partial class Documentos : Form
    {
        //private List<Moneda> listaMonedas;
        private List<Servicio> listaServicio;
        private List<string> listaProductos;
        private List<string> listaProyectos;
        private List<string> listaSocios;
        private List<Image> listaImagenes;
        private List<string> listaFacturas;
        private List<string> listaOrdenes;
        private string[] listaTiposDocumento = {"Factura de clientes", "Orden de Venta", "Notas de credito venta"};
        private Servicio seleccionadoActual;
        public string codigoInserción;
        public string empresa;
        public Documentos(string empresa)
        {
            this.empresa = empresa;
            InitializeComponent();

            this.comboBoxFactura.Enabled = false;
            this.comboBoxOrden.Enabled = true;

            this.listaProductos = LogicaServicios.obtenerNombreServicios(empresa);
            this.comboBoxAgregarProducto.DisplayMember = "Nombre";
            this.comboBoxAgregarProducto.ValueMember = "ID";
            this.comboBoxAgregarProducto.SelectedText = "Nombre";
            this.comboBoxAgregarProducto.DataSource = this.listaProductos;

            this.listaFacturas = LogicaDocumento.obtenerNumeroFacturas(empresa);
            this.comboBoxFactura.DisplayMember = "Nombre";
            this.comboBoxFactura.ValueMember = "ID";
            this.comboBoxFactura.SelectedText = "Nombre";
            this.comboBoxFactura.DataSource = this.listaFacturas;

            this.listaOrdenes = LogicaDocumento.obtenerNumeroOrdenes(empresa);
            this.comboBoxOrden.DisplayMember = "Nombre";
            this.comboBoxOrden.ValueMember = "ID";
            this.comboBoxOrden.SelectedText = "Nombre";
            this.comboBoxOrden.DataSource = this.listaOrdenes;

            this.listaProyectos = LogicaProyectos.obtenerNombreProyectos(empresa);
            this.comboBoxProyecto.DisplayMember = "Nombre";
            this.comboBoxProyecto.ValueMember = "ID";
            this.comboBoxProyecto.SelectedText = "Nombre";
            this.comboBoxProyecto.DataSource = this.listaProyectos;

            string seleccionado = Convert.ToString(comboBoxAgregarProducto.SelectedItem);

            this.listaServicio = LogicaServicios.cargarServicios(seleccionado);
            seleccionadoActual = listaServicio[0];
            this.labelNombre.Text = seleccionadoActual.Nombre;
            this.labelCodigo.Text = seleccionadoActual.Codigo;
            this.textBoxDescripcion.Text = seleccionadoActual.Descripcion;
            this.textBoxComentarios.Text = seleccionadoActual.Comentario;
            this.labelPrecioProd.Text = Convert.ToString(seleccionadoActual.Precio);
            this.labelUnidad.Text = seleccionadoActual.Unidad;
           // this.listaImagenes = LogicaServicios.cargarImagenes(seleccionadoActual.Codigo, empresa);
            //this.pictureBox1.Image = listaImagenes[0];

            this.listaSocios = LogicaSocios.obtenerNombreSocios(empresa);
            this.comboBoxSocio.DisplayMember = "Nombre";
            this.comboBoxSocio.ValueMember = "ID";
            this.comboBoxSocio.SelectedText = "Nombre";
            this.comboBoxSocio.DataSource = this.listaSocios;

            this.comboBoxTipo.DisplayMember = "Nombre";
            this.comboBoxTipo.ValueMember = "ID";
            this.comboBoxTipo.SelectedText = "Nombre";
            this.comboBoxTipo.DataSource = this.listaTiposDocumento;
            
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void labelTotalImpuesto_Click(object sender, EventArgs e)
        {

        }

        private void buttonAgregarArticulo_Click(object sender, EventArgs e)
        {
            this.dataGridViewDocumento.Rows.Add();
            
        }

        private void comboBoxAgregarProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccionado = Convert.ToString(comboBoxAgregarProducto.SelectedItem);

            this.listaServicio = LogicaServicios.cargarServicios(seleccionado);
            seleccionadoActual = listaServicio[0];
            this.labelNombre.Text = seleccionadoActual.Nombre;
            this.labelCodigo.Text = seleccionadoActual.Codigo;
            this.textBoxDescripcion.Text = seleccionadoActual.Descripcion;
            this.textBoxComentarios.Text = seleccionadoActual.Comentario;
            this.labelPrecioProd.Text = Convert.ToString(seleccionadoActual.Precio);
            this.labelUnidad.Text = seleccionadoActual.Unidad; 
        }

        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {
            string[] fila = { labelCodigo.Text, labelNombre.Text, "0", labelPrecioProd.Text, "0", "0" };
            this.dataGridViewDocumento.Rows.Add(fila);
        }

        private void dataGridViewDocumento_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            
            if (dataGridViewDocumento.Rows.Count > 1)
            {
                int filaActual = e.RowIndex;
                if (e.ColumnIndex == 2)
                {
                    try
                    {
                        this.dataGridViewDocumento[5, filaActual].Value = Convert.ToString((Convert.ToDouble(this.dataGridViewDocumento[3, filaActual].Value) * Convert.ToDouble(this.dataGridViewDocumento[2, filaActual].Value)) + ((Convert.ToDouble(this.dataGridViewDocumento[3, filaActual].Value) * Convert.ToDouble(this.dataGridViewDocumento[2, filaActual].Value)) * 0.13));
                        this.dataGridViewDocumento[4, filaActual].Value = Convert.ToString((Convert.ToDouble(this.dataGridViewDocumento[3, filaActual].Value) * Convert.ToDouble(this.dataGridViewDocumento[2, filaActual].Value)) * 0.13);
                        double result = Convert.ToDouble(this.dataGridViewDocumento[2, filaActual].Value);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("La cantidad no es valida", "Información", MessageBoxButtons.OK);
                        this.dataGridViewDocumento[2, filaActual].Value = 0;
                    }   
                }

            }
            double totalGeneral = 0;
            double totalArticulos = 0;
            double totalImpuestos = 0;
            for (int i = 0; i < dataGridViewDocumento.Rows.Count; i++)
            {
                totalGeneral += (Convert.ToDouble(this.dataGridViewDocumento[5, i].Value));
                totalArticulos += (Convert.ToDouble(this.dataGridViewDocumento[3, i].Value) * Convert.ToDouble(this.dataGridViewDocumento[2, i].Value));
                totalImpuestos += (Convert.ToDouble(this.dataGridViewDocumento[4, i].Value));

            }
            this.labelTotal.Text = totalGeneral.ToString();
            this.labelTotalArticulos.Text = totalArticulos.ToString();
            this.labelTotalImpuesto.Text = totalImpuestos.ToString();

        }

        private void dataGridViewDocumento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            double totalGeneral=0;
            double totalArticulos = 0;
            double totalImpuestos = 0;
            for(int i=0; i<dataGridViewDocumento.Rows.Count; i++)
            {
                totalGeneral += (Convert.ToDouble(this.dataGridViewDocumento[5, i].Value));
                totalArticulos += (Convert.ToDouble(this.dataGridViewDocumento[3, i].Value) * Convert.ToDouble(this.dataGridViewDocumento[2, i].Value));
                totalImpuestos += (Convert.ToDouble(this.dataGridViewDocumento[4, i].Value));
            
            }
            this.labelTotal.Text = totalGeneral.ToString();
            this.labelTotalArticulos.Text = totalArticulos.ToString();
            this.labelTotalImpuesto.Text = totalImpuestos.ToString();
        }

        private void comboBoxProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSocio_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            if (comboBoxProyecto.SelectedValue == null || comboBoxSocio.SelectedValue == null)
            {
                MessageBox.Show("Los datos que intentan insertar están incorrectos", "Advertencia", MessageBoxButtons.OK);
           
            }
            else
                if (this.comboBoxTipo.SelectedValue.ToString() == "Factura de clientes" ||
                    this.comboBoxTipo.SelectedValue.ToString() == "Orden de Venta")
            {

                string nombreMonedaLocal = LogicaEmpresas.obtenerMonedaLocalEmpresa(empresa);
                Documento nuevoDocumento = new Documento();

                nuevoDocumento.tipo = this.comboBoxTipo.SelectedValue.ToString();
                nuevoDocumento.fechaContabilizacion = Convert.ToDateTime(this.dateTimePickerFecha.Value.ToString());
                nuevoDocumento.socio = this.comboBoxSocio.SelectedValue.ToString();
                nuevoDocumento.proyecto = this.comboBoxProyecto.SelectedValue.ToString();
                nuevoDocumento.impuesto = Convert.ToDouble(this.labelTotalImpuesto.Text);
                nuevoDocumento.totalPrecio = Convert.ToDouble(this.labelTotalArticulos.Text);
                nuevoDocumento.total = Convert.ToDouble(this.labelTotal.Text);
                nuevoDocumento.moneda = nombreMonedaLocal;

                int codigoUnico = LogicaDocumento.insertarDocumento(nuevoDocumento);

                Linea nuevaLinea = new Linea();
                for (int i = 0; i < dataGridViewDocumento.Rows.Count-1;i++ )
                {

                    nuevaLinea.articuloCodigo = Convert.ToString(this.dataGridViewDocumento[0, i].Value);
                    nuevaLinea.Cantidad = Convert.ToDouble(this.dataGridViewDocumento[2, i].Value);
                    nuevaLinea.Impuesto = Convert.ToDouble(this.dataGridViewDocumento[4, i].Value);
                    nuevaLinea.Total = Convert.ToDouble(this.dataGridViewDocumento[2, i].Value) * Convert.ToDouble(this.dataGridViewDocumento[3, i].Value);
                    nuevaLinea.TotalGeneral = Convert.ToDouble(this.dataGridViewDocumento[5, i].Value);
                    nuevaLinea.documento = codigoUnico;

                    LogicaDocumento.insertarLinea(nuevaLinea);

                }

                MessageBox.Show("La factura fue insertada con el número: " + codigoUnico.ToString(), "Información", MessageBoxButtons.OK);
            }
            else
                if (this.comboBoxTipo.SelectedValue.ToString() == "Notas de credito venta")
            {
                string nombreMonedaLocal = LogicaEmpresas.obtenerMonedaLocalEmpresa(empresa);
                Documento nuevoDocumento = new Documento();

                nuevoDocumento.tipo = this.comboBoxTipo.SelectedValue.ToString();
                nuevoDocumento.fechaContabilizacion = Convert.ToDateTime(this.dateTimePickerFecha.Value.ToString());
                nuevoDocumento.socio = this.comboBoxSocio.SelectedValue.ToString();
                nuevoDocumento.proyecto = this.comboBoxProyecto.SelectedValue.ToString();
                nuevoDocumento.impuesto = Convert.ToDouble(this.labelTotalImpuesto.Text);
                nuevoDocumento.totalPrecio = Convert.ToDouble(this.labelTotalArticulos.Text);
                nuevoDocumento.total = Convert.ToDouble(this.labelTotal.Text);
                nuevoDocumento.moneda = nombreMonedaLocal;
                int numeroFactura = Convert.ToInt16(comboBoxFactura.SelectedValue.ToString());

                int codigoUnico = LogicaDocumento.insertarNotaCredito(nuevoDocumento, numeroFactura );
                MessageBox.Show("La Nota de crédito fue insertada", "Información", MessageBoxButtons.OK);
          
            }

        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxTipo.SelectedValue.ToString() == "Notas de credito venta")
            {
                this.comboBoxFactura.Enabled = true;
                this.comboBoxProyecto.Enabled = false;
                this.comboBoxSocio.Enabled = false;
            }
            else 
            {

                this.comboBoxFactura.Enabled = false;
                this.comboBoxProyecto.Enabled = true;
                this.comboBoxSocio.Enabled = true;
            }
        }

        private void comboBoxFactura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCargarOrden_Click(object sender, EventArgs e)
        {
            if (comboBoxOrden.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Debe seleccionar una orden de venta válida", "Advertencia", MessageBoxButtons.OK);
            }
            else 
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea cargar esta orden de venta?", "Advertencia", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int codigoUnico = LogicaDocumento.tramitarOrdenVenta(Convert.ToInt32(this.comboBoxOrden.SelectedValue.ToString()),
                                                                    Convert.ToDateTime(this.dateTimePickerFecha.Value.ToString()),
                                                                    LogicaEmpresas.obtenerMonedaLocalEmpresa(empresa),empresa);
                    MessageBox.Show("Se ha generado la factura a partir de la orden", "Información", MessageBoxButtons.OK); 
                }
                

            }
        }
    }
}
>>>>>>> origin/Compras-y-ventas
