using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using BibliotecasComunes;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;

namespace SistemaContable.BaseDatos
{
    class AccesoServicios
    {

        public static List<Image> obtenerImagenes(object[] pArgumentos)
        {
            
            List<Image> imagenes = new List<Image>();

            SqlDataReader dataReader = null;
            try
            {
                dataReader = SqlServer.Instance.traerDataReader("cargarImagenes", pArgumentos);
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Image imagen;
                        imagen = byteArrayToImage(ObjectToByteArray(dataReader["Foto"]));

                        imagenes.Add(imagen);
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
            return imagenes;
        }

        private static byte[] ObjectToByteArray(Object obj)
        {
            if (obj == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);
            return ms.ToArray();
        }

        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

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
