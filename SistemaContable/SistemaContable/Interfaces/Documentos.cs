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

namespace SistemaContable.Interfaces
{
    public partial class Documentos : Form
    {
        //private List<Moneda> listaMonedas;
        private List<Servicio> listaServicio;
        private List<string> listaProductos;
        private List<string> listaProyectos;
        private List<string> listaSocios;
        private string[] listaTiposDocumento = {"Factura", "Orden Venta", "Nota Credito"};
        private Servicio seleccionadoActual;
        public string codigoInserción;
        public string empresa;
        public Documentos(string empresa)
        {
            this.empresa = empresa;
            InitializeComponent();


            this.listaProductos = LogicaServicios.obtenerNombreServicios(empresa);
            this.comboBoxAgregarProducto.DisplayMember = "Nombre";
            this.comboBoxAgregarProducto.ValueMember = "ID";
            this.comboBoxAgregarProducto.SelectedText = "Nombre";
            this.comboBoxAgregarProducto.DataSource = this.listaProductos;

            this.listaSocios = LogicaSocios.obtenerNombreSocios(empresa);
            this.comboBoxSocio.DisplayMember = "Nombre";
            this.comboBoxSocio.ValueMember = "ID";
            this.comboBoxSocio.SelectedText = "Nombre";
            this.comboBoxSocio.DataSource = this.listaSocios;

            this.listaProyectos = LogicaProyectos.obtenerNombreProyectos(comboBoxSocio.SelectedValue.ToString(),empresa);
            this.comboBoxProyecto.DisplayMember = "Nombre";
            this.comboBoxProyecto.ValueMember = "ID";
            this.comboBoxProyecto.SelectedText = "Nombre";
            this.comboBoxProyecto.DataSource = this.listaProyectos;

            this.comboBoxTipo.DisplayMember = "Nombre";
            this.comboBoxTipo.ValueMember = "ID";
            this.comboBoxTipo.SelectedText = "Nombre";
            this.comboBoxTipo.DataSource = this.listaTiposDocumento;
            
        }

        private void labelTotalImpuesto_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAgregarArticulo_Click(object sender, EventArgs e)
        {
            this.dataGridViewDocumento.Rows.Add();
            ExplorarProductos ventanaExplorarProductos = new ExplorarProductos(this.empresa, this.dataGridViewDocumento.Rows.Count-1);
            ventanaExplorarProductos.ShowDialog();

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
                    this.dataGridViewDocumento[5, filaActual].Value = Convert.ToString((Convert.ToDouble(this.dataGridViewDocumento[3, filaActual].Value) * Convert.ToDouble(this.dataGridViewDocumento[2, filaActual].Value))+((Convert.ToDouble(this.dataGridViewDocumento[3, filaActual].Value) * Convert.ToDouble(this.dataGridViewDocumento[2, filaActual].Value))*0.13));
                    this.dataGridViewDocumento[4, filaActual].Value = Convert.ToString((Convert.ToDouble(this.dataGridViewDocumento[3, filaActual].Value) * Convert.ToDouble(this.dataGridViewDocumento[2, filaActual].Value))*0.13);
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
            this.listaProyectos = LogicaProyectos.obtenerNombreProyectos(comboBoxSocio.SelectedValue.ToString(), empresa);
            this.comboBoxProyecto.DisplayMember = "Nombre";
            this.comboBoxProyecto.ValueMember = "ID";
            this.comboBoxProyecto.SelectedText = "Nombre";
            this.comboBoxProyecto.DataSource = this.listaProyectos;

          
        }


    }
}
