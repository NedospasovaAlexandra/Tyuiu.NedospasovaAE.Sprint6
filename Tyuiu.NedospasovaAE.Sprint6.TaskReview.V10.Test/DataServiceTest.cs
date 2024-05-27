using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NedospasovaAE.Sprint6.TaskReview.V10.Lib;

namespace Tyuiu.NedospasovaAE.Sprint6.TaskReview.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            int[,] array = { { -1, 2, 4, 6, 9 },
                             { 3, -7, 8, 10, 12 },
                             { 4, 5, 6, 4, 25 },
                             { -2, -5, -1, 3, 3 },
                             { 4, 7, 8, 10, 4 } };
            int k = 0;
            int l = 4;
            int c = 3;
            int res = ds.GetMatrix(array, c, k, l);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
