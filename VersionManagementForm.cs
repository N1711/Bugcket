using BugTracker.models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace BugTracker
{
    public partial class VersionManagementForm : Form
    {
        private DataTable table = new DataTable();
        private BindingList<PriorityModel> pDropDown = new BindingList<PriorityModel>();
        public VersionManagementForm()
        {
            InitializeComponent();
            InitializeItems();
        }

        public void InitializeItems()
        {
            comboVersionProducts.DataSource = pDropDown;
            comboVersionProducts.DisplayMember = "Name";
            comboVersionProducts.ValueMember = "id";

            try
            {
                SQLiteDataAdapter items = DBOperations.getDbItems(@"Select v.id as id, p.description as product, v.version from versions v join products p on p.id = v.productId LIMIT 10");
                if (items != null)
                {
                    items.Fill(table);
                    //for (int i = 0; i < items.FieldCount; i++)
                    //    table.Columns.Add(new DataColumn(items.GetName(i)));
                    dataGridVersions.DataSource = table;
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void dataGridVersions_SelectionChanged(object sender, EventArgs e)
        {
            // Update the labels to reflect changes to the selection.
            UpdateLabelText();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                InsertVersionItem();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InsertVersionItem()
        {
            try
            {
                int product = Int32.Parse(comboVersionProducts.SelectedValue.ToString());
                string productName = comboVersionProducts.GetItemText(comboVersionProducts.SelectedItem);
                string version = txtVersionVer.Text;
                long result = DBOperations.InsertVersionItem(product, version);
                if (result > 0)
                {
                    MessageBox.Show("Item added succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataRow r = table.NewRow();
                    r[0] = result;
                    r[1] = productName;
                    r[2] = version;
                    table.Rows.Add(r);
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

        private void DeleteVersionItem()
        {
            Int32 selectedCellCount = dataGridVersions.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                int row = dataGridVersions.SelectedCells[0].RowIndex;
                DataGridViewRow r = dataGridVersions.Rows[row];
                try
                {
                    int id = Int32.Parse(r.Cells[0].Value.ToString());
                    bool result = DBOperations.DeleteVersionItem(id);
                    if (result)
                    {
                        MessageBox.Show("Item deleted succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridVersions.Rows.Remove(r);
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

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table.Clear();
            dataGridVersions.DataSource = null;
            InitializeItems();
        }

        private void versionItems_SelectionChanged(object sender, EventArgs e)
        {
            // Update the labels to reflect changes to the selection.
            UpdateLabelText();
        }

        private void UpdateLabelText()
        {
            Int32 selectedCellCount = dataGridVersions.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                int row = dataGridVersions.SelectedCells[0].RowIndex;
                DataGridViewRow r = dataGridVersions.Rows[row];
                txtVersionID.Text = r.Cells[0].Value.ToString();
                List<PriorityModel> productItems = DBOperations.GetDropDown(@"Select * from products where description = " + "\"" + r.Cells[1].Value.ToString() + "\"", 1);
                pDropDown.Clear();
                pDropDown.Add(productItems.Count() > 0 ? productItems[0] : new PriorityModel(0, "Error"));
                comboVersionProducts.SelectedIndex = 0;
                txtVersionVer.Text = r.Cells[2].Value.ToString();
            }
        }

        private void newItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                List<PriorityModel> productItems = DBOperations.GetDropDown(@"Select * from products", 1);
                pDropDown.Clear();
                foreach (PriorityModel item in productItems)
                {
                    pDropDown.Add(item);
                }
                comboVersionProducts.DataSource = pDropDown;
                comboVersionProducts.DisplayMember = "Name";
                comboVersionProducts.ValueMember = "id";
                txtVersionID.Text = "";
                txtVersionVer.Text = "";
        }

        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteVersionItem();
        }

    }
}
