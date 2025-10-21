using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades_8
{
    public class Negocio
    {

        private Puesto _caja;
        private Queue<Cliente> _clientes;
        private string _name;

        public Negocio(string name)
            : this()
        {
            _name = name;
        }
        private Negocio()
        {
            _caja = Puesto.Caja1;
            _clientes = new();
        }

        public Cliente NextClient
        {
            get
            {
                if (_clientes.Count > 0 && _clientes.TryPeek(out Cliente cliente))
                {
                    return cliente;
                }
                return null;
            }
            set {
                if (TryAddClientToQueue(value))
                {
                    Console.WriteLine($"\n=== Cliente Nuevo Agregado {value.Name} ===");
                } else Console.WriteLine("\n=== Cliente Existente ===");
            }
        }

        public int PendientClients
        {
            get { return _clientes.Count; }
        }

        public static bool operator +(Negocio n, Cliente cliente)
        {

            bool result = n == cliente;
            if (!result)
                n._clientes.Enqueue(cliente);

            return !result;
        }

        public static bool operator ==(Negocio n, Cliente cliente)
        {
            bool result = false;
            if (n._clientes.Count > 0)
            {
                foreach (Cliente c in n._clientes)
                {
                    if (c == cliente)
                    {
                        result = true;
                    }
                }

            }

            return result;
        }
        public static bool operator !=(Negocio n, Cliente cliente)
        {

            return !(n == cliente);
        }

        private bool TryAddClientToQueue(Cliente value)
        {
            if (!(this == value))
            {
                _clientes.Enqueue(value);
                return true;
            }

            return false;
        }

        /*El operador ~ generará una atención del próximo cliente en la cola,
         * utilizando la propiedad Cliente 
         * y el método Atender de PuestoAtencion. 
         * Retornará true si pudo realizar la operación completa.*/

        public static bool operator ~(Negocio n)
        {
            return n.AttendClient(n);
        }

        private bool AttendClient(Negocio n)
        {
           PuestoAtencion p = new(n._caja);
            if (n.PendientClients > 0)
            {
                if (p.Atender(n.NextClient))
                    n._clientes.Dequeue();

                return true;
            }

            return false;
        }
    }
}
