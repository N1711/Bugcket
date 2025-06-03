namespace BugTracker
{
    partial class Form1
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
            helpToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            dataGridView1 = new DataGridView();
            splitContainer2 = new SplitContainer();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            splitContainer3 = new SplitContainer();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            refreshDataToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
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
            menuStrip2.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, bugTrackerToolStripMenuItem, enhancementsToolStripMenuItem, reportsToolStripMenuItem, refreshDataToolStripMenuItem });
            menuStrip2.Location = new Point(0, 61);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.RenderMode = ToolStripRenderMode.Professional;
            menuStrip2.Size = new Size(132, 559);
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
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1019, 61);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(43, 57);
            newToolStripMenuItem.Text = "New";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(52, 57);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // filterToolStripMenuItem
            // 
            filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            filterToolStripMenuItem.Size = new Size(45, 57);
            filterToolStripMenuItem.Text = "Filter";
            // 
            // configToolStripMenuItem
            // 
            configToolStripMenuItem.Name = "configToolStripMenuItem";
            configToolStripMenuItem.Size = new Size(55, 57);
            configToolStripMenuItem.Text = "Config";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 57);
            helpToolStripMenuItem.Text = "Help";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(132, 61);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(887, 559);
            splitContainer1.SplitterDistance = 292;
            splitContainer1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(887, 292);
            dataGridView1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(comboBox2);
            splitContainer2.Panel1.Controls.Add(comboBox1);
            splitContainer2.Panel1.Controls.Add(dateTimePicker1);
            splitContainer2.Panel1.Controls.Add(textBox6);
            splitContainer2.Panel1.Controls.Add(textBox5);
            splitContainer2.Panel1.Controls.Add(textBox4);
            splitContainer2.Panel1.Controls.Add(textBox3);
            splitContainer2.Panel1.Controls.Add(label7);
            splitContainer2.Panel1.Controls.Add(label6);
            splitContainer2.Panel1.Controls.Add(label5);
            splitContainer2.Panel1.Controls.Add(label4);
            splitContainer2.Panel1.Controls.Add(label3);
            splitContainer2.Panel1.Controls.Add(label2);
            splitContainer2.Panel1.Controls.Add(label1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(splitContainer3);
            splitContainer2.Size = new Size(887, 263);
            splitContainer2.SplitterDistance = 225;
            splitContainer2.TabIndex = 13;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(109, 121);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(110, 23);
            comboBox2.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(110, 86);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(110, 23);
            comboBox1.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(109, 192);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(111, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Location = new Point(109, 225);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(111, 23);
            textBox6.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(109, 157);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(111, 23);
            textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(109, 49);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(111, 23);
            textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(109, 20);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(111, 23);
            textBox3.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 233);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 6;
            label7.Text = "Detected By";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 199);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 5;
            label6.Text = "Detected On:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 165);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 4;
            label5.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 129);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 3;
            label4.Text = "Priority";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 94);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 56);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Version";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 22);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Margin = new Padding(3, 3, 10, 3);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(textBox1);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(textBox2);
            splitContainer3.Size = new Size(658, 263);
            splitContainer3.SplitterDistance = 135;
            splitContainer3.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Notes about the issue";
            textBox1.Size = new Size(658, 135);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(0, 0);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Notes about the fix";
            textBox2.Size = new Size(658, 124);
            textBox2.TabIndex = 0;
            // 
            // refreshDataToolStripMenuItem
            // 
            refreshDataToolStripMenuItem.Name = "refreshDataToolStripMenuItem";
            refreshDataToolStripMenuItem.Size = new Size(128, 19);
            refreshDataToolStripMenuItem.Text = "Refresh Data";
            refreshDataToolStripMenuItem.Click += refreshDataToolStripMenuItem_Click;
            // 
            // Form1
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
            Name = "Form1";
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
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
        private DataGridView dataGridView1;
        private ToolStripMenuItem enhancementsToolStripMenuItem;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label6;
        private TextBox textBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private ToolStripMenuItem refreshDataToolStripMenuItem;
    }
}