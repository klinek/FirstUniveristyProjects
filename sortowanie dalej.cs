using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
        int ilosc;
        int zakres = 100;
        int zapas;

        }
        public void losowanie(ref int[,] tab1,  int ilosc1)
        {
            Console.WriteLine("podaj ile chcesz losowac");
            ilosc1 = Convert.ToInt32(Console.ReadLine());
            int[,] tablos = new int[6, 100];
            //losowanie
            Random random = new Random();
            for (int k = 0; k < ilosc1; k++)
            {
                for (int i = 0; i <= 5; i++)
                {
                    tab1[i, k] = random.Next(0, 100);

                    for (int j = 0; j < i; j++)
                    {
                        if (tab1[j, k] == tab1[i, k])
                        {
                            i--;
                        }


                    }

                }
            }
        }
        public void sortowanie(int[,] tab2 ,int zapas2)
        {
            
            for (int l = 0; l < ilosc; l++)
            {
                for (int i = 0; i <= 5; i++)
                {

                    for (int j = 0; j < 5; j++)
                    {
                        if (tablos[j, l] > tablos[j + 1, l])
                        {
                            zapas = tablos[j, l];
                            tablos[j, l] = tablos[j + 1, l];
                            tablos[j + 1, l] = zapas;

                        }
                    }
                }
            }
        }

        public void wypisywanie()
        {
            for (int l = 0; l < ilosc; l++)
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.Write(tablos[i, l] + " , \t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
