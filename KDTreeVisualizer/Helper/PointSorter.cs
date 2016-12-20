using KDTreeVisualizer.Domain;
using KDTreeVisualizer.Helper.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace KDTreeVisualizer.Helper
{
    class PointSorter : Sorter<Point>
    {
        private Dimension dim;
        public PointSorter()
        {
            dim = Dimension.X;
        }
        public PointSorter(Dimension dim)
        {
            this.dim = dim;
        }

        public IList<Point> SortValues(IList<Point> values)
        {
            return RecursiveSort(values);
        }

        private IList<Point> RecursiveSort(IList<Point> values)
        {

            if (values.Count == 1)
            {
                return values;
            }

            int middle = values.Count / 2;
            IList<Point> leftList = RecursiveSort(GetSubList(values, 0, middle - 1));
            IList<Point> rightList = RecursiveSort(GetSubList(values, middle, values.Count - 1));
            return Merge(leftList, rightList);
        }

        private IList<Point> Merge(IList<Point> left, IList<Point> right)
        {
            IList<Point> mergedList = new List<Point>(right.Count + left.Count);
            int leftIndex = 0;
            int rightIndex = 0;
            while (rightIndex < right.Count && leftIndex < left.Count)
            {
                if (GetCompareValue(left[leftIndex]) < GetCompareValue(right[rightIndex]))
                {
                    mergedList.Add(left[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    mergedList.Add(right[rightIndex]);
                    rightIndex++;
                }
            }

            int copyIndex;
            IList<Point> copyList;
            if(leftIndex < rightIndex)
            {
                copyIndex = leftIndex;
                copyList = left;
            }
            else
            {
                copyIndex = rightIndex;
                copyList = right;
            }

            for(; copyIndex < copyList.Count; copyIndex++)
            {
                mergedList.Add(copyList[copyIndex]);
            }

            return mergedList;
        }

        private int GetCompareValue(Point point)
        {
            switch (dim)
            {
                case Dimension.X:
                    return point.X;
                case Dimension.Y:
                    return point.Y;
                default:
                    return point.X;
            }
        }

        private IList<Point> GetSubList(IList<Point> source, int beginIndex, int endIndex)
        {
            IList<Point> subList = new List<Point>(endIndex - beginIndex + 1);
            for (; beginIndex < endIndex; beginIndex++)
            {
                subList.Add(source[beginIndex]);
            }
            return subList;
        }
    }
}
