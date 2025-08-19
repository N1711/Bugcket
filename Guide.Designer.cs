namespace BugTracker
{
    partial class Guide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guide));
            panel1 = new Panel();
            splitContainer1 = new SplitContainer();
            listBoxMenu = new ListBox();
            splitContainer2 = new SplitContainer();
            txtDescription = new TextBox();
            pbGuide = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbGuide).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(splitContainer1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(685, 497);
            panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(listBoxMenu);
            splitContainer1.Panel1.Padding = new Padding(5);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Panel2.Padding = new Padding(5);
            splitContainer1.Size = new Size(685, 497);
            splitContainer1.SplitterDistance = 159;
            splitContainer1.TabIndex = 0;
            // 
            // listBoxMenu
            // 
            listBoxMenu.Dock = DockStyle.Fill;
            listBoxMenu.FormattingEnabled = true;
            listBoxMenu.ItemHeight = 15;
            listBoxMenu.Items.AddRange(new object[] { "Navigation", "Bugs / Enhancements", "Reports", "Settings" });
            listBoxMenu.Location = new Point(5, 5);
            listBoxMenu.Name = "listBoxMenu";
            listBoxMenu.Size = new Size(149, 487);
            listBoxMenu.TabIndex = 0;
            listBoxMenu.SelectedIndexChanged += listBoxMenu_SelectedIndexChanged;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(5, 5);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(txtDescription);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(pbGuide);
            splitContainer2.Size = new Size(512, 487);
            splitContainer2.SplitterDistance = 288;
            splitContainer2.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Dock = DockStyle.Fill;
            txtDescription.Location = new Point(0, 0);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(512, 288);
            txtDescription.TabIndex = 0;
            txtDescription.Text = "Welcome to Bugcket's Guide. Hope you are having a great day. If not, remember - after the plague came the Rennaisance...";
            // 
            // pbGuide
            // 
            pbGuide.BackgroundImageLayout = ImageLayout.None;
            pbGuide.Dock = DockStyle.Fill;
            pbGuide.InitialImage = (Image)resources.GetObject("pbGuide.InitialImage");
            pbGuide.Location = new Point(0, 0);
            pbGuide.Name = "pbGuide";
            pbGuide.Size = new Size(512, 195);
            pbGuide.SizeMode = PictureBoxSizeMode.Zoom;
            pbGuide.TabIndex = 0;
            pbGuide.TabStop = false;
            // 
            // Guide
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 497);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Guide";
            Text = "App Guide";
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbGuide).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private ListBox listBoxMenu;
        private TextBox txtDescription;
        private PictureBox pbGuide;
    }
}