using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracker
{
    public partial class UserManagementForm : Form
    {
        private DataTable table = new DataTable();
        public UserManagementForm()
        {
            InitializeComponent();
            InitializeItems();
        }

        public void InitializeItems()
        {
            try
            {
                SQLiteDataAdapter items = DBOperations.getDbItems(@"Select id,name,accessLevel from users LIMIT 10");
                if (items != null)
                {
                    items.Fill(table);
                    //for (int i = 0; i < items.FieldCount; i++)
                    //    table.Columns.Add(new DataColumn(items.GetName(i)));
                    dataGridUsers.DataSource = table;
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void newItemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridUsers_SelectionChanged(object sender, EventArgs e)
        {
            UpdateLabelText();
        }

        private void UpdateLabelText()
        {
            Int32 selectedCellCount = dataGridUsers.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                int row = dataGridUsers.SelectedCells[0].RowIndex;
                DataGridViewRow r = dataGridUsers.Rows[row];
                txtUserID.Text = r.Cells[0].Value.ToString();
                txtUserAccess.Text = "Access Level: " + r.Cells[2].Value.ToString() == "1" ? "admin" : "user";
                txtUserName.Text = r.Cells[1].Value.ToString();

            }
            else
            {
                txtUserID.Text = "";
                txtUserAccess.Text = "";
                txtUserName.Text = "";
            }
        }
    }
}
