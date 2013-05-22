using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using SistemaContable.BaseDatos;
using BibliotecasComunes;
using System.Data;
using SistemaContable.Reportes;
using System.Data.OleDb;
using System.Configuration;

namespace SistemaContable.Logica
{
    public class LogicaEstadoResultados
    {
        public static DataSet obtenerEstadoResultados(string pCompañía, string pfechaInicio, string pfechaFin)
        {
            //este es el dataset q devuelve la funcion
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
            object[] argumentosIngresos = new object[] {pCompañía, fechaInicio, fechaFin, "4-%"};
            object[] argumentosGastos = new object[] { pCompañía, fechaInicio, fechaFin, "6-%" };
            object[] argumentosIngresosExtra = new object[] { pCompañía, fechaInicio, fechaFin, "7-%" };
            object[] argumentosGastosExtra = new object[] { pCompañía, fechaInicio, fechaFin, "8-%" };

            object[] argumentosUtilidades = new object[] {pCompañía};
            ListaIngresos = AccesoEstadoResultados.obtenerEstadoResultados("obtenerHaber", argumentosIngresos);
            ListaGastos = AccesoEstadoResultados.obtenerEstadoResultados("obtenerDebe", argumentosGastos);
            ListaIngresosExtra = AccesoEstadoResultados.obtenerEstadoResultados("obtenerHaber", argumentosIngresosExtra);
            ListaGastosExtra = AccesoEstadoResultados.obtenerEstadoResultados("obtenerDebe", argumentosGastosExtra);
           
            UtilidadesPeriodoAnterior = AccesoEstadoResultados.obtenerUtilidades(argumentosUtilidades);
            DataTable TableEstado = new DataTable();
            TableEstado.Columns.Add("Rubro", typeof(string));
            TableEstado.Columns.Add("Monto Local", typeof(double));
            TableEstado.Columns.Add("Monto Sistema", typeof(double));
            TableEstado.Columns.Add("Total Local", typeof(double));
            TableEstado.Columns.Add("Total Sistema", typeof(double));
            totales = obtenerTotal(ListaIngresos);
            totalIngresoLocal = totales[0];
            totalIngresoSistema = totales[1];

            totales = obtenerTotal(ListaGastos);
            totalGastoLocal = totales[0]*-1;
            totalGastoSistema = totales[1]*-1;

            IngresoContraGastoLocal = totalIngresoLocal + totalGastoLocal;
            IngresoContraGastoSistema = totalIngresoSistema + totalGastoSistema;

            totales = obtenerTotal(ListaIngresosExtra);
            totalPartidaLocal = totales[0];
            totalPartidaSistema = totales[1];

            totales = obtenerTotal(ListaGastosExtra);
            totalPartidaLocal -= totales[0];
            totalPartidaSistema -= totales[1];

            utilidadesRetenidasLocal = UtilidadesPeriodoAnterior.TotalLocal;
            utilidadesRetenidasSistema = UtilidadesPeriodoAnterior.TotalSistema;

            ListaGastosExtra = Negativo(ListaGastosExtra);
            
            utilidadesNetasLocal = IngresoContraGastoLocal + totalPartidaLocal;
            utilidadesNetasSistema = IngresoContraGastoSistema + totalPartidaSistema;

            TotalLocal = utilidadesNetasLocal + utilidadesRetenidasLocal;
            TotalSistema = utilidadesNetasSistema + utilidadesRetenidasSistema;
            
      
            //Ingresos
            TableEstado.Rows.Add("Ingresos Operativos", null, null, null, null);
            foreach (Estado elemento in ListaIngresos)
            {
                TableEstado.Rows.Add(elemento.Nombre, elemento.TotalLocal, elemento.TotalSistema, null, null);
            }
            TableEstado.Rows.Add("", null, null, totalIngresoLocal, totalIngresoSistema);
            //Egresos
            TableEstado.Rows.Add("", null, null, null, null);
            TableEstado.Rows.Add("Egresos Operativos", null, null, null, null);
            foreach (Estado elemento in ListaGastos)
            {
                TableEstado.Rows.Add(elemento.Nombre, elemento.TotalLocal, elemento.TotalSistema, null, null);
            }
            TableEstado.Rows.Add("", null, null, totalGastoLocal, totalGastoSistema);

            TableEstado.Rows.Add("Utilidad Operativa", null, null, IngresoContraGastoLocal, IngresoContraGastoSistema);
            //Partidas

            TableEstado.Rows.Add("", null, null, null, null);
            TableEstado.Rows.Add("Partidas Extraordinarias", null, null, null, null);
            foreach (Estado elemento in ListaIngresosExtra)
            {
                TableEstado.Rows.Add(elemento.Nombre, elemento.TotalLocal, elemento.TotalSistema, null, null);
            }
            foreach (Estado elemento in ListaGastosExtra)
            {
                TableEstado.Rows.Add(elemento.Nombre, elemento.TotalLocal, elemento.TotalSistema, null, null);
            }
            TableEstado.Rows.Add("", null, null, totalPartidaLocal, totalPartidaSistema);


            TableEstado.Rows.Add("", null, null, null, null);
            TableEstado.Rows.Add("Utilidad Neta del periodo", null, null, utilidadesNetasLocal, utilidadesNetasSistema);
            TableEstado.Rows.Add("Utilidades retenidas periodo anterior", null, null, utilidadesRetenidasLocal, utilidadesRetenidasSistema);
            TableEstado.Rows.Add("Utilidades retenidas periodo actual", null, null, TotalLocal, TotalSistema);
            DataSet EstadoResultados = new DataSet("estadoResultados");
            EstadoResultados.Tables.Add(TableEstado);
            //OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["default"].ToString());
            //using (conn)
            //{
            //    string sql = @"SELECT * FROM TableIngresos";
            //    OleDbCommand command = new OleDbCommand(sql, conn);
            //    OleDbDataAdapter da = new OleDbDataAdapter(command);
            //    da.Fill(EstadoResultados, "TableIngresos");
            //}
            // Visualize DataSet.
            Console.WriteLine(EstadoResultados.GetXml());
            return EstadoResultados;
            

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

        public static List<Estado> Negativo(List<Estado> estado)
        {

            foreach (Estado element in estado)
            {
                element.TotalLocal = element.TotalLocal * -1;
                element.TotalSistema = element.TotalSistema * -1;
            }

            return estado;
        }

    }
}
