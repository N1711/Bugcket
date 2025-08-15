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
using Excel = Microsoft.Office.Interop.Excel;

namespace BugTracker
{
    public partial class BugTracker : Form
    {
        private bool updateAction = false;
        private List<string> versions = new List<string>();
        private BindingList<PriorityModel> pDropDown = new BindingList<PriorityModel>();
        private BindingList<PriorityModel> vDropDown = new BindingList<PriorityModel>();
        private BindingList<PriorityModel> pEnDropDown = new BindingList<PriorityModel>();
        private BindingList<PriorityModel> vEnDropDown = new BindingList<PriorityModel>();
        private DataTable table = new DataTable();
        private DataTable enhancementTable = new DataTable();
        private DataTable reportTable = new DataTable();
        public string lastQuery = "";
        public BugTracker()
        {
            if (!User.loggedIn)
            {
                Login l = new Login();
                l.ShowDialog();
                this.Close();
                return;
            }
            InitializeComponent();
            InitializeDialog();
            InitializeEnhancementDialog();

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

            comboView.Items.Clear();
            comboView.Items.Add("All Items");
            comboView.Items.Add("Custom View");
            comboView.SelectedIndex = 0;

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

        public void InitializeEnhancementDialog()
        {
            comboEnStatus.Items.Clear();
            comboEnStatus.Items.Add("Open");
            comboEnStatus.Items.Add("In Progress");
            comboEnStatus.Items.Add("Closed");

            comboViewEn.Items.Clear();
            comboViewEn.Items.Add("All Items");
            comboViewEn.Items.Add("Custom View");
            comboViewEn.SelectedIndex = 0;

            comboEnPriority.Items.Clear();
            comboEnPriority.Items.Add("High");
            comboEnPriority.Items.Add("Medium");
            comboEnPriority.Items.Add("Low");

            comboEnProduct.DataSource = pEnDropDown;
            comboEnProduct.DisplayMember = "Name";
            comboEnProduct.ValueMember = "id";
            comboEnVersion.DataSource = vEnDropDown;
            comboEnVersion.DisplayMember = "Name";
            comboEnVersion.ValueMember = "id";

            try
            {
                SQLiteDataAdapter items = DBOperations.getDbItems(@"SELECT b.id as id, b.description as description, p.description as product, a.version as version, status, priority, detectedBy, dateDetected, b.notes FROM enhancements as b left join products p on b.productId=p.id left join versions as a on a.id = b.versionId where status = 'Open'");
                if (items != null)
                {
                    items.Fill(enhancementTable);
                    //for (int i = 0; i < items.FieldCount; i++)
                    //    table.Columns.Add(new DataColumn(items.GetName(i)));
                    enhancementItems.DataSource = enhancementTable;
                    txtOpenItemsEn.Text = "Open Items: " + enhancementItems.Rows.Count.ToString();
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

        private void btnSaveEn_Click(object sender, EventArgs e)
        {
            int id;
            try
            {
                if (int.TryParse(txtEnID.Text, out id))
                {
                    UpdateEnhancementItem();
                }
                else
                {
                    InsertEnhancementItem();
                }

            }
            catch (Exception ex)
            {
                InsertEnhancementItem();
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

        private void InsertEnhancementItem()
        {
            try
            {
                string description = txtEnDescription.Text;
                int product = Int32.Parse(comboEnProduct.SelectedValue.ToString());
                string productName = comboEnProduct.GetItemText(comboEnProduct.SelectedItem);
                int version = Int32.Parse(comboEnVersion.SelectedValue.ToString());
                string versionName = comboEnVersion.GetItemText(comboEnVersion.SelectedItem);
                string status = comboEnStatus.SelectedItem.ToString();
                string priority = comboEnPriority.SelectedItem.ToString();
                string detectedBy = txtEnDetected.Text;
                string dateDetected = dtDetected.Value.ToString();
                string notes = txtEnNotes.Text;
                long result = DBOperations.InsertEnhancementItem(description, product, version, status, priority, detectedBy, dateDetected, notes);
                if (result > 0)
                {
                    MessageBox.Show("Item added succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataRow r = enhancementTable.NewRow();
                    r[0] = result;
                    r[1] = productName;
                    r[2] = versionName;
                    r[3] = description;
                    r[4] = status;
                    r[5] = priority;
                    r[6] = detectedBy;
                    r[7] = dateDetected;
                    r[8] = notes;
                    enhancementTable.Rows.Add(r);
                    txtOpenItemsEn.Text = "Open Items: " + enhancementItems.Rows.Count.ToString();
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

        private void DeleteEnhancementItem()
        {
            Int32 selectedCellCount = enhancementItems.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                int row = enhancementItems.SelectedCells[0].RowIndex;
                DataGridViewRow r = enhancementItems.Rows[row];
                try
                {
                    int id = Int32.Parse(r.Cells[0].Value.ToString());
                    bool result = DBOperations.DeleteEnhancementItem(id);
                    if (result)
                    {
                        MessageBox.Show("Item deleted succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        enhancementItems.Rows.Remove(r);
                        txtOpenItemsEn.Text = "Open Items: " + enhancementItems.Rows.Count.ToString();
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

        private void UpdateEnhancementItem()
        {
            try
            {
                string description = txtEnDescription.Text;
                string status = comboEnStatus.SelectedItem.ToString();
                string priority = comboEnPriority.SelectedItem.ToString();
                string notes = txtEnNotes.Text;
                int id = Int32.Parse(txtEnID.Text);
                bool result = DBOperations.UpdateEnhancementItem(id, description, status, priority, notes);
                if (result)
                {
                    MessageBox.Show("Item updated succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataRow r = enhancementTable.Rows[enhancementItems.SelectedCells[0].RowIndex];
                    r[3] = description;
                    r[4] = status;
                    r[5] = priority;
                    r[8] = notes;
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

        private void enhancementItems_SelectionChanged(object sender, EventArgs e)
        {
            // Update the labels to reflect changes to the selection.
            UpdateEnhancementText();
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

        private void UpdateEnhancementText()
        {
            Int32 selectedCellCount = enhancementItems.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                int row = enhancementItems.SelectedCells[0].RowIndex;
                DataGridViewRow r = enhancementItems.Rows[row];
                txtEnID.Text = r.Cells[0].Value.ToString();
                txtEnDescription.Text = r.Cells[1].Value.ToString();
                List<PriorityModel> productItems = DBOperations.GetDropDown(@"Select * from products where description = " + "\"" + r.Cells[2].Value.ToString() + "\"", 1);
                List<PriorityModel> versionItems = DBOperations.GetDropDown(@"Select * from versions where version = " + "\"" + r.Cells[3].Value.ToString() + "\"", 2);
                pEnDropDown.Clear();
                pEnDropDown.Add(productItems.Count() > 0 ? productItems[0] : new PriorityModel(0, "Error"));
                comboEnProduct.SelectedIndex = 0;
                vEnDropDown.Add(versionItems.Count() > 0 ? versionItems[0] : new PriorityModel(0, "Error"));
                comboEnVersion.SelectedIndex = 0;
                comboEnStatus.SelectedIndex = r.Cells[4].Value.ToString() == "Open" ? 0 : r.Cells[4].Value.ToString() == "In Progress" ? 1 : 2;
                comboEnPriority.SelectedIndex = r.Cells[5].Value.ToString() == "High" ? 0 : r.Cells[5].Value.ToString() == "Medium" ? 1 : 2;
                txtEnDetected.Text = r.Cells[6].Value.ToString();
                dtDetected.Value = DateTime.Parse(r.Cells[7].Value.ToString());
                txtEnNotes.Text = r.Cells[8].Value.ToString();
                if (r.Cells[4].Value.ToString() == "Closed")
                {
                    txtEnDescription.ReadOnly = true;
                    comboEnVersion.Enabled = false;
                    comboEnProduct.Enabled = false;
                    txtEnDetected.ReadOnly = true;
                    txtEnNotes.ReadOnly = true;
                    dtDetected.Enabled = false;
                    comboEnPriority.Enabled = false;
                    comboEnStatus.Enabled = false;
                }
                SetReadOnlyEnStatus(false, false);
            }
            else
            {
                txtEnID.Text = "";
                txtEnDescription.Text = "";
                pEnDropDown.Clear();
                vEnDropDown.Clear();
                comboEnStatus.SelectedValue = "";
                comboEnPriority.SelectedValue = "";
                txtEnDetected.Text = "";
                //dtPicker.Text = "";
                txtEnNotes.Text = "";
                SetReadOnlyEnStatus(true, false);
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

        private void SetReadOnlyEnStatus(bool state, bool newItem)
        {
            txtEnDescription.ReadOnly = state;
            comboEnVersion.Enabled = newItem ? true : state;
            comboEnProduct.Enabled = newItem ? true : state;
            txtEnDetected.ReadOnly = newItem ? false : !state;
            txtEnNotes.ReadOnly = state;
            dtDetected.Enabled = newItem ? true : state;
            comboEnPriority.Enabled = !state;
            comboEnStatus.Enabled = !state;
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
                || txtReportQuery.Text.ToUpper().Contains("DROP") || !txtReportQuery.Text.ToUpper().Contains("SELECT") || lastQuery == txtReportQuery.Text) return;
            lastQuery = txtReportQuery.Text;
            reportTable.Clear();
            dataGridReport.DataSource = null;

            try
            {
                SQLiteDataAdapter items = DBOperations.getDbItems(txtReportQuery.Text);
                if (items != null)
                {
                    items.Fill(reportTable);
                    dataGridReport.DataSource = reportTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Report run failed", "Report error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex.Message);
            }

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridReport.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel (.xlsx)|  *.xlsx";
                sfd.FileName = "Output.xlsx";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Unable to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            Excel.Application XcelApp = new Excel.Application();
                            Excel._Workbook workbook = XcelApp.Workbooks.Add(Type.Missing);
                            Excel._Worksheet worksheet = null;

                            worksheet = workbook.Sheets["Sheet1"];
                            worksheet = workbook.ActiveSheet;
                            worksheet.Name = "Output";
                            worksheet.Application.ActiveWindow.SplitRow = 1;
                            worksheet.Application.ActiveWindow.FreezePanes = true;

                            for (int i = 1; i < dataGridReport.Columns.Count + 1; i++)
                            {
                                worksheet.Cells[1, i] = dataGridReport.Columns[i - 1].HeaderText;
                                worksheet.Cells[1, i].Font.NAME = "Calibri";
                                worksheet.Cells[1, i].Font.Bold = true;
                                worksheet.Cells[1, i].Interior.Color = Color.Wheat;
                                worksheet.Cells[1, i].Font.Size = 12;
                            }

                            for (int i = 0; i < dataGridReport.Rows.Count; i++)
                            {
                                for (int j = 0; j < dataGridReport.Columns.Count; j++)
                                {
                                    worksheet.Cells[i + 2, j + 1] = dataGridReport.Rows[i].Cells[j].Value.ToString();
                                }
                            }

                            worksheet.Columns.AutoFit();
                            workbook.SaveAs(sfd.FileName);
                            XcelApp.Quit();

                            ReleaseObject(worksheet);
                            ReleaseObject(workbook);
                            ReleaseObject(XcelApp);

                            MessageBox.Show("Report Data Exported Successfully", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Report Data To Export", "Info");
            }
        }

        private void btnSaveQuery_Click(object sender, EventArgs e)
        {
            if (txtReportQuery.Text.Length > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text Files | *.txt";
                sfd.DefaultExt = "txt";
                sfd.FileName = "SQLQuery.txt";
                bool fileError = false;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Unable to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            Stream fileStream = sfd.OpenFile();
                            StreamWriter sw = new StreamWriter(fileStream);
                            sw.WriteLine(txtReportQuery.Text);
                            sw.Flush();
                            sw.Close();
                            MessageBox.Show("Query Exported Successfully", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nothing to export", "Info");
            }
        }

        private static void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table.Clear();
            bugItems.DataSource = null;
            InitializeDialog();
        }

        private void newItemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<PriorityModel> productItems = DBOperations.GetDropDown(@"Select * from products", 1);
            List<PriorityModel> versionItems = DBOperations.GetDropDown(@"Select * from versions", 2);
            pEnDropDown.Clear();
            vEnDropDown.Clear();
            foreach (PriorityModel item in productItems)
            {
                pEnDropDown.Add(item);
            }
            foreach (PriorityModel item in versionItems)
            {
                vEnDropDown.Add(item);
            }
            comboEnProduct.DataSource = pEnDropDown;
            comboEnProduct.DisplayMember = "Name";
            comboEnProduct.ValueMember = "id";
            comboEnVersion.DataSource = vDropDown;
            comboEnVersion.DisplayMember = "Name";
            comboEnVersion.ValueMember = "id";
            txtEnID.Text = "";
            txtEnDescription.Text = "";
            comboEnVersion.SelectedValue = "";
            comboEnProduct.SelectedValue = "";
            comboEnStatus.SelectedIndex = 0;
            comboEnPriority.SelectedIndex = 0;
            txtEnDetected.Text = "";
            //dtPicker.Text = "";
            txtEnNotes.Text = "";
            SetReadOnlyEnStatus(false, true);
        }

        private void deleteItemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteEnhancementItem();
        }

        private void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            enhancementTable.Clear();
            enhancementItems.DataSource = null;
            InitializeEnhancementDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var sql = "";
            if (txtFilter.Text.Length == 0 || txtFilter.Text.ToUpper().Contains("DROP") || txtFilter.Text.ToUpper().Contains("DELETE") || txtFilter.Text.ToUpper().Contains("UPDATE")
                || txtFilter.Text.ToUpper().Contains("UNION")) return;
            table.Clear();
            bugItems.DataSource = null;
            if (txtFilter.Text.Contains("id="))
            {
                try
                {
                    int id = Int32.Parse(txtFilter.Text.Split('=')[1]);
                    sql = @"SELECT b.id as id, b.description as description, p.description as product, a.version as version, status, priority, detectedBy, dateDetected, IssueNotes, FixNotes FROM bugs as b left join products p on b.productId=p.id left join versions as a on a.id = b.versionId where b.id = " + id;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid text", "Error");
                }
            }
            else
            {
                sql = @"SELECT b.id as id, b.description as description, p.description as product, a.version as version, status, priority, detectedBy, dateDetected, IssueNotes, FixNotes FROM bugs as b left join products p on b.productId=p.id left join versions as a on a.id = b.versionId where b.description like '" + txtFilter.Text + "' or IssueNotes like '" + txtFilter.Text + "' or FixNotes like '" + txtFilter.Text + "'";
            }
            try
            {
                SQLiteDataAdapter items = DBOperations.getDbItems(sql);
                if (items != null)
                {
                    items.Fill(table);
                    //for (int i = 0; i < items.FieldCount; i++)
                    //    table.Columns.Add(new DataColumn(items.GetName(i)));
                    bugItems.DataSource = table;
                    label1.Text = "Items: " + bugItems.Rows.Count.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting data from the database", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex.Message);
            }
        }

        private void bFilterEn_Click(object sender, EventArgs e)
        {
            var sql = "";
            if (txtFilterEn.Text.Length == 0 || txtFilterEn.Text.ToUpper().Contains("DROP") || txtFilterEn.Text.ToUpper().Contains("DELETE") || txtFilterEn.Text.ToUpper().Contains("UPDATE")
                || txtFilterEn.Text.ToUpper().Contains("UNION")) return;
            enhancementTable.Clear();
            enhancementItems.DataSource = null;
            if (txtFilter.Text.Contains("id="))
            {
                try
                {
                    int id = Int32.Parse(txtFilterEn.Text.Split('=')[1]);
                    sql = @"SELECT b.id as id, b.description as description, p.description as product, a.version as version, status, priority, detectedBy, dateDetected, b.notes FROM enhancements as b left join products p on b.productId=p.id left join versions as a on a.id = b.versionId where b.id = " + id;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid text", "Error");
                }
            }
            else
            {
                sql = @"SELECT b.id as id, b.description as description, p.description as product, a.version as version, status, priority, detectedBy, dateDetected, b.notes FROM enhancements as b left join products p on b.productId=p.id left join versions as a on a.id = b.versionId where b.description like '" + txtFilterEn.Text + "' or notes like '" + txtFilterEn.Text + "'";
            }
            try
            {
                SQLiteDataAdapter items = DBOperations.getDbItems(sql);
                if (items != null)
                {
                    items.Fill(enhancementTable);
                    //for (int i = 0; i < items.FieldCount; i++)
                    //    table.Columns.Add(new DataColumn(items.GetName(i)));
                    enhancementItems.DataSource = enhancementTable;
                    txtOpenItemsEn.Text = "Items: " + enhancementItems.Rows.Count.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting data from the database", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex.Message);
            }
        }

        private void BugTracker_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.loggedIn = false;
            User.Name = null;
            User.accessLevel = 0;
            User.bypass = false;
            Login l = new Login();
            this.Close();
            l.ShowDialog();
        }
    }
}
