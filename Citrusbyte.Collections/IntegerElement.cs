using System.Collections.Generic;

namespace Citrusbyte.Collections
{
    internal class IntegerElement : IFlattenable
    {
        private readonly int _value;

        public IntegerElement(int value)
        {
            _value = value;
        }

        public IEnumerable<int> Flatten()
        {
            yield return _value;
        }
    }
}
