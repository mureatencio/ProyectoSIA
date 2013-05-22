using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BibliotecasComunes;

namespace SistemaContable.BaseDatos
{
    class AccesoEstadoResultados
    {

        public static List<Estado> obtenerEstadoResultados(string sp, object[] pArgumentos)
        {
            List<Estado> resultado = new List<Estado>(); 
            SqlDataReader dataReader = null;
            try
            {
                dataReader = SqlServer.Instance.traerDataReader(sp, pArgumentos);
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Estado estado = new Estado();
                        estado.Nombre = dataReader["Nombre"].ToString();
                        estado.TotalLocal = Double.Parse(dataReader["MontoLocal"].ToString());
                        estado.TotalSistema = Double.Parse(dataReader["MontoSistema"].ToString());
                        
                        resultado.Add(estado);
                    }
                }
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
            return resultado;
        }
        public static Estado obtenerUtilidades(object[] pArgumentos)
        {

            SqlDataReader dataReader = null;
            Estado estado = new Estado();
            try
            {
                dataReader = SqlServer.Instance.traerDataReader("obtenerUtilidades", pArgumentos);
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        estado.TotalLocal = Double.Parse(dataReader["SaldoLocal"].ToString());
                        estado.TotalSistema = Double.Parse(dataReader["SaldoSistema"].ToString());
                    }
                }
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
            return estado;
        }
    
    }
}
