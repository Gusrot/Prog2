using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MisClases;
using System.Threading.Tasks;

namespace Indexador
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*PC pc1 = new PC("PCBOX");
            PC pc2 = new PC("JORGEBOX");
            PC pc3 = new PC("SORNI");*/

            PC pc1 = "LG";
            PC pc2 = "PCBOX";
            PC pc3 = "ASUS";

            Laboratorio labo = new Laboratorio("Laboratorio");

            labo[0] = pc1;
            labo[1] = pc2;
            


            /*foreach (PC item in Laboratorio.miLab)
            {
                Console.WriteLine(item.marca);
            }         
                        
            foreach (PC item in Laboratorio.miLab)
            {
                Console.WriteLine(item.marca);
            }*/

            for (int i = 0; i < labo.miLab.Count; i++)
            {
                Console.WriteLine(labo.miLab[i].marca);
                Console.WriteLine(labo.miLab[i].SO);
                Console.WriteLine(labo.miLab[i].Numero);
            }

            labo[2] = pc3;
            for (int i = 3; i < 10; i++)
            {
                
                PC pcaux = "Ejemplo";
                labo[i] = pcaux;
            }

            for (int i = 0; i < labo.miLab.Count; i++)
            {
                Console.WriteLine(labo.miLab[i].marca);
                Console.WriteLine(labo.miLab[i].SO);
                Console.WriteLine(labo.miLab[i].Numero);
            }

            Console.ReadKey();

        }
    }
}
