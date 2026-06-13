using System.Diagnostics;
using Tdd_With_Interfaces;

namespace TestProject1
{
    internal class Indexer<T> : IIndexer<string>
    {
        string _nimi;


        public Indexer()
        {
            Debug.WriteLine("Indexer class created");
            _nimi = string.Empty;

        }

        public string this[int index]
        {
            get => _nimi;
            set => _nimi = value;
        }
    }
}