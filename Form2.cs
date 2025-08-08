using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            InitializeComponent();
            InitializeConnection();
        }

        private void InitializeConnection()
        {
            if (DBOperations.ConnectToDB())
            {
                //Thread.Sleep(5000);
                connected = true;
                label1.Text = "Connected!";
                loading = false;
                System.Diagnostics.Debug.WriteLine("Connected");
                Program.SetMainForm(new Login());
                Program.ShowMainForm();
                this.Close();
            }
            else
            {
                connected = false;
                System.Diagnostics.Debug.WriteLine("Not connected");
                label1.Text = "DB Connection failed!";
                loading = false;
                failed = true;
                Program.SetMainForm(new ConnectionForm());
                Program.ShowMainForm();
                this.Close();
            }
        }
    }
}
