using KDTreeVisualizer.Domain;
using KDTreeVisualizer.Helper.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace KDTreeVisualizer.Business
{
    class PointKDTreeController : TreeController<Point, int>
    {
        private TreeNode<Point> KDTree;
        private KdTreeFactory<Point> treeFactory;

        public PointKDTreeController(KdTreeFactory<Point> treeFactory)
        {
            this.treeFactory = treeFactory;
        }

        public void CreateTree(IList<Point> points)
        {
            throw new NotImplementedException();
        }

        public TreeNode<Point> getTree()
        {
            throw new NotImplementedException();
        }

        public Point NearestNeightbour(int value)
        {
            throw new NotImplementedException();
        }

        public IList<Point> RangeSearch(int min, int max)
        {
            throw new NotImplementedException();
        }
    }
}
