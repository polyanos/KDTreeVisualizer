using KDTreeVisualizer.Helper.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDTreeVisualizer.Helper
{
    class PointListTransformer : ListTransformer<Point>
    {
        public IList<Point> Transform(string input)
        {
            string[] pointStrings = input.Split(';');
            IList<Point> pointList = new List<Point>(pointStrings.Length);

            int x, y;
            string[] xyString;
            foreach (string pointString in pointStrings)
            {
                xyString = pointString.Split(',');
                x = int.Parse(xyString[0]);
                y = int.Parse(xyString[1]);
                pointList.Add(new Point(x, y));
            }

            return pointList;
        }
    }
}
