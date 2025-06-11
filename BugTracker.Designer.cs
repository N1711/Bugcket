namespace BugTracker
{
    partial class BugTracker
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
            menuStrip2 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            bugTrackerToolStripMenuItem = new ToolStripMenuItem();
            enhancementsToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            newToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            filterToolStripMenuItem = new ToolStripMenuItem();
            configToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            userManagementToolStripMenuItem = new ToolStripMenuItem();
            productManagementToolStripMenuItem = new ToolStripMenuItem();
            versionsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            guideToolStripMenuItem = new ToolStripMenuItem();
            changesToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            bugItems = new DataGridView();
            contextMenu = new ContextMenuStrip(components);
            newItemToolStripMenuItem = new ToolStripMenuItem();
            deleteItemToolStripMenuItem = new ToolStripMenuItem();
            filterToolStripMenuItem1 = new ToolStripMenuItem();
            sortToolStripMenuItem = new ToolStripMenuItem();
            ascendingToolStripMenuItem = new ToolStripMenuItem();
            descendingToolStripMenuItem = new ToolStripMenuItem();
            splitContainer2 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtID = new TextBox();
            txtVersion = new TextBox();
            txtDescription = new TextBox();
            comboStatus = new ComboBox();
            button1 = new Button();
            dtPicker = new DateTimePicker();
            comboPriority = new ComboBox();
            txtDetectedName = new TextBox();
            splitContainer3 = new SplitContainer();
            txtNotesIssue = new TextBox();
            txtNotesFix = new TextBox();
            menuStrip2.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bugItems).BeginInit();
            contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.AutoSize = false;
            menuStrip2.Dock = DockStyle.Left;
            menuStrip2.GripStyle = ToolStripGripStyle.Visible;
            menuStrip2.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, bugTrackerToolStripMenuItem, enhancementsToolStripMenuItem, reportsToolStripMenuItem });
            menuStrip2.Location = new Point(5, 66);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.RenderMode = ToolStripRenderMode.Professional;
            menuStrip2.Size = new Size(132, 549);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(128, 19);
            homeToolStripMenuItem.Text = "Home";
            // 
            // bugTrackerToolStripMenuItem
            // 
            bugTrackerToolStripMenuItem.Name = "bugTrackerToolStripMenuItem";
            bugTrackerToolStripMenuItem.Size = new Size(128, 19);
            bugTrackerToolStripMenuItem.Text = "Bug Tracker";
            // 
            // enhancementsToolStripMenuItem
            // 
            enhancementsToolStripMenuItem.Name = "enhancementsToolStripMenuItem";
            enhancementsToolStripMenuItem.Size = new Size(128, 19);
            enhancementsToolStripMenuItem.Text = "Enhancements";
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(128, 19);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.Items.AddRange(new ToolStripItem[] { newToolStripMenuItem, deleteToolStripMenuItem, filterToolStripMenuItem, configToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(5, 5);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1009, 61);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(41, 57);
            newToolStripMenuItem.Text = "App";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(44, 57);
            deleteToolStripMenuItem.Text = "View";
            // 
            // filterToolStripMenuItem
            // 
            filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            filterToolStripMenuItem.Size = new Size(45, 57);
            filterToolStripMenuItem.Text = "Filter";
            // 
            // configToolStripMenuItem
            // 
            configToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, userManagementToolStripMenuItem, productManagementToolStripMenuItem, versionsToolStripMenuItem, exitToolStripMenuItem });
            configToolStripMenuItem.Name = "configToolStripMenuItem";
            configToolStripMenuItem.Size = new Size(55, 57);
            configToolStripMenuItem.Text = "Config";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(190, 22);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // userManagementToolStripMenuItem
            // 
            userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            userManagementToolStripMenuItem.Size = new Size(190, 22);
            userManagementToolStripMenuItem.Text = "User Management";
            // 
            // productManagementToolStripMenuItem
            // 
            productManagementToolStripMenuItem.Name = "productManagementToolStripMenuItem";
            productManagementToolStripMenuItem.Size = new Size(190, 22);
            productManagementToolStripMenuItem.Text = "Product Management";
            productManagementToolStripMenuItem.Click += productManagementToolStripMenuItem_Click;
            // 
            // versionsToolStripMenuItem
            // 
            versionsToolStripMenuItem.Name = "versionsToolStripMenuItem";
            versionsToolStripMenuItem.Size = new Size(190, 22);
            versionsToolStripMenuItem.Text = "Versions";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(190, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, guideToolStripMenuItem, changesToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 57);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(120, 22);
            aboutToolStripMenuItem.Text = "About";
            // 
            // guideToolStripMenuItem
            // 
            guideToolStripMenuItem.Name = "guideToolStripMenuItem";
            guideToolStripMenuItem.Size = new Size(120, 22);
            guideToolStripMenuItem.Text = "Guide";
            // 
            // changesToolStripMenuItem
            // 
            changesToolStripMenuItem.Name = "changesToolStripMenuItem";
            changesToolStripMenuItem.Size = new Size(120, 22);
            changesToolStripMenuItem.Text = "Changes";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(137, 66);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(bugItems);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Panel2.Margin = new Padding(0, 0, 0, 20);
            splitContainer1.Size = new Size(877, 549);
            splitContainer1.SplitterDistance = 269;
            splitContainer1.TabIndex = 3;
            // 
            // bugItems
            // 
            bugItems.AllowUserToAddRows = false;
            bugItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bugItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            bugItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bugItems.ContextMenuStrip = contextMenu;
            bugItems.Dock = DockStyle.Fill;
            bugItems.Location = new Point(0, 0);
            bugItems.Name = "bugItems";
            bugItems.ReadOnly = true;
            bugItems.RowTemplate.Height = 25;
            bugItems.Size = new Size(877, 269);
            bugItems.TabIndex = 0;
            bugItems.SelectionChanged += bugItems_SelectionChanged;
            // 
            // contextMenu
            // 
            contextMenu.Items.AddRange(new ToolStripItem[] { newItemToolStripMenuItem, deleteItemToolStripMenuItem, filterToolStripMenuItem1, sortToolStripMenuItem });
            contextMenu.Name = "contextMenu";
            contextMenu.Size = new Size(135, 92);
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
            // filterToolStripMenuItem1
            // 
            filterToolStripMenuItem1.Name = "filterToolStripMenuItem1";
            filterToolStripMenuItem1.Size = new Size(134, 22);
            filterToolStripMenuItem1.Text = "Filter";
            // 
            // sortToolStripMenuItem
            // 
            sortToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ascendingToolStripMenuItem, descendingToolStripMenuItem });
            sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            sortToolStripMenuItem.Size = new Size(134, 22);
            sortToolStripMenuItem.Text = "Sort";
            // 
            // ascendingToolStripMenuItem
            // 
            ascendingToolStripMenuItem.Name = "ascendingToolStripMenuItem";
            ascendingToolStripMenuItem.Size = new Size(136, 22);
            ascendingToolStripMenuItem.Text = "Ascending";
            // 
            // descendingToolStripMenuItem
            // 
            descendingToolStripMenuItem.Name = "descendingToolStripMenuItem";
            descendingToolStripMenuItem.Size = new Size(136, 22);
            descendingToolStripMenuItem.Text = "Descending";
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(splitContainer3);
            splitContainer2.Size = new Size(877, 276);
            splitContainer2.SplitterDistance = 236;
            splitContainer2.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(txtID, 0, 0);
            tableLayoutPanel1.Controls.Add(txtVersion, 0, 1);
            tableLayoutPanel1.Controls.Add(txtDescription, 0, 2);
            tableLayoutPanel1.Controls.Add(comboStatus, 0, 3);
            tableLayoutPanel1.Controls.Add(button1, 0, 7);
            tableLayoutPanel1.Controls.Add(dtPicker, 0, 6);
            tableLayoutPanel1.Controls.Add(comboPriority, 0, 4);
            tableLayoutPanel1.Controls.Add(txtDetectedName, 0, 5);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28.7356339F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 29.5976982F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 41.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.Size = new Size(236, 279);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtID
            // 
            txtID.Dock = DockStyle.Fill;
            txtID.Location = new Point(3, 3);
            txtID.Name = "txtID";
            txtID.PlaceholderText = "ID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(230, 23);
            txtID.TabIndex = 0;
            // 
            // txtVersion
            // 
            txtVersion.Dock = DockStyle.Fill;
            txtVersion.Location = new Point(3, 35);
            txtVersion.Name = "txtVersion";
            txtVersion.PlaceholderText = "Version";
            txtVersion.ReadOnly = true;
            txtVersion.Size = new Size(230, 23);
            txtVersion.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Dock = DockStyle.Fill;
            txtDescription.ForeColor = Color.Black;
            txtDescription.Location = new Point(3, 68);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Description of the Bug";
            txtDescription.ReadOnly = true;
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(230, 41);
            txtDescription.TabIndex = 2;
            // 
            // comboStatus
            // 
            comboStatus.Dock = DockStyle.Fill;
            comboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboStatus.Enabled = false;
            comboStatus.FormattingEnabled = true;
            comboStatus.Location = new Point(3, 115);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(230, 23);
            comboStatus.TabIndex = 4;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 236);
            button1.Name = "button1";
            button1.Size = new Size(230, 40);
            button1.TabIndex = 3;
            button1.Text = "Save Changes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtPicker
            // 
            dtPicker.Dock = DockStyle.Fill;
            dtPicker.Location = new Point(3, 206);
            dtPicker.MaxDate = new DateTime(2098, 12, 31, 0, 0, 0, 0);
            dtPicker.MinDate = new DateTime(2022, 1, 1, 0, 0, 0, 0);
            dtPicker.Name = "dtPicker";
            dtPicker.Size = new Size(230, 23);
            dtPicker.TabIndex = 5;
            // 
            // comboPriority
            // 
            comboPriority.Dock = DockStyle.Fill;
            comboPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPriority.Enabled = false;
            comboPriority.FormattingEnabled = true;
            comboPriority.Location = new Point(3, 144);
            comboPriority.Name = "comboPriority";
            comboPriority.Size = new Size(230, 23);
            comboPriority.TabIndex = 6;
            // 
            // txtDetectedName
            // 
            txtDetectedName.Dock = DockStyle.Fill;
            txtDetectedName.Location = new Point(3, 177);
            txtDetectedName.Name = "txtDetectedName";
            txtDetectedName.PlaceholderText = "DetectedBy";
            txtDetectedName.ReadOnly = true;
            txtDetectedName.Size = new Size(230, 23);
            txtDetectedName.TabIndex = 7;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Margin = new Padding(3, 3, 10, 20);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(txtNotesIssue);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(txtNotesFix);
            splitContainer3.Size = new Size(637, 276);
            splitContainer3.SplitterDistance = 141;
            splitContainer3.TabIndex = 0;
            // 
            // txtNotesIssue
            // 
            txtNotesIssue.Dock = DockStyle.Fill;
            txtNotesIssue.Location = new Point(0, 0);
            txtNotesIssue.Multiline = true;
            txtNotesIssue.Name = "txtNotesIssue";
            txtNotesIssue.PlaceholderText = "Notes about the issue";
            txtNotesIssue.Size = new Size(637, 141);
            txtNotesIssue.TabIndex = 0;
            // 
            // txtNotesFix
            // 
            txtNotesFix.Dock = DockStyle.Fill;
            txtNotesFix.Location = new Point(0, 0);
            txtNotesFix.Margin = new Padding(3, 3, 3, 20);
            txtNotesFix.Multiline = true;
            txtNotesFix.Name = "txtNotesFix";
            txtNotesFix.PlaceholderText = "Notes about the fix";
            txtNotesFix.Size = new Size(637, 131);
            txtNotesFix.TabIndex = 0;
            // 
            // BugTracker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 620);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BugTracker";
            Padding = new Padding(5);
            Text = "Bug Tracker";
            WindowState = FormWindowState.Maximized;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bugItems).EndInit();
            contextMenu.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel1.PerformLayout();
            splitContainer3.Panel2.ResumeLayout(false);
            splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip2;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem bugTrackerToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem configToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem filterToolStripMenuItem;
        private SplitContainer splitContainer1;
        private DataGridView bugItems;
        private ToolStripMenuItem enhancementsToolStripMenuItem;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private TextBox txtNotesIssue;
        private TextBox txtNotesFix;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem userManagementToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem guideToolStripMenuItem;
        private ToolStripMenuItem changesToolStripMenuItem;
        private ToolStripMenuItem productManagementToolStripMenuItem;
        private ToolStripMenuItem versionsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtID;
        private TextBox txtVersion;
        private TextBox txtDescription;
        private Button button1;
        private ComboBox comboStatus;
        private DateTimePicker dtPicker;
        private ComboBox comboPriority;
        private TextBox txtDetectedName;
        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem newItemToolStripMenuItem;
        private ToolStripMenuItem deleteItemToolStripMenuItem;
        private ToolStripMenuItem filterToolStripMenuItem1;
        private ToolStripMenuItem sortToolStripMenuItem;
        private ToolStripMenuItem ascendingToolStripMenuItem;
        private ToolStripMenuItem descendingToolStripMenuItem;
    }

}