using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracker
{
    public partial class Login : Form
    {
        public static bool loggedIn = false;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User.Id = 1;
            User.Name = "Admin";
            User.Role = "Admin";
            User.loggedIn = true;
            loggedIn = true;
            btnLogin.Cursor = Cursors.WaitCursor;  
            Program.SetMainForm(new BugTracker());
            Program.ShowMainForm();
            this.Close();
        }
    }
}
