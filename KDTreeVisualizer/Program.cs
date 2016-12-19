using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using KDTreeVisualizer.GUI;
using System.Drawing;
using KDTreeVisualizer.Business;
using KDTreeVisualizer.Helper;
using KDTreeVisualizer.Helper.Interfaces;

namespace KDTreeVisualizer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            KdTreeFactory<Point> treeFactory = new PointKDTreeFactory();
            TreeController<Point, int> treeController = new PointKDTreeController(treeFactory);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow(treeController));
        }
    }
}
