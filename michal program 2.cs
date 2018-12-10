using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        { 
            int rok;
            int jednosci;
            Console.Write("slowe");
            Console.Write("slowe2");
            Console.WriteLine("podaj liczbe");
            if (Int32.TryParse(Console.ReadLine(), out rok) == true)
            {
                jednosci = rok % 10;
                if(jednosci == 1)
                
            else Console.WriteLine("to nie jest liczba");

            
                    Console.ReadKey();
        }
    }
}
