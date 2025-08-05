namespace BugTracker
{
    partial class ConnectionForm
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
            splitContainer1 = new SplitContainer();
            listBox1 = new ListBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            btnSave = new Button();
            rbtnEmbed = new RadioButton();
            rbtnMongo = new RadioButton();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnBrowse = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(listBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnSave);
            splitContainer1.Panel2.Controls.Add(groupBox3);
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(355, 354);
            splitContainer1.SplitterDistance = 118;
            splitContainer1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "General", "Connection", "Security" });
            listBox1.Location = new Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(118, 354);
            listBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnMongo);
            groupBox1.Controls.Add(rbtnEmbed);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(227, 60);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Connection";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Location = new Point(3, 69);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(227, 84);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Security";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnBrowse);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Location = new Point(4, 159);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(226, 161);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Connection Details";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(2, 325);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(231, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // rbtnEmbed
            // 
            rbtnEmbed.AutoSize = true;
            rbtnEmbed.Location = new Point(21, 26);
            rbtnEmbed.Name = "rbtnEmbed";
            rbtnEmbed.Size = new Size(75, 19);
            rbtnEmbed.TabIndex = 0;
            rbtnEmbed.TabStop = true;
            rbtnEmbed.Text = "Embeded";
            rbtnEmbed.UseVisualStyleBackColor = true;
            // 
            // rbtnMongo
            // 
            rbtnMongo.AutoSize = true;
            rbtnMongo.Location = new Point(125, 26);
            rbtnMongo.Name = "rbtnMongo";
            rbtnMongo.Size = new Size(79, 19);
            rbtnMongo.TabIndex = 1;
            rbtnMongo.TabStop = true;
            rbtnMongo.Text = "MongoDB";
            rbtnMongo.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 22);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(117, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Encrypt Database";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 47);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Password";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(212, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(5, 26);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Connection String";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(212, 23);
            textBox2.TabIndex = 0;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(5, 60);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(212, 23);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            // 
            // ConnectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 354);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "ConnectionForm";
            Text = "ConnectionForm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ListBox listBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Button btnSave;
        private RadioButton rbtnMongo;
        private RadioButton rbtnEmbed;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnBrowse;
    }
}