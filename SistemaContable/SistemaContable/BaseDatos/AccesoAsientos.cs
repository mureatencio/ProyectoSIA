using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecasComunes;
using System.Data.SqlClient;

namespace SistemaContable.BaseDatos
{
    public static class AccesoAsientos
    {
        public static int obtenerNuevoNumeroAsiento(object[] pArgumentos)
        {
            int retorno = 0;
            try
            {
                retorno = Int32.Parse(SqlServer.Instance.traerValorEscalar("obtenerNuevoNumeroAsiento", pArgumentos).ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                SqlServer.Instance.CerrarConexion();
            }
            return retorno;
        }

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

        public static void anularAsiento(object[] pArgumentos)
        {
            try
            {
                int retorno = SqlServer.Instance.ejecutar("anularAsiento", pArgumentos);
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

        public static List<Partida> obtenerPartidas(object[] pArgumentos)
        {
            List<Partida> resultado = new List<Partida>();

            SqlDataReader dataReader = null;
            try
            {
                dataReader = SqlServer.Instance.traerDataReader("obtenerPartidas", pArgumentos);
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Partida part = new Partida();
                        part.Cuenta = dataReader[0].ToString();
                        part.Moneda = dataReader[1].ToString();
                        part.Debe = dataReader[2].ToString();
                        part.Haber = dataReader[3].ToString();
                        part.DebeLocal = dataReader[4].ToString();
                        part.HaberLocal = dataReader[5].ToString();
                        part.DebeSistema = dataReader[6].ToString();
                        part.HaberSistema = dataReader[7].ToString();
                        resultado.Add(part);
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

        public static List<Asiento> obtenerAsientos(object[] pArgumentos)
        {
            List<Asiento> resultado = new List<Asiento>();

            SqlDataReader dataReader = null;
            try
            {
                dataReader = SqlServer.Instance.traerDataReader("obtenerAsientos", pArgumentos);
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Asiento asiento = new Asiento();                        
                        asiento.Codigo = Int32.Parse(dataReader[0].ToString());
                        asiento.Detalle = dataReader[1].ToString();
                        asiento.FechaDocumento = dataReader[2].ToString();
                        asiento.FechaContabilizacion = dataReader[3].ToString();
                        asiento.TipoAsiento = dataReader[4].ToString();
                        asiento.TotalDebeLocal = dataReader[5].ToString();
                        asiento.TotalHaberLocal = dataReader[6].ToString();
                        asiento.TotalDebeSistema = dataReader[7].ToString();
                        asiento.TotalHaberSistema = dataReader[8].ToString();
                        resultado.Add(asiento);
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
