using System;
using System.Drawing;

namespace GDLab1.Exercise1
{
    public class Triangle
    {
        #region Constructor

        public Triangle(Point point1, Point point2, Point point3)
        {
            Line1 = new MyLine(point1, point2);
            Line2 = new MyLine(point2, point3);
            Line3 = new MyLine(point3, point1);
        }

        #endregion

        #region CalculateAreaMethod

        private void CalculateArea()
        {
            var p = (Line1.Length + Line2.Length + Line3.Length) / 2d;
            Area = Math.Sqrt(p * (p - Line1.Length) * (p - Line2.Length) * (p - Line3.Length));
        }

        #endregion

        #region Private class MyLine

        private class MyLine
        {
            #region Constructor

            public MyLine(Point one, Point two)
            {
                Vector = new Point(two.X - one.X, two.Y - one.Y);
                Length = Math.Sqrt(Vector.X * Vector.X + Vector.Y * Vector.Y);
            }

            #endregion

            #region Properies

            private Point Vector { get; }

            public double Length { get; }

            #endregion
        }

        #endregion

        #region Properties

        private MyLine Line1 { get; }
        private MyLine Line2 { get; }
        private MyLine Line3 { get; }

        private double _area;

        /// <summary>
        ///     Returns area of a triangle, if the triangle is incorrect, returns 0
        /// </summary>
        public double Area
        {
            get
            {
                if (_area is 0d)
                    CalculateArea();
                return _area;
            }
            private set => _area = value;
        }

        #endregion
    }
}