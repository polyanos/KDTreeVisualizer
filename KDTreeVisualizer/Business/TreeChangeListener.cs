using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDTreeVisualizer.Business
{
    public interface TreeChangeListener
    {
        void TreeHasChanged();
    }
}
