using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecasComunes;
using SistemaContable.BaseDatos;

namespace SistemaContable.Logica
{
    public static class LogicaProyectos
    {
        public static List<string> obtenerNombreProyectos(string pEmpresa)
        {
            List<string> resultado = new List<string>();
            try
            {
                object[] pArgumentos = new object[] { pEmpresa };
                resultado = AccesoProyectos.obtenerNombreProyectos(pArgumentos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return resultado;
        }

        public static List<Proyecto> obtenerProyectos(string nombreEmpresa)
        {
            List<Proyecto> resultado = new List<Proyecto>();
            try
            {
                object[] pArgumentos = new object[] { nombreEmpresa };
                resultado = AccesoProyectos.obtenerProyectos(pArgumentos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return resultado;
        }

        public static void insertarProyecto(string pNombreEmpresa, string pNombreProyecto, string pCodigoProyecto, string pDescripcionProyecto)
        {
            try
            {
                object[] pArgumentos = new object[] {pNombreEmpresa, pNombreProyecto, pCodigoProyecto, pDescripcionProyecto };
                AccesoProyectos.insertarProyecto(pArgumentos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<string> obtenerEstadosProyecto()
        {
            List<string> resultado = new List<string>();
            try
            {
                resultado = AccesoProyectos.obtenerEstadosProyecto();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return resultado;
        }

        public static List<Proyecto> obtenerProyectosActivos(string nombreEmpresa)
        {
            List<Proyecto> resultado = new List<Proyecto>();
            try
            {
                object[] pArgumentos = new object[] { nombreEmpresa };
                resultado = AccesoProyectos.obtenerProyectosActivos(pArgumentos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return resultado;
        }
    }
}
