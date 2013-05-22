using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using BibliotecasComunes;
using SistemaContable.Logica;
using System.Globalization;
using SistemaContable.Reportes;

namespace SistemaContable.Interfaces
{
    public partial class Reportes : Form
    {
        string Empresa, Reporte;
        public Reportes(string Empresa, string reporte)
        {
            this.Empresa = Empresa;
            this.Reporte = reporte;
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

        private void ReporteComprobación_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            if (cmbPeriodo.Text.Equals("") || comboBoxPeriodoFin.Text.Equals(""))
            {
                MessageBox.Show("Error, escoja un periodo de inicio y uno de fin");
            }
            else 
            {
                ReportDocument oRep = new ReportDocument();
                Periodo periodoNuevo = new Periodo();
                string nuevoEstado = this.cmbPeriodo.SelectedItem.ToString();
                string[] tokens = nuevoEstado.Split('/');
                string fechaini = tokens[0];

                string nuevoEstadofin = this.comboBoxPeriodoFin.SelectedItem.ToString();
                string[] tokensfin = nuevoEstado.Split('/');
                string fechafin = tokensfin[1];
                    
                
                if (Reporte.Equals("BalanceComprobacion"))
                {
                    ParameterField PfCompania = new ParameterField();
                    ParameterField PfFechaIni = new ParameterField();
                    ParameterField PfFechaFin = new ParameterField();
                    ParameterFields Pfs = new ParameterFields();
                    ParameterDiscreteValue PvdCompania = new ParameterDiscreteValue();
                    ParameterDiscreteValue PvdFechaIni = new ParameterDiscreteValue();
                    ParameterDiscreteValue PvdFechaFin = new ParameterDiscreteValue();
                    PfCompania.Name = "@Compañia";
                    PfFechaIni.Name = "@FechaInicio";
                    PfFechaFin.Name = "@FechaFinal";
                    PvdCompania.Value = Empresa;
                    DateTimeFormatInfo dtfi = new DateTimeFormatInfo();
                    dtfi.ShortDatePattern = "yyyy-MM-dd";
                    dtfi.DateSeparator = "-";
                    DateTime objDate = Convert.ToDateTime(fechaini, dtfi);
                    DateTimeFormatInfo dtffin = new DateTimeFormatInfo();
                    dtffin.ShortDatePattern = "yyyy-MM-dd";
                    dtffin.DateSeparator = "-";
                    DateTime objDatefin = Convert.ToDateTime(fechafin, dtffin);
                    PfCompania.CurrentValues.Add(PvdCompania);
                    PvdFechaIni.Value = objDate;
                    PfFechaIni.CurrentValues.Add(PvdFechaIni);
                    PvdFechaFin.Value = objDatefin;
                    PfFechaFin.CurrentValues.Add(PvdFechaFin);
                    Pfs.Add(PfFechaIni);
                    Pfs.Add(PfFechaFin);
                    Pfs.Add(PfCompania);
                    crstlRComprobacion.ParameterFieldInfo = Pfs;
                    oRep.Load(@"C:\Users\Hugo\Desktop\Proyecto SIA\SistemaContable\SistemaContable\Reportes\BalanceComprobacion.rpt");//cambiar por su direccion
                    crstlRComprobacion.ReportSource = oRep;
                    //oRepBalanceCom.SetDatabaseLogon("", "", "", "");User, Password, Server, Database(poner para no autentificarse siempre)
                }
                
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
