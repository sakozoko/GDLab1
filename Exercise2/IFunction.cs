namespace GDLab1.Exercise2
{
    public interface IFunction
    {
        /// <summary>
        /// Can to count a member of the row
        /// </summary>
        /// <param name="number">member number</param>
        /// <param name="x">variable X</param>
        /// <returns>row member value</returns>
        public double GetMember(uint number, double x);
    }
}