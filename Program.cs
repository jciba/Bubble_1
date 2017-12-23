using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] tab = new int[10];
            int i,j;
            for (i = 0; i <tab.Length; i++)
            {
                tab[i] = rnd.Next(1, 100);
                Console.WriteLine(tab[i]);
            }
            for(i=0; i < tab.Length; i++)
            {
                for (j = 0; j < tab.Length-1; j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        tab[j] = tab[j] + tab[j + 1];
                        tab[j + 1] = tab[j] - tab[j+1];
                        tab[j] = tab[j] - tab[j + 1];
                    }
                }               
            }
            for (i = 0; i < tab.Length; i++)
            {                
                Console.WriteLine(tab[i]);
            }

            Console.ReadKey();
        }
    }
}
