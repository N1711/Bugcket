namespace BugTracker
{
    partial class UserManagementForm
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
            dataGridUsers = new DataGridView();
            splitContainer2 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            splitContainer4 = new SplitContainer();
            txtUserID = new TextBox();
            txtUserAccess = new TextBox();
            txtUserName = new TextBox();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsers).BeginInit();
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
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridUsers);
            splitContainer1.Panel1.Padding = new Padding(5);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Panel2.Padding = new Padding(5);
            splitContainer1.Size = new Size(366, 371);
            splitContainer1.SplitterDistance = 251;
            splitContainer1.TabIndex = 1;
            // 
            // dataGridUsers
            // 
            dataGridUsers.AllowUserToAddRows = false;
            dataGridUsers.AllowUserToDeleteRows = false;
            dataGridUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUsers.Dock = DockStyle.Fill;
            dataGridUsers.Location = new Point(5, 5);
            dataGridUsers.Name = "dataGridUsers";
            dataGridUsers.RowTemplate.Height = 25;
            dataGridUsers.Size = new Size(356, 241);
            dataGridUsers.TabIndex = 0;
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
            splitContainer2.Size = new Size(356, 106);
            splitContainer2.SplitterDistance = 58;
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
            splitContainer3.Panel1.Controls.Add(splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(txtUserName);
            splitContainer3.Size = new Size(356, 58);
            splitContainer3.SplitterDistance = 25;
            splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.Location = new Point(0, 0);
            splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(txtUserID);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(txtUserAccess);
            splitContainer4.Size = new Size(356, 25);
            splitContainer4.SplitterDistance = 80;
            splitContainer4.TabIndex = 0;
            // 
            // txtUserID
            // 
            txtUserID.Dock = DockStyle.Fill;
            txtUserID.Enabled = false;
            txtUserID.Location = new Point(0, 0);
            txtUserID.Name = "txtUserID";
            txtUserID.PlaceholderText = "ID";
            txtUserID.ReadOnly = true;
            txtUserID.Size = new Size(80, 23);
            txtUserID.TabIndex = 0;
            // 
            // txtUserAccess
            // 
            txtUserAccess.Dock = DockStyle.Fill;
            txtUserAccess.Enabled = false;
            txtUserAccess.Location = new Point(0, 0);
            txtUserAccess.Name = "txtUserAccess";
            txtUserAccess.PlaceholderText = "Access Level";
            txtUserAccess.ReadOnly = true;
            txtUserAccess.Size = new Size(272, 23);
            txtUserAccess.TabIndex = 0;
            // 
            // txtUserName
            // 
            txtUserName.Dock = DockStyle.Fill;
            txtUserName.Enabled = false;
            txtUserName.Location = new Point(0, 0);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "User Name";
            txtUserName.ReadOnly = true;
            txtUserName.Size = new Size(356, 23);
            txtUserName.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.Location = new Point(0, 0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(356, 44);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // UserManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 371);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "UserManagementForm";
            Text = "User Management";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridUsers).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel1.PerformLayout();
            splitContainer4.Panel2.ResumeLayout(false);
            splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private DataGridView dataGridUsers;
        private Button btnSave;
        private SplitContainer splitContainer4;
        private TextBox txtUserName;
        private TextBox txtUserID;
        private TextBox txtUserAccess;
    }
}