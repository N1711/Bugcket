using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracker
{
    public partial class Login : Form
    {
        public static bool loggedIn = false;
        public static bool loading = true;
        public Login()
        {
            InitializeComponent();
            InitializeConnection();
        }

        private void InitializeConnection()
        {
            if(!DBOperations.ConnectToDB())
            {
                MessageBox.Show("Error loading database", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            if(!DBOperations.DefaultUserExists())
            {
                if(!DBOperations.CreateDefaultUser())
                {
                    MessageBox.Show("Failed to initialize database", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            Form2 f = new Form2();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(DBOperations.LoginUser(txtUser.Text, txtPass.Text))
            {
                loggedIn = true;
                btnLogin.Cursor = Cursors.WaitCursor;
                BugTracker b = new BugTracker();
                b.ShowDialog();
                this.Close();
            } else
            {
                MessageBox.Show("Invalid Login Credentials", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
