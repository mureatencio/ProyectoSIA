using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecasComunes;
using System.Data.SqlClient;

namespace SistemaContable.BaseDatos
{
    public static class AccesoProyectos
    {
        public static List<Proyecto> obtenerProyectos(object[] pArgumentos)
        {
            List<Proyecto> resultado = new List<Proyecto>();

            SqlDataReader dataReader = null;
            try
            {
                dataReader = SqlServer.Instance.traerDataReader("obtenerProyectos", pArgumentos);
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Proyecto proyecto = new Proyecto();
                        proyecto.Nombre = dataReader[0].ToString();
                        proyecto.Codigo = dataReader[1].ToString();
                        proyecto.Descripcion = dataReader[2].ToString();
                        proyecto.FechaInicio = DateTime.Parse(dataReader[3].ToString());
                        proyecto.Estado = dataReader[4].ToString();
                        resultado.Add(proyecto);
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
        
        public static void insertarProyecto(object[] pArgumentos)
        {
            try
            {
                SqlServer.Instance.ejecutar("insertarProyecto", pArgumentos);
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

        public static List<string> obtenerEstadosProyecto()
        {
            List<string> resultado = new List<string>();

            SqlDataReader dataReader = null;
            try
            {
                dataReader = SqlServer.Instance.traerDataReader("obtenerEstadosProyectos");
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {                     
                        resultado.Add(dataReader[0].ToString());
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
