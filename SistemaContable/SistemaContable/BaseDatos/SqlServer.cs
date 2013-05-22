using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace SistemaContable.BaseDatos
{
    public class SqlServer : AccesoDatos
    {
        #region Declaracion Variables
        /*
             * Mecanismo de “preservación” de los Comandos creados, para acelerar su utilización. Esto es, cada procedimiento que sea accedido, se guardará 
             * en memoria hasta que la instancia del objeto se destruya. Para ello, declararemos una variable como HashTable para la clase, con el modificador 
             * Static que permite persistir la misma entre creaciones de objetos
             */
        private static readonly Hashtable _ColComandos = new Hashtable();
        private static Object _LockObject = new Object();
        private static SqlServer _Instance;

        #endregion

        #region Metodos

        /*	
         * Se deberá asignar cada valor al parámetro que corresponda (considerando que, en el caso de SQLServer©, el parameter 0 
         * siempre corresponde al “return Value” del Procedimiento Almacenado). Por otra parte, en algunos casos,
         * como la ejecución de procedimientos almacenados que devuelven un valor como parámetro de salida, 
         * la cantidad de elementos en el vector de argumentos, puede no corresponder con la cantidad de parámetros. 
         * Por ello, se decide comparar el indicador con la cantidad de argumentos recibidos, antes de asignar el valor.
         */
        protected override void cargarParametros(SqlCommand pComando, Object[] pArgumentos)
        {
            for (int argumento = 1; argumento < pComando.Parameters.Count; argumento++)
            {
                var parametro = (SqlParameter)pComando.Parameters[argumento];
                parametro.Value = argumento <= pArgumentos.Length ? pArgumentos[argumento - 1] : null;

                if (parametro.SqlDbType == SqlDbType.Structured)
                {
                    string nombre = parametro.TypeName;
                    int index = nombre.IndexOf(".");
                    if (index != -1)
                    {
                        nombre = nombre.Substring(index + 1);

                        if (nombre.Contains("."))
                        {
                            parametro.TypeName = nombre;
                        }
                    }
                }
            }
        }
        /*
         * Se buscará primero si ya existe el comando en dicha Hashtable para retornarla 
         * (convertida en el tipo correcto). Caso contrario, se procederá a la creación del mismo, 
         * y su agregado en el repositorio. Dado que cabe la posibilidad de que ya estemos dentro de una transacción,
         * es necesario abrir una segunda conexión a la base de datos, para obtener la definición de los parámetros 
         * del procedimiento Almacenado (caso contrario da error, por intentar leer sin tener asignado el
         * objeto Transaction correspondiente). Además, el comando, obtenido por cualquiera de los mecanismos 
         * debe recibir la conexión y la transacción correspondientes (si no hay Transacción, la variable es null, 
         * y ese es el valor que se le pasa al objeto Command)
         */

        protected override SqlCommand cargarComando(string pProcedimientoAlmacenado)
        {
            SqlCommand comando;
            if (_ColComandos.Contains(pProcedimientoAlmacenado))
                comando = (SqlCommand)_ColComandos[pProcedimientoAlmacenado];
            else
            {
                SqlConnection conexion = new SqlConnection(StringConnection);
                conexion.Open();
                comando = new SqlCommand(pProcedimientoAlmacenado, conexion) { CommandType = CommandType.StoredProcedure };
                SqlCommandBuilder.DeriveParameters(comando);
                conexion.Close();
                conexion.Dispose();
                _ColComandos.Add(pProcedimientoAlmacenado, comando);
            }
            comando.Connection = (SqlConnection)Conexion;

            return comando;
        }

        /* 
         * Se devuelve una nueva instancia del objeto Conexión de SqlClient, utilizando la cadena de conexión del objeto.
         */
        protected override SqlConnection crearConexion(string cadenaConexion)
        {
            return new SqlConnection(cadenaConexion);
        }

        #endregion

        #region Properties
        public static SqlServer Instance
        {
            get
            {
                if (_Instance == null)
                {
                    lock (_LockObject)
                    {
                        if (_Instance == null)
                        {
                            _Instance = new SqlServer();
                        }
                    }
                }
                return _Instance;
            }
        }

        #endregion

        #region Constructor

        private SqlServer() { }

        #endregion
    }
}
