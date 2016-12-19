using KDTreeVisualizer.Helper.Interfaces;
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
            IList<Tuple<int,IList<int>>> randomValues = new List<Tuple<int,IList<int>>>(yMax);
            for(int y =0; y < yMax; y++)
            {
                List<int> xValues = new List<int>();
                for(int x = 0; x<xMax; x++)
                {
                    xValues.Add(x);
                }

                randomValues.Add(new Tuple<int, IList<int>>(y, xValues));
            }


            Point[] pa = new Point[amount];
            for(int x = 0; x < amount; x++)
            {
                int yKey = rng.Next(randomValues.Count);
                Tuple<int, IList<int>> xTuple = randomValues[yKey];
                int yValue = xTuple.Item1;

                int xKey = rng.Next(xTuple.Item2.Count);
                int xValue = xTuple.Item2[xKey];
                xTuple.Item2.RemoveAt(xKey);

                if(xTuple.Item2.Count < 1) { randomValues.RemoveAt(yKey); }

                pa[x] = new Point(xValue, yValue);
            }

            return pa;
        }

        public Point GenerateSingleValue()
        {
            return new Point(rng.Next(xMax), rng.Next(yMax));
        }

    }
}
