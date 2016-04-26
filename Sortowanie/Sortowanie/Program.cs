using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie
{
    public class Program
    {
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

        public static void sort(ref int[] tab)
        {

        }

        public static void Main(string[] args)
        {

        }
    }
}
