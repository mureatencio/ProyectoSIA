<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecasComunes;
using SistemaContable.BaseDatos;

namespace SistemaContable.Logica
{
    public class LogicaDocumento
    {

        public static void insertarLinea(Linea plinea)
        {
            try
            {
                AccesoDocumento.insertarLinea(new object[] { plinea.documento, plinea.articuloCodigo, plinea.Cantidad, plinea.Total, 
                    plinea.Impuesto, plinea.TotalGeneral });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<string> obtenerNumeroFacturas(string pEmpresa)
        {
            List<string> resultado = new List<string>();
            try
            {
                object[] pArgumentos = new object[] { pEmpresa };
                resultado = AccesoDocumento.obtenerNumeroFacturas(pArgumentos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return resultado;
        }

        public static List<string> obtenerNumeroOrdenes(string pEmpresa)
        {
            List<string> resultado = new List<string>();
            try
            {
                object[] pArgumentos = new object[] { pEmpresa };
                resultado = AccesoDocumento.obtenerNumeroOrdenes(pArgumentos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return resultado;
        }


        public static int insertarDocumento(Documento pdocumento)
        {

            try
            {
                return AccesoDocumento.insertarDocumento(new object[] 
                { 
                  pdocumento.socio, pdocumento.fechaContabilizacion,
                  pdocumento.moneda, pdocumento.tipo, pdocumento.proyecto,
                  pdocumento.totalPrecio, pdocumento.impuesto, pdocumento.total
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static int insertarNotaCredito(Documento pdocumento, int pnumeroFactura)
        {

            try
            {
                return AccesoDocumento.insertarNotaCredito(new object[] 
                { 
                  pdocumento.fechaContabilizacion,
                  pdocumento.moneda, pdocumento.tipo,
                  pdocumento.totalPrecio, pdocumento.impuesto, pdocumento.total, pnumeroFactura
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static int tramitarOrdenVenta(int pNumeroOrden, DateTime pFecha, string pMoneda, string pCompania)
        {

            try
            {
                return AccesoDocumento.tramitarOrdenVenta(new object[] 
                { 
                  pNumeroOrden,pFecha,pMoneda,pCompania
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}

=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecasComunes;
using SistemaContable.BaseDatos;

namespace SistemaContable.Logica
{
    public class LogicaDocumento
    {
        public static void insertarLinea(Linea plinea)
        {
            try
            {
                AccesoDocumento.insertarLinea(new object[] { plinea.documento, plinea.articuloCodigo, plinea.Cantidad, plinea.Total, 
                    plinea.Impuesto, plinea.TotalGeneral });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<string> obtenerNumeroFacturas(string pEmpresa)
        {
            List<string> resultado = new List<string>();
            try
            {
                object[] pArgumentos = new object[] { pEmpresa };
                resultado = AccesoDocumento.obtenerNumeroFacturas(pArgumentos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return resultado;
        }

        public static List<string> obtenerNumeroOrdenes(string pEmpresa)
        {
            List<string> resultado = new List<string>();
            try
            {
                object[] pArgumentos = new object[] { pEmpresa };
                resultado = AccesoDocumento.obtenerNumeroOrdenes(pArgumentos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return resultado;
        }

        public static int insertarDocumento(Documento pdocumento)
        {

            try
            {
                return AccesoDocumento.insertarDocumento(new object[] 
                { 
                  pdocumento.socio, pdocumento.fechaContabilizacion,
                  pdocumento.moneda, pdocumento.tipo, pdocumento.proyecto,
                  pdocumento.totalPrecio, pdocumento.impuesto, pdocumento.total
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static int insertarNotaCredito(Documento pdocumento, int pnumeroFactura)
        {

            try
            {
                return AccesoDocumento.insertarNotaCredito(new object[] 
                { 
                  pdocumento.fechaContabilizacion,
                  pdocumento.moneda, pdocumento.tipo,
                  pdocumento.totalPrecio, pdocumento.impuesto, pdocumento.total, pnumeroFactura
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static int tramitarOrdenVenta(int pNumeroOrden, DateTime pFecha, string pMoneda, string pCompania)
        {

            try
            {
                return AccesoDocumento.tramitarOrdenVenta(new object[] 
                { 
                  pNumeroOrden,pFecha,pMoneda,pCompania
                });

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<Documento> obtenerFacturasVentaPendientes(string pEmpresa, string pCodigoSocio)
        {
            List<Documento> resultado = new List<Documento>();
            try
            {
                object[] pArgumentos = new object[] { pEmpresa, pCodigoSocio };
                resultado = AccesoDocumento.obtenerFacturasVentaPendientes(pArgumentos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return resultado;
        }

        public static List<Documento> obtenerTotalFacturasVentaPendientes(string pEmpresa)
        {
            List<Documento> resultado = new List<Documento>();
            try
            {
                object[] pArgumentos = new object[] { pEmpresa };
                resultado = AccesoDocumento.obtenerTotalFacturasVentaPendientes(pArgumentos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return resultado;
        }

    }
}

>>>>>>> origin/Compras-y-ventas
