using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class DepositoDePintura
    {
        public List<Producto> listaDeProducto;
        public int cantidadMaxima;

        public DepositoDePintura(int cantidad)
        {
            this.listaDeProducto = new List<Producto>();
            this.cantidadMaxima = cantidad;
        }

        public bool NoHayLugar()
        {
            return this.cantidadMaxima == this.listaDeProducto.Count;
        }

        public bool ExisteElemento(Producto prod)
        {
            foreach (Producto item in this.listaDeProducto)
            {
                if (item == prod)
                    return true;
            }

            return false;
        }

        public bool Agregar(Producto prod)
        {
            return this + prod;
        }

        public static bool operator +(DepositoDePintura dep, Producto prod)
        {
            if (!dep.ExisteElemento(prod) && !dep.NoHayLugar())
            {
                dep.listaDeProducto.Add(prod);
                return true;
            }
            return false;
        }
    }
}
