using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceccionBasica
{
    public class MiExcepcion:Exception
    {
        public Exception ex;
        public DateTime horaDeLaEx;
        public string horaDeLaExTexto;

        public MiExcepcion(DateTime hora,string texto):base(texto)
        {
            this.horaDeLaEx = hora;
            this.horaDeLaExTexto = texto;

        }
        public MiExcepcion(Exception x, DateTime hora, string horatex):this(hora,horatex)                   
        {
            this.ex = x.InnerException;
        }

    }
}
