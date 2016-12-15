using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDTreeVisualizer.Helper
{
    interface RandomGenerator<T>
    {
        T GenerateSingleValue();

        T[] GenerateMultipleValues(int amount);
    }
}
