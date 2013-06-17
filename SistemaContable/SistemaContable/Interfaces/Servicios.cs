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
    public partial class Servicios : Form
    {
        private string empresa;

        public Servicios(string empresa)
        {
            this.empresa = empresa;
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonAgregarArticulo_Click(object sender, EventArgs e)
        {

            Servicio servicioNuevo =  new Servicio();
            servicioNuevo.Nombre = textBoxNombre.Text;
            servicioNuevo.Codigo = textBoxCodigo.Text;
            servicioNuevo.Descripcion = textBoxDescripcion.Text;
            servicioNuevo.Comentario = textBoxComentario.Text;
            servicioNuevo.Precio = Convert.ToDouble(textBoxPrecio.Text);
            servicioNuevo.Unidad = textBoxUnidad.Text;

            byte[] imagenInsertar;

            LogicaServicios.insertarServicio(servicioNuevo, empresa);

            if (pictureBox1.Image != null)
            {
                // Stream usado como buffer
                System.IO.MemoryStream ms1 = new System.IO.MemoryStream();
                // Se guarda la imagen en el buffer
                pictureBox1.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg); // Se extraen los bytes del buffer para asignarlos como valor para el parámetro.
                imagenInsertar = ms1.GetBuffer();
                LogicaServicios.insertarImagen(servicioNuevo.Codigo, imagenInsertar);
            }
            if (pictureBox2.Image != null)
            {
                System.IO.MemoryStream ms2 = new System.IO.MemoryStream();
                pictureBox2.Image.Save(ms2, System.Drawing.Imaging.ImageFormat.Jpeg); // Se extraen los bytes del buffer para asignarlos como valor para el parámetro.
                imagenInsertar = ms2.GetBuffer();
                LogicaServicios.insertarImagen(servicioNuevo.Codigo, imagenInsertar);
            }
            if (pictureBox3.Image != null)
            {
                System.IO.MemoryStream ms3 = new System.IO.MemoryStream();
                pictureBox3.Image.Save(ms3, System.Drawing.Imaging.ImageFormat.Jpeg); // Se extraen los bytes del buffer para asignarlos como valor para el parámetro.
                imagenInsertar = ms3.GetBuffer();
                LogicaServicios.insertarImagen(servicioNuevo.Codigo, imagenInsertar);            
            }
            if (pictureBox4.Image != null)
            {
                System.IO.MemoryStream ms4 = new System.IO.MemoryStream();
                pictureBox4.Image.Save(ms4, System.Drawing.Imaging.ImageFormat.Jpeg); // Se extraen los bytes del buffer para asignarlos como valor para el parámetro.
                imagenInsertar = ms4.GetBuffer();
                LogicaServicios.insertarImagen(servicioNuevo.Codigo, imagenInsertar);            
            }
            if (pictureBox5.Image != null)
            {
                System.IO.MemoryStream ms5 = new System.IO.MemoryStream();
                pictureBox5.Image.Save(ms5, System.Drawing.Imaging.ImageFormat.Jpeg); // Se extraen los bytes del buffer para asignarlos como valor para el parámetro.
                imagenInsertar = ms5.GetBuffer();
                LogicaServicios.insertarImagen(servicioNuevo.Codigo, imagenInsertar);            
            }

            MessageBox.Show("El artículo de tipo servicio ha sido insertado", "Información", MessageBoxButtons.OK);
               


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            // abrir file dialog
            OpenFileDialog open = new OpenFileDialog();
            // agregarle filtros de imagenes
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // Mostrar imagenes
                pictureBox1.Image = new Bitmap(open.FileName);
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // abrir file dialog
            OpenFileDialog open = new OpenFileDialog();
            // agregarle filtros de imagenes
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // Mostrar imagenes
                pictureBox2.Image = new Bitmap(open.FileName);
            }
            else
            {
                pictureBox2.Image = null;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // abrir file dialog
            OpenFileDialog open = new OpenFileDialog();
            // agregarle filtros de imagenes
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // Mostrar imagenes
                pictureBox3.Image = new Bitmap(open.FileName);
            }
            else
            {
                pictureBox3.Image = null;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // abrir file dialog
            OpenFileDialog open = new OpenFileDialog();
            // agregarle filtros de imagenes
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // Mostrar imagenes
                pictureBox4.Image = new Bitmap(open.FileName);
            }
            else
            {
                pictureBox4.Image = null;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // abrir file dialog
            OpenFileDialog open = new OpenFileDialog();
            // agregarle filtros de imagenes
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // Mostrar imagenes
                pictureBox5.Image = new Bitmap(open.FileName);
            }
            else 
            {
                pictureBox5.Image = null;
            }
        }
    }
}
