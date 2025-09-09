using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{

    
    public class Conductor
    {

        private string name;
        private int[] kmsPorDia;

        public Conductor(string name)
        {
            this.name = name;
            this.kmsPorDia = new int[3];
        }

        public string GetName() => name;
        public int[] GetKmsDays() => this.kmsPorDia;
        public int GetKmsDays(int i) => this.kmsPorDia[i];
        public void SetDay(int i, int Kms) => this.kmsPorDia[i] = Kms;
        
    }
}
