using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excep
{
    public class MiEx:Exception
    {
        public string text;

        public MiEx()
        {
            new Exception("jorge");
        }
        public MiEx(string text):this()
        {
            this.text = text;
        }
    }
}
