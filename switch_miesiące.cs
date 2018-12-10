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
            int num;
            Console.WriteLine("podaj liczbe");
            if (Int32.TryParse(Console.ReadLine(), out num) == true)
                switch (num)
                {
                    case 1: Console.WriteLine("styczen"); break;
                    case 2: Console.WriteLine("luty"); break;
                    case 3: Console.WriteLine("marzec"); break;
                    case 4: Console.WriteLine("kwiecien"); break;
                    case 5: Console.WriteLine("maj"); break;
                    case 6: Console.WriteLine("czerwiec"); break;
                    case 7: Console.WriteLine("lipiec"); break;
                    case 8: Console.WriteLine("sierpien"); break;
                    case 9: Console.WriteLine("wrzesien"); break;
                    case 10: Console.WriteLine("pazdziernik"); break;
                    case 11: Console.WriteLine("listopad"); break;
                    case 12: Console.WriteLine("grudzien"); break;
                    default: Console.WriteLine("to nie jest miesiac"); break;
                }
            else Console.WriteLine("to nie jest liczba");
            
                    Console.ReadKey();
        }
    }
}
