using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Utilidades
{
    public static class ProgramaConductor
    {

        public static void CargarKmsPorDia(int[] dayWeek)
        {
            Random kms = new Random();
            for(int i = 0;i < dayWeek.Length; i++)
            {
                if (!ValidarFreeDay()) dayWeek[i] = kms.Next(0,100);
                else dayWeek[i] = 0;
            }
        }

        public static bool ValidarFreeDay()
        {
            Console.WriteLine("Dia De Franco Hoy? S/N");
            return Validador.ValidarRespuesta();
        }

        public static string DriverStats(Conductor[] conductores)
        {
            string nombre = "";
            int max = 0;
            foreach (Conductor conductor in conductores)
            {
                int total = VerMaxKms(conductor.GetKmsDays());
                if (total > max) {
                    max = total;
                    nombre = conductor.GetName();
                    
                 }
            }
            return $"\nConductor Con Mas Kms De Esta Semana : {nombre}\nKms Recorridos : {max}";
        }

        public static int VerMaxKms(int[] Conductor)
        {
            int suma = 0;

            foreach (int kms in Conductor)
                suma += kms;

            return suma;
        }

        public static string MaxKmdPorDia(Conductor[] conductores, int dia)
        {
            int kms = 0;
            int max = 0;
            string nombre = "";
           foreach(Conductor conductor in conductores)
            {
                kms = conductor.GetKmsDays(dia - 1);
                    if(kms > max)
                {
                    max = kms;
                    nombre = conductor.GetName(); 
                }
            }
                return $"Conductor con mas Kms Del Dia {dia} : {nombre} con {max} Kms Recorridos";
        }
    }
}
