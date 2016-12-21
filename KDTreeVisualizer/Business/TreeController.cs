using KDTreeVisualizer.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDTreeVisualizer.Business
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">Type of the values stored in the tree,</typeparam>
    /// <typeparam name="X">Type of the searchvalues</typeparam>
    public interface TreeController<T, X> 
    {
        void CreateTree(IList<T> points);
        void AddItemToTree(T item);
        void RemoveItemFromTree(T item);
        TreeNode<T> getTree();
        IList<T> RangeSearch(X min, X max);
        T NearestNeightbour(X value);

        //Listener
        void addListener(TreeChangeListener listener);
        void removeListener(TreeChangeListener listener);
    }
}
