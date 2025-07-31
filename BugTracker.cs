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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.AxHost;

namespace BugTracker
{
    public partial class BugTracker : Form
    {
        private bool updateAction = false;
        private List<string> versions = new List<string>();
        private BindingList<PriorityModel> pDropDown = new BindingList<PriorityModel>();
        private BindingList<PriorityModel> vDropDown = new BindingList<PriorityModel>();
        private DataTable table = new DataTable();
        private DataTable reportTable = new DataTable();
        public string lastQuery = "";
        public BugTracker()
        {
            InitializeComponent();
            InitializeDialog();

        }

        private void BugTracker_Load(object sender, EventArgs e)
        {
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Left = 0;
            this.Top = 0;
            WindowState = FormWindowState.Normal;
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

            comboProducts.DataSource = pDropDown;
            comboProducts.DisplayMember = "Name";
            comboProducts.ValueMember = "id";
            comboVersions.DataSource = vDropDown;
            comboVersions.DisplayMember = "Name";
            comboVersions.ValueMember = "id";

            try
            {
                SQLiteDataAdapter items = DBOperations.getDbItems(@"SELECT b.id as id, b.description as description, p.description as product, a.version as version, status, priority, detectedBy, dateDetected, IssueNotes, FixNotes FROM bugs as b left join products p on b.productId=p.id left join versions as a on a.id = b.versionId where status = 'Open'");
                if (items != null)
                {
                    items.Fill(table);
                    //for (int i = 0; i < items.FieldCount; i++)
                    //    table.Columns.Add(new DataColumn(items.GetName(i)));
                    bugItems.DataSource = table;
                    label1.Text = "Open Items: " + bugItems.Rows.Count.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting data from the database", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex.Message);
            }

        }

        private void productManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ProductManagement();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            try
            {
                if (int.TryParse(txtID.Text, out id))
                {
                    UpdateItem();
                }
                else
                {
                    InsertItem();
                }

            }
            catch (Exception ex)
            {
                InsertItem();
            }

        }

        private void InsertItem()
        {
            try
            {
                string description = txtDescription.Text;
                int product = Int32.Parse(comboProducts.SelectedValue.ToString());
                string productName = comboProducts.GetItemText(comboProducts.SelectedItem);
                int version = Int32.Parse(comboVersions.SelectedValue.ToString());
                string versionName = comboVersions.GetItemText(comboVersions.SelectedItem);
                string status = comboStatus.SelectedItem.ToString();
                string priority = comboPriority.SelectedItem.ToString();
                string detectedBy = txtDetectedName.Text;
                string dateDetected = dtPicker.Value.ToString();
                string notesIssue = txtNotesIssue.Text;
                string notesFix = txtNotesFix.Text;
                long result = DBOperations.InsertBugItem(description, product, version, status, priority, detectedBy, dateDetected, notesIssue, notesFix);
                if (result > 0)
                {
                    MessageBox.Show("Item added succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataRow r = table.NewRow();
                    r[0] = result;
                    r[1] = productName;
                    r[2] = versionName;
                    r[3] = description;
                    r[4] = status;
                    r[5] = priority;
                    r[6] = detectedBy;
                    r[7] = dateDetected;
                    r[8] = notesIssue;
                    r[9] = notesFix;
                    table.Rows.Add(r);
                    label1.Text = "Open Items: " + bugItems.Rows.Count.ToString();
                }
                else
                {
                    MessageBox.Show("Operation failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operation failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex.Message);
            }
        }

        private void DeleteItem()
        {
            Int32 selectedCellCount = bugItems.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                int row = bugItems.SelectedCells[0].RowIndex;
                DataGridViewRow r = bugItems.Rows[row];
                try
                {
                    int id = Int32.Parse(r.Cells[0].Value.ToString());
                    bool result = DBOperations.DeleteItem(id);
                    if (result)
                    {
                        MessageBox.Show("Item deleted succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bugItems.Rows.Remove(r);
                        label1.Text = "Open Items: " + bugItems.Rows.Count.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Operation failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Operation failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Debug.WriteLine(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("You must select at least one item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UpdateItem()
        {
            try
            {
                string description = txtDescription.Text;
                string status = comboStatus.SelectedItem.ToString();
                string priority = comboPriority.SelectedItem.ToString();
                string notesIssue = txtNotesIssue.Text;
                string notesFix = txtNotesFix.Text;
                int id = Int32.Parse(txtID.Text);
                bool result = DBOperations.UpdateBugItem(id, description, status, priority, notesIssue, notesFix);
                if (result)
                {
                    MessageBox.Show("Item updated succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataRow r = table.Rows[bugItems.SelectedCells[0].RowIndex];
                    r[3] = description;
                    r[4] = status;
                    r[5] = priority;
                    r[8] = notesIssue;
                    r[9] = notesFix;
                }
                else
                {
                    MessageBox.Show("Operation failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Operation failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex.Message);
            }
        }

        private void bugItems_SelectionChanged(object sender, EventArgs e)
        {
            // Update the labels to reflect changes to the selection.
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
                txtDescription.Text = r.Cells[1].Value.ToString();
                List<PriorityModel> productItems = DBOperations.GetDropDown(@"Select * from products where description = " + "\"" + r.Cells[2].Value.ToString() + "\"", 1);
                List<PriorityModel> versionItems = DBOperations.GetDropDown(@"Select * from versions where version = " + "\"" + r.Cells[3].Value.ToString() + "\"", 2);
                pDropDown.Clear();
                pDropDown.Add(productItems.Count() > 0 ? productItems[0] : new PriorityModel(0, "Error"));
                comboProducts.SelectedIndex = 0;
                vDropDown.Add(versionItems.Count() > 0 ? versionItems[0] : new PriorityModel(0, "Error"));
                comboVersions.SelectedIndex = 0;
                comboStatus.SelectedIndex = r.Cells[4].Value.ToString() == "Open" ? 0 : r.Cells[4].Value.ToString() == "In Progress" ? 1 : 2;
                comboPriority.SelectedIndex = r.Cells[5].Value.ToString() == "High" ? 0 : r.Cells[5].Value.ToString() == "Medium" ? 1 : 2;
                txtDetectedName.Text = r.Cells[6].Value.ToString();
                dtPicker.Value = DateTime.Parse(r.Cells[7].Value.ToString());
                txtNotesIssue.Text = r.Cells[8].Value.ToString();
                txtNotesFix.Text = r.Cells[9].Value.ToString();
                if (r.Cells[4].Value.ToString() == "Closed")
                {
                    txtDescription.ReadOnly = true;
                    comboVersions.Enabled = false;
                    comboProducts.Enabled = false;
                    txtDetectedName.ReadOnly = true;
                    txtNotesIssue.ReadOnly = true;
                    txtNotesFix.ReadOnly = true;
                    dtPicker.Enabled = false;
                    comboPriority.Enabled = false;
                    comboStatus.Enabled = false;
                }
                SetReadOnlyStatus(false, false);
            }
            else
            {
                txtID.Text = "";
                txtDescription.Text = "";
                pDropDown.Clear();
                vDropDown.Clear();
                comboStatus.SelectedValue = "";
                comboPriority.SelectedValue = "";
                txtDetectedName.Text = "";
                //dtPicker.Text = "";
                txtNotesIssue.Text = "";
                txtNotesFix.Text = "";
                SetReadOnlyStatus(true, false);
            }
        }

        private void SetReadOnlyStatus(bool state, bool newItem)
        {
            txtDescription.ReadOnly = state;
            comboVersions.Enabled = newItem ? true : state;
            comboProducts.Enabled = newItem ? true : state;
            txtDetectedName.ReadOnly = newItem ? false : !state;
            txtNotesIssue.ReadOnly = state;
            txtNotesFix.ReadOnly = state;
            dtPicker.Enabled = newItem ? true : state;
            comboPriority.Enabled = !state;
            comboStatus.Enabled = !state;
        }

        private void newItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<PriorityModel> productItems = DBOperations.GetDropDown(@"Select * from products", 1);
            List<PriorityModel> versionItems = DBOperations.GetDropDown(@"Select * from versions", 2);
            pDropDown.Clear();
            vDropDown.Clear();
            foreach (PriorityModel item in productItems)
            {
                pDropDown.Add(item);
            }
            foreach (PriorityModel item in versionItems)
            {
                vDropDown.Add(item);
            }
            comboProducts.DataSource = pDropDown;
            comboProducts.DisplayMember = "Name";
            comboProducts.ValueMember = "id";
            comboVersions.DataSource = vDropDown;
            comboVersions.DisplayMember = "Name";
            comboVersions.ValueMember = "id";
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
            SetReadOnlyStatus(false, true);
        }

        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settingsForm = new ConnectionForm();
            settingsForm.ShowDialog();
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userManagementForm = new UserManagementForm();
            userManagementForm.ShowDialog();
        }

        private void versionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var versionForm = new VersionManagementForm();
            versionForm.ShowDialog();
        }

        private void btnReportRun_Click(object sender, EventArgs e)
        {
            if (txtReportQuery.Text.Length < 10 || txtReportQuery.Text.ToUpper().Contains("UPDATE") || txtReportQuery.Text.ToUpper().Contains("DELETE")
                || txtReportQuery.Text.ToUpper().Contains("DROP") || !txtReportQuery.Text.ToUpper().Contains("SELECT")) return;
            lastQuery = txtReportQuery.Text;
            dataGridReport.DataSource = null;
            try
            {
                SQLiteDataAdapter items = DBOperations.getDbItems(txtReportQuery.Text);
                if (items != null)
                {
                    items.Fill(reportTable);
                    //for (int i = 0; i < items.FieldCount; i++)
                    //    table.Columns.Add(new DataColumn(items.GetName(i)));
                    dataGridReport.DataSource = reportTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Report run failed", "Report error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex.Message);
            }

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bugItems.Refresh();
        }
    }
}
