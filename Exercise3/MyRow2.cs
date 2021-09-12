using GDLab1.Exercise2;

namespace GDLab1.Exercise3
{
    public sealed class MyRow2 : Row
    {
        private double _accuracy = -1;

        public MyRow2(uint amount, double variable)
        {
            Variable = variable;
            Amount = amount;
            Func = new Function3();
        }

        private ISolutionRow Solution { get; } = new Solution1();

        public double Accuracy
        {
            get
            {
                if (_accuracy is -1)
                    GetError();
                return _accuracy;
            }
            private set
            {
                if (value < 0)
                    value = -value;
                value = 1 - value;
                _accuracy = value;
            }
        }

        private void GetError()
        {
            var res = (Result - Solution.GetValue(Variable)) / Solution.GetValue(Variable);
            Accuracy = res;
        }
    }
}