using Tdd_With_Interfaces;

namespace TestProject1
{
    internal class Name<T> : IName<T>
    {
        public Name(string nameValue) 
        {
            if (string.IsNullOrEmpty(nameValue))
            {
                Value = "Empty";
            }
            else
            {
                Value = nameValue;
            }
        }

        public string Value { get; set; } = string.Empty; // ""
        string IName<T>.Name { get => Value; set => Value = value; }
    }
}