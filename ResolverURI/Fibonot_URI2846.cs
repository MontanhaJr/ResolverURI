using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolverURI
{
    class Fibonot_URI2846
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());
            bool continuar = true;
            List<int> fibonacci = new List<int>();
            List<int> fibonot = new List<int>();
            int i = 2;
            int contador = 0;

            fibonacci.Add(1);
            fibonacci.Add(2);
            Console.Write(fibonacci[0] + " ");
            Console.Write(fibonacci[1] + " ");



            while (continuar)
            {
                fibonacci.Insert(i, fibonacci[i - 1] + fibonacci[i - 2]);
                Console.Write(fibonacci[i] + " ");

                if ((fibonacci[i - 1] - fibonacci[i - 2]) > 1)
                {
                    contador += (fibonacci[i - 1] - fibonacci[i - 2]);
                }

                i++;

                if (contador >= K)
                {
                    continuar = false;
                }
                
            }

            for(var j = 0; j <= contador; j++)
            {
                fibonot.Add(j);
            }

            for (var j = 0; j < fibonot.Count; j++)
            {
                if (fibonacci.Contains(fibonot[j]))
                {
                    fibonot.Remove(fibonot[j]);
                }
            }
            

            Console.WriteLine(fibonot);

            Console.WriteLine(fibonot[K]);

            Console.ReadKey();
        }
    }
}
