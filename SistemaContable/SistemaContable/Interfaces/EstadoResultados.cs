using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SistemaContable.Logica;

namespace SistemaContable.Interfaces
{
    public partial class EstadoResultados : Form
    {
        private string compania;
        public EstadoResultados(string Compania)
        {
            this.compania = Compania;
            InitializeComponent();

            comboBoxPeriodoInicio.Items.Clear();
            comboBoxPeriodoInicio.Items.Add("2012-10-01 / 2012-10-31");
            comboBoxPeriodoInicio.Items.Add("2012-11-01 / 2012-11-30");
            comboBoxPeriodoInicio.Items.Add("2012-12-01 / 2013-12-31");
            comboBoxPeriodoInicio.Items.Add("2013-01-01 / 2012-01-31");
            comboBoxPeriodoInicio.Items.Add("2013-02-01 / 2013-02-28");
            comboBoxPeriodoInicio.Items.Add("2013-03-01 / 2013-03-31");
            comboBoxPeriodoInicio.Items.Add("2013-04-01 / 2013-04-30");
            comboBoxPeriodoInicio.Items.Add("2013-05-01 / 2013-05-31");
            comboBoxPeriodoInicio.Items.Add("2013-06-01 / 2013-06-30");
            comboBoxPeriodoInicio.Items.Add("2013-07-01 / 2013-07-31");
            comboBoxPeriodoInicio.Items.Add("2013-08-01 / 2013-08-31");
            comboBoxPeriodoInicio.Items.Add("2013-09-01 / 2013-09-30");
            comboBoxPeriodoInicio.SelectedIndex = 0;

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
            comboBoxPeriodoFin.Items.Add("2013-09-01 / 2013-09-30");
            comboBoxPeriodoFin.SelectedIndex = 0;
        }

        private void buttonVerEstadoResultados_Click(object sender, EventArgs e)
        {
            string fechaInicio;
            string fechaFin;

            fechaInicio = comboBoxPeriodoInicio.ToString();
            fechaFin = comboBoxPeriodoFin.ToString();

            string stringFechaInicio = comboBoxPeriodoInicio.SelectedItem.ToString();
            string[] tokensInicio = stringFechaInicio.Split('/');
            fechaInicio = tokensInicio[0];

            string stringFechaFin = comboBoxPeriodoFin.SelectedItem.ToString();
            string[] tokensFin = stringFechaFin.Split('/');
            fechaFin = tokensFin[1];
            //LogicaBalance.obtenerBalance(compania, fechaInicio, fechaFin);
            LogicaEstadoResultados.obtenerEstadoResultados(compania, fechaInicio, fechaFin);
        }
    }
}
