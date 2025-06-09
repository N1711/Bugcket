using BugTracker.models;
using System.Data.SQLite;
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
    public partial class BugTracker : Form
    {

        public BugTracker()
        {
            InitializeComponent();
            InitializeDialog();

        }

        public void InitializeDialog()
        {
            DataTable table = new DataTable();
            try
            {
                SQLiteDataAdapter items = DBOperations.getDbItems(@"SELECT b.id, description, a.version as version, status, priority, detectedBy, dateDetected, IssueNotes, FixNotes FROM bugs as b left join versions as a on b.id = a.productId");
                if (items != null)
                {
                    items.Fill(table);
                    //for (int i = 0; i < items.FieldCount; i++)
                    //    table.Columns.Add(new DataColumn(items.GetName(i)));
                    bugItems.DataSource = table;
                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

        }

        private void productManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ProductManagement();
            form.ShowDialog();
        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
