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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
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
            resources.ApplyResources(this.MainMenu, "MainMenu");
            this.MainMenu.Name = "MainMenu";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.withCustomNumbersToolStripMenuItem,
            this.withRandomNumbersToolStripMenuItem,
            this.withVisualToolToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            resources.ApplyResources(this.createToolStripMenuItem, "createToolStripMenuItem");
            // 
            // withCustomNumbersToolStripMenuItem
            // 
            this.withCustomNumbersToolStripMenuItem.Name = "withCustomNumbersToolStripMenuItem";
            resources.ApplyResources(this.withCustomNumbersToolStripMenuItem, "withCustomNumbersToolStripMenuItem");
            // 
            // withRandomNumbersToolStripMenuItem
            // 
            this.withRandomNumbersToolStripMenuItem.Name = "withRandomNumbersToolStripMenuItem";
            resources.ApplyResources(this.withRandomNumbersToolStripMenuItem, "withRandomNumbersToolStripMenuItem");
            // 
            // withVisualToolToolStripMenuItem
            // 
            this.withVisualToolToolStripMenuItem.Name = "withVisualToolToolStripMenuItem";
            resources.ApplyResources(this.withVisualToolToolStripMenuItem, "withVisualToolToolStripMenuItem");
            // 
            // viewTreeToolStripMenuItem
            // 
            this.viewTreeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graphToolStripMenuItem,
            this.visualPointsToolStripMenuItem});
            this.viewTreeToolStripMenuItem.Name = "viewTreeToolStripMenuItem";
            resources.ApplyResources(this.viewTreeToolStripMenuItem, "viewTreeToolStripMenuItem");
            // 
            // graphToolStripMenuItem
            // 
            this.graphToolStripMenuItem.Name = "graphToolStripMenuItem";
            resources.ApplyResources(this.graphToolStripMenuItem, "graphToolStripMenuItem");
            // 
            // visualPointsToolStripMenuItem
            // 
            this.visualPointsToolStripMenuItem.Name = "visualPointsToolStripMenuItem";
            resources.ApplyResources(this.visualPointsToolStripMenuItem, "visualPointsToolStripMenuItem");
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singlePointToolStripMenuItem,
            this.pointRangeToolStripMenuItem,
            this.neasestPointToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            resources.ApplyResources(this.searchToolStripMenuItem, "searchToolStripMenuItem");
            // 
            // singlePointToolStripMenuItem
            // 
            this.singlePointToolStripMenuItem.Name = "singlePointToolStripMenuItem";
            resources.ApplyResources(this.singlePointToolStripMenuItem, "singlePointToolStripMenuItem");
            // 
            // pointRangeToolStripMenuItem
            // 
            this.pointRangeToolStripMenuItem.Name = "pointRangeToolStripMenuItem";
            resources.ApplyResources(this.pointRangeToolStripMenuItem, "pointRangeToolStripMenuItem");
            // 
            // neasestPointToolStripMenuItem
            // 
            this.neasestPointToolStripMenuItem.Name = "neasestPointToolStripMenuItem";
            resources.ApplyResources(this.neasestPointToolStripMenuItem, "neasestPointToolStripMenuItem");
            // 
            // ViewPort
            // 
            resources.ApplyResources(this.ViewPort, "ViewPort");
            this.ViewPort.Name = "ViewPort";
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ViewPort);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainWindow";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
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
    }
}

