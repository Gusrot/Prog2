using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Deposito<T>
    {
        public List<T> listaDeProducto;
        public int cantidadMaxima;

        public Deposito(int cantidad)
        {
            this.listaDeProducto = new List<T>();
            this.cantidadMaxima = cantidad;
        }

        public bool NoHayLugar()
        {
            return this.cantidadMaxima == this.listaDeProducto.Count;
        }

        public bool ExisteElemento(T item)
        {
            foreach (T algo in this.listaDeProducto)
            {
                if (algo.Equals(item))
                    return true;
            }

            return false;
        }

        public bool Agregar(T item)
        {
            return this + item;
        }

        public static bool operator +(Deposito<T> dep, T prod)
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
