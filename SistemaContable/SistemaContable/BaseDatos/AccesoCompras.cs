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

        public static List<Compra> obtenerDocumentoAnterior(object[] pArgumentos)
        {
            List<Compra> resultado = new List<Compra>();

            SqlDataReader dataReader = null;
            try
            {
                dataReader = SqlServer.Instance.traerDataReader("obtenerDocumentoCompraAnterior", pArgumentos);
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Compra compra = new Compra();
                        compra.ID = Int32.Parse(dataReader[0].ToString());
                        compra.Consecutivo = Int32.Parse(dataReader[1].ToString());
                        compra.Fecha = DateTime.Parse(dataReader[2].ToString());
                        compra.Total = Double.Parse(dataReader[3].ToString());
                        compra.Impuesto = Double.Parse(dataReader[4].ToString());
                        compra.TotalJunto = Double.Parse(dataReader[5].ToString());
                        compra.TipoCompra = dataReader[6].ToString();
                        compra.Moneda = new Moneda { Nombre = dataReader[7].ToString(), Codigo = dataReader[8].ToString() };
                        compra.Proveedor = new Socio { Nombre = dataReader[9].ToString(), Codigo = dataReader[10].ToString() };
                        compra.Proyecto = new Proyecto { Nombre = dataReader[11].ToString(), Codigo = dataReader[12].ToString() };
                        resultado.Add(compra);
                    }
                }

                for (int contador = 0; contador < resultado.Count; contador++)
                {
                    dataReader.Close();
                    List<ServicioCompra> lineas = new List<ServicioCompra>();
                    dataReader = SqlServer.Instance.traerDataReader("obtenerServiciosXCompra", resultado[contador].ID);
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            //S.Nombre, S.Descripcion, S.Cantidad, S.Precio, S.Total, S.Impuesto, S.TotalImpuesto
                            ServicioCompra lineaCompra = new ServicioCompra();
                            lineaCompra.Nombre = dataReader[0].ToString();
                            lineaCompra.Descripcion = dataReader[1].ToString();
                            lineaCompra.Cantidad = Int32.Parse(dataReader[2].ToString());
                            lineaCompra.Precio = Double.Parse(dataReader[3].ToString());
                            lineaCompra.Total = Double.Parse(dataReader[4].ToString());
                            lineaCompra.Impuesto = Double.Parse(dataReader[5].ToString());
                            lineaCompra.TotalImpuesto = Double.Parse(dataReader[6].ToString());
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
                        compra.ID = Int32.Parse(dataReader[0].ToString());
                        compra.Consecutivo = Int32.Parse(dataReader[1].ToString());
                        compra.Fecha = DateTime.Parse(dataReader[2].ToString());
                        compra.Total = Double.Parse(dataReader[3].ToString());
                        compra.Impuesto = Double.Parse(dataReader[4].ToString());
                        compra.TotalJunto = Double.Parse(dataReader[5].ToString());
                        compra.TipoCompra = dataReader[6].ToString();
                        compra.Moneda = new Moneda { Nombre = dataReader[7].ToString(), Codigo = dataReader[8].ToString() };
                        compra.Proveedor = new Socio { Nombre = dataReader[9].ToString(), Codigo = dataReader[10].ToString() };
                        compra.Proyecto = new Proyecto { Nombre = dataReader[11].ToString(), Codigo = dataReader[12].ToString() };
                        resultado.Add(compra);
                    }
                }

                for (int contador = 0; contador < resultado.Count; contador++)
                {
                    dataReader.Close();
                    List<ServicioCompra> lineas = new List<ServicioCompra>();
                    dataReader = SqlServer.Instance.traerDataReader("obtenerServiciosXCompra", resultado[contador].ID);
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            //S.Nombre, S.Descripcion, S.Cantidad, S.Precio, S.Total, S.Impuesto, S.TotalImpuesto
                            ServicioCompra lineaCompra = new ServicioCompra();
                            lineaCompra.Nombre = dataReader[0].ToString();
                            lineaCompra.Descripcion = dataReader[1].ToString();
                            lineaCompra.Cantidad = Int32.Parse(dataReader[2].ToString());
                            lineaCompra.Precio = Double.Parse(dataReader[3].ToString());
                            lineaCompra.Total = Double.Parse(dataReader[4].ToString());
                            lineaCompra.Impuesto = Double.Parse(dataReader[5].ToString());
                            lineaCompra.TotalImpuesto = Double.Parse(dataReader[6].ToString());
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

        public static List<Compra> obtenerTotalFacturasCompraPendientes(object[] pArgumentos)
        {
            List<Compra> resultado = new List<Compra>();

            SqlDataReader dataReader = null;
            try
            {
                dataReader = SqlServer.Instance.traerDataReader("obtenerTotalFacturasCompraPendientes", pArgumentos);
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Compra compra = new Compra();
                        compra.ID = Int32.Parse(dataReader[0].ToString());
                        compra.Consecutivo = Int32.Parse(dataReader[1].ToString());
                        compra.Fecha = DateTime.Parse(dataReader[2].ToString());
                        compra.Total = Double.Parse(dataReader[3].ToString());
                        compra.Impuesto = Double.Parse(dataReader[4].ToString());
                        compra.TotalJunto = Double.Parse(dataReader[5].ToString());
                        compra.TipoCompra = dataReader[6].ToString();
                        compra.Moneda = new Moneda { Nombre = dataReader[7].ToString(), Codigo = dataReader[8].ToString() };
                        compra.Proveedor = new Socio { Nombre = dataReader[9].ToString(), Codigo = dataReader[10].ToString() };
                        compra.Proyecto = new Proyecto { Nombre = dataReader[11].ToString(), Codigo = dataReader[12].ToString() };
                        resultado.Add(compra);
                    }
                }

                for (int contador = 0; contador < resultado.Count; contador++)
                {
                    dataReader.Close();
                    List<ServicioCompra> lineas = new List<ServicioCompra>();
                    dataReader = SqlServer.Instance.traerDataReader("obtenerServiciosXCompra", resultado[contador].ID);
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            //S.Nombre, S.Descripcion, S.Cantidad, S.Precio, S.Total, S.Impuesto, S.TotalImpuesto
                            ServicioCompra lineaCompra = new ServicioCompra();
                            lineaCompra.Nombre = dataReader[0].ToString();
                            lineaCompra.Descripcion = dataReader[1].ToString();
                            lineaCompra.Cantidad = Int32.Parse(dataReader[2].ToString());
                            lineaCompra.Precio = Double.Parse(dataReader[3].ToString());
                            lineaCompra.Total = Double.Parse(dataReader[4].ToString());
                            lineaCompra.Impuesto = Double.Parse(dataReader[5].ToString());
                            lineaCompra.TotalImpuesto = Double.Parse(dataReader[6].ToString());
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
