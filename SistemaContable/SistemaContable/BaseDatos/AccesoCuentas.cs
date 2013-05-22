using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecasComunes;
using System.Data.SqlClient;
using System.Data;

namespace SistemaContable.BaseDatos
{
    public static class AccesoCuentas
    {
        public static List<String> obtenerTipoCuentas()
        {
            List<String> tiposcuentas = new List<String>();

            SqlDataReader dataReader = null;
            try
            {
                dataReader = SqlServer.Instance.traerDataReader("obtenerTiposCuenta");
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        tiposcuentas.Add(dataReader["Nombre"].ToString());
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
            return tiposcuentas;
        }

        public static void modificarCuenta(object[] pArgumentos)
        {
            try
            {
                int retorno = SqlServer.Instance.ejecutar("modificarCuenta", pArgumentos);//////////////CAMB
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

        public static void eliminarCuenta(object[] pArgumentos)
        {
            try
            {
                int retorno = SqlServer.Instance.ejecutar("elimanarCuenta", pArgumentos);//////////////CAMB
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

        public static void insertarCuenta(object[] pArgumentos)
        {
            try
            {
                int retorno = SqlServer.Instance.ejecutar("insertarCuenta", pArgumentos);//////////////CAMB
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

        public static List<Cuenta> obtenerPadres(object[] pArgumentos)
        {
            List<Cuenta> padres = new List<Cuenta>();

            SqlDataReader dataReader = null;
            try
            {
                dataReader = SqlServer.Instance.traerDataReader("cargarCuentasPadreDisponibles", pArgumentos);
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Cuenta cuenta = new Cuenta();
                        cuenta.ID = Int32.Parse(dataReader["IdCatalogoCuentas"].ToString());
                        cuenta.Nombre = dataReader["Nombre"].ToString();
                        padres.Add(cuenta);
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
            return padres;
        }

        public static List<Cuenta> obtenerCuentas(object[] pArgumentos)
        {
            List<Cuenta> cuentas = new List<Cuenta>();

            SqlDataReader dataReader = null;
            try
            {
                dataReader = SqlServer.Instance.traerDataReader("cargarCuentas", pArgumentos);
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Cuenta cuenta = new Cuenta();
                        Moneda moneda = new Moneda();
                        cuenta.Moneda = moneda;
                        cuenta.ID = Int32.Parse(dataReader["IdCatalogoCuentas"].ToString());
                        cuenta.CodigoCuenta = dataReader[2].ToString();
                        cuenta.Nombre = dataReader["Nombre"].ToString();
                        cuenta.SaldoSistema = double.Parse(dataReader["SaldoSistema"].ToString());
                        cuenta.SaldoLocal = double.Parse(dataReader["SaldoLocal"].ToString());
                        cuenta.Moneda.Codigo = dataReader[5].ToString();
                        cuentas.Add(cuenta);
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
            return cuentas;
        }

        public static List<Cuenta> cargarCuentasDisponiblesAsiento(object[] pArgumentos)
        {
            List<Cuenta> cuentas = new List<Cuenta>();

            SqlDataReader dataReader = null;
            try
            {
                dataReader = SqlServer.Instance.traerDataReader("cargarCuentasDisponiblesAsiento", pArgumentos);
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Cuenta cuenta = new Cuenta();
                        Moneda moneda = new Moneda();
                        cuenta.Moneda = moneda;
                        cuenta.ID = Int32.Parse(dataReader["IdCatalogoCuentas"].ToString());
                        cuenta.CodigoCuenta = dataReader[2].ToString();
                        cuenta.Nombre = dataReader["Nombre"].ToString();
                        cuenta.SaldoSistema = double.Parse(dataReader["SaldoSistema"].ToString());
                        cuenta.SaldoLocal = double.Parse(dataReader["SaldoLocal"].ToString());
                        cuenta.Moneda.Codigo = dataReader[5].ToString();
                        cuentas.Add(cuenta);
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
            return cuentas;
        }
    }
}
