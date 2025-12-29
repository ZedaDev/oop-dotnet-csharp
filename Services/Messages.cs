using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public static class Messages
    {
        public static string DoYouWantMessage(string value)
        {
            return $"Seguro/a Desea Eliminar {value}?";
        }
        public static string CongratsDeleteMessage(string value)
        {
            return $"{value} Eliminado/a Con Exito";
        }
        public static string CongratsMessage(string value)
        {
            return $"{value} Cargado/a Con Exito";
        }
        public static string SureSelectMessage(string value)
        {
            return $"Asegúrese de seleccionar un/a {value}.";
        }
        public static string SureSelectCampsMessage()
        {
            return $"Asegúrese de Completar Todos Los Campos.";
        }

    }
}
