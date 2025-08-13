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
            Form2 f = new Form2();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User.Id = 1;
            User.Name = "Admin";
            User.Role = "Admin";
            User.loggedIn = true;
            loggedIn = true;
            btnLogin.Cursor = Cursors.WaitCursor;
            BugTracker b = new BugTracker();
            b.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
