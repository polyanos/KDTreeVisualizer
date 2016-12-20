using System;
using System.Collections.Generic;
using System.Drawing;
using KDTreeVisualizer.Helper.Interfaces;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KDTreeVisualizer.Domain;

namespace KDTreeVisualizer.Helper
{
    class PointKDTreeFactory : KdTreeFactory<Point>
    {
        private Sorter<Point> pointSorter;
        public PointKDTreeFactory() : this(new PointSorter()) { }

        public PointKDTreeFactory(Sorter<Point> pointSorter)
        {
            this.pointSorter = pointSorter;
        }

        public TreeNode<Point> CreateTree(IList<Point> values)
        {
            
        }

        public TreeNode<Point> DeleteNodes(Domain.TreeNode<Point> currentTree, IList<Point> values)
        {
            throw new NotImplementedException();
        }

        public TreeNode<Point> InsertNodes(Domain.TreeNode<Point> currentTree, IList<Point> values)
        {
            throw new NotImplementedException();
        }

        private TreeNode<Point> RecursiveCreateTree(TreeNode<Point> parent, IList<Point> values, Dimension dim)
        {
            PointSorter sorter = new PointSorter(dim);
            Dimension nextDim = DimensionHelper.NextDimension(dim);
            TreeNode<Point> root;
            switch (values.Count)
            {
                case 1:
                    root = new PointTreeNode(parent, dim, values[0]);
                    break;
                case 2:
                    values = sorter.SortValues(values);
                    root = new PointTreeNode(parent, dim, values[1]);
                    root.LeftChild = RecursiveCreateTree(root, values, nextDim);
                    break;
                default:
                    values = pointSorter.SortValues(values);
                    int middleIndex = values.Count / 2;
                    Point value = values[middleIndex];
                    IList<Point> leftValues = CopySubNode(values, 0, middleIndex - 1);
                    IList<Point> rightValues = CopySubNode(values, middleIndex + 1, values.Count - 1);

                    root = new PointTreeNode(parent, dim, value);
                    root.LeftChild = RecursiveCreateTree(root, leftValues, nextDim);
                    root.RightChild = RecursiveCreateTree(root, rightValues, nextDim);
                    break;
            }
            return root;
        }

        private IList<Point> CopySubNode(IList<Point> source, int beginIndex, int endIndex)
        {
            IList<Point> sublist = new List<Point>(endIndex + 1 - beginIndex);
            for(; beginIndex < endIndex + 1; beginIndex++)
            {
                sublist.Add(source[beginIndex]);
            }
            return sublist;
        }
    }
}
