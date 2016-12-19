using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDTreeVisualizer.Helper.Interfaces
{
    public interface Sorter<T>
    {
        IList<T> SortValues(IList<T> values);
    }
}
