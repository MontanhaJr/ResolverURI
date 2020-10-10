using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolverURI
{
    class Fase_URI2663
    {
        static void Main(string[] args)
        {

            var entrada = int.Parse(Console.ReadLine());
            int maior = 0;

            //ArrayList fraseCompleta = new ArrayList();
            ArrayList palavras = new ArrayList();
            string[] fraseCompleta = new string[entrada-1];

            for (var i=0; i<entrada; i++)
            {
                string frases = Console.ReadLine();
                string[] vetor;

                vetor = frases.Split(' ');

                for(var j=0; j<vetor.Length; j++)
                {
                    if (!vetor[j].Equals(""))
                    {
                        palavras.Add(vetor[j]);
                    }
                }

                int contador = 0;
                string frase = "";
                for (var j=0; j<palavras.Count; j++)
                {
                    contador += palavras[j].ToString().Length;
                    
                    if (j == 0)
                        frase = (palavras[0].ToString());
                    else
                        frase = (frase + " " + palavras[j]);
                }
                fraseCompleta[i] = (frase);

                if (contador > maior)
                {
                    maior = contador;
                }
            }

            foreach(var item in fraseCompleta)
            Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
