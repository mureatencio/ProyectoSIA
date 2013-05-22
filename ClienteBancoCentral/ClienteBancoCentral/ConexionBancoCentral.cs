using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClienteBancoCentral.WS_BancoCentral;
using System.Data;
using BibliotecasComunes;

namespace ClienteBancoCentral
{
    public static class ConexionBancoCentral
    {
        private const string TC_NOMBRE = "Sistema Contable";
        private const string TN_SUBNIVELES = "No";
        private const string NOMBRE_TABLA = "INGC011_CAT_INDICADORECONOMIC";
        private const int COLUMNA = 2;

        private static wsIndicadoresEconomicosSoapClient cliente = new wsIndicadoresEconomicosSoapClient();

        public static List<Moneda> actualizarMonedasBC(List<Moneda> listaMonedas)
        {
            List<Moneda> listaMonedasCambio = obtenerMonedas(listaMonedas);
            return listaMonedasCambio;
        }
            //guardar lista monedas

        private static List<Moneda> obtenerMonedas(List<Moneda> ListaMonedas)
        {
            string fecha = "10/05/2013"; //String.Format("{0:d}", DateTime.Now); //
            return obtenerTiposCambio(ListaMonedas, fecha);
        }

        private static List<Moneda> obtenerTiposCambio(List<Moneda> ListaMonedas, String Fecha)
        {
            for (int moneda = 0; moneda < ListaMonedas.Count; moneda++)
            {
                ListaMonedas[moneda] = obtenerMoneda(ListaMonedas[moneda], Fecha);
            }
            return ListaMonedas;
        }

        private static Moneda obtenerMoneda(Moneda moneda, string Fecha)
        {
            moneda.Factor = obtenerValor(moneda.CodigoBC, Fecha);
            return moneda;
        }

        public static double obtenerValor(int CodigoBC, string Fecha)
        {
            DataSet datos = cliente.ObtenerIndicadoresEconomicos(CodigoBC.ToString(), Fecha, Fecha, TC_NOMBRE, TN_SUBNIVELES);
            return Double.Parse(datos.Tables[NOMBRE_TABLA].Rows[0][COLUMNA].ToString());
        }
    }    
}
