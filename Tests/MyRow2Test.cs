using GDLab1.Exercise3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class MyRow2Test
    {
        [TestMethod]
        public void TestMethod()
        {
            var delta = 0.0001d;

            var rowWithCond1 = new MyRow2(200, 5);
            var rowWithCond2 = new MyRow2(100, 1);
            var rowWithCond3 = new MyRow2(150, 2);
            var rowWithCond4= new MyRow2(150, 0);
            var rowWithCond5 = new MyRow2(150, -2);

            var actualValue1 = rowWithCond1.Result;
            var actualValue2 = rowWithCond2.Result;
            var actualValue3 = rowWithCond3.Result;
            var actualValue4 = rowWithCond4.Result;
            var actualValue5 = rowWithCond5.Result;

            var actualAccuracy1 = rowWithCond1.Accuracy;
            var actualAccuracy2 = rowWithCond2.Accuracy;
            var actualAccuracy3 = rowWithCond3.Accuracy;
            var actualAccuracy4 = rowWithCond4.Accuracy;
            var actualAccuracy5 = rowWithCond5.Accuracy;

            const double expectedValue1 = 3672550000000d;
            const double expectedValue2 = 8.15485d;
            const double expectedValue3 = 491.38335d;
            const double expectedValue4 = 1d;
            const double expectedValue5 = 491.38335d;

            var expectedAccuracy1 = 1 + (actualValue1 - expectedValue1) / expectedValue1;
            var expectedAccuracy2 = 1 + (actualValue2 - expectedValue2) / expectedValue2;
            var expectedAccuracy3 = 1 + (actualValue3 - expectedValue3) / expectedValue3;
            var expectedAccuracy4 = 1 + (actualValue4 - expectedValue4) / expectedValue4;
            var expectedAccuracy5 = 1 + (actualValue5 - expectedValue5) / expectedValue5;

            Assert.AreEqual(expectedAccuracy1, actualAccuracy1, delta);
            Assert.AreEqual(expectedAccuracy2, actualAccuracy2, delta);
            Assert.AreEqual(expectedAccuracy3, actualAccuracy3, delta);
            Assert.AreEqual(expectedAccuracy4, actualAccuracy4, delta);
            Assert.AreEqual(expectedAccuracy5, actualAccuracy5, delta);
        }

    }
}