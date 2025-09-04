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
             * - FUNÇÕES DE MANIPULAÇÃO DE STRINGS
             * - ARRAYS (Matrizes)
             */
            string word = " program ";

            Console.WriteLine(word.Length);
            

            Console.WriteLine(word.ToUpper());
            

            Console.WriteLine(word.ToLower());
            

            Console.WriteLine(word.Substring(2, 2));
            
            
            Console.WriteLine(word.Contains("program"));
            

            Console.WriteLine(word.IndexOf("a"));

            Console.WriteLine(word.LastIndexOf("a"));

            Console.WriteLine(word.Remove(2, 2));

            Console.WriteLine(word.Insert(2, "aa"));

            Console.WriteLine(word.TrimEnd());

            Console.WriteLine(word.IsNullOrEmpty(word));






            Console.ReadKey();


        }
    }
}
