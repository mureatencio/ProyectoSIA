using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecasComunes;
using SistemaContable.BaseDatos;
using System.Data;

namespace SistemaContable.Logica
{
    public class LogicaCuentas
    {
        public static List<String> obtenerTipoCuentas()
        {
            List<String> tiposcuentas = new List<String>();
            try
            {
                tiposcuentas = AccesoCuentas.obtenerTipoCuentas();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tiposcuentas;
        }

        public static List<Cuenta> cargarCuentasDisponiblesAsiento(string empresa)
        {
            List<Cuenta> cuentas = new List<Cuenta>();
            try
            {
                cuentas = AccesoCuentas.cargarCuentasDisponiblesAsiento(new object[] { empresa, "" });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return cuentas;
        }

        //método para insertar una cuenta dado una empresa
        public static void insertarCuentas(string empresa, string nombre, string nombreinternacional, string numerocuenta, bool titulo, string moneda, int padre)
        {
            try
            {
                AccesoCuentas.insertarCuenta(new object[] { empresa, nombre, nombreinternacional, numerocuenta, titulo, moneda, padre });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //método para editar una cuenta
        public static void modificarCuentas(int idcuenta, string nombre, string nombreinternacional, bool titulo, string moneda, int padre)
        {
            try
            {
                AccesoCuentas.modificarCuenta(new object[] { idcuenta, nombre, nombreinternacional, titulo, moneda, padre });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<Cuenta> obtenerPadres(string Empresa, string nivel, string moneda, string tipocuenta)
        {
            List<Cuenta> tiposcuentas = new List<Cuenta>();
            int niveli = Int32.Parse(nivel);
            try
            {
                tiposcuentas = AccesoCuentas.obtenerPadres(new object[] { Empresa, tipocuenta, niveli, moneda });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tiposcuentas;
        }
        //cargar lista de cuentas con codigo, cuenta, saldo Sistema y saldo local
        //para mostrar en el datagrid
        public static List<Cuenta> obtenerCuentas(string empresa)
        {
            List<Cuenta> cuentas = new List<Cuenta>();
            try
            {
                cuentas = AccesoCuentas.obtenerCuentas(new object[] { empresa, "" });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return cuentas;
        }

        //método para borrar una cuenta (teniendo en cuenta que no tenga movimientos asociados)
        public static void eliminarCuenta(int idcuenta)
        {
            try
            {
                AccesoCuentas.eliminarCuenta(new object[] { idcuenta });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
