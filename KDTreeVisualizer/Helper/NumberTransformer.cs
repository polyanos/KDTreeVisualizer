using KDTreeVisualizer.Helper.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDTreeVisualizer.Helper
{
    class NumberTransformer : Transformer<int>
    {
        public int TransformInput(string input)
        {
            return Int32.Parse(input);
        }
    }
}
