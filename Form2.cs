using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracker
{
    public partial class Form2 : Form
    {
        public static bool connected = false;
        public static bool loading = true;
        public static bool failed = false;
        public Form2()
        {
            this.Show();
            InitializeComponent();
            InitializeConnection();
        }

        private void InitializeConnection()
        {
            Thread.Sleep(1000);
            if (DBOperations.ConnectToDB())
            {
                connected = true;
                label1.Text = "Connected!";
                loading = false;
                System.Diagnostics.Debug.WriteLine("Connected");
                Thread.Sleep(1000);
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
                
            }
            else
            {
                connected = false;
                System.Diagnostics.Debug.WriteLine("Not connected");
                label1.Text = "DB Connection failed!";
                loading = false;
                failed = true;
                this.Hide();
                ConnectionForm c = new ConnectionForm();
                c.ShowDialog();
            }
        }
    }
}
