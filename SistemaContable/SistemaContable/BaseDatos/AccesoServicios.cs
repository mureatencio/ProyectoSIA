using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecasComunes;
using System.Data.SqlClient;

namespace SistemaContable.BaseDatos
{
    class AccesoServicios
    {


        public static List<Servicio> obtenerServicios(object[] pArgumentos)
        {
            List<Servicio> servicios = new List<Servicio>();

            SqlDataReader dataReader = null;
            try
            {
                dataReader = SqlServer.Instance.traerDataReader("cargarArticulos", pArgumentos);
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Servicio servicio = new Servicio();
                        servicio.Nombre = dataReader["Nombre"].ToString();
                        servicio.Codigo = dataReader["CodigoUnico"].ToString();
                        servicio.Descripcion = dataReader["Descripcion"].ToString();
                        servicio.Comentario = dataReader["Comentario"].ToString();
                        servicio.Unidad = dataReader["Unidad"].ToString();
                        servicio.Precio = double.Parse(dataReader["Precio"].ToString());
                        servicios.Add(servicio);
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
            return servicios;
        }


        public static List<String> obtenerNombresServicios(object[] pArgumentos)
        {
            List<String> servicios = new List<String>();

            SqlDataReader dataReader = null;
            try
            {
                dataReader = SqlServer.Instance.traerDataReader("cargarArticulosNombre", pArgumentos);
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                         string Nombre = dataReader["Nombre"].ToString();
                        servicios.Add(Nombre);
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
            return servicios;
        }


        public static void insertarServicio(object[] pArgumentos)
        {
            try
            {
                SqlServer.Instance.ejecutar("RegistrarArticulo", pArgumentos);
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

        public static void insertarImagen(object[] pArgumentos)
        {
            try
            {
                SqlServer.Instance.ejecutar("insertarImagenArticulo", pArgumentos);
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

        
    }
}
