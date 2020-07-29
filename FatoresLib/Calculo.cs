using System.Collections.Generic;

namespace FatoresLib.Interfaces
{
    public class Calculo : ICalculos
    {
        public bool EhPrimo(int numero)
        {
            bool boolPrimo = true;
            int fator = numero / 2;
            int i = 0;
            for (i = 2; i <= fator; i++)
            {
                if ((numero % i) == 0)
                    boolPrimo = false;
           }
            return boolPrimo;
        }

        public List<int> RetornaFatores(int numero, List<int> fatores)
        {
            int contador = 0;
            int[] vetor = new int[int.MaxValue];

            int i = 0;
            int indice = 0;
            for (i = 2; i <= numero; i++)
            {
                if (EhPrimo(i) == true)
                    vetor[contador++] = i;
            }
            while (true)
            {
                if (EhPrimo(numero) == true)
                {
                    fatores[indice++] = numero;
                    break;
                }
                for (i = contador - 1; i >= 0; i--)
                {
                    if ((numero % vetor[i]) == 0)
                    {
                        fatores[indice++] = vetor[i];
                        numero = numero / vetor[i];
                        break;
                    }
               }
            }
            return fatores;
        }
    }
}