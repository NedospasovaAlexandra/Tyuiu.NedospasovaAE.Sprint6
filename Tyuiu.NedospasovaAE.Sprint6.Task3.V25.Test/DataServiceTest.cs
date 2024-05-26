using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NedospasovaAE.Sprint6.Task3.V25.Lib;

namespace Tyuiu.NedospasovaAE.Sprint6.Task3.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {          
            int rows = 5;
            int columns = 5;
            int[,] mtrx = new int[rows, columns];
            int[,] start = new int[5, 5] { { 14, 5, -9, 18, 21 },
                                           { -5, -12, -12, 4, 28 },
                                           { 27, -2, -14, 23, 27 },
                                           { -19, -15, 17, 15, 1 },
                                           { 33, 2, 6, 24, 24 } };
            DataService ds = new DataService();
            int[,] res = ds.Calculate(start);
            int[,] wait = new int[5, 5] { { 14, 5, -14, 18, 21 },
                                           { -5, -12, -12, 4, 28 },
                                           { 27, -2, -9, 23, 27 },
                                           { -19, -15, 6, 15, 1 },
                                           { 33, 2, 17, 24, 24 } }; ;
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
