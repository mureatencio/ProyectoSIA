using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecasComunes;
using SistemaContable.BaseDatos;
using System.Globalization;
using System.Data;

namespace SistemaContable.Logica
{
    class LogicaBalance
    {
        public static DataSet obtenerBalance(string pCompañía, string pfechaInicio, string pfechaFin)
        {
            List<Padre> padresActivos = new List<Padre>();
            List<Padre> padresPasivos = new List<Padre>();

            DateTime fechaInicio;
            DateTime fechaFin;
            DateTimeFormatInfo dtfi = new DateTimeFormatInfo();
            dtfi.ShortDatePattern = "yyyy-MM-dd";
            dtfi.DateSeparator = "-";
            List<Estado> ListaIngresos = new List<Estado>();
            List<Estado> ListaGastos = new List<Estado>();
            List<Estado> ListaIngresosExtra = new List<Estado>();
            List<Estado> ListaGastosExtra = new List<Estado>();
            double totalIngresoLocal;
            double totalIngresoSistema;
            double totalGastoLocal;
            double totalGastoSistema;
            double IngresoContraGastoLocal;
            double IngresoContraGastoSistema;
            double totalPartidaLocal;
            double totalPartidaSistema;
            double utilidadesRetenidasLocal;
            double utilidadesRetenidasSistema;
            double utilidadesNetasLocal;
            double utilidadesNetasSistema;
            double TotalLocal;
            double TotalSistema;
            List<double> totales = new List<double>();
            Estado UtilidadesPeriodoAnterior = new Estado();

            fechaInicio = Convert.ToDateTime(pfechaInicio, dtfi);
            fechaFin = Convert.ToDateTime(pfechaFin, dtfi);


            object[] pArgumentosActivos = new object[] { pCompañía, "1-%" };
            object[] pArgumentosPasivos = new object[] { pCompañía, "2-%" };

            padresActivos = AccesoBalance.obtenerHijos("obtenerHijos", pArgumentosActivos);
            padresPasivos = AccesoBalance.obtenerHijos("obtenerHijos", pArgumentosPasivos);

            DataTable TableBalance = new DataTable();
            TableBalance.Columns.Add("Rubro", typeof(string));
            TableBalance.Columns.Add("Monto Local", typeof(double));
            TableBalance.Columns.Add("Monto Sistema", typeof(double));
            TableBalance.Columns.Add("Total Local", typeof(double));
            TableBalance.Columns.Add("Total Sistema", typeof(double));
            object[] argumentosActivos;
            object[] argumentosPasivos;
            object[] argumentosPatrimonio;
            object[] argumentosUtilidades = new object[] { pCompañía };
            List<Estado> listaEstados = new List<Estado>();
            double totalLocal = 0;
            double totalSistema = 0;
            double totalLocalAux = 0; 
            double totalSistemaAux = 0;


            TableBalance.Rows.Add("Activos", null, null, null, null);
            foreach(Padre elemento in padresActivos){
                TableBalance.Rows.Add(elemento.Nombre, null, null, null, null);
                argumentosActivos = new object[] { pCompañía, fechaInicio, fechaFin, elemento.Codigo + "%" };
                listaEstados = AccesoEstadoResultados.obtenerEstadoResultados("obtenerDebe", argumentosActivos);
                foreach (Estado estado in listaEstados) {
                    TableBalance.Rows.Add(estado.Nombre, estado.TotalLocal, estado.TotalSistema, null, null);
                }
                totales = obtenerTotal(listaEstados);
                totalLocalAux = totales[0];
                totalSistemaAux = totales[1];
                totalLocal += totalLocalAux;
                totalSistema += totalSistemaAux;
                TableBalance.Rows.Add("Total", null, null, totalLocalAux, totalSistemaAux);
            }
            TableBalance.Rows.Add("Total Activos", null, null, totalLocal, totalSistema);

            totalLocal = 0;
            totalSistema = 0;
            totalLocalAux = 0;
            totalSistemaAux = 0;
            
            TableBalance.Rows.Add("Pasivos", null, null, null, null);
            foreach (Padre elemento in padresPasivos)
            {
                TableBalance.Rows.Add(elemento.Nombre, null, null, null, null);
                argumentosPasivos = new object[] { pCompañía, fechaInicio, fechaFin, elemento.Codigo + "%" };
                listaEstados = AccesoEstadoResultados.obtenerEstadoResultados("obtenerHaber", argumentosPasivos);
                foreach (Estado estado in listaEstados)
                {
                    TableBalance.Rows.Add(estado.Nombre, estado.TotalLocal, estado.TotalSistema, null, null);
                }
                totales = obtenerTotal(listaEstados);
                totalLocalAux = totales[0];
                totalSistemaAux = totales[1];
                totalLocal += totalLocalAux;
                totalSistema += totalSistemaAux;
                TableBalance.Rows.Add("Total", null, null, totalLocalAux, totalSistemaAux);
            }
            TableBalance.Rows.Add("Total Pasivos", null, null, totalLocal, totalSistema);


            totalLocalAux = 0;
            totalSistemaAux = 0;
            TableBalance.Rows.Add("Patrimonio", null, null, null, null);
            argumentosPatrimonio = new object[] { pCompañía, fechaInicio, fechaFin, "3-%" };
            listaEstados = AccesoEstadoResultados.obtenerEstadoResultados("obtenerHaber", argumentosPatrimonio);
            foreach (Estado estado in listaEstados)
            {
                TableBalance.Rows.Add(estado.Nombre, estado.TotalLocal, estado.TotalSistema, null, null);
            }
            totales = obtenerTotal(listaEstados);
            totalLocalAux = totales[0];
            totalSistemaAux = totales[1];
            totalLocal += totalLocalAux;
            totalSistema += totalSistemaAux;
            TableBalance.Rows.Add("Total Patrimonio", null, null, totalLocalAux, totalSistemaAux);
            TableBalance.Rows.Add("Total", null, null, totalLocal, totalSistema);
          
            DataSet estadoResultados = new DataSet("estadoResultados");
            estadoResultados.Tables.Add(TableBalance);
            // Visualize DataSet.
            Console.WriteLine(estadoResultados.GetXml());
            return estadoResultados;

            

        }

        public static List<double> obtenerTotal(List<Estado> estado)
        {
            List<double> resultado = new List<double>();
            double totalLocal = 0;
            double totalSistema = 0;
            foreach (Estado element in estado)
            {
                totalLocal += element.TotalLocal;
                totalSistema += element.TotalSistema;
            }
            resultado.Add(totalLocal);
            resultado.Add(totalSistema);

            return resultado;
        }

     }
}
