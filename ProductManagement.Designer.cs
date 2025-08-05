namespace BugTracker
{
    partial class ProductManagement
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
            productItemsList = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            insertItemToolStripMenuItem = new ToolStripMenuItem();
            deleteItemToolStripMenuItem = new ToolStripMenuItem();
            refreshToolStripMenuItem = new ToolStripMenuItem();
            splitContainer2 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            txtProdID = new TextBox();
            txtProdVersion = new TextBox();
            txtProdNotes = new TextBox();
            txtProdTech = new TextBox();
            txtProdName = new TextBox();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productItemsList).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(productItemsList);
            splitContainer1.Panel1.Padding = new Padding(5);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Panel2.Padding = new Padding(5);
            splitContainer1.Size = new Size(480, 464);
            splitContainer1.SplitterDistance = 217;
            splitContainer1.TabIndex = 0;
            // 
            // productItemsList
            // 
            productItemsList.AllowUserToAddRows = false;
            productItemsList.AllowUserToDeleteRows = false;
            productItemsList.AllowUserToOrderColumns = true;
            productItemsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productItemsList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            productItemsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productItemsList.ContextMenuStrip = contextMenuStrip1;
            productItemsList.Dock = DockStyle.Fill;
            productItemsList.Location = new Point(5, 5);
            productItemsList.Name = "productItemsList";
            productItemsList.ReadOnly = true;
            productItemsList.RowTemplate.Height = 25;
            productItemsList.Size = new Size(468, 205);
            productItemsList.TabIndex = 0;
            productItemsList.SelectionChanged += productItems_SelectionChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { insertItemToolStripMenuItem, deleteItemToolStripMenuItem, refreshToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(135, 70);
            // 
            // insertItemToolStripMenuItem
            // 
            insertItemToolStripMenuItem.Name = "insertItemToolStripMenuItem";
            insertItemToolStripMenuItem.Size = new Size(134, 22);
            insertItemToolStripMenuItem.Text = "New Item";
            insertItemToolStripMenuItem.Click += insertItemToolStripMenuItem_Click;
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
            splitContainer2.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(btnSave);
            splitContainer2.Size = new Size(468, 231);
            splitContainer2.SplitterDistance = 188;
            splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.2136765F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.7863235F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtProdID, 0, 1);
            tableLayoutPanel1.Controls.Add(txtProdVersion, 0, 2);
            tableLayoutPanel1.Controls.Add(txtProdNotes, 0, 3);
            tableLayoutPanel1.Controls.Add(txtProdTech, 1, 2);
            tableLayoutPanel1.Controls.Add(txtProdName, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28.7425156F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 71.2574844F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tableLayoutPanel1.Size = new Size(468, 188);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(229, 24);
            label1.TabIndex = 0;
            label1.Text = "Product Management";
            // 
            // txtProdID
            // 
            txtProdID.Dock = DockStyle.Fill;
            txtProdID.Enabled = false;
            txtProdID.Location = new Point(3, 27);
            txtProdID.Name = "txtProdID";
            txtProdID.PlaceholderText = "ID";
            txtProdID.ReadOnly = true;
            txtProdID.Size = new Size(229, 23);
            txtProdID.TabIndex = 1;
            // 
            // txtProdVersion
            // 
            txtProdVersion.Dock = DockStyle.Fill;
            txtProdVersion.Location = new Point(3, 58);
            txtProdVersion.Multiline = true;
            txtProdVersion.Name = "txtProdVersion";
            txtProdVersion.PlaceholderText = "Latest Version";
            txtProdVersion.ReadOnly = true;
            txtProdVersion.Size = new Size(229, 54);
            txtProdVersion.TabIndex = 3;
            // 
            // txtProdNotes
            // 
            tableLayoutPanel1.SetColumnSpan(txtProdNotes, 2);
            txtProdNotes.Dock = DockStyle.Fill;
            txtProdNotes.Location = new Point(3, 118);
            txtProdNotes.Multiline = true;
            txtProdNotes.Name = "txtProdNotes";
            txtProdNotes.PlaceholderText = "Notes";
            txtProdNotes.ScrollBars = ScrollBars.Vertical;
            txtProdNotes.Size = new Size(462, 67);
            txtProdNotes.TabIndex = 4;
            // 
            // txtProdTech
            // 
            txtProdTech.Dock = DockStyle.Fill;
            txtProdTech.Location = new Point(238, 58);
            txtProdTech.Multiline = true;
            txtProdTech.Name = "txtProdTech";
            txtProdTech.PlaceholderText = "Technologies";
            txtProdTech.Size = new Size(227, 54);
            txtProdTech.TabIndex = 6;
            // 
            // txtProdName
            // 
            txtProdName.Dock = DockStyle.Fill;
            txtProdName.Location = new Point(238, 27);
            txtProdName.Name = "txtProdName";
            txtProdName.PlaceholderText = "Product";
            txtProdName.Size = new Size(227, 23);
            txtProdName.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.Location = new Point(0, 0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(468, 39);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // ProductManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 464);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ProductManagement";
            Text = "Product Management";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)productItemsList).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView productItemsList;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteItemToolStripMenuItem;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private ToolStripMenuItem insertItemToolStripMenuItem;
        private SplitContainer splitContainer2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox txtProdID;
        private TextBox txtProdVersion;
        private TextBox txtProdNotes;
        private TextBox txtProdTech;
        private TextBox txtProdName;
        private Button btnSave;
    }
}