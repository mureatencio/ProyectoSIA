using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecasComunes;
using SistemaContable.BaseDatos;
using System.Drawing;

namespace SistemaContable.Logica
{
    class LogicaServicios
    {

        public static List<Image> cargarImagenes(string pCodigoArticulo, string pNombreEmpresa)
        {
            List<Image> imagenes = new List<Image>();
            try
            {
                imagenes = AccesoServicios.obtenerImagenes(new object[] { pNombreEmpresa, pCodigoArticulo });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return imagenes;
        }

        
        public static void insertarServicio(Servicio pservicio, string pNombreEmpresa)
        {
            try
            {
                AccesoServicios.insertarServicio(new object[] { pNombreEmpresa, pservicio.Nombre, pservicio.Codigo, pservicio.Descripcion, pservicio.Comentario, pservicio.Unidad, pservicio.Precio });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<Servicio> cargarServicios(string nombre)
        {
            List<Servicio> servicios = new List<Servicio>();
            try
            {
                servicios = AccesoServicios.obtenerServicios(new object[] { nombre, "" });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return servicios;
        }

        public static void insertarImagen(string pCodigo, byte[] pImagen)
        {
            try
            {
                AccesoServicios.insertarImagen(new object[] { pCodigo, pImagen });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<String> obtenerNombreServicios(string empresa)
        {
            List<String> servicios = new List<String>();
            try
            {
                servicios = AccesoServicios.obtenerNombresServicios(new object[] { empresa, "" });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return servicios;
        }


    }
}
