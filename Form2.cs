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
using System.Timers;
using System.Runtime.CompilerServices;
using DnsClient;

namespace BugTracker
{
    public partial class Form2 : Form
    {
        int waitSeconds = 3;
        public Form2()
        {
            InitializeComponent();
            //show the form, it will be closed once the connection has been initiated. It will close after waitSeconds has expired
            this.Show();
            progressBar1.Value = 10;
            InitializeConnection();
        }

        private void InitializeConnection()
        {
            //a bit of an ugly hack - allows form loading whilst running the background task of connecting to db.
            Application.DoEvents();
            try
            {
                if (DBOperations.ConnectToDB())
                {
                    progressBar1.Value = 100;
                    label1.Text = "Application loaded";
                    //show the form for a minimum time, allows the user to see the product image and developer
                    CloseMe();
                    progressBar1.Value = 0;
                }
                else
                {
                    progressBar1.Value = 50;
                    label1.Text = "Application failed";
                    CloseMe();
                    progressBar1.Value = 0;
                    ConnectionForm c = new ConnectionForm();
                    c.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                progressBar1.Value = 0;
                CloseMe();
                MessageBox.Show("Error connecting to the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseMe()
        {
            WaitNSeconds(waitSeconds);
        }

        private void WaitNSeconds(int segundos)
        {
            if (segundos < 1) return;
            DateTime _desired = DateTime.Now.AddSeconds(segundos);
            //do not pause form loading meanwhile
            while (DateTime.Now < _desired)
            {
                Application.DoEvents();
            }
            //close after the time has elapsed
            this.Close();
        }
    }
}
