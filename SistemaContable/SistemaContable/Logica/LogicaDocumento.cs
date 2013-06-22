using System;
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

        public static int insertarDocumento(Documento pdocumento)
        {
            
            try
            {
                return AccesoDocumento.insertarDocumento(new object[] 
                { 
                  pdocumento.socio, pdocumento.fechaContabilizacion,
                  pdocumento.moneda, pdocumento.tipo, pdocumento.proyecto,pdocumento.numero ,
                  pdocumento.totalPrecio, pdocumento.impuesto, pdocumento.total
                });
           
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}

