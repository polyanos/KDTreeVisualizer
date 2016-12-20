using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDTreeVisualizer.Domain
{
    public interface TreeNode<T> : IComparable<TreeNode<T>>
    {
        T Value { get; }
        Dimension Dimension { get; set; }
        TreeNode<T> LeftChild { get; set; }
        TreeNode<T> RightChild { get; set; }
        TreeNode<T> Parent { get; set; }
    }
}
