using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GDLab1.Exercise2;

namespace Tests
{
    [TestClass]
    public class MyRowTest
    {
        [TestMethod]
        public void GetResultTest()
        {
            const double delta = 0.00001d;

            var myRow1 = new MyRow(3, 4);
            var myRow2 = new MyRow(1, 5);
            var myRow3 = new MyRow(4, 1);
            var myRow4 = new MyRow(2, 10);
            var myRow5 = new MyRow(2, 3,new Function2());

            const double expected1 = -0.617511d;
            const double expected2 = -0.958924d;
            const double expected3 = 2.64674d;
            const double expected4 = -0.248062d;
            const double expected5 = -0.00990735d;

            var actual1 = myRow1.Result;
            var actual2 = myRow2.Result;
            var actual3 = myRow3.Result;
            var actual4 = myRow4.Result;
            var actual5 = myRow5.Result;

            Assert.AreEqual(expected1, actual1, delta);
            Assert.AreEqual(expected2, actual2, delta);
            Assert.AreEqual(expected3, actual3, delta);
            Assert.AreEqual(expected4, actual4, delta);
            Assert.AreEqual(expected5, actual5, delta);

            Assert.ThrowsException<Exception>(() => new MyRow(0, 4));

        }
    }
}