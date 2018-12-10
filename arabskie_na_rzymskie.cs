using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rok;
            int jednosci;
            int dziesiatki;
            int setki;
            int tysiace;
            Console.WriteLine("podaj liczbe");
            if (Int32.TryParse(Console.ReadLine(), out rok) == true)
            {
                tysiace = rok % 10000 - rok % 1000;
                switch (tysiace)
                {
                    case 1000: Console.Write("M"); break;
                    case 2000: Console.Write("MM"); break;
                    case 3000: Console.Write("MMM"); break;
                    case 4000: Console.Write("Mↁ"); break;
                    case 5000: Console.Write("ↁ"); break;
                    case 6000: Console.Write("ↁM"); break;
                    case 7000: Console.Write("ↁMM"); break;
                    case 8000: Console.Write("ↁMMM"); break;
                    case 9000: Console.Write("Mↂ"); break;
                }
                setki = rok % 1000 - rok % 100;
                switch (setki)
                {
                    case 100: Console.Write("C"); break;
                    case 200: Console.Write("CC"); break;
                    case 300: Console.Write("CCC"); break;
                    case 400: Console.Write("CD"); break;
                    case 500: Console.Write("D"); break;
                    case 600: Console.Write("DC"); break;
                    case 700: Console.Write("DCC"); break;
                    case 800: Console.Write("DCCC"); break;
                    case 900: Console.Write("CM"); break;
                }
                dziesiatki = rok % 100 - rok % 10;
                switch (dziesiatki)
                {
                    case 10: Console.Write("X"); break;
                    case 20: Console.Write("XX"); break;
                    case 30: Console.Write("XXX"); break;
                    case 40: Console.Write("XL"); break;
                    case 50: Console.Write("L"); break;
                    case 60: Console.Write("LX"); break;
                    case 70: Console.Write("LXX"); break;
                    case 80: Console.Write("LXXX"); break;
                    case 90: Console.Write("XC"); break;
                }
                jednosci = rok % 10;
                switch (jednosci)
                {
                    case 1: Console.Write("I"); break;
                    case 2: Console.Write("II"); break;
                    case 3: Console.Write("III"); break;
                    case 4: Console.Write("IV"); break;
                    case 5: Console.Write("V"); break;
                    case 6: Console.Write("VI"); break;
                    case 7: Console.Write("VII"); break;
                    case 8: Console.Write("VIII"); break;
                    case 9: Console.Write("IX"); break;
                }
             
            
            
            }
            else Console.WriteLine("to nie jest liczba");


                Console.ReadKey();
            }
        }
    }

