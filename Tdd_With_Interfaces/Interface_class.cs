namespace Tdd_With_Interfaces
{
    public interface IClass1<T>
    {
        public string Name { get; set; }

        T Calculate(T a, T b);

        
    }
    public interface IClass2<T> where T : struct
    {
        T CalcSqr(T a);

    }
    public interface IName<T>
    {
        public string Name { get; set; }
    }
    public interface IIndexer<T>
    {
        T this[int index] { get; set; }
    }
    

}