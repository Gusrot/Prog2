using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public class PC
    {
        public string marca;
        public string SO;
        public static int ContadorPC;
        public int Numero;

       static PC()
       {
            ContadorPC = 1;
       }       
       public PC(string marca)
       {
            this.marca = marca;
            this.Numero = ContadorPC;
            ContadorPC++;
            this.SO = "Windows";

           
       }
        public static implicit operator PC(string marca)
        {
            return new PC(marca);
        }
    }
}
