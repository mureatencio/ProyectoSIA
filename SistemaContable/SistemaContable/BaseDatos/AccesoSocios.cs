using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecasComunes;
using System.Data.SqlClient;

namespace SistemaContable.BaseDatos
{
    public static class AccesoSocios
    {
        public static List<string> obtenerNombresSocios(object[] pArgumentos)
        {
            List<string> resultado = new List<string>();

            SqlDataReader dataReader = null;
            try
            {
                dataReader = SqlServer.Instance.traerDataReader("cargarNombresSocios", pArgumentos);
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

        public static List<Socio> obtenerSocios(object[] pArgumentos)
        {
            List<Socio> resultado = new List<Socio>();

            SqlDataReader dataReader = null;
            try
            {
                dataReader = SqlServer.Instance.traerDataReader("obtenerSocios", pArgumentos);
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Socio socio = new Socio();
                        socio.Codigo = dataReader[0].ToString();
                        socio.Nombre = dataReader[1].ToString();
                        socio.LimiteLocal = Double.Parse(dataReader[2].ToString());
                        socio.CondicionPago = Int32.Parse(dataReader[3].ToString());
                        socio.TipoSocio = dataReader[4].ToString();
                        
                        Cuenta cuenta = new Cuenta();
                        cuenta.CodigoCuenta = dataReader[5].ToString();
                        cuenta.Nombre = dataReader[6].ToString();
                        cuenta.SaldoLocal = Double.Parse(dataReader[7].ToString());

                        socio.Cuenta = cuenta;

                        Moneda moneda = new Moneda();
                        moneda.Nombre = dataReader[8].ToString();
                        moneda.Codigo = dataReader[9].ToString();

                        socio.Moneda = moneda;

                        resultado.Add(socio);
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

        public static void insertarSocio(object[] pArgumentos)
        {
            try
            {
                SqlServer.Instance.ejecutar("insertarSocio", pArgumentos);
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

        public static List<string> obtenerTiposSocios()
        {
            List<string> resultado = new List<string>();
            SqlDataReader dataReader = null;
            try
            {
                dataReader = SqlServer.Instance.traerDataReader("obtenerTiposSocios");
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
