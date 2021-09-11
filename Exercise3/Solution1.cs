using System;

namespace GDLab1.Exercise3
{
    public class Solution1 : ISolutionRow
    {
        public double GetValue(double variable)
        {
            return (1 + 2 * Math.Pow(variable, 2)) * Math.Pow(Math.E, Math.Pow(variable, 2));
        }
    }
}