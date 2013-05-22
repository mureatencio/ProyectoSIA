using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using BibliotecasComunes;

namespace SistemaContable.BaseDatos
{
    public static class AccesoEmpresas
    {
        public static List<string> obtenerNombreEmpresas()
        {
            List<string> resultado = new List<string>();

            SqlDataReader dataReader = null;
            try
            {
                dataReader = SqlServer.Instance.traerDataReader("cargarCompañias");
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        string empresa = dataReader["Nombre"].ToString();
                        resultado.Add(empresa);
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

        
        public static Empresa informacionEmpresa(object[] pArgumentos)
        {
            Empresa resultado = new Empresa();

            SqlDataReader dataReader = null;
            try
            {
                dataReader = SqlServer.Instance.traerDataReader("informacionCompañia", pArgumentos);
                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    resultado.CedulaJuridica = (long)dataReader[0];
                    resultado.Telefono = (long)dataReader[1];
                    resultado.Fax = (long)dataReader[2];
                    resultado.Imagen = (byte[])dataReader[3];
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


        public static void introducirEmpresa(object[] pArgumentos)
        {
            try
            {
                int retorno = SqlServer.Instance.ejecutar("insertarEmpresa", pArgumentos);
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


        public static void actualizarPeriodo(object[] pArgumentos)
        {
            try
            {
                int retorno = SqlServer.Instance.ejecutar("actualizarPeriodo", pArgumentos);
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


        public static void introducirTipo(object[] pArgumentos)
        {
            try
            {
                int retorno = SqlServer.Instance.ejecutar("asociarTipo", pArgumentos);
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


        public static List<Periodo> obtenerPeriodo(object[] pArgumento)
        {
            List<Periodo> resultado = new List<Periodo>();
            //  List<DateTime> fechas = new List<DateTime>();


            SqlDataReader dataReader = null;
            try
            {
                dataReader = SqlServer.Instance.traerDataReader("cargarPeriodo", pArgumento);
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Periodo periodo = new Periodo();
                     //   periodo.FechaInicio = (DateTime)dataReader["FechaInicio"];
                     //   periodo.FechaFin = (DateTime)dataReader["FechaFin"];
                        resultado.Add(periodo);

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
