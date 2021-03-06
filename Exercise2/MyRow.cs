using System;

namespace GDLab1.Exercise2
{
    /// <summary>
    ///     implements abstract Row
    /// </summary>
    public sealed class MyRow : Row
    {
        #region Constructors

        public MyRow(uint amount, double variable)
        {
            Amount = amount;
            Variable = variable;
            Func = new Function();
        }

        public MyRow(uint amount, double variable, IFunction func)
        {
            Amount = amount;
            Variable = variable;
            Func = func;
        }

        #endregion

        #region Propetries

        #region Amount

        private readonly uint _amount;

        /// <summary>
        ///     overrides virtual property Amount
        /// </summary>
        public override uint Amount
        {
            get => _amount;
            init
            {
                if (value is 0)
                    throw new Exception($"Can only be is natural number. {value} is't natural");
                _amount = value;
            }
        }

        #endregion

        #endregion
    }
}