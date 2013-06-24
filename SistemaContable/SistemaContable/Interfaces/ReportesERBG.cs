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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.IO;


namespace SistemaContable.Interfaces
{
    public partial class ReportesERBG : Form
    {
        string Empresa, reporte;
        DataSet dataset = new DataSet(); 
        public ReportesERBG(string empresa, string reporte)
        {
            this.Empresa = empresa;
            this.reporte = reporte;
            InitializeComponent();
            cmbPeriodo.Items.Clear();
            cmbPeriodo.Items.Add("2012-10-01 / 2012-10-31");
            cmbPeriodo.Items.Add("2012-11-01 / 2012-11-30");
            cmbPeriodo.Items.Add("2012-12-01 / 2013-12-31");
            cmbPeriodo.Items.Add("2013-01-01 / 2012-01-31");
            cmbPeriodo.Items.Add("2013-02-01 / 2013-02-28");
            cmbPeriodo.Items.Add("2013-03-01 / 2013-03-31");
            cmbPeriodo.Items.Add("2013-04-01 / 2013-04-30");
            cmbPeriodo.Items.Add("2013-05-01 / 2013-05-31");
            cmbPeriodo.Items.Add("2013-06-01 / 2013-06-30");
            cmbPeriodo.Items.Add("2013-07-01 / 2013-07-31");
            cmbPeriodo.Items.Add("2013-08-01 / 2013-08-31");
            cmbPeriodo.Items.Add("2013-09-01 / 2013-09-30");
            cmbPeriodo.SelectedIndex = 0;

            comboBoxPeriodoFin.Items.Clear();
            comboBoxPeriodoFin.Items.Add("2012-10-01 / 2012-10-31");
            comboBoxPeriodoFin.Items.Add("2012-11-01 / 2012-11-30");
            comboBoxPeriodoFin.Items.Add("2012-12-01 / 2013-12-31");
            comboBoxPeriodoFin.Items.Add("2013-01-01 / 2012-01-31");
            comboBoxPeriodoFin.Items.Add("2013-02-01 / 2013-02-28");
            comboBoxPeriodoFin.Items.Add("2013-03-01 / 2013-03-31");
            comboBoxPeriodoFin.Items.Add("2013-04-01 / 2013-04-30");
            comboBoxPeriodoFin.Items.Add("2013-05-01 / 2013-05-31");
            comboBoxPeriodoFin.Items.Add("2013-06-01 / 2013-06-30");
            comboBoxPeriodoFin.Items.Add("2013-07-01 / 2013-07-31");
            comboBoxPeriodoFin.Items.Add("2013-08-01 / 2013-08-31");
            comboBoxPeriodoFin.Items.Add("2013-09-01 / 2014-09-30");
            comboBoxPeriodoFin.SelectedIndex = 0;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (cmbPeriodo.Text.Equals(""))
            {
                MessageBox.Show("Error, escoja un periodo");
            }
            else
            {
                Periodo periodoNuevo = new Periodo();
                string nuevoEstado = this.cmbPeriodo.SelectedItem.ToString();
                string[] tokens = nuevoEstado.Split('/');
                string fechaini = tokens[0];

                string nuevoEstadofin = this.comboBoxPeriodoFin.SelectedItem.ToString();
                string[] tokensfin = nuevoEstadofin.Split('/');
                string fechafin = tokensfin[1];

                if (reporte.Equals("EstadoResultados"))
                {
                    dataset = LogicaEstadoResultados.obtenerEstadoResultados(Empresa, fechaini, fechafin);
                    dtgReporte.DataSource = dataset.Tables[0];
                    dtgReporte.Refresh();
                }
                else if (reporte.Equals("BalanceGeneral"))
                {
                    DataSet dataset = LogicaBalance.obtenerBalance(Empresa, fechaini, fechafin);
                    dtgReporte.DataSource = dataset.Tables[0];
                    dtgReporte.Refresh();
                }
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "pdf Files (*.pdf)|*.pdf| All Files (*.*)|*.*";
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    string filename = saveFileDialog.FileName;
                    if (filename.Trim() != "")
                    {
                        //string filename = "Reporte.pdf";
                        FileStream file = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                        PdfWriter.GetInstance(doc, file);
                        doc.Open();

                        if (reporte.Equals("EstadoResultados"))
                        {
                            doc.Add(new Paragraph("Estado Resultados"));
                        }
                        else if (reporte.Equals("BalanceGenera"))
                        {
                            doc.Add(new Paragraph("Balance General"));
                        }
                        doc.Add(new Paragraph(Empresa));
                        doc.Add(new Paragraph(""));
                        GenerarDocumento(doc);
                        doc.Close();
                        Process.Start(filename);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GenerarDocumento(Document document)
        {
            //se crea un objeto PdfTable con el numero de columnas del 
            //dataGridView
            PdfPTable datatable = new PdfPTable(dtgReporte.ColumnCount);
            //asignamos algunas propiedades para el diseño del pdf
            datatable.DefaultCell.Padding = 3;
            float[] headerwidths = GetTamañoColumnas(dtgReporte);
            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 2;
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            //SE GENERA EL ENCABEZADO DE LA TABLA EN EL PDF
            for (int i = 0; i < dtgReporte.ColumnCount; i++)
            {
                datatable.AddCell(dtgReporte.Columns[i].HeaderText);
            }
            datatable.HeaderRows = 1;
            datatable.DefaultCell.BorderWidth = 1;
            //SE GENERA EL CUERPO DEL PDF
            for (int i = 0; i < dtgReporte.RowCount-1; i++)
            {
                if (datatable.Rows[i] == null)
                {
                    break;
                }
                for (int j = 0; j < dtgReporte.ColumnCount; j++)
                {
                    if (i >= dtgReporte.RowCount - 1) { break; }
                    datatable.AddCell(dtgReporte[j, i].Value.ToString());
                }
                datatable.CompleteRow();
            }
            //SE AGREGAR LA PDFPTABLE AL DOCUMENTO
            document.Add(datatable);
        }
        //Función que obtiene los tamaños de las columnas del grid
        public float[] GetTamañoColumnas(DataGridView dg)
        {

            float[] values = new float[dg.ColumnCount];

            for (int i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;
            }

            return values;
        }
    }
}
