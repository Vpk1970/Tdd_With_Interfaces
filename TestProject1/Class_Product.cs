using Tdd_With_Interfaces;

namespace TestProject1
{
    internal class Class_Product<T> : IClass1<T> where T : struct
    {
        public string Name { get; set; }

        public Class_Product()
        {
            Name = string.Empty;
        }

        public Class_Product(string name)
        {
            Name = name;
        }

        public T Calculate(T a, T b)
        {
            return (dynamic)a * (dynamic)b;
        }
    }
}