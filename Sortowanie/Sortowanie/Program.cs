using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie
{
    public class Program
    {
        /// <summary>
        /// metoda dzielaca tabele na elementy
        /// </summary>
        /// <param name="tab">tablica ktora sie dzieli</param>
        /// <returns>elementy tabeli</returns>
        public static int[][] divide(int[] tab)
        {
            int[][] output = new int[tab.Count()][];
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            int[][] leftTab;
            int[][] rightTab;

            for(int i = 0; i < tab.Count(); i++)
            {
                if (i < (int)(tab.Count() / 2.0))
                {
                    left.Add(tab[i]);
                }
                else
                {
                    right.Add(tab[i]);
                }
            }

            if (left.Count > 1)
            {
                leftTab = divide(left.ToArray());
            }
            else
            {
                leftTab = new int[1][];
                leftTab[0] = left.ToArray();
            }

            if (right.Count > 1)
            {
                rightTab = divide(right.ToArray());
            }
            else
            {
                rightTab = new int[1][];
                rightTab[0] = right.ToArray();
            }

            for (int i = 0; i < tab.Count(); i++) 
            {
                output[i] = new int[1];
                output[i][0] = tab[i];
            }

            return output;
        }

        /// <summary>
        /// polaczenie elementow tabeli w uporzadkowana tabele
        /// </summary>
        /// <param name="tab">elementy tabeli</param>
        /// <returns>postrtowana tabela</returns>
        public static int[] merge(int[][] tab)
        {
            List<int> buffor = new List<int>();
            int min = 1000;
            int last = 0;

            for (int p = 0; p < tab.Count(); p++) 
            {
                for (int i = 0; i < tab.Count(); i++)
                {
                    if (tab[i][0] < min && tab[i][0] > last) min = tab[i][0];
                }
                buffor.Add(min);
                last = min;
                min = 1000;
            }

            return buffor.ToArray();
        }

        /// <summary>
        /// sortowanie elementow
        /// </summary>
        /// <param name="tab">tabela ktora nalezy posortowac</param>
        public static void sort(ref int[] tab)
        {
            int[][] buffor = divide(tab);
            tab = merge(buffor);
        }

        /// <summary>
        /// glowna metoda w ktorej wywolywane jest sortowanie
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            int[] arr = { 14, 7, 3, 12, 9, 11, 6, 2 };
            int[] sorted = { 2, 3, 6, 7, 9, 11, 12, 14 };

            Program.sort(ref arr);
        }
    }
}
