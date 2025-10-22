using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades_8
{
    public class Libro
    {
        private List<string> _paginas;

        public Libro()
        {
            _paginas = new();
        }

        public string this[int index]
        {
            get
            {
                if(_paginas.Count > 0 && (index <= _paginas.Count))
                {
                    return _paginas[index - 1];
                }
                return "Pagina No Encontrada";
            }

            set
            {
                if(index <= _paginas.Count)
                {
                    _paginas[index-1] = value;
                }else if (index > _paginas.Count)
                {
                    _paginas.Add(value);
                }
            }

        }
    }
}
