using System;
using System.Collections.Generic;
using System.Drawing;
using KDTreeVisualizer.Helper.Interfaces;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Domain.TreeNode<Point> CreateTree(IList<Point> values)
        {
            throw new NotImplementedException();
        }

        public Domain.TreeNode<Point> DeleteNodes(Domain.TreeNode<Point> currentTree, IList<Point> values)
        {
            throw new NotImplementedException();
        }

        public Domain.TreeNode<Point> InsertNodes(Domain.TreeNode<Point> currentTree, IList<Point> values)
        {
            throw new NotImplementedException();
        }
    }
}
