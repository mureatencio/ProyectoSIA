using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecasComunes;
using System.Data.SqlClient;


namespace SistemaContable.BaseDatos
{
    public class AccesoBalance
    {
        public static List<Padre> obtenerHijos(string sp, object[] pArgumentos) 
        {
            List<Padre> resultado = new List<Padre>();
            SqlDataReader dataReader = null;
            try
            {
                dataReader = SqlServer.Instance.traerDataReader(sp, pArgumentos);
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Padre padre = new Padre();
                        padre.Nombre = dataReader["Nombre"].ToString();
                        padre.Codigo = dataReader["Codigo"].ToString();
                        resultado.Add(padre);
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

        

        public static List<Estado> obtenerBalance (string sp, object[] pArgumentos)
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


    }

}
