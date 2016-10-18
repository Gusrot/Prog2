using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceccionBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrera miCarrera = new Carrera("chingolo");
            Auto CAR = new Auto("Zorro", 1);
            Auto Car2 = new Auto("Zorro",12);
            Auto car3 = new Auto("Zorro",13);
            Auto car4 = new Auto("Zorro", 1);
            for (int i = 0; i < 4; i++)
            {
                CAR.michetti.Add(new Rueda("ruedita"));
            }
            for (int i = 0; i < 4; i++)
            {
                Car2.michetti.Add(new Rueda("ruedita"));
            }
            for (int i = 0; i < 4; i++)
            {
                car3.michetti.Add(new Rueda("ruedita"));
            }
            for (int i = 0; i < 4; i++)
            {
                car4.michetti.Add(new Rueda("ruedita"));
                
            }
            
            miCarrera.misAutos.Add(CAR);
            miCarrera.misAutos.Add(Car2);
            miCarrera.misAutos.Add(car3);
            miCarrera.misAutos.Add(car4);
            /*miCarrera.correrCarrera();   */                    
            //CAR.Andar();
            //car4.michetti[2].rodar();



            try
            {
                miCarrera.correrCarrera();
                /*lanzarError();
                operar();*/

            }
            catch (PinchaduraEx x)
            {
                Console.Write(x.Message);

            }
            catch (AutoEx x)
            {
                Console.Write(x.Message);

            }
            catch (MiExcepcion x)
            {
                Console.Write(x.Message);

            }
            catch (Exception x)
            {
                Console.Write(x.Message);
            }
            /*finally
            {
                Console.WriteLine(" El gato estuvo aqui");
            }*/
            Console.ReadKey();
        }

        /*public static void operar()
        {
          

            try
            {
                string dato;
                int numero;

                dato = Console.ReadLine();
                numero = int.Parse(dato);
                numero = numero / numero;
            }
            catch (Exception x)
            {
                //operaciones para guardar informacion de la exception
                throw new Exception("Se quedo sin internet");
                
            }
           
        }
        public static void lanzarError()
        {
            throw new Exception("No tenes ram");
        }*/
    }
}
