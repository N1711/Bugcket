namespace BugTracker
{
    partial class AboutForm
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
            label1 = new Label();
            listBoxCredits = new ListBox();
            txtCredits = new TextBox();
            lblAgreement = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(171, 35);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 0;
            label1.Text = "Logo";
            // 
            // listBoxCredits
            // 
            listBoxCredits.FormattingEnabled = true;
            listBoxCredits.ItemHeight = 15;
            listBoxCredits.Items.AddRange(new object[] { "About", "Technologies", "Programming", "UI" });
            listBoxCredits.Location = new Point(12, 71);
            listBoxCredits.Name = "listBoxCredits";
            listBoxCredits.Size = new Size(120, 334);
            listBoxCredits.TabIndex = 1;
            listBoxCredits.SelectedIndexChanged += listBoxCredits_SelectedIndexChanged;
            // 
            // txtCredits
            // 
            txtCredits.Location = new Point(146, 72);
            txtCredits.Multiline = true;
            txtCredits.Name = "txtCredits";
            txtCredits.ReadOnly = true;
            txtCredits.Size = new Size(248, 333);
            txtCredits.TabIndex = 2;
            // 
            // lblAgreement
            // 
            lblAgreement.Dock = DockStyle.Bottom;
            lblAgreement.Location = new Point(0, 408);
            lblAgreement.Name = "lblAgreement";
            lblAgreement.Size = new Size(406, 32);
            lblAgreement.TabIndex = 3;
            lblAgreement.Text = "For demonstration purposes. Dexinis 2025";
            lblAgreement.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 440);
            Controls.Add(lblAgreement);
            Controls.Add(txtCredits);
            Controls.Add(listBoxCredits);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AboutForm";
            Text = "About Bugcket";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBoxCredits;
        private TextBox txtCredits;
        private Label lblAgreement;
    }
}