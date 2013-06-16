using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecasComunes;
using System.Data.SqlClient;

namespace SistemaContable.BaseDatos
{
    public static class AccesoCompras
    {
        public static void insertarCompra(object[] pArgumentos)
        {
            try
            {
                SqlServer.Instance.ejecutar("insertarCompra", pArgumentos);
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

        public static List<Compra> obtenerCompras(object[] pArgumentos)
        {
            List<Compra> resultado = new List<Compra>();

            SqlDataReader dataReader = null;
            try
            {
                dataReader = SqlServer.Instance.traerDataReader("obtenerCompras", pArgumentos);
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Compra compra = new Compra();
                        //TODOOOO:
                        
                        resultado.Add(compra);
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

        public static List<Compra> obtenerFacturasCompraPendientes(object[] pArgumentos)
        {
            List<Compra> resultado = new List<Compra>();

            SqlDataReader dataReader = null;
            try
            {
                dataReader = SqlServer.Instance.traerDataReader("obtenerFacturasCompraPendientes", pArgumentos);
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Compra compra = new Compra();
                        //TODOOOO

                        resultado.Add(compra);
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

        public static List<string> obtenerTipoCompras()
        {
            List<string> resultado = new List<string>();

            SqlDataReader dataReader = null;
            try
            {
                dataReader = SqlServer.Instance.traerDataReader("obtenerTipoCompras");
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
