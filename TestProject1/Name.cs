using Tdd_With_Interfaces;

namespace TestProject1
{
    internal class Name<T> : IName<T>
    {
        private string _name = string.Empty;
                
        public Name(string name) { _name = name; }

        string IName<T>.Name 
        { 
            get { return _name; }
            set { _name = value; } 
        }

    }
}