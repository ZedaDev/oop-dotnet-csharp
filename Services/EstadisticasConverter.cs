using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Text.Json;

using System.Text.Json.Serialization;

namespace Service
{
    public class EstadisticasConverter : JsonConverter<Estadisticas>
    {
        public override Estadisticas Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
            {
                var root = doc.RootElement;
                var tipo = root.GetProperty("Tipo").GetString();

                Estadisticas stats = null;
                if (tipo == "EFutbolista")
                {
                    stats = JsonSerializer.Deserialize<EFutbolista>(root.GetRawText(), options);
                }else
                    throw new JsonException("Tipo de estadística no reconocido.");
                    /*else if (tipo == "EBoxeador")
                    {
                        return JsonSerializer.Deserialize<EBoxeador>(root.GetRawText(), options);
                    }
                    else if (tipo == "ETenisista")
                    {
                        return JsonSerializer.Deserialize<ETenisista>(root.GetRawText(), options);
                    }*/


                if (root.TryGetProperty("FechaDeRegistro", out var fechaRegistro) && stats is not null)
                {
                    stats.FechaDeRegistro = fechaRegistro.GetString();  // Asigna la fecha de registro desde el JSON
                }

                    return stats;
            }

        }


        public override void Write(Utf8JsonWriter writer, Estadisticas value, JsonSerializerOptions options)
        {
            var tipo = value.GetType().Name;  // Obtienes el nombre del tipo como string
            writer.WriteStartObject();
            writer.WriteString("Tipo", tipo);  // Escribes el nombre del tipo como string

            // Serializa las propiedades comunes de todas las clases derivadas
            writer.WriteString("Deportista", value.Deportista);
            writer.WriteString("Resultado", value.Resultado);
            writer.WriteString("Fecha", value.Fecha);
            writer.WriteString("Rival", value.Rival);
            writer.WriteString("Competicion", value.Competicion);
            writer.WriteString("Estadio", value.Estadio);
            writer.WriteString("Comentario", value.Comentario);
            writer.WriteString("FechaDeRegistro", value.FechaDeRegistro);

            // Serializa las propiedades específicas según el tipo
            switch (tipo)
            {
                case "EFutbolista":
                    var futbolista = (EFutbolista)value;
                    writer.WriteBoolean("Titular", futbolista.Titular);
                    writer.WriteString("Goles", futbolista.Goles);
                    writer.WriteString("Asistencias", futbolista.Asistencias);
                    writer.WriteString("MinutosJugados", futbolista.MinutosJugados);
                    writer.WriteString("TarjetaAmarilla", futbolista.TarjetaAmarilla);
                    writer.WriteBoolean("TarjetaRoja", futbolista.TarjetaRoja);
                    writer.WriteString("GolesTiroLibre", futbolista.GolesTiroLibre);
                    writer.WriteString("GolesPenal", futbolista.GolesPenal);
                    writer.WriteString("Usuario", futbolista.Usuario);
                    writer.WriteString("Deporte", futbolista.Deportista);
                    writer.WriteString("FechaDeRegistro", futbolista.FechaDeRegistro);
                    break;
               /* case "EBoxeador":
                    var boxeador = (EBoxeador)value;
                    writer.WriteNumber("RondasGanadas", boxeador.RondasGanadas);
                    writer.WriteNumber("RondasPerdidas", boxeador.RondasPerdidas);
                    writer.WriteString("Categoria", boxeador.Categoria);
                    writer.WriteBoolean("KO", boxeador.KO);
                    break;
                case "ETenisista":
                    var tenista = (ETenisista)value;
                    writer.WriteNumber("JuegosGanados", tenista.JuegosGanados);
                    writer.WriteNumber("JuegosPerdidos", tenista.JuegosPerdidos);
                    writer.WriteString("Superficie", tenista.Superficie);
                    break;*/
            }

            writer.WriteEndObject();
        }
    }
}

