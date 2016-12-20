using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDTreeVisualizer.Domain
{
    class PointTreeNode : TreeNode<Point>
    {
        public Dimension Dimension
        {
            get; set;
        }

        public TreeNode<Point> LeftChild
        {
            get; set;
        }

        public TreeNode<Point> Parent
        {
            get; set;
        }

        public TreeNode<Point> RightChild
        {
            get; set;
        }

        public Point Value
        {
            get;
        }

        public PointTreeNode(TreeNode<Point> parent, Dimension dim, Point value)
        {
            Parent = parent;
            Dimension = dim;
            Value = value;
        }

        public int CompareTo(TreeNode<Point> point)
        {
            switch (Dimension)
            {
                case Dimension.X:
                    return Value.X - point.Value.X;
                case Dimension.Y:
                    return Value.Y - point.Value.Y;
                default:
                    return Value.X - point.Value.X;
            }
        }
    }
}
