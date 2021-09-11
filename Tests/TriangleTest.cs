using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GDLab1.Exercise1;

namespace Tests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void GetAreaTest()
        {
            const double delta = 0.00001d;

            var triangleTest1 = new Triangle(new Point(1, 2), new Point(3, 5), new Point(6, 5));
            var triangleTest2 = new Triangle(new Point(4, 1), new Point(8, 9), new Point(0, 0));
            var triangleTest3 = new Triangle(new Point(5, 1), new Point(4, 6), new Point(1, 3));
            var triangleTest4 = new Triangle(new Point(1, 1), new Point(1, 1), new Point(1, 1));
            var triangleTest5 = new Triangle(new Point(1, 1), new Point(0, 0), new Point(0, 0));

            const double expected1 = 4.50000d;
            const double expected2 = 14.00000d;
            const double expected3 = 9.00000d;
            const double expected4 = 0.00000d;
            const double expected5 = 0.00000d;

            var actual1 = triangleTest1.Area;
            var actual2 = triangleTest2.Area;
            var actual3 = triangleTest3.Area;
            var actual4 = triangleTest4.Area;
            var actual5 = triangleTest5.Area;

            Assert.AreEqual(expected1,actual1,delta);
            Assert.AreEqual(expected2, actual2, delta);
            Assert.AreEqual(expected3, actual3, delta);
            Assert.AreEqual(expected4, actual4, delta);
            Assert.AreEqual(expected5, actual5, delta);
        }
    }
}
