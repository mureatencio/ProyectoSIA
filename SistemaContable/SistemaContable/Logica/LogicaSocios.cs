<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecasComunes;
using SistemaContable.BaseDatos;

namespace SistemaContable.Logica
{
    public static class LogicaSocios
    {
        public static List<string> obtenerNombreSocios(string pEmpresa)
        {
            List<string> resultado = new List<string>();
            try
            {
                object[] pArgumentos = new object[] {pEmpresa };
                resultado = AccesoSocios.obtenerNombresSocios(pArgumentos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return resultado;
        }

        public static List<Socio> obtenerSocios(string pEmpresa)
        {
            try
            {
                return AccesoSocios.obtenerSocios(new object[] { pEmpresa });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<string> obtenerTiposSocios()
        {
            try
            {
                return AccesoSocios.obtenerTiposSocios();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void insertarSocio(string pEmpresa, string pCodigoMoneda, int pidCuentaMayor, string pTipoSocio, string pCodigoSocio, string pNombreSocio, double pLimiteLocal, int pCondicion)
        {
            try
            {
                AccesoSocios.insertarSocio(new object[] { pEmpresa, pCodigoMoneda, pidCuentaMayor, pTipoSocio, pCodigoSocio, pNombreSocio, pLimiteLocal, pCondicion });
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
    public static class LogicaSocios
    {
        public static List<string> obtenerNombreSocios(string pEmpresa)
        {
            List<string> resultado = new List<string>();
            try
            {
                object[] pArgumentos = new object[] {pEmpresa };
                resultado = AccesoSocios.obtenerNombresSocios(pArgumentos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return resultado;
        }

        public static List<Socio> obtenerSocios(string pEmpresa)
        {
            try
            {
                return AccesoSocios.obtenerSocios(new object[] { pEmpresa });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<string> obtenerTiposSocios()
        {
            try
            {
                return AccesoSocios.obtenerTiposSocios();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void insertarSocio(string pEmpresa, string pCodigoMoneda, int pidCuentaMayor, string pTipoSocio, string pCodigoSocio, string pNombreSocio, double pLimiteLocal, int pCondicion)
        {
            try
            {
                AccesoSocios.insertarSocio(new object[] { pEmpresa, pCodigoMoneda, pidCuentaMayor, pTipoSocio, pCodigoSocio, pNombreSocio, pLimiteLocal, pCondicion });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
		
    }
}
>>>>>>> origin/Compras-y-ventas
