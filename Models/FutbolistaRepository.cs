using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class FutbolistaRepository : ConnectionRepository, IFutbolistaRepository
    {

        public bool Eliminar(Futbolista futbolista, int userId)
        {
            throw new NotImplementedException();
        }

        public bool Insertar(Futbolista value, int id)
        {
            // Insertar Futbolista 
            string query = @"
                            INSERT INTO futbolista (DeportistaId, Posicion, ClubActual, UsuarioId)
                            VALUES (@deportistaId, @posicion, @clubActual, @UsuarioId)";

            return InsertFutbolista(value, query, value.Id, id);
        }

        public bool Modificar(Futbolista futbolista, int id)
        {
            string query = @"
                            UPDATE futbolista
                            SET ClubActual = @ClubActual, Posicion = @Posicion, UsuarioId = @UsuarioId
                            WHERE DeportistaId = @DeportistaId AND UsuarioId = @UsuarioId";

            return InsertFutbolista(futbolista, query, futbolista.Id, id);

        }

        public List<Futbolista> ObtenerLista(int userId, Futbolista futbolista)
        {
            List<Futbolista> lista = new();
            string query = @"SELECT
f.Posicion, f.ClubActual, f.DeportistaId
FROM futbolista f
WHERE f.DeportistaId = @UserId AND f.Active = 1";
            futbolista.Posicion = Reader.IsDBNull(Reader.GetOrdinal("Posicion")) ? null : Reader.GetString(Reader.GetOrdinal("Posicion"));
            futbolista.ClubActual = Reader.IsDBNull(Reader.GetOrdinal("ClubActual")) ? null : Reader.GetString(Reader.GetOrdinal("ClubActual"));

            lista.Add(futbolista);
            return lista;
        }

        private bool InsertFutbolista(Futbolista futbolista, string query, int deportistaId, int userId)
        {
            try
            {
                using (Connection)
                {
                    Connection.Open();
                    using (Command = new SqlCommand(query, Connection))
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
            catch (Exception)
            {

                return false;
            }

            return true;

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
    }
}
