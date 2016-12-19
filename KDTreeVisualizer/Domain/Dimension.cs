using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDTreeVisualizer.Domain
{
    public enum Dimension
    {
        X, Y
    }

    public static class DimensionHelper{
        public static Dimension NextDimension(Dimension currentDimension)
        {
            switch (currentDimension)
            {
                case Dimension.X:
                    return Dimension.Y;
                case Dimension.Y:
                    return Dimension.X;
                default:
                    return Dimension.X;
            }
        }
    }
}
