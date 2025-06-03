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
        private bool connected = false;
        public Form2()
        {
            InitializeComponent();
            this.Show();
            if (DBOperations.ConnectToDB())
            {
                Thread.Sleep(5000);
                connected = true;
                label1.Text = "Connected!";
                System.Diagnostics.Debug.WriteLine("Connected");
                this.Close();

            }
            else
            {
                connected = false;
                System.Diagnostics.Debug.WriteLine("Not connected");
                label1.Text = "DB Connection failed!";
                this.Close();
            }
        }

    }
}
