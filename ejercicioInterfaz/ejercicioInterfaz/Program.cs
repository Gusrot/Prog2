using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioInterfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            Deportivo dep1 = new Deportivo(12000, "aaa", 300);
            Comercial com1 = new Comercial(20000, 900);

            Console.WriteLine(((IAFIP)dep1).CalcularImpuesto());

        }
    }
}
