using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excep
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex1 uno = new Ex1();
            try
            {
                uno.algo();
            }
            catch (Exception x)
            {
                Console.Write(x.Message);
                Console.ReadKey();
                
            }
        }
        /*public static void algo()
        {
            throw new Exception("error");
        }
        public void algo2()
        {
            try
            {
                Program.algo();
            }
            catch (Exception x)
            {
                
                throw ;
            }
        }*/

    }
}
