using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDTreeVisualizer.Helper
{
    interface Transformer<T, X>
    {
        T transform(X input);
    }
}
