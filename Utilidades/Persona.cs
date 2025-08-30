using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    /*Crear una aplicación de consola y una biblioteca de clases que contenga la clase Persona.

Deberá tener los atributos:

nombre
fechaDeNacimiento
dni
Deberá tener un constructor que inicialice todos los atributos.

Construir los siguientes métodos para la clase:

Setter y getter para cada uno de los atributos.
CalcularEdad será privado y retornará la edad de la persona calculándola
    a partir de la fecha de nacimiento.
Mostrar retornará una cadena de texto con todos los datos de la persona,
    incluyendo la edad actual.
EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad",
    sino devuelve “es menor”.
Instanciar 3 objetos de tipo Persona en el método Main.
Mostrar quiénes son mayores de edad y quiénes no.*/
    public class Persona
    {
        public string nombre;
        public DateTime fechaDeNacimiento;
        public int dni;
        public Persona(string nombre, DateTime fechaDeNacimiento, int dni) {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        public void SettNombre(string nuevoNombre)
        {
            this.nombre = nuevoNombre;
        }
        public void SettFechaDeNacimiento(DateTime nuevaFecha)
        {
            this.fechaDeNacimiento = nuevaFecha;
        }
        public void SettDni(int nuevoDni)
        {
            this.dni = nuevoDni;
        }
    }
}
