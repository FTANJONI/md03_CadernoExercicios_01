using System;

namespace md03_CadernoExercicios_01
{
    class Program
    {
        /*
         1. Construa um algoritmo que receba como entrada três valores e os imprima em
        ordem crescente.

         */
        static void Main(string[] args)
        {
            int v1, v2, v3, aux;
            Console.WriteLine("\nDigite o primeiro valor:");
            v1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nDigite o segundo valor:");
            v2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nDigite o terceiro valor:");
            v3 = Convert.ToInt32(Console.ReadLine());
            //  123, 132, 213,231,312;321
            if (v1 > v2)
            {   //321
                aux = v1;
                v1 = v2;
                v2 = aux;
                //231
            }
            if (v1 > v3)
            {   //231
                aux = v1;
                v1 = v3;
                v3 = aux;
                //132
            }
            if (v2 > v3)
            {   //132
                aux = v2;
                v2 = v3;
                v3 = aux;
                //123
            }
            Console.WriteLine("Ordem Crescente " + v1.ToString() + v2.ToString() + v3.ToString());
        }
    }
}
