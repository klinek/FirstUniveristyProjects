using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumawierszy = 0;
            int sumakolumn = 0;
            int sumaprzekontnych = 0;
            int wiersze;
            Console.WriteLine("podaj ilosc wierszy");
            wiersze = Convert.ToInt32(Console.ReadLine());

            int kolumny;
            Console.WriteLine("podaj ilosc kolumn");
            kolumny = Convert.ToInt32(Console.ReadLine());

            int[,] tablica = new int[wiersze, kolumny];

            Random random = new Random();

            for (int i = 0; i < wiersze; i++)
            {
                for (int j = 0; j < kolumny; j++)
                {

                    tablica[i, j] = random.Next(0, 100);
                }
            }

            for (int i = 0; i < wiersze; i++)
            {
                for (int j = 0; j < kolumny; j++)
                {
                    Console.Write(tablica[i, j]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
            for(int m = 0 ; m < wiersze; m++)
            {
                Console.Write("suma wiersza nr ");
                Console.Write(m+1);
                Console.Write(" :");
                for(int n = 0; n < kolumny; n++ )
                {
                    sumawierszy = sumawierszy + tablica[m, n];

                }
                Console.WriteLine(sumawierszy);
                sumawierszy = 0;
            }
            Console.WriteLine();
            for (int m = 0; m < kolumny; m++)
            {
                Console.Write("suma kolumny nr ");
                Console.Write(m+1);
                Console.Write(" :");
                for (int n = 0; n < wiersze; n++)
                {
                    sumakolumn = sumakolumn + tablica[n, m];

                }
                Console.WriteLine(sumakolumn);
                sumakolumn = 0;
            }
            for (int n = 0; n < wiersze; n++)
            {
                sumaprzekontnych = sumaprzekontnych + tablica[n, n];

            }
            Console.Write("suma przekontnej prawej gornej ");
            Console.WriteLine(sumaprzekontnych);
            sumaprzekontnych = 0;
            for (int n = wiersze-1; n > 0; n--)
            {
                sumaprzekontnych = sumaprzekontnych + tablica[n, n];

            }
            Console.Write("suma przekontnej lewej gornej ");
            Console.WriteLine(sumaprzekontnych);
            sumaprzekontnych = 0;
            Console.ReadLine();
        }
    }
}
