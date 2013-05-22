using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaContable.BaseDatos
{
    public static class AccesoCierre
    {
        public static void ejecutarCierre(object[] pArgumentos)
        {
            try
            {
                int retorno = SqlServer.Instance.ejecutar("ejecutarCierre", pArgumentos);//////////////CAMB
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
