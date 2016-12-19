using KDTreeVisualizer.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDTreeVisualizer.Helper.Interfaces
{
    interface KdTreeFactory<T>
    {
        TreeNode<T> CreateTree(IList<T> values);
        TreeNode<T> InsertNodes(TreeNode<T> currentTree, IList<T> values);
        TreeNode<T> DeleteNodes(TreeNode<T> currentTree, IList<T> values);
    }
}
