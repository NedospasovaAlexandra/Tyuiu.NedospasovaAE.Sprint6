using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NedospasovaAE.Sprint6.Task6.V20.Lib;

namespace Tyuiu.NedospasovaAE.Sprint6.Task6.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\ASUS\source\repos\Tyuiu.NedospasovaAE.Sprint6\Tyuiu.NedospasovaAE.Sprint6.Task6.V20\bin\Debug\InPutFileTask6V20.txt";
            string res = ds.CollectTextFromFile(path);
            string wait = "dKOPBC IqjpIlKAaSCBuaQUU GPeEqZo FPsrQHsImzbTBckw NgAfitECn";
            Assert.AreEqual(wait, res);
        }
    }
}
