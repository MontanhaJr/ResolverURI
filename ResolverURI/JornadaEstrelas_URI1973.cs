using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolverURI
{
    class JornadaEstrelas_URI1973
    {
        static void Main(string[] args)
        {
            var estrelas = int.Parse(Console.ReadLine());
            var carneirosTot = Console.ReadLine();
            int[] pontos = new int[estrelas+1];

            pontos = Array.ConvertAll(carneirosTot.Split(' '), s => int.Parse(s));

            int i = 0;
            int estVisit = 1;
            bool encontrouPar = false;

            do
            {
                if (i >= 8)
                {
                    break;
                }
                else
                {
                    if (pontos[i] % 2 != 0)
                    {
                        estVisit++;
                        pontos[i] -= 1;
                        i++;
                    }
                    else if (pontos[i] % 2 == 0)
                    {
                        encontrouPar = true;
                        if (pontos[i] == 0)
                        {
                            break;
                        }
                        else
                        {
                            pontos[i] -= 1;
                            i--;
                        }
                    }
                }
            } while (i < estrelas);

            if (encontrouPar == false)
            {
                estVisit--;
            }

            int contador = 0;
            foreach (var item in pontos)
            {
                contador += item;
            }

            Console.WriteLine(estVisit+" "+contador);


            Console.ReadKey();
        }
    }
}
