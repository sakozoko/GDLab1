
using System;
using GDLab1.Exercise2;

namespace GDLab1.Exercise3
{
    public class Function3:IFunction
    {
        public double GetMember(uint number, double x)
        {
           return (2 * number + 1) * (Math.Pow(x, 2 * number) / Factorial(number));
        }
        private double Factorial(uint numb)
        {
            if (numb <= 1)
                return 1;
            return numb * Factorial(--numb);
        }
    }
}