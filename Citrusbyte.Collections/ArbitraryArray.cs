using System;
using System.Collections.Generic;

namespace Citrusbyte.Collections
{
    public class ArbitraryArray : Element
    {
        private List<Element> _elements = new List<Element>();

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

        //execution time for deep structure of:
        //1000 elements - 00:00:00.0020284
        //5000 elements - 00:00:00.0023037
        public IEnumerable<int> Flatten()
        {
            var stack = new Stack<Element>();

            void AddToStack(IList<Element> elements)
            {
                for (var i = elements.Count - 1; i >= 0; --i)
                {
                    stack.Push(elements[i]);
                }
            }

            AddToStack(_elements);

            while (stack.TryPop(out var element))
            {
                if (element is IntegerElement)
                {
                    yield return ((IntegerElement)element).Value;
                }

                if (element is ArbitraryArray)
                {
                    AddToStack(((ArbitraryArray)element)._elements);
                }
            }
        }
    }
}
