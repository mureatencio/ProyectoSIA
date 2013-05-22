using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace SistemaContable.BaseDatos
{
    public static class AccesoUsuarios
    {
        public static void introducirUsuario(object[] pArgumentos)
        {
            try
            {
                int retorno = SqlServer.Instance.ejecutar("insertarUsuario", pArgumentos); //////////////CAMB
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

        public static bool AutenticarUsuario(object[] pArgumentos)
        {
            int autenticado = 0;// = new int();

            SqlDataReader dataReader = null;
            try
            {
                autenticado = int.Parse(SqlServer.Instance.traerValorEscalar("autenticarUsuario", pArgumentos).ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                SqlServer.Instance.cerrarDataReader(dataReader);
                SqlServer.Instance.CerrarConexion();
            }
            return autenticado == 1 ? true : false;
        }
    }
}
