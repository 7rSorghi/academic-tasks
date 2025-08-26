using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double soma, angulo1, angulo2;
            Console.Write("Digite o primeiro ângulo: ");
            angulo1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo ângulo: ");
            angulo2 = double.Parse(Console.ReadLine());

            soma = angulo1 + angulo2;

            if (soma == 90)
            {
                Console.WriteLine("Os ângulos são complementares.");
            }
            else if (soma == 180)
            {
                Console.WriteLine("Os ângulos são suplementares.");
            }
            else
            {
                Console.WriteLine("Os ângulos não são nem complementares nem suplementares.");
            }
        }
    }
}
