using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Service
{
    public class DeportistaConverter : JsonConverter<Deportista>
    {
        public override Deportista Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
            {
                var root = doc.RootElement;
                var tipo = root.GetProperty("Tipo").GetString(); // Suponiendo que tienes un campo "Tipo" para identificar el tipo

                // Deserializar según el tipo
                if (tipo == "Futbolista")
                {
                    return JsonSerializer.Deserialize<Futbolista>(root.GetRawText(), options);
                }else
                    throw new JsonException("Tipo de deportista no reconocido.");
                    /*else if (tipo == "Boxeador")
                    {
                        return JsonSerializer.Deserialize<Boxeador>(root.GetRawText(), options);
                    }
                    else if (tipo == "Tenista")
                    {
                        return JsonSerializer.Deserialize<Tenista>(root.GetRawText(), options);
                    }*/

            }
        }

        public override void Write(Utf8JsonWriter writer, Deportista value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            // Escribe los campos comunes
            writer.WriteString("Usuario", value.Usuario);
            writer.WriteString("Deporte", value.Deporte.ToString());
            writer.WriteString("FullName", value.FullName);
            writer.WriteString("Fecha Debut", value.FechaDebut);
            writer.WriteString("Edad", value.Edad);
            writer.WriteString("Altura", value.Altura);
            writer.WriteString("Apodo", value.Apodo);
            writer.WriteString("Nacionalidad", value.Nacionalidad);
            writer.WriteString("phHabil", value.PhHabil.ToString());
            writer.WriteString("FechaRegistro", value.FechaDeRegistro);

            // Escribe el tipo de deportista
            var tipo = value.GetType().Name;  // Obtenemos el tipo como string
            writer.WriteString("Tipo", tipo);

            // Escribe los campos específicos según el tipo
            switch (tipo)
            {
                case "Futbolista":
                    var futbolista = (Futbolista)value;
                    writer.WriteString("Posicion", futbolista.Posicion);
                    writer.WriteString("Club Actual", futbolista.ClubActual);
                    break;
               /* case "Boxeador":
                    var boxeador = (Boxeador)value;
                    writer.WriteNumber("RondasGanadas", boxeador.RondasGanadas);
                    writer.WriteNumber("RondasPerdidas", boxeador.RondasPerdidas);
                    break;
                case "Tenista":
                    var tenista = (Tenista)value;
                    writer.WriteNumber("JuegosGanados", tenista.JuegosGanados);
                    writer.WriteNumber("JuegosPerdidos", tenista.JuegosPerdidos);
                    break;*/
            }

            writer.WriteEndObject();
        }
    }
}
