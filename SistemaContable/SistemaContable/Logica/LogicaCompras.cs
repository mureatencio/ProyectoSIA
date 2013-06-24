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
        public static void insertarCompra(string pEmpresa, string pCodigoSocio, string pCodigoProyecto, string pCodigoMoneda, string pTipoCompra, double pTotal, double pTotalImpuesto, double pTotalJunto, DataTable pServicios, DateTime pFecha, int pNumeroFactura)
        {
            try
            {
                object[] pArgumentos = { pEmpresa, pCodigoSocio, pCodigoProyecto, pCodigoMoneda, pTipoCompra, pTotal, pTotalImpuesto, pTotalJunto, pServicios, pFecha, pNumeroFactura };
                AccesoCompras.insertarCompra(pArgumentos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<Compra> obtenerDocumentoAnterior(string pEmpresa, string pTipoDocumento)
        {
            List<Compra> resultado = new List<Compra>();
            try
            {
                object[] pArgumentos = new object[] { pEmpresa, pTipoDocumento };
                resultado = AccesoCompras.obtenerDocumentoAnterior(pArgumentos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return resultado;

        }

        public static List<Compra> obtenerFacturasCompraPendientes(string pEmpresa, string pCodigoSocio)
        {
            List<Compra> resultado = new List<Compra>();
            try
            {
                object[] pArgumentos = new object[] { pEmpresa , pCodigoSocio};
                resultado = AccesoCompras.obtenerFacturasCompraPendientes(pArgumentos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return resultado;
        }

        public static List<Compra> obtenerTotalFacturasCompraPendientes(string pEmpresa)
        {
            List<Compra> resultado = new List<Compra>();
            try
            {
                object[] pArgumentos = new object[] { pEmpresa };
                resultado = AccesoCompras.obtenerTotalFacturasCompraPendientes(pArgumentos);
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
                resultado = AccesoCompras.obtenerTipoCompras();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return resultado;
        }
    }
}
