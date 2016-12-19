using KDTreeVisualizer.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDTreeVisualizer.GUI
{
    public partial class MainWindow : Form
    {
        private TreeController<Point, int> treeController;
        public MainWindow(TreeController<Point, int> treeController)
        {
            this.treeController = treeController;
            InitializeComponent();
        }

        private void withRandomNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
