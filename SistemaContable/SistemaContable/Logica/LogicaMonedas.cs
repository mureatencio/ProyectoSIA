using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecasComunes;
using SistemaContable.BaseDatos;
using System.Data;

namespace SistemaContable.Logica
{
    public class LogicaMonedas
    {
        public static List<Moneda> obtenerMonedas()
        {
            List<Moneda> monedas = new List<Moneda>();
            try
            {
                monedas = AccesoMonedas.obtenerMonedas();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return monedas;
        }

        public static List<Moneda> obtenerMonedasCuenta(int idCuenta)
        {
            List<Moneda> monedas = new List<Moneda>();
            try
            {
                monedas = AccesoMonedas.obtenerMonedasCuenta(new object[] { idCuenta });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return monedas;
        }

        public static List<Moneda> obtenerMonedasWSBC()
        {
            List<Moneda> monedas = new List<Moneda>();
            try
            {
                monedas = AccesoMonedas.obtenerMonedasWSBC();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return monedas;

        }

        public static void PreModificarTipoCambio(List<Moneda> pMonedas)
        {
            DataTable datosMonedas = crearDatatable(pMonedas);
            ModificarTipoCambio(datosMonedas);
        }

        public static void ModificarTipoCambio(DataTable datosMonedas)
        {
            try
            {
                object[] param = { datosMonedas };
                AccesoMonedas.alterarTipoCambio( param );
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private static DataTable crearDatatable(List<Moneda> listaMonedasCambio)
        {
            DataTable datosMonedas = new DataTable();
            datosMonedas.Columns.Add("ID", typeof(int));
            datosMonedas.Columns.Add("TipoCambio", typeof(double));

            foreach(Moneda mon in listaMonedasCambio)
            {
                DataRow fila = datosMonedas.NewRow();
                fila["ID"] = mon.Id;
                fila["TipoCambio"] = mon.Factor;
                datosMonedas.Rows.Add(fila);
            }
            return datosMonedas;
        }
    }
}
