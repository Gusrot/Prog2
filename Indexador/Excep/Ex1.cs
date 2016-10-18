using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excep
{
    public class Ex1:MiEx
    {
       

        public void algo()
        {
            try
            {
                new MiEx("Jorge");
            }
            catch (Exception x)
            {
                
                throw x;
            }
        }
    }
}
