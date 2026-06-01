using Entities;
using Microsoft.Data.SqlClient;
using ProjectExceptions;
using Service.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Service
{
    public class AccesoDatos //: ConnectionRepository
    {
        #region Atributos

        static string _cadena_conexion;
        SqlConnection _sqlConnection;
        SqlCommand _sqlCommand;
        SqlDataReader _sqlDataReader;




        #endregion



        #region Contructores

        static AccesoDatos()
        {
           _cadena_conexion = Properties.Resources.miConexion;
           
            //_cadena_conexion = @"DESKTOP - NUL46N1\SQLEXPRESS; Initial Catalog = mi_base; Integrated Security = True; Trust Server Certificate = True";
        }
        public AccesoDatos()
        {
            //CREO EL OBJETO SQLCONNECTION
            _sqlConnection = new SqlConnection(_cadena_conexion);
            //InitializeConnection(_cadena_conexion);
        }


        #endregion

        #region Properties

        private SqlConnection Connection
        {
            get => _sqlConnection;
            set => _sqlConnection = value;
        }
        private SqlCommand Command
        {
            get => _sqlCommand;
            set => _sqlCommand = value;
        }
        private SqlDataReader Reader
        {
            get => _sqlDataReader;
            set => _sqlDataReader = value;
        }
        private static string LinkConnection
        {
            get => _cadena_conexion;
            set => _cadena_conexion = value;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Verifica si el usuario con NICKNAME/PW existe en la base de datos
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <returns>Retorna un usuario instanciado o el usuario cargado (se instancia con id negativo para luego, saber si se cargo el objeto)</returns>
        public User Login(string name)//, string pw)
        {
            // ProbarConexion();
            User us = new User();

            

            string query = "SELECT * FROM usuario WHERE nickname = @nickName and active = 1";
           
                Connection.Open();
                using (Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.Add("@nickName", SqlDbType.NVarChar).Value = name;
                    


                    using (Reader = Command.ExecuteReader())
                    {

                        if (Reader.HasRows)
                        {
                            if (Reader.Read())
                            {
                                us.Pw = Reader["pass"].ToString();
                                /* if(us.Pw != pw)
                                 {
                                     us.Id = -1;
                                 }
                                 else
                                 {
                                     us.Id = (int)Reader["Id"];
                                 }*/
                                us.Id = (int)Reader["Id"];
                                us.NickName = Reader["nickname"].ToString();
                                us.FechaRegistro = (DateTime)Reader["FechaDeRegistro"];
                            }
                        }
                    }

                

            }
                 return us;
        }
        public User Login(string name, string pw)
        {
            // ProbarConexion();
            User us = new User();

            

            string query = "SELECT * FROM usuario WHERE nickname = @nickName and pass = @pw";
            using(var conection = new SqlConnection(_cadena_conexion))
            {
                conection.Open();
                using (var command = new SqlCommand(query, conection))
                {
                    command.Parameters.Add("@nickName", SqlDbType.NVarChar).Value = name;
                    command.Parameters.Add("@pw", SqlDbType.NVarChar).Value = pw;
                    


                    using (var dataReader = command.ExecuteReader())
                    {

                        if (dataReader.HasRows)
                        {
                            if (dataReader.Read())
                            {
                                us.Pw = dataReader["pass"].ToString();
                                if(us.Pw != pw)
                                {
                                    return null;
                                }
                                else
                                {
                                    us.Id = (int)dataReader["Id"];
                                }
                                    //us.Id = (int)dataReader["Id"];
                                us.NickName = dataReader["nickname"].ToString();
                                us.FechaRegistro = (DateTime)dataReader["FechaDeRegistro"];
                            }
                        }
                    }

                }

            }
                 return us;
        }
        public void InsertarUsuario(User usuario)
        {
            using(Connection)
            {
                Connection.Open();
                string query = "INSERT INTO usuario (fechaDeRegistro, nickname, pass) VALUES (@FechaRegistro, @NickName, @Pass) SELECT SCOPE_IDENTITY()";
                using (Command = new SqlCommand(query, Connection))
                {
                    //Command.Parameters.Add(", SqlDbType.NVarChar).Value = ;
                    Command.Parameters.AddWithValue("@FechaRegistro", usuario.FechaRegistro);
                    Command.Parameters.AddWithValue("@NickName", usuario.NickName);
                    Command.Parameters.AddWithValue("@Pass", usuario.Pw);
                    usuario.Id = Convert.ToInt32(Command.ExecuteScalar());
                
                }

            }
            
        }

        //open si falla tira excepcion, la captura y en el finnaly siempre cerrar la conexion verificando que este en open.
        public bool ProbarConexion()
        {
            bool option = true;
            try
            {
                    Connection.Open();
            }
            catch (Exception)
            {
                option = false;
                //throw new BddNotConnect("Error en la conexion a la base de datos");
            }
            finally
            {
                if(Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
            return option;
        }

        /// <summary>
        /// Carga todas las estadisticas de la base de datos que coincidan con el Id del Deportista pasado por argumento
        /// </summary>
        /// <param name="d"></param>
        /// <exception cref="BddNotConnect"> Puede devolver BddNotConnect cuando hubo un error al cargar la estadistica en el metodo 'TraerEstadisticasFutbolista'</exception>
        public void TraerEstadisticasDeportista(Deportista d)
        {
            try
            {
                string query = string.Empty;
                switch (d)
                {
                    case Futbolista:
                        query = @"
                    SELECT ef.Id, ef.Goles, ef.Asistencias, ef.MinutosJugados, ef.TarjetaAmarilla, 
                           ef.TarjetaRoja, ef.GolesTiroLibre, ef.GolesPenal, ef.Titular, ef.EstadisticaId, ef.Mvp, ef.Club,
                           e.Fecha, e.Rival, e.Competicion, e.Estadio, e.Comentario, 
                           e.UsuarioId, e.Resultado, e.FechaDeRegistro, e.TipoDeportista, e.Score
                    FROM EstadisticaFutbolista ef
                    INNER JOIN estadistica e ON ef.EstadisticaId = e.Id
                    WHERE e.UsuarioId = @userId AND e.IdDeportista = @DeportistaId
                    AND ef.UsuarioId = @userId AND ef.IdDeportista = @DeportistaId
                    AND ef.Active = 1 AND e.Active = 1"; //AQUI COMPROBAR IDS, se guarda con el id 1 del primer deportista. 
                        //ProbarCo
                        //
                        TraerEstadisticas<EFutbolista>(query, d, Usuarios.MyUser.Id);

                        break;
                    default:
                        break;
                }
            }
            catch (BddNotConnect e)
            {

                throw new BddNotConnect($"Error! {e.Message}", e.InnerException);
            }


        }

        private void CharguinStat(IEstadistica e, SqlDataReader reader)
        {

            switch (e)
            {
                case EFutbolista stat:
                    stat.Id = reader.GetInt32(reader.GetOrdinal("EstadisticaId"));

                    stat.Goles = reader.IsDBNull(reader.GetOrdinal("Goles")) ? "0" : reader.GetInt32(reader.GetOrdinal("Goles")).ToString();
                    stat.Asistencias = reader.IsDBNull(reader.GetOrdinal("Asistencias")) ? "0" : reader.GetInt32(reader.GetOrdinal("Asistencias")).ToString();
                    stat.MinutosJugados = reader.IsDBNull(reader.GetOrdinal("MinutosJugados")) ? "0" : reader.GetInt32(reader.GetOrdinal("MinutosJugados")).ToString();
                    stat.TarjetaAmarilla = reader.GetInt32(reader.GetOrdinal("TarjetaAmarilla"));
                    stat.TarjetaRoja = reader.GetInt32(reader.GetOrdinal("TarjetaRoja")) == 0 ? false : true;
                    stat.GolesTiroLibre = reader.IsDBNull(reader.GetOrdinal("GolesTiroLibre")) ? "0" : reader.GetInt32(reader.GetOrdinal("GolesTiroLibre")).ToString();
                    stat.GolesPenal = reader.IsDBNull(reader.GetOrdinal("GolesPenal")) ? "0" : reader.GetInt32(reader.GetOrdinal("GolesPenal")).ToString();
                    stat.Titular = reader.IsDBNull(reader.GetOrdinal("Titular")) ? false : reader.GetInt32(reader.GetOrdinal("Titular")) == 1 ? true : false;
                    stat.Mvp = reader.IsDBNull(reader.GetOrdinal("Mvp")) ? false : reader.GetInt32(reader.GetOrdinal("Mvp")) == 1 ? true : false;
                    stat.club = reader.IsDBNull(reader.GetOrdinal("Club")) ? string.Empty : reader.GetString(reader.GetOrdinal("Club"));

                    // Estadísticas generales
                    stat.Resultado = reader.IsDBNull(reader.GetOrdinal("Resultado")) ? string.Empty : reader.GetString(reader.GetOrdinal("Resultado"));
                    stat.Fecha = reader.IsDBNull(reader.GetOrdinal("Fecha")) ? (DateTime)new() : reader.GetDateTime(reader.GetOrdinal("Fecha"));
                    stat.Rival = reader.IsDBNull(reader.GetOrdinal("Rival")) ? string.Empty : reader.GetString(reader.GetOrdinal("Rival"));
                    stat.Competicion = reader.IsDBNull(reader.GetOrdinal("Competicion")) ? string.Empty : reader.GetString(reader.GetOrdinal("Competicion"));
                    stat.Estadio = reader.IsDBNull(reader.GetOrdinal("Estadio")) ? string.Empty : reader.GetString(reader.GetOrdinal("Estadio"));
                    stat.Comentario = reader.IsDBNull(reader.GetOrdinal("Comentario")) ? string.Empty : reader.GetString(reader.GetOrdinal("Comentario"));
                    stat.FechaDeRegistro = reader.IsDBNull(reader.GetOrdinal("FechaDeRegistro")) ? (DateTime)new() : reader.GetDateTime("FechaDeRegistro");
                    stat.Deportista = reader.IsDBNull(reader.GetOrdinal("TipoDeportista")) ? string.Empty : reader.GetString(reader.GetOrdinal("TipoDeportista"));
                    stat.Score = reader.IsDBNull(reader.GetOrdinal("Score")) ? (EResultado)new() : (EResultado)reader.GetInt32(reader.GetOrdinal("Score"));
                    stat.Usuario = $"{Usuarios.MyUser.NickName}";
                    break;

                   //Agregar mas cases para retornar segun que estadistica de deporte es(Futbol,Boxeo,Tenis,etc).
                default:
                    break;
            }
        }
        private void AddStatsFromReader<T>(List<Estadisticas> list, SqlDataReader reader) where T : Estadisticas, new()
        {
            
            while (reader.Read())
            {
                T estadistica = new();
                CharguinStat(estadistica, reader);
                list.Add(estadistica);
            }
        }
        
        private void TraerEstadisticas<T>(string queryEstadisticas, Deportista d, int userId) where T : Estadisticas, new()
        {
            try
            {
                
                using(Connection)
                {
                    using (Command = new(queryEstadisticas, Connection))
                    {
                       Command.Parameters.AddWithValue("@userId", userId);
                       Command.Parameters.AddWithValue("@DeportistaId", d.Id);
                       
                       Connection.Open();
                        using (Reader = Command.ExecuteReader())
                        {
                            if (Reader.HasRows)
                                AddStatsFromReader<T>(d.Estadisticas, Reader);
                        }
                    }
                }  
            }
            catch (Exception e)
            {
                 throw new BddNotConnect($"No se pudo cargar Estadistica del futbolista {e.Message}", e.InnerException);
            }
        }


        public List<Deportista> TraerListaDeportistasV1(int userId)
        {
            List<Deportista> listaDeportistas = new List<Deportista>();

            string query = @"
        SELECT 
            d.Id, d.FullName, d.Apodo, d.Edad, d.FechaDebut, d.FechaDeRegistro, d.Pais, d.Altura, d.LadoHabil, d.Deporte,
            f.Posicion AS PosicionFutbolista, f.ClubActual AS ClubActualFutbolista,
            b.Peso AS PesoBoxeador, b.Division AS DivisionBoxeador, b.ClubActual AS ClubActualBoxeador,
            t.Ranking AS RankingTenista, t.ClubActual AS ClubActualTenista
        FROM 
            deportista d
        LEFT JOIN futbolista f ON d.Id = f.DeportistaId AND d.Deporte = 0
        LEFT JOIN boxeador b ON d.Id = b.DeportistaId AND d.Deporte = 1
        LEFT JOIN tenista t ON d.Id = t.DeportistaId AND d.Deporte = 2
        WHERE d.UsuarioId = @UsuarioId";
            //especifico los datos que voy a traer con sus alias especificos de cada deporte y, tabla.
            //especifico segun el deporte y, la misma ID que del deportista
            // especifico que solo se busque en la ID del USUARIO.
            //LEFT JOIN se encarga de indexar la consulta segun el deporte.
            using (var conection = new SqlConnection(_cadena_conexion))
            {
                conection.Open();
                using (var command = new SqlCommand(query, conection))
                {
                    command.Parameters.AddWithValue("@UsuarioId", userId);

                    conection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {

                                // Verificar el tipo de deporte y crear la instancia correspondiente
                                EDeporte deporte = (EDeporte)reader.GetInt32(reader.GetOrdinal("deporte"));
                                switch (deporte)
                                {
                                    case EDeporte.Futbol:
                                        Futbolista futbolista = new Futbolista
                                        {
                                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                            FullName = reader.GetString(reader.GetOrdinal("FullName")),
                                            Apodo = reader.GetString(reader.GetOrdinal("Apodo")),
                                            Edad = reader.GetString(reader.GetOrdinal("Edad")),
                                            FechaDebut = reader.GetDateTime(reader.GetOrdinal("FechaDebut")),
                                            FechaDeRegistro = reader.GetDateTime(reader.GetOrdinal("FechaDeRegistro")),
                                            Nacionalidad = reader.GetString(reader.GetOrdinal("Pais")),
                                            Altura = reader.GetString(reader.GetOrdinal("Altura")),
                                            PhHabil = (ELadoHabil)reader.GetInt32(reader.GetOrdinal("LadoHabil")),
                                            // Propiedades específicas de Futbolista
                                            Posicion = reader.GetString(reader.GetOrdinal("Posicion")),
                                            ClubActual = reader.GetString(reader.GetOrdinal("ClubActual"))
                                        };

                                        listaDeportistas.Add(futbolista);
                                        break;
                                    default:
                                        throw new Exception("Deporte no soportado");
                                }
                            }
                        }
                    }


                }
            }
            return listaDeportistas;
        }

        private void AddAllDeportistasToList(SqlDataReader reader, int userId, Action< EDeporte, SqlDataReader> d)
        {
                EDeporte deporte = new();

              
         
            while (reader.Read())
            {

                // Verificar el tipo de deporte y crear la instancia correspondiente
                deporte = (EDeporte)reader.GetInt32("deporte");


                d.Invoke(deporte, reader);


               /* switch (deporte)
                {
                    case EDeporte.Futbol:

                        Futbolista futbolista = new Futbolista();
                        //CargarPropiedadesDesdeBDD(futbolista, reader);
                        /*{
                            Id = reader.GetInt32(reader.GetOrdinal("DeportistaId")),
                            FullName = reader.GetString(reader.GetOrdinal("FullName")),
                            Apodo = reader.GetString(reader.GetOrdinal("Apodo")),
                            Edad = reader.GetInt32(reader.GetOrdinal("Edad")).ToString(),
                            FechaDebut = reader.GetDateTime(reader.GetOrdinal("FechaDebut")),
                            FechaDeRegistro = reader.GetDateTime(reader.GetOrdinal("FechaDeRegistro")),
                            Nacionalidad = reader.GetString(reader.GetOrdinal("Pais")),
                            Altura = reader.GetString(reader.GetOrdinal("Altura")),
                            PhHabil = (ELadoHabil)reader.GetInt32(reader.GetOrdinal("LadoHabil")),
                            Comentario = reader.IsDBNull(reader.GetOrdinal("Comentario")) ? string.Empty : reader.GetString(reader.GetOrdinal("Comentario")),
                            
                        };
                            // Propiedades específicas de Futbolista
                           futbolista.Posicion = reader.IsDBNull(reader.GetOrdinal("Posicion")) ? null : reader.GetString(reader.GetOrdinal("Posicion")),
                            futbolista.ClubActual = reader.IsDBNull(reader.GetOrdinal("ClubActual")) ? null : reader.GetString(reader.GetOrdinal("ClubActual"))


                        listaDeportistas.Add(futbolista);
                        break;
                        
                    default:
                        throw new Exception("Deporte no soportado");
                }*/
            }
        }

        /// <summary>
        /// Carga las propiedades del deportista desde el reader de la BDD.
        /// Carga las propiedades especificas del deporte
        /// Agrega el deportista instanciado con su deporte (ej: new Futbolista()), a la lista de deportistas general.
        /// </summary>
        /// <param name="deporte"></param>
        /// <param name="reader"></param>
        /// <param name="listaDeportistas"></param>
        /// <exception cref="Exception"> Lanza excepcion si se pasa un deporte o una clase inexistente</exception>
        private void DeportistaTo(EDeporte deporte, SqlDataReader reader, List<Deportista> listaDeportistas)
        {
            switch (deporte)
            {
                case EDeporte.Futbol:

                    Futbolista futbolista = new Futbolista();
                    CargarPropiedadesDesdeBDD(futbolista, reader);

                    futbolista.Posicion = reader.IsDBNull(reader.GetOrdinal("Posicion")) ? null : reader.GetString(reader.GetOrdinal("Posicion"));
                    futbolista.ClubActual = reader.IsDBNull(reader.GetOrdinal("ClubActual")) ? null : reader.GetString(reader.GetOrdinal("ClubActual"));

                        listaDeportistas.Add(futbolista);
                        
                    break;

                default:
                    throw new Exception("Deporte no soportado");
            }
        }
        private void CargarPropiedadesDesdeBDD(Deportista d, SqlDataReader reader)
        {
            d.Id = reader.GetInt32(reader.GetOrdinal("DeportistaId"));
            d.FullName = reader.GetString(reader.GetOrdinal("FullName"));
            d.Apodo = reader.GetString(reader.GetOrdinal("Apodo"));
            d.Edad = reader.GetInt32(reader.GetOrdinal("Edad")).ToString();
            d.FechaDebut = reader.GetDateTime(reader.GetOrdinal("FechaDebut"));
            d.FechaDeRegistro = reader.GetDateTime(reader.GetOrdinal("FechaDeRegistro"));
            d.Nacionalidad = reader.GetString(reader.GetOrdinal("Pais"));
            d.Altura = reader.GetString(reader.GetOrdinal("Altura"));
            d.PhHabil = (ELadoHabil)reader.GetInt32(reader.GetOrdinal("LadoHabil"));
            d.Comentario = reader.IsDBNull(reader.GetOrdinal("Comentario")) ? string.Empty : reader.GetString(reader.GetOrdinal("Comentario"));
        }


        public List<Deportista> TraerListaDeportistas(int userId)
        {
            List<Deportista> listaDeportistas = new List<Deportista>();
            
            string query = @"SELECT d.FullName, d.Apodo, d.Edad, d.FechaDebut, d.FechaDeRegistro, d.Pais, d.Altura, d.LadoHabil, d.Deporte, d.Comentario,
f.Posicion, f.ClubActual, f.DeportistaId
FROM deportista d
LEFT JOIN futbolista f ON d.Id = f.DeportistaId AND d.Deporte = 0 
WHERE d.UsuarioId = @UsuarioId AND d.Active = 1;";
            //especifico los datos que voy a traer con sus alias especificos de cada deporte y, tabla.
            //especifico segun el deporte y, la misma ID que del deportista
            // especifico que solo se busque en la ID del USUARIO.
            //LEFT JOIN se encarga de indexar la consulta segun el deporte.
            using(Connection)
            {
                Connection.Open();
                using (Command = new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@UsuarioId", userId);
                    using (Reader = Command.ExecuteReader())
                    {
                        if (Reader.HasRows)
                        {
                            AddAllDeportistasToList(Reader, userId, (deporte, reader) => DeportistaTo(deporte, reader, listaDeportistas));

                        }
                    }
                }
            }
            return listaDeportistas;
        }
        

        //CONTINUED AQUI..
        public string GetQueryUpdateDeleteStat(EFutbolista futbolista)
        {
            string query = @"
            UPDATE Estadistica
            SET Active = 0
            OUTPUT INSERTED.Id
            WHERE IdDeportista = @IdDeportista AND UsuarioId = @UsuarioId AND Id = @Id";

            return query;
        }
        public string GetQueryDeleteStatFutbolista(EFutbolista futbolista)
        {
            string query = @"
            UPDATE EstadisticaFutbolista
            SET Active = 0
            WHERE IdDeportista = @IdDeportista AND UsuarioId = @UsuarioId AND EstadisticaId = @EstadisticaId";

            return query;
        }
        public bool UpdateDeleteEstadisticaFutbolista(EFutbolista stat, int userId, EOption deleteOrUpdate)
        {
            try
            {
                string query1 = string.Empty;
                string query2 = string.Empty;

                switch (deleteOrUpdate) //Seria un enum de EOpcion{Eliminar, Modificar, Cargar}
                {
                    case EOption.Eliminar:
                        query1 = GetQueryUpdateDeleteStat(stat);
                        query2 = GetQueryDeleteStatFutbolista(stat);

                        break;
                    case EOption.Modificar:
                        //Deportista Table
                        query1 = @"
                            UPDATE Estadistica 
                            SET  TipoDeportista = @TipoDeportista, Fecha = @Fecha, Rival = @Rival, Competicion = @Competicion,
                            Estadio = @Estadio, Comentario = @Comentario, FechaDeRegistro = @FechaDeRegistro, Score = @Score, Resultado = @Resultado
                            OUTPUT INSERTED.Id
                            WHERE UsuarioId = @UsuarioId AND Id = @Id AND IdDeportista = @IdDeportista;";


                        //Futbolista Table
                        query2 = @"
                            UPDATE EstadisticaFutbolista
    SET Goles = @Goles,  Asistencias = @Asistencias, MinutosJugados = @MinutosJugados, TarjetaAmarilla = @TarjetaAmarilla, TarjetaRoja = @TarjetaRoja, 
        GolesTiroLibre = @GolesTiroLibre, 
        GolesPenal = @GolesPenal
    WHERE EstadisticaId = @EstadisticaId AND UsuarioId = @UsuarioId AND IdDeportista = @IdDeportista;";
                        break;
                    default:
                        //throw;
                        break;
                }
                int id = InsertarEstadisticaGeneral(stat, query1, userId, Deportistas.MyAtleta.Id, false);
                InsertarEstadisticaFutbolista(stat, id, query2, userId, Deportistas.MyAtleta.Id);





                //Cuando elimino va en false, para que ADD el parametro Id y poder encontrar el deportista a eliminar.
                //Cuando Modifico Tambien deberia ir en false para que ADD Parametro IDbusque el deportista por Id, pero cambiando la query ya que eliminar pone active en 0 y modificar solo sria modificar datos no inahbilitar el active a 0.
                //y aqui radica la exception, necesitaria un enum de cargar, modificar, eliminar, lo mando por parametro y, aqui en este metodo
                //hago un switch de cada enum, dando la query correcta, luego mando deleteOrUpdate de igual manera, 


            }
            catch (Exception e)
            {

                return false;
            }

            return true;
        }
        public bool UpdateEstadisticaFutbolista(EFutbolista stat, int deportistaId, int userId)
        {
            try
            {
                string query1 = @"
                            UPDATE estadistica 
                            SET TipoDeportista = @TipoDeportista, Fecha = @Fecha, Rival = @Rival, Competicion = @Competicion, Estadio = @Estadio, Comentario = @Comentario, Score = @Score, Resultado = @Resultado
                           OUTPUT INSERTED.Id
                           WHERE usuarioId = @UsuarioId AND IdDeportista = @IdDeportista AND Id = @Id ;";
                int id = InsertarEstadisticaGeneral(stat, query1, userId, deportistaId, false);

                string query2 = @"
    UPDATE estadisticaFutbolista
    SET Goles = @Goles,  Asistencias = @Asistencias, MinutosJugados = @MinutosJugados, TarjetaAmarilla = @TarjetaAmarilla, TarjetaRoja = @TarjetaRoja, 
        GolesTiroLibre = @GolesTiroLibre, 
        GolesPenal = @GolesPenal
    WHERE EstadisticaId = @EstadisticaId AND UsuarioId = @UsuarioId AND IdDeportista = @IdDeportista;";

                InsertarEstadisticaFutbolista(stat, id, query2, userId, deportistaId);

            }
            catch (Exception e)
            {

                return false;
            }

            return true;
        }


        //solo hago un insert de la estadistica al futbolista.

        private int InsertarEstadisticaGeneral(EFutbolista stat, string query, int userId, int idDeportista, bool option)
        {
            int estadisticaId = 0;

            using (var conection = new SqlConnection(_cadena_conexion))
            {
                conection.Open();
                using (var command = new SqlCommand(query, conection))
                {
                    if (!option)
                    {
                        command.Parameters.AddWithValue("@Id", stat.Id);
                    }
                    command.Parameters.AddWithValue("@TipoDeportista", "Futbol");
                    command.Parameters.AddWithValue("@Fecha", stat.Fecha);
                    command.Parameters.AddWithValue("@Rival", stat.Rival);
                    command.Parameters.AddWithValue("@Competicion", stat.Competicion);
                    command.Parameters.AddWithValue("@Estadio", stat.Estadio);
                    command.Parameters.AddWithValue("@Comentario", stat.Comentario);
                    command.Parameters.AddWithValue("@FechaDeRegistro", DateTime.Now);
                    command.Parameters.AddWithValue("@UsuarioId", userId);
                    command.Parameters.AddWithValue("@IdDeportista", idDeportista);
                    command.Parameters.AddWithValue("@Score", (int)stat.Score);
                    command.Parameters.AddWithValue("@Resultado", stat.Resultado);

                    estadisticaId = Convert.ToInt32(command.ExecuteScalar()); // Obtenemos el Id de la estadística insertada
                }
            }
           

            
            return estadisticaId;
        }
        private void InsertarEstadisticaFutbolista(EFutbolista stat, int estadisticaId, string query, int userId, int idDeportista)
        {
            /* string insertEstadisticaFutbolistaQuery = @"
                     INSERT INTO EstadisticaFutbolista (EstadisticaId, Goles, Asistencias, MinutosJugados, TarjetaAmarilla, TarjetaRoja, GolesTiroLibre, GolesPenal)
                     VALUES (@EstadisticaId, @Goles, @Asistencias, @MinutosJugados, @TarjetaAmarilla, @TarjetaRoja, @GolesTiroLibre, @GolesPenal);";*/
            using (Connection)
            {
                Connection.Open();
                using (Command= new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@EstadisticaId", estadisticaId);
                    Command.Parameters.AddWithValue("@Goles", stat.Goles);
                    Command.Parameters.AddWithValue("@Asistencias", stat.Asistencias);
                    Command.Parameters.AddWithValue("@MinutosJugados", stat.MinutosJugados);
                    Command.Parameters.AddWithValue("@TarjetaAmarilla", stat.TarjetaAmarilla);
                    Command.Parameters.AddWithValue("@TarjetaRoja", stat.TarjetaRoja ? 1 : 0); // Convertimos booleano a int
                    Command.Parameters.AddWithValue("@GolesTiroLibre", stat.GolesTiroLibre);
                    Command.Parameters.AddWithValue("@GolesPenal", stat.GolesPenal);
                    Command.Parameters.AddWithValue("@Mvp", stat.Mvp ? 1 : 0);
                    Command.Parameters.AddWithValue("@Titular", stat.Titular ? 1 : 0);
                    Command.Parameters.AddWithValue("@Club", stat.club is null ? string.Empty : stat.club); //mejorar esta sentencia
                    Command.Parameters.AddWithValue("@UsuarioId", userId);
                    Command.Parameters.AddWithValue("@IdDeportista", idDeportista);

                    stat.Id = Convert.ToInt32(Command.ExecuteScalar());
                }
            }
        }
        public bool InsertarEstadisticasFutbolista(EFutbolista stat, int userId, int deportistaId)
        {
          //Encapsular logica y, llamar desde el main al metodo que primero settea la query luego llamar internamente a este metodo con la query ya setteada.
          //Mediante un switch si es Efutbolista,etc y asi poder aceptar estadisticas segun el deporte.
            try
            {
                
                string insertEstadisticaQuery = @"
                        INSERT INTO estadistica (TipoDeportista, Fecha, Rival, Competicion, Estadio, Comentario, FechaDeRegistro, UsuarioId, Score, Resultado, IdDeportista)
                        VALUES (@TipoDeportista, @Fecha, @Rival, @Competicion, @Estadio, @Comentario, @FechaDeRegistro, @UsuarioId, @Score, @Resultado, @IdDeportista);
                        SELECT SCOPE_IDENTITY();"; // Obtener el Id de la estadística recién insertada

                
                stat.Id = InsertarEstadisticaGeneral(stat, insertEstadisticaQuery, userId, deportistaId, true);
                string query = @"
                            INSERT INTO estadisticaFutbolista (EstadisticaId, Goles, Asistencias, MinutosJugados, TarjetaAmarilla, TarjetaRoja, GolesTiroLibre, GolesPenal, Mvp, Titular, Club, UsuarioId, IdDeportista)
                        VALUES (@EstadisticaId, @Goles, @Asistencias, @MinutosJugados, @TarjetaAmarilla, @TarjetaRoja, @GolesTiroLibre, @GolesPenal, @Mvp, @Titular, @Club, @UsuarioId, @IdDeportista)";
                // Insertar las estadísticas específicas del futbolista
                InsertarEstadisticaFutbolista(stat, stat.Id, query, userId, deportistaId);
                  
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }


        public string GetQueryUpdateDeleteDeportista(Futbolista futbolista)
        {
            string query = @"
                            UPDATE deportista 
                            SET Active = 0
                            OUTPUT INSERTED.Id
                            WHERE UsuarioId = @UsuarioId AND Id = @Id";

            return query;
        }
        public string GetQueryUpdateDeleteFutbolista(Futbolista futbolista)
        {
            string query = @"
            UPDATE futbolista
            SET Active = 0
            
            WHERE DeportistaId = @DeportistaId AND UsuarioId = @UsuarioId";
//OUTPUT INSERTED.DeportistaId
            return query;
        }
        public bool UpdateFutbolista(Futbolista futbolista, int userId, EOption deleteOrUpdate)
        {
            try
            {
                string query1 = string.Empty;
                string query2 = string.Empty;
              
                switch (deleteOrUpdate) //Seria un enum de EOpcion{Eliminar, Modificar, Cargar}
                {
                    case EOption.Eliminar:
                        query1 = GetQueryUpdateDeleteDeportista(futbolista);
                        query2 = GetQueryUpdateDeleteFutbolista(futbolista);

                        break;
                    case EOption.Modificar:
                       //Deportista Table
                        query1 = @"
                            UPDATE deportista 
                            SET  FullName = @FullName, Apodo = @Apodo, Edad = @Edad, FechaDebut = @FechaDebut,
                              Altura = @Altura, Comentario = @Comentario, LadoHabil = @LadoHabil, Pais = @Pais
                            OUTPUT INSERTED.Id
                            WHERE UsuarioId = @UsuarioId AND Id = @Id;";


                       //Futbolista Table
                        query2 = @"
                            UPDATE futbolista
                            SET ClubActual = @ClubActual, Posicion = @Posicion, UsuarioId = @UsuarioId
                            
                            WHERE DeportistaId = @DeportistaId AND UsuarioId = @UsuarioId;";
                        break;
                    default:
                        //throw;
                        break;
                }
                  int id = InsertDeportista(futbolista, query1, userId, false);
                //futbolista.Id = id;
                            InsertFutbolista(futbolista, query2, id, userId);
              
               


               
                //Cuando elimino va en false, para que ADD el parametro Id y poder encontrar el deportista a eliminar.
                //Cuando Modifico Tambien deberia ir en false para que ADD Parametro IDbusque el deportista por Id, pero cambiando la query ya que eliminar pone active en 0 y modificar solo sria modificar datos no inahbilitar el active a 0.
                //y aqui radica la exception, necesitaria un enum de cargar, modificar, eliminar, lo mando por parametro y, aqui en este metodo
                //hago un switch de cada enum, dando la query correcta, luego mando deleteOrUpdate de igual manera, 


            }
            catch (Exception e)
            {

                return false;
            }

            return true;
        }

        private int InsertDeportista(Deportista d, string query, int userId, bool option)
        {
            using (Connection)
            {
                Connection.Open();
                using (Command = new SqlCommand(query, Connection))
                {
                    if (!option)
                    {
                     Command.Parameters.AddWithValue("@Id", Deportistas.MyAtleta.Id);
                    }
                    Command.Parameters.AddWithValue("@FullName", d.FullName);
                    Command.Parameters.AddWithValue("@Apodo", d.Apodo);
                    Command.Parameters.AddWithValue("@Edad", int.Parse(d.Edad));
                    Command.Parameters.AddWithValue("@FechaDebut", d.FechaDebut);
                    Command.Parameters.AddWithValue("@FechaDeRegistro", d.FechaDeRegistro);
                    Command.Parameters.AddWithValue("@Pais", d.Nacionalidad); // Convertimos booleano a int
                    Command.Parameters.AddWithValue("@Altura", d.Altura);
                    Command.Parameters.AddWithValue("@UsuarioId", userId);
                    Command.Parameters.AddWithValue("@Deporte", (int)d.Deporte);
                    Command.Parameters.AddWithValue("@LadoHabil", (int)d.PhHabil);
                    Command.Parameters.AddWithValue("@Comentario", d.Comentario is not null ? d.Comentario : string.Empty);
                    
                    int id = Convert.ToInt32(Command.ExecuteScalar());
                    d.Id = id;
                        return id;
                }

            }
        }
        private void InsertFutbolista(Futbolista futbolista, string query, int deportistaId, int userId)
        {
            using (Connection)
            {
                Connection.Open();
                using (Command= new SqlCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@DeportistaId", deportistaId);
                    Command.Parameters.AddWithValue("@UsuarioId", userId);
                    Command.Parameters.AddWithValue("@Posicion", futbolista.Posicion);
                    Command.Parameters.AddWithValue("@ClubActual", futbolista.ClubActual);
                    
                    Command.ExecuteNonQuery();
                    //futbolista.Id = Convert.ToInt32(command.ExecuteScalar());
                }
            }


        }
        public void InsertarFutbolista(Futbolista futbolista, int userId)
        {

            // Insertar Deportista 
            string query1 = @"
                            INSERT INTO deportista (FullName, Apodo, Edad, FechaDebut, FechaDeRegistro, Pais, Altura, UsuarioId, Deporte, LadoHabil, Comentario)
                        VALUES (@FullName, @Apodo, @Edad, @FechaDebut, @FechaDeRegistro, @Pais, @Altura, @UsuarioId, @Deporte, @LadoHabil, @Comentario)
                        SELECT SCOPE_IDENTITY();";
            int deportistaId = InsertDeportista(futbolista, query1, userId, true);

               // Insertar Futbolista 
                string query = @"
                            INSERT INTO futbolista (DeportistaId, Posicion, ClubActual, UsuarioId)
                            VALUES (@deportistaId, @posicion, @clubActual, @UsuarioId)";
            InsertFutbolista(futbolista, query, deportistaId, userId);
             //SELECT SCOPE_IDENTITY();
        }


        #endregion
    }
}
