using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemaContable.BaseDatos;
using BibliotecasComunes;
using System.IO;

namespace SistemaContable.Logica
{
    public class LogicaEmpresas
    {

        public static List<string> obtenerNombreEmpresas()
        {
            List<string> empresas = new List<string>();
            try
            {
                empresas = AccesoEmpresas.obtenerNombreEmpresas();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return empresas;
        }

        public static Empresa informacionEmpresa(string pNombreEmpresa)
        {
            Empresa empresa = new Empresa();
            try
            {
                empresa = AccesoEmpresas.informacionEmpresa(new object[] { pNombreEmpresa });
                FileStream file = new FileStream("logo.jpg", FileMode.Create);
                file.Write(empresa.Imagen, 0, empresa.Imagen.Length);
                file.Close();
                file = null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return empresa;
        }

        public static void introducirEmpresa(Empresa pempresa)
        {
            try
            {
                AccesoEmpresas.introducirEmpresa(new object[] { pempresa.Nombre, pempresa.CedulaJuridica, pempresa.Telefono, pempresa.Fax, pempresa.Imagen, pempresa.MonedaLocal, pempresa.MonedaSistema });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void actualizarPeriodo(Periodo pperiodo)
        {
            try
            {
                AccesoEmpresas.actualizarPeriodo(new object[] { pperiodo.NombreEmpresa, pperiodo.FechaInicio, pperiodo.TipoPeriodo });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<string> obtenerPeriodo(Empresa pempresa)
        {
            List<string> fechas = new List<string>();
            List<Periodo> periodo = new List<Periodo>();
            int contador;

            try
            {
                periodo = obtenerFechaPeriodo(pempresa);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            for (contador = 0; contador < fechas.Count; contador++)
            {
                string desplegar = "";
                desplegar = periodo[contador].FechaInicio.ToString();
                desplegar += "-";
                desplegar += periodo[contador].FechaFin.ToString();
                fechas.Add(desplegar);
            }
            return fechas;
        }

        public static List<Periodo> obtenerFechaPeriodo(Empresa pempresa)
        {
            List<Periodo> fechas = new List<Periodo>();
            try
            {
                fechas = AccesoEmpresas.obtenerPeriodo(new object[] { pempresa });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return fechas;
        }

        public static void introducirTipo(Empresa pempresa, Periodo pperiodo, string ptipo)
        {
            try
            {
                AccesoEmpresas.introducirTipo(new object[] { pempresa, pperiodo, ptipo });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
