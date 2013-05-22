using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemaContable.BaseDatos;

namespace SistemaContable.Logica
{
    public static class LogicaUsuarios
    {
        public static void introducirUsuario(string pnombre, string ppass, string pempresa)
        {
            try
            {
                AccesoUsuarios.introducirUsuario(new object[] { pnombre, ConvertToBinary(ppass), pempresa });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static byte[] ConvertToBinary(string str)
        {
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            return encoding.GetBytes(str);
        }

        public static bool AutenticarUsuario(string nombre, string pass, string nombreEmpresa)
        {
            bool autorizado = false;
            try
            {
                object[] pArgumentos = { nombre, ConvertToBinary(pass), nombreEmpresa };
                autorizado = AccesoUsuarios.AutenticarUsuario(pArgumentos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return autorizado;
        }
    }
}
