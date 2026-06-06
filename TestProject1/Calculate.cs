using Tdd_With_Interfaces;

namespace TestProject1
{
    internal class CalculateSqr<T> : IClass2<decimal>
    {
        //private decimal v;

        public CalculateSqr()
        {
        }

        

        public decimal CalcSqr(decimal a)
        {
            //throw new NotImplementedException();
            return a * a;

        }
    }
}