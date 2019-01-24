using System.Collections.Generic;

namespace Citrusbyte.Collections
{
    public interface IFlattenable
    {
        IEnumerable<int> Flatten();
    }
}
