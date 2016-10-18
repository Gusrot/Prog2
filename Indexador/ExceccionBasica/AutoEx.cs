using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceccionBasica
{
    public class AutoEx:MiExcepcion
    {
        public Auto car;
        

        public AutoEx(Auto auto, DateTime hora, string texto)
            : base(hora, texto)
        {
            this.car = auto;
           
        }
        /*public AutoEx(Auto auto, DateTime hora, string texto)
            : base(hora, texto)
        {
            this.car = auto;
        }*/
    }
}
