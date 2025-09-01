using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;
        #region CONSIGNA
        /*La clase Estudiante:

Tendrá un constructor estático que inicializará el atributo estático random.
Tendrá un constructor de instancia que inicializará los atributos nombre, apellido y legajo.

-El método setter SetNotaPrimerParcial permitirá cambiar el valor del atributo notaPrimerParcial.

-El método setter SetNotaSegundoParcial permitirá cambiar el valor del atributo notaSegundoParcial.

-El método privado CalcularPromedio retornará el promedio de las dos notas.

-El método CalcularNotaFinal deberá retornar la nota del final con un numero
 aleatorio entre 6 y 10 incluidos siempre y cuando las notas del primer y segundo parcial
  sean mayores o iguales a 4, caso contrario la inicializará con el valor -1.

-El método Mostrar utilizará StringBuilder para armar una cadena de texto
 con todos los datos de los alumnos:
Nombre, apellido y legajo.
Nota del primer y segundo parcial.
Promedio.
Nota final. Se mostrará sólo si el valor es distinto de -1, caso contrario se mostrará la leyenda "Alumno desaprobado".
Crear tres instancias de la clase Estudiante (tres objetos) en el método Main.
Cargar las notas del primer y segundo parcial a todos los alumnos. Dos deberán estar aprobados y uno desaprobado.
Mostrar los datos de todos los alumnos.
Importante
Para darle un valor aleatorio a la nota final utilice el método de instancia Next de la clase Random.*/
        #endregion
        public Estudiante(string apellido, string nombre, string legajo)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
            this.notaPrimerParcial = -1;
            this.notaSegundoParcial = -1;
        }

        static Estudiante()
        {
            random = new Random();
        }

        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }
        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }

        private int CalcularPromedio(int nota, int nota1)
        {
            return (nota + nota1) / 2;
        }

        public int CalcularNotaFinal()
        {
            int nota = -1;
            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4) nota = random.Next(6, 11);
                return nota;
        }

        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine($"Nombre : {nombre}");
            datos.AppendLine($"Apelldio : {apellido}");
            datos.AppendLine($"Legajo : {legajo}");
            datos.AppendLine($"Nota Primer Parcial : {notaPrimerParcial}");
            datos.AppendLine($"Nota Segundo Parcial : {notaSegundoParcial}");
            int promedio = CalcularPromedio(notaPrimerParcial, notaSegundoParcial);
            datos.AppendLine($"Promedio : {promedio}");
            if (promedio >= 4) datos.AppendLine($"Final : {CalcularNotaFinal()}");
            else datos.AppendLine("Alumno Desaprobado");

            return datos.ToString();
        }
    }
}
