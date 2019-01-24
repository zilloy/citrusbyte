using System;
using System.Collections.Generic;

namespace Citrusbyte.Collections
{
    public class ArbitraryArray : IFlattenable
    {
        private List<IFlattenable> _elements = new List<IFlattenable>();

        public ArbitraryArray Add(int element)
        {
            _elements.Add(new IntegerElement(element));
            return this;
        }

        public ArbitraryArray Add(ArbitraryArray element)
        {
            if (element == null)
                throw new ArgumentNullException(nameof(element));

            _elements.Add(element);
            return this;
        }

        //execution time for deepest possible structure of:
        //1000 elements - 00:00:00.0194165
        //5000 elements - 00:00:00.4333768
        public IEnumerable<int> Flatten()
        {
            foreach (var element in _elements)
            {
                foreach (var subElement in element.Flatten())
                {
                    yield return subElement;
                }
            }
        }
    }
}
