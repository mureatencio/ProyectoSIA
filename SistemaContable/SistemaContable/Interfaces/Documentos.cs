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
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

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

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxAgregarProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccionado = Convert.ToString(comboBoxAgregarProducto.SelectedItem);

            this.listaServicio = LogicaServicios.cargarServicios(seleccionado);
            seleccionadoActual = listaServicio[0];
            this.labelNombre.Text = seleccionadoActual.Nombre;
            this.textBoxDescripcion.Text = seleccionadoActual.Descripcion;
            this.textBoxComentarios.Text = seleccionadoActual.Comentario;
            this.labelPrecioProd.Text = Convert.ToString(seleccionadoActual.Precio);
            this.labelUnidad.Text = seleccionadoActual.Unidad; 
        }


    }
}
