using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SistemaContable.BaseDatos;
using BibliotecasComunes;
using SistemaContable.ServicioAsientos;

namespace SistemaContable.Logica
{
    public static class LogicaAsientos
    {
        public static int obtenerNuevoNumeroAsiento(string compania)
        {
            int numeroCompania = 0;
            try
            {
                object[] pArgumentos = new object[] { compania };
                numeroCompania = AccesoAsientos.obtenerNuevoNumeroAsiento(pArgumentos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return numeroCompania;
        }

        /*public static void crearAsiento(DataTable Tabla, string Compania, int numAsiento, string detalle)
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
        }*/

        //USANDO EL WS
        public static void crearAsiento(DataTable Tabla, string Compania, int numAsiento, string detalle)
        {
            try
            {
                AsientosWSSoapClient asientos = new AsientosWSSoapClient();
                asientos.GuardarAsiento(Tabla, Compania, numAsiento, detalle);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<Asiento> obtenerAsientos(string nombreEmpresa)
        {
            List<Asiento> resultado = new List<Asiento>();
            try
            {
                object[] pArgumentos = new object[] { nombreEmpresa };
                resultado = AccesoAsientos.obtenerAsientos(pArgumentos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return resultado;

        }

        public static List<Partida> obtenerPartidas(int numeroAsiento, string nombreEmpresa)
        {
            List<Partida> resultado = new List<Partida>();
            try
            {
                object[] pArgumentos = new object[] { numeroAsiento, nombreEmpresa };
                resultado = AccesoAsientos.obtenerPartidas(pArgumentos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return resultado;
        }

        public static void anularAsiento(int numeroAsiento, string nombreEmpresa)
        {
            try
            {
                object[] pArgumentos = new object[] { numeroAsiento, nombreEmpresa };
                AccesoAsientos.anularAsiento(pArgumentos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
