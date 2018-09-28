using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace E_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lares Dominguez Brandon - 17211532
            Console.WriteLine("Ejercicio 2.1");
            For factofor = new For();
            factofor.Desplegar();
            Console.ReadLine();
            Console.WriteLine("Factorial utilizando Pseudocodigo");
            Console.Write("Introduzca algun numero: ");
            int x = Convert.ToInt16(Console.ReadLine());
            Pseudo pseudo = new Pseudo(x);
            pseudo.Desplegar();
            Console.ReadKey();
        }
        public class For
        {
            public int Resu = 0, x = 1;
            public For()
            {
                Resu = 0;
            }
            public int Proce()
            {
                for (int i = 1; i < 7; i++)
                {
                    x = x * i;
                }
                return x;
            }
            public void Desplegar()
            {
                Console.WriteLine("Factorial utilizando for");
                Console.WriteLine("El factorial de 6 es: {0}", Proce());
                Stopwatch Tiempo = new Stopwatch();
                Tiempo.Start();
                Tiempo.Stop();
                Console.WriteLine("El tiempo de ejecucion es de: {0}", Tiempo.Elapsed.TotalMilliseconds.ToString());
            }
        }
        public class Pseudo
        {
            public int y;
            public Pseudo(int x)
            {
                y = x;
            }
            public int Proce(int a)
            {
                if (a == 0)
                {
                    return 1;
                }
                else
                {
                    return a * Proce(a - 1);
                }
            }
            public void Desplegar()
            {
                Console.WriteLine("\nEl resultado es: {0}", Proce(y));
                Stopwatch Tiempo = new Stopwatch();
                Tiempo.Start();
                Tiempo.Stop();
                Console.WriteLine("El tiempo de ejecucion es de: {0}", Tiempo.Elapsed.TotalMilliseconds.ToString());
            }
        }
    }
}
