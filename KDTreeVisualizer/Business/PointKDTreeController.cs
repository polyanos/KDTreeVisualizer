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
        private ICollection<TreeChangeListener> listeners;

        public PointKDTreeController(KdTreeFactory<Point> treeFactory)
        {
            this.treeFactory = treeFactory;
        }

        public void CreateTree(IList<Point> points)
        {
            KDTree = treeFactory.CreateTree(points);
            NotifyTreeChangeListeners();
        }

        public void AddItemToTree(Point item)
        {
            throw new NotImplementedException();
        }

        public void RemoveItemFromTree(Point item)
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

        //Listeners
        public void addListener(TreeChangeListener listener)
        {
            listeners.Add(listener);
        }

        public void removeListener(TreeChangeListener listener)
        {
            listeners.Remove(listener);
        }

        private void NotifyTreeChangeListeners()
        {
            foreach(TreeChangeListener listener in listeners)
            {
                listener.TreeHasChanged();
            }
        }
    }
}
