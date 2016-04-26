using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sortowanie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void sortTest()
        {
            int[] arr = { 14, 7, 3, 12, 9, 11, 6, 2 };
            int[] sorted = { 2, 3, 6, 7, 9, 11, 12, 14 };

            Program.sort(ref arr);

            for (int i = 0; i < arr.Count(); i++)
            {
                Assert.AreEqual(arr, sorted);
            }
        }

        [TestMethod()]
        public void divideTest()
        {
            int[] arr = { 14, 7, 3, 12, 9, 11, 6, 2 };
            int[] divided = { 14, 7, 3, 12, 9, 11, 6, 2 };

            int[][] output = Program.divide(arr);

            for(int i = 0; i < arr.Count(); i++)
            {
                Assert.AreEqual(arr[i], output[i][0]);
            }
        }
    }
}