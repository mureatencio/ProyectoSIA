using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecasComunes;

using System.Data.SqlClient;
using System.Data;

//using SistemaContable.BaseDatos;

namespace SistemaContable.BaseDatos
{
    public static class AccesoMonedas
    {
        public static List<Moneda> obtenerMonedas()
        {
            List<Moneda> monedas = new List<Moneda>();

            SqlDataReader dataReader = null;
            try
            {
                dataReader = SqlServer.Instance.traerDataReader("cargarCaracteristicasMoneda");
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Moneda moneda = new Moneda();
                        moneda.Nombre = dataReader["Nombre"].ToString();
                        moneda.Codigo = dataReader["Codigo"].ToString();
                        moneda.Simbolo = dataReader["Simbolo"].ToString();
                        moneda.Id = Int32.Parse(dataReader["IdMoneda"].ToString());
                        monedas.Add(moneda);
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
            return monedas;
        }

        public static List<Moneda> obtenerMonedasWSBC()
        {
            List<Moneda> monedas = new List<Moneda>();

            SqlDataReader dataReader = null;
            try
            {
                dataReader = SqlServer.Instance.traerDataReader("obtenerMonedasWSBC");
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Moneda moneda = new Moneda();
                        moneda.Id = Int32.Parse(dataReader["IdMoneda"].ToString());
                        moneda.CodigoBC = Int32.Parse(dataReader["WSBCCR_Ref"].ToString());
                        monedas.Add(moneda);
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
            return monedas;
        }

        public static void alterarTipoCambio(object[] pArgumentos)
        {
            try
            {
                int retorno = SqlServer.Instance.ejecutar("registrarTipoCambios", pArgumentos);
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

        public static List<Moneda> obtenerMonedasCuenta(object[] pArgumentos)
        {
            List<Moneda> monedas = new List<Moneda>();
            SqlDataReader dataReader = null;
            try
            {
                dataReader = SqlServer.Instance.traerDataReader("obtenerMonedasCuenta", pArgumentos);
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Moneda moneda = new Moneda();
                        moneda.Nombre = dataReader["Nombre"].ToString();
                        moneda.Codigo = dataReader["Codigo"].ToString();
                        moneda.Simbolo = dataReader["Simbolo"].ToString();
                        monedas.Add(moneda);
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
            return monedas;
        }
    }
}
