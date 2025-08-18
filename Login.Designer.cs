namespace BugTracker
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            logo = new PictureBox();
            label2 = new Label();
            lblCopyright = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            btnLogin = new Button();
            txtPass = new TextBox();
            txtUser = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(logo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblCopyright);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(txtUser);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 332);
            panel1.TabIndex = 0;
            // 
            // logo
            // 
            logo.BackgroundImage = (Image)resources.GetObject("logo.BackgroundImage");
            logo.BackgroundImageLayout = ImageLayout.Zoom;
            logo.Location = new Point(217, 257);
            logo.Name = "logo";
            logo.Size = new Size(100, 66);
            logo.TabIndex = 8;
            logo.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(12, 300);
            label2.Name = "label2";
            label2.Size = new Size(206, 23);
            label2.TabIndex = 7;
            label2.Text = "Demo. For demonstration purposes";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCopyright
            // 
            lblCopyright.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCopyright.Location = new Point(12, 284);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(116, 23);
            lblCopyright.TabIndex = 5;
            lblCopyright.Text = "2025 Dexinis inc. ";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(69, 220);
            button1.Name = "button1";
            button1.Size = new Size(190, 28);
            button1.TabIndex = 4;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(69, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(69, 186);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(190, 28);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(69, 157);
            txtPass.MaxLength = 14;
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.PlaceholderText = "Password";
            txtPass.Size = new Size(190, 23);
            txtPass.TabIndex = 1;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(69, 128);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "User name";
            txtUser.Size = new Size(190, 23);
            txtUser.TabIndex = 0;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 332);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLogin;
        private TextBox txtPass;
        private TextBox txtUser;
        private PictureBox pictureBox1;
        private Button button1;
        private Label lblCopyright;
        private Label label2;
        private PictureBox logo;
    }
}