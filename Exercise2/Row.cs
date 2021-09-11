namespace GDLab1.Exercise2
{
    public abstract class Row
    {
        #region Properties

        public abstract uint Amount { get; init; }

        private double _result;

        public virtual double Result
        {
            get
            {
                if (_result is 0)
                    GetResult();
                return _result;
            }
            protected set => _result = value;
        }

        protected double Variable { get; set; }

        /// <summary>
        /// Should be able to count member of row
        /// </summary>
        protected abstract IFunction Func { get; }
        #endregion

        #region Private methods

        private void GetResult()
        {
            double res = 0;
            for (uint c = 1; c <= Amount; c++) res += Func.GetMember(c, Variable);
            Result = res;
        }

        #endregion
    }
}