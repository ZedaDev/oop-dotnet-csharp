using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal interface IRepository<T> 
    {
        public  List<T> List{get;}
        public  T Add {set; }
        public  T Delete{set;}
        public  T MyAtleta  {get; set;}
        public  int INDEX {get; set;}

    }
}
