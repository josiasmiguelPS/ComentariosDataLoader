using Microsoft.Data.SqlClient;


namespace ComentarioDataLoader.Data.Base
{
    /// <summary>
    /// Objetivo de la clase
    /// </summary>
    public abstract class ComentsDataConnection
    {
        private readonly string _connString;
        /// <summary>
        /// Objetivo de constructor
        /// </summary>
        /// <param name="connectionString">Cadena de conexión a la base de datos</param>
        public ComentsDataConnection(string connectionString)
        {
            _connString = connectionString;
        }
        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connString);
        }
    }
}
