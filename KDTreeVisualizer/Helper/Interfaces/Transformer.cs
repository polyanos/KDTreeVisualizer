﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDTreeVisualizer.Helper.Interfaces
{
    interface Transformer<T>
    {
        T TransformInput(string input);
    }
}
