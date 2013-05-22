using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AsientosWS.Datos;

namespace AsientosWS.Logica
{
    public static class LogicaAsientos
    {
        public static void crearAsiento(DataTable Tabla, string Compania, int numAsiento, string detalle)
        {
            try
            {
                object[] pArgumentos = new object[] { Tabla, Compania, numAsiento, detalle };
                AccesoAsientos.crearAsiento(pArgumentos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
