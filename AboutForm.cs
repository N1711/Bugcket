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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void listBoxCredits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCredits.SelectedIndex == 0)
            {
                txtCredits.Text = "A bug and enhancements logging system created to capture bugs / security issues and potential enhancements to an existing software.\r\n" +
                    "Built for demonstration purposes only, there might be some missing functionality which might not be fixed in the future. \r\n\r\nTo whom it may concern: feel free to copy / modify the project and adapt it to your needs." +
                    "The creator of Bugcket uses it to log and track bugs / enhancement for their own projects. \r\n\r\nThis code is not legally bound and can be used freely. \r\n\r\nThis code is 100% human generated.";
            }
            else if (listBoxCredits.SelectedIndex == 1)
            {
                txtCredits.Text = "Core Language: C#\r\nDatabase: SQLite & MongoDB";
            }
            else if (listBoxCredits.SelectedIndex == 2 || listBoxCredits.SelectedIndex == 3)
            {

                txtCredits.Text = "Stoyan 'Dexinis' Georgiev\r\nsg@dexinis.com\r\n\r\nFor full portfolio visit https://github.com/N1711";
            } else
            {
                txtCredits.Text = "";
            }
        }
    }
}
