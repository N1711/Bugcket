namespace BugTracker
{
    partial class VersionManagementForm
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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            dataGridVersions = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            newItemToolStripMenuItem = new ToolStripMenuItem();
            deleteItemToolStripMenuItem = new ToolStripMenuItem();
            refreshToolStripMenuItem = new ToolStripMenuItem();
            splitContainer2 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            txtVersionID = new TextBox();
            splitContainer4 = new SplitContainer();
            comboVersionProducts = new ComboBox();
            txtVersionVer = new TextBox();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVersions).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridVersions);
            splitContainer1.Panel1.Padding = new Padding(5);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Panel2.Padding = new Padding(5);
            splitContainer1.Size = new Size(312, 318);
            splitContainer1.SplitterDistance = 151;
            splitContainer1.TabIndex = 0;
            // 
            // dataGridVersions
            // 
            dataGridVersions.AllowUserToAddRows = false;
            dataGridVersions.AllowUserToDeleteRows = false;
            dataGridVersions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridVersions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridVersions.ContextMenuStrip = contextMenuStrip1;
            dataGridVersions.Dock = DockStyle.Fill;
            dataGridVersions.Location = new Point(5, 5);
            dataGridVersions.Name = "dataGridVersions";
            dataGridVersions.ReadOnly = true;
            dataGridVersions.RowTemplate.Height = 25;
            dataGridVersions.Size = new Size(302, 141);
            dataGridVersions.TabIndex = 0;
            dataGridVersions.SelectionChanged += dataGridVersions_SelectionChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { newItemToolStripMenuItem, deleteItemToolStripMenuItem, refreshToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(135, 70);
            // 
            // newItemToolStripMenuItem
            // 
            newItemToolStripMenuItem.Name = "newItemToolStripMenuItem";
            newItemToolStripMenuItem.Size = new Size(134, 22);
            newItemToolStripMenuItem.Text = "New Item";
            newItemToolStripMenuItem.Click += newItemToolStripMenuItem_Click;
            // 
            // deleteItemToolStripMenuItem
            // 
            deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
            deleteItemToolStripMenuItem.Size = new Size(134, 22);
            deleteItemToolStripMenuItem.Text = "Delete Item";
            deleteItemToolStripMenuItem.Click += deleteItemToolStripMenuItem_Click;
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.Size = new Size(134, 22);
            refreshToolStripMenuItem.Text = "Refresh";
            refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(5, 5);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(btnSave);
            splitContainer2.Size = new Size(302, 153);
            splitContainer2.SplitterDistance = 100;
            splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(txtVersionID);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(splitContainer4);
            splitContainer3.Size = new Size(302, 100);
            splitContainer3.SplitterDistance = 28;
            splitContainer3.TabIndex = 0;
            // 
            // txtVersionID
            // 
            txtVersionID.Dock = DockStyle.Fill;
            txtVersionID.Enabled = false;
            txtVersionID.Location = new Point(0, 0);
            txtVersionID.Name = "txtVersionID";
            txtVersionID.PlaceholderText = "ID";
            txtVersionID.ReadOnly = true;
            txtVersionID.Size = new Size(302, 23);
            txtVersionID.TabIndex = 0;
            // 
            // splitContainer4
            // 
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.Location = new Point(0, 0);
            splitContainer4.Name = "splitContainer4";
            splitContainer4.Orientation = Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(comboVersionProducts);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(txtVersionVer);
            splitContainer4.Size = new Size(302, 68);
            splitContainer4.SplitterDistance = 28;
            splitContainer4.TabIndex = 0;
            // 
            // comboVersionProducts
            // 
            comboVersionProducts.Dock = DockStyle.Fill;
            comboVersionProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            comboVersionProducts.Enabled = false;
            comboVersionProducts.FormattingEnabled = true;
            comboVersionProducts.Location = new Point(0, 0);
            comboVersionProducts.Name = "comboVersionProducts";
            comboVersionProducts.Size = new Size(302, 23);
            comboVersionProducts.TabIndex = 0;
            // 
            // txtVersionVer
            // 
            txtVersionVer.Dock = DockStyle.Fill;
            txtVersionVer.Enabled = false;
            txtVersionVer.Location = new Point(0, 0);
            txtVersionVer.Name = "txtVersionVer";
            txtVersionVer.PlaceholderText = "Version";
            txtVersionVer.ReadOnly = true;
            txtVersionVer.Size = new Size(302, 23);
            txtVersionVer.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.Location = new Point(0, 0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(302, 49);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // VersionManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 318);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "VersionManagementForm";
            Text = "Version Management";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridVersions).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel1.PerformLayout();
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel2.ResumeLayout(false);
            splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dataGridVersions;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem newItemToolStripMenuItem;
        private ToolStripMenuItem deleteItemToolStripMenuItem;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private SplitContainer splitContainer2;
        private Button btnSave;
        private SplitContainer splitContainer3;
        private TextBox txtVersionID;
        private SplitContainer splitContainer4;
        private ComboBox comboVersionProducts;
        private TextBox txtVersionVer;
    }
}