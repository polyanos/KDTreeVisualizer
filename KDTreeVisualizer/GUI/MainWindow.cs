using KDTreeVisualizer.Business;
using KDTreeVisualizer.Helper;
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
            SimpleInputWindow inputWindow = new SimpleInputWindow("Number amount",
                "Insert the amount of generated numbers: ",
                "Amount",
                new NumberValidator());
            inputWindow.ShowDialog();
            if (inputWindow.IsSubmitted())
            {
                IList<Point> pointList = new RandomPointGenerator(ViewPort.Size.Width, ViewPort.Size.Height).GenerateMultipleValues(new NumberTransformer().TransformInput(inputWindow.GetInputString()));
                treeController.CreateTree(pointList);
            }
        }

        private void withCustomNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimpleInputWindow inputWindow = new SimpleInputWindow("Custom Input",
                "Enter the X and Y values seperated by a ',' and end each point with ';'.",
                "23,66;321,123;...",
                new PointListValidator(ViewPort.Size.Width, ViewPort.Size.Height));
            inputWindow.ShowDialog();
            if (inputWindow.IsSubmitted())
            {
                IList<Point> pointList = new PointListTransformer().Transform(inputWindow.GetInputString());
                treeController.CreateTree(pointList);
            }
        }
    }
}
