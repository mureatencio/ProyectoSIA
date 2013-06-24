using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BibliotecasComunes;

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

        public static List<String> obtenerNumeroFacturas(object[] pArgumentos)
        {
            List<String> resultado = new List<String>();

            SqlDataReader dataReader = null;
            try
            {
                dataReader = SqlServer.Instance.traerDataReader("cargarNumeroFacturas", pArgumentos);
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        String Numero = dataReader[0].ToString();
                        resultado.Add(Numero);
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

        public static List<String> obtenerNumeroOrdenes(object[] pArgumentos)
        {
            List<String> resultado = new List<String>();

            SqlDataReader dataReader = null;
            try
            {
                dataReader = SqlServer.Instance.traerDataReader("cargarNumeroOrdenes", pArgumentos);
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        String Numero = dataReader[0].ToString();
                        resultado.Add(Numero);
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

        public static int tramitarOrdenVenta(object[] pArgumentos)
        {
            int resultado = 0;

            SqlDataReader dataReader = null;
            try
            {
                dataReader = SqlServer.Instance.traerDataReader("TramitarOrdenVenta", pArgumentos);
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

        public static int insertarNotaCredito(object[] pArgumentos)
        {
            int resultado = 0;

            SqlDataReader dataReader = null;
            try
            {
                dataReader = SqlServer.Instance.traerDataReader("insertarNotaCredito", pArgumentos);
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

        public static List<Documento> obtenerFacturasVentaPendientes(object[] pArgumentos)
        {
            List<Documento> resultado = new List<Documento>();

            SqlDataReader dataReader = null;
            try
            {
                dataReader = SqlServer.Instance.traerDataReader("obtenerFacturasVentaPendientes", pArgumentos);
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Documento venta = new Documento();
                        venta.Numero = Int32.Parse(dataReader[0].ToString());
                        venta.ID = Int32.Parse(dataReader[1].ToString());
                        venta.fechaContabilizacion = DateTime.Parse(dataReader[2].ToString());
                        venta.totalPrecio = Double.Parse(dataReader[3].ToString());
                        venta.impuesto = Double.Parse(dataReader[4].ToString());
                        venta.total = Double.Parse(dataReader[5].ToString());
                        venta.tipo = dataReader[6].ToString();
                        venta.moneda = dataReader[7].ToString();
                        venta.socio = dataReader[8].ToString();
                        venta.proyecto = dataReader[9].ToString();
                        resultado.Add(venta);
                    }
                }

                for (int contador = 0; contador < resultado.Count; contador++)
                {
                    dataReader.Close();
                    List<Linea> lineas = new List<Linea>();
                    dataReader = SqlServer.Instance.traerDataReader("obtenerServiciosXVenta", resultado[contador].ID);
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            Linea lineaCompra = new Linea();
                            lineaCompra.nombre = dataReader[0].ToString();
                            lineaCompra.precio = Double.Parse(dataReader[1].ToString());
                            lineaCompra.Cantidad = Int32.Parse(dataReader[2].ToString());
                            lineaCompra.Total = Double.Parse(dataReader[3].ToString());
                            lineaCompra.Impuesto = Double.Parse(dataReader[4].ToString());
                            lineaCompra.TotalGeneral = Double.Parse(dataReader[5].ToString());
                            lineas.Add(lineaCompra);
                        }
                    }
                    resultado[contador].Servicios = lineas;
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

        public static List<Documento> obtenerTotalFacturasVentaPendientes(object[] pArgumentos)
        {
            List<Documento> resultado = new List<Documento>();

            SqlDataReader dataReader = null;
            try
            {
                dataReader = SqlServer.Instance.traerDataReader("obtenerTotalFacturasVentaPendientes", pArgumentos);
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Documento venta = new Documento();
                        venta.Numero = Int32.Parse(dataReader[0].ToString());
                        venta.ID = Int32.Parse(dataReader[1].ToString());
                        venta.fechaContabilizacion = DateTime.Parse(dataReader[2].ToString());
                        venta.totalPrecio = Double.Parse(dataReader[3].ToString());
                        venta.impuesto = Double.Parse(dataReader[4].ToString());
                        venta.total = Double.Parse(dataReader[5].ToString());
                        venta.tipo = dataReader[6].ToString();
                        venta.moneda = dataReader[7].ToString();
                        venta.socio = dataReader[8].ToString();
                        venta.proyecto = dataReader[9].ToString();
                        resultado.Add(venta);
                    }
                }

                for (int contador = 0; contador < resultado.Count; contador++)
                {
                    dataReader.Close();
                    List<Linea> lineas = new List<Linea>();
                    dataReader = SqlServer.Instance.traerDataReader("obtenerServiciosXVenta", resultado[contador].ID);
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            Linea lineaCompra = new Linea();
                            lineaCompra.nombre = dataReader[0].ToString();
                            lineaCompra.precio = Double.Parse(dataReader[1].ToString());
                            lineaCompra.Cantidad = Int32.Parse(dataReader[2].ToString());
                            lineaCompra.Total = Double.Parse(dataReader[3].ToString());
                            lineaCompra.Impuesto = Double.Parse(dataReader[4].ToString());
                            lineaCompra.TotalGeneral = Double.Parse(dataReader[5].ToString());
                            lineas.Add(lineaCompra);
                        }
                    }
                    resultado[contador].Servicios = lineas;
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
