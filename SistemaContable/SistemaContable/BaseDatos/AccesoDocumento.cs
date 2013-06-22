using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace SistemaContable.BaseDatos
{
    public class AccesoDocumento
    {

        public static void insertarLinea(object[] pArgumentos)
        {
            try
            {
                SqlServer.Instance.ejecutar("insertarLinea", pArgumentos);
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

        public static int insertarDocumento(object[] pArgumentos)
        {
            int resultado = 0;

            SqlDataReader dataReader = null;
            try
            {
                dataReader = SqlServer.Instance.traerDataReader("insertarDocumento", pArgumentos);
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        resultado = Int32.Parse(dataReader[0].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                SqlServer.Instance.CerrarConexion();
            }
            return resultado;
        }


    }
}
