using BugTracker.models;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public void openDialog()
        {
            try
            {
                List<BugModelSQL> items = DBOperations.getBugItems();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

        }

        private void refreshDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDialog();
        }
    }
}
