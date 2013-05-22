using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace AsientosWS.Datos
{
    public static class AccesoAsientos
    {
        public static void crearAsiento(object[] pArgumentos)
        {
            try
            {
                int retorno = SqlServer.Instance.ejecutar("crearAsiento", pArgumentos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                SqlServer.Instance.CerrarConexion();
            }
        }
    }
}
