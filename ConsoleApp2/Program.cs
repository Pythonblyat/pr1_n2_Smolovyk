using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Smolovyk Daniil");
            int a;
            int x, y;
            Console.WriteLine("Введiть кількість хвилин:");      
            a = int.Parse(Console.ReadLine());
            x = a / 60;

            y = a - (x * 60);
            Console.WriteLine(x + "годин:" + y + "хвилин" );

        }   
    }
}
