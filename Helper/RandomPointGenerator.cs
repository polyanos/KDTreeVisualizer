using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDTreeVisualizer.Helper
{
    class RandomPointGenerator : RandomGenerator<Point>
    {
        private Random rng;
        private int xMax;
        private int yMax;

        public RandomPointGenerator(int xMax, int yMax, int seed = 0)
        {
            rng = seed == 0 ? new Random() : new Random(seed);
            this.xMax = xMax;
            this.yMax = yMax;
        }


        public Point[] GenerateMultipleValues(int amount)
        {
            Point[] points = new Point[amount];

            for (int x = 0; x < amount; x++)
            {
                points[x] = new Point(rng.Next(xMax), rng.Next(yMax));
            }

            return points;
        }

        public Point GenerateSingleValue()
        {
            return new Point(rng.Next(xMax), rng.Next(yMax));
        }

    }
}
