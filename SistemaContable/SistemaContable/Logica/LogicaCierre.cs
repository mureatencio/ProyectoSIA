using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemaContable.BaseDatos;

namespace SistemaContable.Logica
{
    public static class LogicaCierre
    {
        public static void ejecutarCierre(string empresa)
        {
            try
            {
                AccesoCierre.ejecutarCierre(new object[] { empresa});
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
