using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public class Ingresante
    {
        private string[] _cursos;
        private string _direccion;
        private int _edad;
        private string _genero;
        private string _nombre;
        private string _pais;

        public Ingresante(string[] cursos, string direccion, int edad, string genero, string nombre, string pais)
        {
            _cursos = cursos;
            _direccion = direccion;
            _edad = edad;
            _genero = genero;
            _nombre = nombre;
            _pais = pais;
        }

        public string mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre : {_nombre}");
            sb.AppendLine($"Direccion : {_direccion}");
            sb.AppendLine($"Edad : {_edad}");
            sb.AppendLine($"Genero : {_genero}");
            sb.AppendLine($"Pais : {_pais}");
            sb.AppendLine($"\nCurso/s :");
            if (_cursos != null && _cursos.Length > 0)
            {
                foreach (string curso in _cursos)
                {
                    sb.AppendLine($"{curso}");
                }
            }
            else sb.Append("-");

                return sb.ToString();
        }
    }
}
