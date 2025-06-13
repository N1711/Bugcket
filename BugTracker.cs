using BugTracker.models;
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.Common;
using System.Globalization;

namespace BugTracker
{
    public partial class BugTracker : Form
    {
        private bool updateAction = false;
        private List<string> versions = new List<string>();
        public BugTracker()
        {
            InitializeComponent();
            InitializeDialog();

        }

        public void InitializeDialog()
        {
            comboStatus.Items.Clear();
            comboStatus.Items.Add("Open");
            comboStatus.Items.Add("In Progress");
            comboStatus.Items.Add("Closed");

            comboPriority.Items.Clear();
            comboPriority.Items.Add("High");
            comboPriority.Items.Add("Medium");
            comboPriority.Items.Add("Low");

            DataTable table = new DataTable();
            try
            {
                SQLiteDataAdapter items = DBOperations.getDbItems(@"SELECT b.id as id, b.description as description, b.productId as product, a.version as version, status, priority, detectedBy, dateDetected, IssueNotes, FixNotes FROM bugs as b left join products p on b.productId=p.id left join versions as a on b.id = a.productId");
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
                MessageBox.Show("Error getting data from the database", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

        }

        private void productManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ProductManagement();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (bugItems.SelectedRows.Count > 0)
            {
                string selectedId = "";
                if (selectedId.Length > 0) updateAction = true;
                if (comboStatus.SelectedIndex == 2 && updateAction)
                {
                    MessageBox.Show("The item is now closed and cannot be re-opened", "Read-only item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!updateAction)
                {
                    InsertItem();
                }
                else
                {
                    UpdateItem();
                }
            }
        }

        private void InsertItem()
        {
            try
            {
                string description = txtDescription.Text;
                int product = Int32.Parse(comboProducts.SelectedItem.ToString());
                string version = comboVersions.SelectedItem.ToString();
                string status = comboStatus.SelectedItem.ToString();
                string priority = comboPriority.SelectedItem.ToString();
                string detectedBy = txtDetectedName.Text;
                string dateDetected = dtPicker.Value.ToString();
                string notesIssue = txtNotesIssue.Text;
                string notesFix = txtNotesFix.Text;
                bool result = DBOperations.InsertBugItem(description, product, version, status, priority, detectedBy, dateDetected, notesIssue, notesFix);
                if (result)
                {
                    MessageBox.Show("Item added succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Operation failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operation failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        private void DeleteItem()
        {
            try
            {
                int id = Int32.Parse(bugItems.SelectedRows[0].Cells[0].Value.ToString());
                bool result = DBOperations.DeleteItem(id);
                if (result)
                {
                    MessageBox.Show("Item deleted succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Operation failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Operation failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

        }

        private void UpdateItem()
        {
            try
            {
                string description = txtDescription.Text;
                int product = Int32.Parse(comboProducts.SelectedItem.ToString());
                string version = comboVersions.SelectedItem.ToString();
                string status = comboStatus.SelectedItem.ToString();
                string priority = comboPriority.SelectedItem.ToString();
                string detectedBy = txtDetectedName.Text;
                string dateDetected = dtPicker.Text;
                string notesIssue = txtNotesIssue.Text;
                string notesFix = txtNotesFix.Text;
                int id = Int32.Parse(txtID.Text);
                bool result = DBOperations.UpdateBugItem(id, description, product, version, status, priority, detectedBy, dateDetected, notesIssue, notesFix);
                if (!result)
                {
                    MessageBox.Show("Item updated succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Operation failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Operation failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        private void bugItems_SelectionChanged(object sender, EventArgs e)
        {
            // Update the labels to reflect changes to the selection.
            System.Diagnostics.Debug.WriteLine("Selection changed");
            UpdateLabelText();
        }

        private void bugItems_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenu.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void UpdateLabelText()
        {
            Int32 selectedCellCount = bugItems.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                int row = bugItems.SelectedCells[0].RowIndex;
                DataGridViewRow r = bugItems.Rows[row];
                txtID.Text = r.Cells[0].Value.ToString();
                txtDescription.Text = r.Cells[2].Value.ToString();
                comboVersions.SelectedIndex = 0;
                comboProducts.SelectedIndex = 0;
                comboStatus.SelectedIndex = r.Cells[4].Value.ToString() == "Open" ? 0 : r.Cells[4].Value.ToString() == "In Progress" ? 1 : 2; 
                comboPriority.SelectedIndex = r.Cells[5].Value.ToString() == "High" ? 0 : r.Cells[5].Value.ToString() == "Medium" ? 1 : 2; 
                txtDetectedName.Text = r.Cells[6].Value.ToString();
                dtPicker.Value = DateTime.Parse(r.Cells[7].Value.ToString());
                txtNotesIssue.Text = r.Cells[8].Value.ToString(); 
                txtNotesFix.Text = r.Cells[9].Value.ToString(); 
                SetReadOnlyStatus(false);
            }
            else
            {
                txtID.Text = "";
                txtDescription.Text = "";
                comboVersions.SelectedValue = "";
                comboProducts.SelectedValue = "";
                comboStatus.SelectedValue = "";
                comboPriority.SelectedValue = "";
                txtDetectedName.Text = "";
                //dtPicker.Text = "";
                txtNotesIssue.Text = "";
                txtNotesFix.Text = "";
                SetReadOnlyStatus(true);
            }
        }

        private void SetReadOnlyStatus(bool state)
        {
            txtDescription.ReadOnly = state;
            comboVersions.Enabled = !state;
            comboProducts.Enabled = !state;
            txtDetectedName.ReadOnly = state;
            txtNotesIssue.ReadOnly = state;
            txtNotesFix.ReadOnly = state;
            dtPicker.Enabled = !state;
            comboPriority.Enabled = !state;
            comboStatus.Enabled = !state;
        }

        private void newItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> productItems = DBOperations.GetDropDown(@"Select * from products", 1);
            List<string> versionItems = DBOperations.GetDropDown(@"Select * from versions", 2);
            comboProducts.Items.Clear();
            comboVersions.Items.Clear();
            foreach (string item in productItems)
            {
                comboProducts.Items.Add(item);
            }
            foreach (string item in versionItems)
            {
                comboVersions.Items.Add(item);
            }
            txtID.Text = "";
            txtDescription.Text = "";
            comboVersions.SelectedValue = "";
            comboProducts.SelectedValue = "";
            comboStatus.SelectedIndex = 0;
            comboPriority.SelectedIndex = 0;
            txtDetectedName.Text = "";
            //dtPicker.Text = "";
            txtNotesIssue.Text = "";
            txtNotesFix.Text = "";
            SetReadOnlyStatus(false);
        }

        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }

    }
}
