using KDTreeVisualizer.GUI.Panels;
using System.Windows.Forms;

namespace KDTreeVisualizer.GUI
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withCustomNumbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withRandomNumbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withVisualToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singlePointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neasestPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabbedViewports = new System.Windows.Forms.TabControl();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(784, 24);
            this.MainMenu.TabIndex = 0;
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.withCustomNumbersToolStripMenuItem,
            this.withRandomNumbersToolStripMenuItem,
            this.withVisualToolToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.createToolStripMenuItem.Text = "Create Tree";
            // 
            // withCustomNumbersToolStripMenuItem
            // 
            this.withCustomNumbersToolStripMenuItem.Name = "withCustomNumbersToolStripMenuItem";
            this.withCustomNumbersToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.withCustomNumbersToolStripMenuItem.Text = "With Custom Points";
            this.withCustomNumbersToolStripMenuItem.Click += new System.EventHandler(this.withCustomNumbersToolStripMenuItem_Click);
            // 
            // withRandomNumbersToolStripMenuItem
            // 
            this.withRandomNumbersToolStripMenuItem.Name = "withRandomNumbersToolStripMenuItem";
            this.withRandomNumbersToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.withRandomNumbersToolStripMenuItem.Text = "With Random Points";
            this.withRandomNumbersToolStripMenuItem.Click += new System.EventHandler(this.withRandomNumbersToolStripMenuItem_Click);
            // 
            // withVisualToolToolStripMenuItem
            // 
            this.withVisualToolToolStripMenuItem.Name = "withVisualToolToolStripMenuItem";
            this.withVisualToolToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.withVisualToolToolStripMenuItem.Text = "With Visual Tool";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singlePointToolStripMenuItem,
            this.pointRangeToolStripMenuItem,
            this.neasestPointToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // singlePointToolStripMenuItem
            // 
            this.singlePointToolStripMenuItem.Name = "singlePointToolStripMenuItem";
            this.singlePointToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.singlePointToolStripMenuItem.Text = "Single Point";
            // 
            // pointRangeToolStripMenuItem
            // 
            this.pointRangeToolStripMenuItem.Name = "pointRangeToolStripMenuItem";
            this.pointRangeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pointRangeToolStripMenuItem.Text = "Point Range";
            // 
            // neasestPointToolStripMenuItem
            // 
            this.neasestPointToolStripMenuItem.Name = "neasestPointToolStripMenuItem";
            this.neasestPointToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.neasestPointToolStripMenuItem.Text = "Neasest Point";
            // 
            // tabbedViewports
            // 
            this.tabbedViewports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabbedViewports.Location = new System.Drawing.Point(0, 24);
            this.tabbedViewports.Name = "tabbedViewports";
            this.tabbedViewports.SelectedIndex = 0;
            this.tabbedViewports.Size = new System.Drawing.Size(784, 537);
            this.tabbedViewports.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabbedViewports);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainWindow";
            this.Text = "KDVisualiser";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InitializeViewports()
        {
            tabbedViewports.TabPages.Add(new VisualPointPanel());
            tabbedViewports.TabPages.Add(new VisualGraphPanel());
        }
        #endregion

        private MenuStrip MainMenu;
        private ToolStripMenuItem withCustomNumbersToolStripMenuItem;
        private ToolStripMenuItem withRandomNumbersToolStripMenuItem;
        private ToolStripMenuItem withVisualToolToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem singlePointToolStripMenuItem;
        private ToolStripMenuItem pointRangeToolStripMenuItem;
        private ToolStripMenuItem neasestPointToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem;
        private TabControl tabbedViewports;
        private Panel visualPoints;
        private Panel visualGraph;
    }
}

