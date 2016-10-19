using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Producto
    {
        public int codigo;
        public string descripcion;
        public float precioDeVenta;

        public override string ToString()
        {
 	        StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.codigo.ToString());
            sb.AppendLine(this.descripcion);
            sb.AppendLine(this.precioDeVenta.ToString());

            return sb.ToString();
        }

        public static bool operator ==(Producto prod1, Producto prod2)
        {
            if (prod1.codigo == prod2.codigo)
                return true;
            return false;
        }

        public static bool operator !=(Producto prod1, Producto prod2)
        {
            return !(prod1 == prod2);
        }

        public override bool Equals(object obj)
        {
            try
            {
                if (this == obj)
                {
                    return true;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No seas pelotudo");
            }
            return false;
            
        }
    }
}
