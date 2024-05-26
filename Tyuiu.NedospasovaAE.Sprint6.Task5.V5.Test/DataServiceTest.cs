using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NedospasovaAE.Sprint6.Task5.V5.Lib;
using System.IO;

namespace Tyuiu.NedospasovaAE.Sprint6.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\ASUS\source\repos\Tyuiu.NedospasovaAE.Sprint6\InPutFileTask5V5.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
