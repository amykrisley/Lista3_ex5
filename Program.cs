using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c = 1;

            do
            {
                Console.Write("Digite um valor positivo: ");
                b = int.Parse(Console.ReadLine());

            }
            while (b <= 0);

            for (; c <= 10; c++)
            {
                a = b * c;
                Console.WriteLine("{1} * {2} = {0}", a, b, c);
            }
        }
    }
}
