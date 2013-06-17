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
