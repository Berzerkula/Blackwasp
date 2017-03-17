//http://www.blackwasp.co.uk/CSharpIndexers.aspx
using System;

namespace IndexerDemo
{
    class MyArray
    {
        int _lowerBound;
        int _upperBound;
        string[] _items;

        //constructor
        public MyArray(int lowerBound, int upperBound)
        {
            _lowerBound = lowerBound;
            _upperBound = upperBound;
            _items = new string[1 + upperBound - lowerBound];
        }

        public string this[int index]
        {
            get
            {
                return _items[index - _lowerBound];
            }
            set
            {
                _items[index - _lowerBound] = value;
            }
        }

        //multidimensional indexer
        public string this[int word, int position]
        {
            get
            {
                return _items[word - _lowerBound].Substring(position, 1);
            }
        }

        //index with no underlying array
        public float this[float toSquare]
        {
            get
            {
                return toSquare * toSquare;
            }
        }
    }
}