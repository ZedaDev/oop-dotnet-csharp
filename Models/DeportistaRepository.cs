using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class DeportistaRepository : ConnectionRepository, IDeportistaRepository
    {

        public bool Eliminar(Deportista deportista, int userId)
        {
            string query = @"
                            UPDATE deportista 
                            SET Active = 0
                            WHERE UsuarioId = @UsuarioId AND Id = @Id";


            return EliminarDeportista(userId, deportista.Id, query);
            //if (EliminarDeportista(userId, deportista.Id, query))
            //{

            //    if (deportista is Futbolista futbolista)
            //    {
            //        //FutbolistaRepository fP = new();
            //       return _repositorio.Eliminar(futbolista, userId);
            //       // return fP.Eliminar(futbolista, userId);
            //    }
            //}
            //return false;
        }

       

        public bool Insertar(Deportista deportista, int userId)
        {
            // Insertar Deportista 
            string query = @"
INSERT INTO deportista (FullName, Apodo, Edad, FechaDebut, FechaDeRegistro, Pais, Altura, UsuarioId, Deporte, LadoHabil, Comentario)
VALUES (@FullName, @Apodo, @Edad, @FechaDebut, @FechaDeRegistro, @Pais, @Altura, @UsuarioId, @Deporte, @LadoHabil, @Comentario)
 SELECT SCOPE_IDENTITY();";

            return InsertDeportista(deportista, query, userId, true);

            //if (InsertDeportista(deportista, query, userId, true))
            //{
            //   // Futbolista futbolista = deportista as Futbolista;
            //    if (deportista is Futbolista futbolista)
            //    {
            //        FutbolistaRepository fP = new();
            //        //var futbolRepo = Repository as IRepository<Futbolista>;
            //        return _repositorio.Insertar(futbolista, userId);
            //        //return fP.Insertar(futbolista, userId);

            //    }
            //    //else if(deportista is Boxeador boxeador)
            //}

            //return false;

        }

        //continued aqui
        public bool Modificar(Deportista deportista, int userId)
        {
            string query = @"
                            UPDATE deportista 
                            SET  FullName = @FullName, Apodo = @Apodo, Edad = @Edad, FechaDebut = @FechaDebut,
                              Altura = @Altura, Comentario = @Comentario, LadoHabil = @LadoHabil, Pais = @Pais
                            WHERE UsuarioId = @UsuarioId AND Id = @Id;";
            //OUTPUT INSERTED.Id
            return InsertDeportista(deportista, query, userId, false);
            //if (InsertDeportista(deportista, query, userId, false))
            //{
            //    if (deportista is Futbolista futbolista)
            //    {
            //        FutbolistaRepository fP = new();
            //        return fP.Modificar(futbolista, userId);
            //    }
            //}


            //return false;
        }

        public List<Deportista> ObtenerLista(int userId, Deportista value)
        {
           return TraerListaDeportistas(userId);
        }


        private bool InsertDeportista(Deportista d, string query, int userId, bool nuevoDeportista)
        {
            bool op = true;
            try
            {
                using (Connection)
                {
                    using (Command = new SqlCommand(query, Connection))
                    {
                        Connection.Open();
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
                        if (!nuevoDeportista)
                        {
                            Command.Parameters.AddWithValue("@Id", d.Id);
                            Command.ExecuteNonQuery();
                        }
                        else
                        {
                            d.Id = Convert.ToInt32(Command.ExecuteScalar());

                            if (d.Id < 0)
                                return false;
                        }

                    }
                }
            }
            catch (Exception)
            {
                op = false;
            }
            return op;
        }


        private bool EliminarDeportista(int userID, int deportistaId, string query)
        {
            try
            {
                using (Connection)
                {
                    using (Command = new(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@Id", deportistaId);
                        Command.Parameters.AddWithValue("@UsuarioId", userID);
                        Command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
               return true;
        }


        private void AgregarDeportistaToList(int userId, Action<EDeporte> cargarDeportista)
        {
            EDeporte deporte = new();

            while (Reader.Read())
            {
                deporte = (EDeporte)Reader.GetInt32("deporte");
                cargarDeportista.Invoke(deporte);
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
        private void CastearDeporteYCargarDatos(EDeporte deporte, List<Deportista> listaDeportistas, int userId)
        {
            switch (deporte)
            {
                case EDeporte.Futbol:

                    Futbolista futbolista = new Futbolista();
                    CargarPropiedadesDesdeBDD(futbolista, Reader);
                    FutbolistaRepository fP = new();
                    listaDeportistas.AddRange(fP.ObtenerLista(userId, futbolista));

                    break;
                //case EDeporte.Boxeo:
                //    break;
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
FROM deportista d
WHERE d.UsuarioId = @UsuarioId AND d.Active = 1";

            SqlTransaction sqlTransaction = Connection.BeginTransaction();
            try
            {
                using (Connection)
                {
                    Connection.Open();
                    using (Command = new SqlCommand(query, Connection, sqlTransaction))
                    {
                        Command.Parameters.AddWithValue("@UsuarioId", userId);
                        using (Reader = Command.ExecuteReader())
                        {
                            if (Reader.HasRows)
                            {
                                AgregarDeportistaToList(userId, (deporte) => CastearDeporteYCargarDatos(deporte, listaDeportistas, userId));
                            }
                        }
                    }
                    sqlTransaction.Commit();
                }

            }
            catch (Exception)
            {

                sqlTransaction.Rollback();
                return null;
            }

            return listaDeportistas;
        }

    }

}
