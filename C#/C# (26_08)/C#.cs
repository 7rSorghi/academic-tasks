 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C___26_08_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 3ºBimestre
             * - ARRAYS (Vetores)
             * - MÉTODOS DE ORDENAÇÃO (Bubble, Insertion, Selection)
             * - MÉTODOS DE PESQUISA (Sequencial, Binário - Ordenado)
             */

            /*
             * int[] num;
             * num = new int[10];
             */

            //           0  1  2  3  4  5  6  7  8  9
            int[] num = {6, 1, 9, 0, 5, 4, 7, 2, 3, 8};
            int search = 2;
            /*
            for (int i = 0; i < num.Length; i++) 
            {
                if (num[i] == pesq)
                {
                    Console.WriteLine($"O número {pesq} foi encontrado");
                    break;
                }
                else
                {
                    Console.WriteLine($"O número {pesq} não foi encontrado");
                }
            }
            */
            bool find = false;
            int ct = 0; 
            while (ct < num.Length && find == false)
            {
                if (search == num[ct])
                {
                    find = true;
                }
                ct++;
            }
            if (find == true)
            {
                Console.WriteLine($"O número {search} foi encontrado na posição {ct}, com o índice {ct - 1}");
            }
            else {
                Console.WriteLine($"O número {search} não foi encontrado");
            }

        }
    }
}
