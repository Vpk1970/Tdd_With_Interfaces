using Tdd_With_Interfaces;

namespace TestProject1
{
    internal class Name<T> : IName<string>
    {
        public Name(string _name) 
        {
            if (string.IsNullOrEmpty(_name))
            {
                ((IName<string>)this).Name = "Empty";
            }
            else
            {
                ((IName<string>)this).Name = _name;
            }
        }

        string IName<string>.Name { get; set; } = string.Empty;// oletus ""

    }
}