using System;

namespace GDLab1.Exercise2
{
    public class Function : IFunction
    {
        public double GetMember(uint number, double x)
        {
            return Math.Pow(Math.Sin(x), number);
        }
    }

    /// <summary>
    /// Func2 for testing abstract system
    /// </summary>
    public class Function2 : IFunction
    {
        public double GetMember(uint number, double x)
        {
            return Math.Pow(Math.Cos(x), number);
        }
    }
}