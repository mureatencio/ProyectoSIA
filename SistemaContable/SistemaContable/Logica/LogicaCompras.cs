using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecasComunes;
using SistemaContable.BaseDatos;
using System.Data;

namespace SistemaContable.Logica
{
    public static class LogicaCompras
    {
        /*  EL DATATABLE QUE RECIBE ESTA FUNCION TIENE QUE TENER:
         * Nombre string
         * Descripcion string
         * Cantidad int
         * Precio double
         * Impuesto int
         * 
         * EL DATAGRID PUEDE CONTENER ESTO CUANDO SE CREA LA VENTANA
         * 
         */
        public static void insertarCompra(string pEmpresa, string pCodigoSocio ,string pCodigoProyecto, string pCodigoMoneda, string pTipoCompra, DataTable pServicios)
        {
            try
            {
                object[] pArgumentos = { pEmpresa, pCodigoSocio, pCodigoProyecto, pCodigoMoneda, pTipoCompra, pServicios };
                AccesoCompras.insertarCompra(pArgumentos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<Compra> obtenerCompras(string pEmpresa, string pCodigoProyecto)
        {
            List<Compra> resultado = new List<Compra>();
            try
            {
                object[] pArgumentos = new object[] { pEmpresa, pCodigoProyecto };
                resultado = AccesoCompras.obtenerCompras(pArgumentos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return resultado;
        }

        public static List<Compra> obtenerFacturasCompraPendientes(string pEmpresa)
        {
            List<Compra> resultado = new List<Compra>();
            try
            {
                object[] pArgumentos = new object[] { pEmpresa };
                resultado = AccesoCompras.obtenerFacturasCompraPendientes(pArgumentos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return resultado;
        }

        public static List<string> obtenerTipoCompras()
        {
            List<string> resultado = new List<string>();
            try
            {
                resultado = AccesoCuentas.obtenerTipoCuentas();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return resultado;
        }
    }
}
