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
            this.viewTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singlePointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neasestPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewPort = new System.Windows.Forms.Panel();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.viewTreeToolStripMenuItem,
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
            // viewTreeToolStripMenuItem
            // 
            this.viewTreeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graphToolStripMenuItem,
            this.visualPointsToolStripMenuItem});
            this.viewTreeToolStripMenuItem.Name = "viewTreeToolStripMenuItem";
            this.viewTreeToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.viewTreeToolStripMenuItem.Text = "View Tree";
            // 
            // graphToolStripMenuItem
            // 
            this.graphToolStripMenuItem.Name = "graphToolStripMenuItem";
            this.graphToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.graphToolStripMenuItem.Text = "Graph";
            // 
            // visualPointsToolStripMenuItem
            // 
            this.visualPointsToolStripMenuItem.Name = "visualPointsToolStripMenuItem";
            this.visualPointsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.visualPointsToolStripMenuItem.Text = "Visual Points";
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
            this.singlePointToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.singlePointToolStripMenuItem.Text = "Single Point";
            // 
            // pointRangeToolStripMenuItem
            // 
            this.pointRangeToolStripMenuItem.Name = "pointRangeToolStripMenuItem";
            this.pointRangeToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.pointRangeToolStripMenuItem.Text = "Point Range";
            // 
            // neasestPointToolStripMenuItem
            // 
            this.neasestPointToolStripMenuItem.Name = "neasestPointToolStripMenuItem";
            this.neasestPointToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.neasestPointToolStripMenuItem.Text = "Neasest Point";
            // 
            // ViewPort
            // 
            this.ViewPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewPort.Location = new System.Drawing.Point(0, 24);
            this.ViewPort.Name = "ViewPort";
            this.ViewPort.Size = new System.Drawing.Size(784, 537);
            this.ViewPort.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ViewPort);
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

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem withCustomNumbersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withRandomNumbersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withVisualToolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singlePointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neasestPointToolStripMenuItem;
        private System.Windows.Forms.Panel ViewPort;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
    }
}

