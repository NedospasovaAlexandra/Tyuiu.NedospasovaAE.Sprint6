using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NedospasovaAE.Sprint6.Task1.V13.Lib;

namespace Tyuiu.NedospasovaAE.Sprint6.Task1.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] res = ds.GetMassFunction(startValue, stopValue);
            double[] wait = { 23.92, 18.88, 13.10, 7.24, 1.80, -8, -5.70, -11.26, -17.12, -22.88, -27.92 };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
