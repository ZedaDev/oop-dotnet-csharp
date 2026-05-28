using Microsoft.Data.SqlClient;
using System.ComponentModel;
using System.Reflection;

namespace Entities
{
    public class ConnectionRepository
    {
        #region Atributos

        static string _cadena_conexion;
        SqlConnection _sqlConnection;
        SqlCommand _sqlCommand;
        SqlDataReader _sqlDataReader;

        static ConnectionRepository()
        {
            _cadena_conexion = "Data Source=DESKTOP-NUL46N1\\SQLEXPRESS;Initial Catalog=usuarios;Integrated Security=True;Trust Server Certificate=True";
        }
        public ConnectionRepository()
        {
            LinkConnection = _cadena_conexion;
            Connection = new(LinkConnection);
        }


        #endregion


        public void InitializeConnection()
        {
            Connection = new(_cadena_conexion);
        }



        #region Properties

        public  SqlConnection Connection
        {
            get => _sqlConnection;
            set => _sqlConnection = value;
        }
        public SqlCommand Command
        {
            get => _sqlCommand;
            set => _sqlCommand = value;
        }
        public SqlDataReader Reader
        {
            get => _sqlDataReader;
            set => _sqlDataReader = value;
        }
        public static string LinkConnection
        {
            get => _cadena_conexion;
            set => _cadena_conexion = value;
        }

        #endregion
    }
}