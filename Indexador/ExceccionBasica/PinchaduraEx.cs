using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceccionBasica
{
    public class PinchaduraEx:MiExcepcion
    {
        public string marca;
        

        public PinchaduraEx(string marcaRueda,DateTime hora,string horaex)
            : base(hora, horaex)
        {
            this.marca = marcaRueda;
            throw new MiExcepcion(hora, horaex);
        }
         /*public PinchaduraEx(string marcaRueda,DateTime hora,string horaex,MiExcepcion x)
            : base(x,hora, horaex)
        {
             this.marca = marcaRueda;
         }*/
    }
}
