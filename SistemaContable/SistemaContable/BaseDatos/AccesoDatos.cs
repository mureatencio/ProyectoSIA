using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SistemaContable.BaseDatos
{
    public abstract class AccesoDatos
    {
        #region Declaración de Variables

        private SqlConnection _SqlConexion = null;
        
        private const string NOMBRE_CONEXION = "ConexionSistema";
        private string _StringConnection = ConfigurationManager.ConnectionStrings[NOMBRE_CONEXION].ConnectionString;

        #endregion

        #region Properties

        // Crea u obtiene un objeto para conectarse a la base de datos. 
        public SqlConnection Conexion
        {
            get
            {
                // si aun no tiene asignada la cadena de conexion lo hace
                if (_SqlConexion == null)
                    _SqlConexion = crearConexion(StringConnection);

                // si no esta abierta aun la conexion, lo abre
                if (_SqlConexion.State != ConnectionState.Open)
                    _SqlConexion.Open();

                // retorna la conexion en modo interfaz, para que se adapte a cualquier implementacion de los distintos fabricantes de motores de bases de datos
                return _SqlConexion;
            } // end get
        }

        protected string StringConnection
        {
            get { return _StringConnection; }
            set { _StringConnection = value; }
        }

        #endregion

        #region Metodos

        #region Lecturas

        // Obtiene un DataReader a partir de un Procedimiento Almacenado. 
        public SqlDataReader traerDataReader(string pProcedimientoAlmacenado)
        {
            try
            {
                SqlCommand comando = cargarComando(pProcedimientoAlmacenado);
                return comando.ExecuteReader();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }


        // Obtiene un DataReader a partir de un Procedimiento Almacenado y sus parámetros. 
        public SqlDataReader traerDataReader(string pProcedimientoAlmacenado, params object[] pArgumentos)
        {
            try
            {
                SqlCommand comando = cargarComando(pProcedimientoAlmacenado);
                cargarParametros(comando, pArgumentos);
                return comando.ExecuteReader();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Obtiene un Valor Escalar a partir de un Procedimiento Almacenado. Solo funciona con SP's que tengan
        // definida variables de tipo output, para funciones escalares mas abajo se declara un metodo
        public object traerValorOutput(string pProcedimientoAlmacenado)
        {
            try
            {
                // asignar el string sql al command
                SqlCommand comando = cargarComando(pProcedimientoAlmacenado);

                comando.ExecuteNonQuery();
                // declarar variable de retorno
                Object respuesta = null;

                // recorrer los parametros del SP
                foreach (IDbDataParameter parametro in comando.Parameters)
                    // si tiene parametros de tipo IO/Output retornar ese valor
                    if (parametro.Direction == ParameterDirection.InputOutput || parametro.Direction == ParameterDirection.Output)
                        respuesta = parametro.Value;
                return respuesta;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Obtiene un Valor a partir de un Procedimiento Almacenado, y sus parámetros. 
        public object traerValorOutput(string pProcedimientoAlmacenado, params Object[] pArgumentos)
        {
            try
            {
                // asignar el string sql al command
                SqlCommand comando = cargarComando(pProcedimientoAlmacenado);
                // cargar los parametros del SP
                cargarParametros(comando, pArgumentos);
                // ejecutar el command
                comando.ExecuteNonQuery();
                // declarar variable de retorno
                Object respuesta = null;

                // recorrer los parametros del SP
                foreach (IDbDataParameter parametro in comando.Parameters)
                    // si tiene parametros de tipo IO/Output retornar ese valor
                    if (parametro.Direction == ParameterDirection.InputOutput || parametro.Direction == ParameterDirection.Output)
                        respuesta = parametro.Value;
                return respuesta;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        } // end TraerValor

        // Obtiene un Valor de una funcion Escalar a partir de un Procedimiento Almacenado. 
        public object traerValorEscalar(string pProcedimientoAlmacenado)
        {
            try
            {
                SqlCommand comando = cargarComando(pProcedimientoAlmacenado);
                return comando.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        } // end TraerValorEscalar

        /// Obtiene un Valor de una funcion Escalar a partir de un Procedimiento Almacenado, con Params de Entrada
        public Object traerValorEscalar(string pProcedimientoAlmacenado, params object[] pArgumentos)
        {
            try
            {
                SqlCommand comando = cargarComando(pProcedimientoAlmacenado);
                cargarParametros(comando, pArgumentos);
                return comando.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        } // end TraerValorEscalar

        public Object traerValorRetorno(string pProcedimientoAlmacenado, params object[] pArgumentos)
        {
            try
            {
                SqlCommand comando = cargarComando(pProcedimientoAlmacenado);
                cargarParametros(comando, pArgumentos);
                comando.ExecuteNonQuery();
                return comando.Parameters[0].Value;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Object traerValorRetorno(string pProcedimientoAlmacenado)
        {
            try
            {
                SqlCommand comando = cargarComando(pProcedimientoAlmacenado);
                comando.ExecuteNonQuery();
                return comando.Parameters[0].Value;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region Acciones

        protected abstract SqlConnection crearConexion(string pCadena);
        protected abstract SqlCommand cargarComando(string pProcedimientoAlmacenado);
        protected abstract void cargarParametros(SqlCommand pComando, Object[] pArgumentos);

        public void cerrarDataReader(SqlDataReader pDataReader)
        {
            if (pDataReader != null && !pDataReader.IsClosed)
            {
                pDataReader.Close();
            }
        }

        public void CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open 
                && Conexion.State != ConnectionState.Connecting 
                && Conexion.State != ConnectionState.Executing
                && Conexion.State != ConnectionState.Fetching)
                _SqlConexion.Close();
        }

        // Ejecuta un Procedimiento Almacenado en la base. 
        public int ejecutar(string pProcedimientoAlmacenado)
        {
            try
            {
                return cargarComando(pProcedimientoAlmacenado).ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Ejecuta un Procedimiento Almacenado en la base, utilizando los parámetros. 
        public int ejecutar(string pProcedimientoAlmacenado, params  Object[] pArgumentos)
        {
            try
            {
                SqlCommand comando = cargarComando(pProcedimientoAlmacenado);
                cargarParametros(comando, pArgumentos);
                var respuesta = comando.ExecuteNonQuery();

                return respuesta;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #endregion

    }
}
