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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionForm));
            splitContainer1 = new SplitContainer();
            listBox1 = new ListBox();
            btnSave = new Button();
            groupBox3 = new GroupBox();
            btnTest = new Button();
            btnBrowse = new Button();
            txtString = new TextBox();
            groupBox2 = new GroupBox();
            txtDBEncrypt = new TextBox();
            chkBox = new CheckBox();
            groupBox1 = new GroupBox();
            rbtnMongo = new RadioButton();
            rbtnEmbed = new RadioButton();
            ofDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
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
            listBox1.Items.AddRange(new object[] { "Connection" });
            listBox1.Location = new Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(118, 354);
            listBox1.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(2, 325);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(231, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnTest);
            groupBox3.Controls.Add(btnBrowse);
            groupBox3.Controls.Add(txtString);
            groupBox3.Location = new Point(4, 159);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(226, 161);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Connection Details";
            // 
            // btnTest
            // 
            btnTest.Location = new Point(5, 89);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(212, 23);
            btnTest.TabIndex = 2;
            btnTest.Text = "Test DB Connection";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(5, 60);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(212, 23);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtString
            // 
            txtString.Location = new Point(5, 26);
            txtString.Name = "txtString";
            txtString.PlaceholderText = "Connection String";
            txtString.ReadOnly = true;
            txtString.Size = new Size(212, 23);
            txtString.TabIndex = 0;
            txtString.TextChanged += txtString_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtDBEncrypt);
            groupBox2.Controls.Add(chkBox);
            groupBox2.Location = new Point(3, 69);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(227, 84);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Security";
            // 
            // txtDBEncrypt
            // 
            txtDBEncrypt.Location = new Point(6, 47);
            txtDBEncrypt.Name = "txtDBEncrypt";
            txtDBEncrypt.PasswordChar = '#';
            txtDBEncrypt.PlaceholderText = "Password";
            txtDBEncrypt.ReadOnly = true;
            txtDBEncrypt.Size = new Size(212, 23);
            txtDBEncrypt.TabIndex = 1;
            // 
            // chkBox
            // 
            chkBox.AutoSize = true;
            chkBox.Location = new Point(6, 22);
            chkBox.Name = "chkBox";
            chkBox.Size = new Size(117, 19);
            chkBox.TabIndex = 0;
            chkBox.Text = "Encrypt Database";
            chkBox.UseVisualStyleBackColor = true;
            chkBox.CheckedChanged += chkBox_CheckedChanged;
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
            rbtnMongo.CheckedChanged += rbtnMongo_CheckedChanged;
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
            // ConnectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 354);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ConnectionForm";
            Text = "ConnectionForm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private CheckBox chkBox;
        private TextBox txtDBEncrypt;
        private TextBox txtString;
        private Button btnBrowse;
        private Button btnTest;
        private OpenFileDialog ofDialog;
    }
}