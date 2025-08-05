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
    public partial class ProductManagement : Form
    {
        private DataTable table = new DataTable();
        public ProductManagement()
        {
            InitializeComponent();
            InitializeItems();

        }

        public void InitializeItems()
        {
            try
            {
                SQLiteDataAdapter items = DBOperations.getDbItems(@"Select * from products LIMIT 10");
                if (items != null)
                {
                    items.Fill(table);
                    //for (int i = 0; i < items.FieldCount; i++)
                    //    table.Columns.Add(new DataColumn(items.GetName(i)));
                    productItemsList.DataSource = table;
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id;
            try
            {
                if (int.TryParse(txtProdID.Text, out id))
                {
                    UpdateProductItem();
                }
                else
                {
                    InsertProductItem();
                }

            }
            catch (Exception ex)
            {
                InsertProductItem();
            }
        }

        private void productItems_SelectionChanged(object sender, EventArgs e)
        {
            // Update the labels to reflect changes to the selection.
            UpdateLabelText();
        }

        private void UpdateLabelText()
        {
            Int32 selectedCellCount = productItemsList.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                int row = productItemsList.SelectedCells[0].RowIndex;
                DataGridViewRow r = productItemsList.Rows[row];
                txtProdID.Text = r.Cells[0].Value.ToString();
                txtProdName.Text = r.Cells[1].Value.ToString();
                string productVersion = r.Cells[0].Value.ToString() == null ? "" : DBOperations.GetProductItemVersion(Int32.Parse(r.Cells[0].Value.ToString()));
                txtProdVersion.Text = productVersion;
                txtProdNotes.Text = r.Cells[2].Value.ToString();
                txtProdTech.Text = r.Cells[3].Value.ToString();

            }
            else
            {
                txtProdID.Text = "";
                txtProdVersion.Text = "";
                txtProdNotes.Text = "";
                txtProdTech.Text = "";
                txtProdName.Text = "";
            }
        }

        private void insertItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtProdNotes.Text = "";
            txtProdVersion.Text = "";
            txtProdTech.Text = "";
            txtProdName.Text = "";
        }

        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteProductItem();
        }

        private void InsertProductItem()
        {
            try
            {
                string description = txtProdName.Text;
                string notes = txtProdNotes.Text;
                string technology = txtProdTech.Text;
                long result = DBOperations.InsertProductItem(description, notes, technology);
                if (result > 0)
                {
                    MessageBox.Show("Item added succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataRow r = table.NewRow();
                    r[0] = result;
                    r[1] = description;
                    r[2] = notes;
                    r[3] = technology;
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

        private void DeleteProductItem()
        {
            Int32 selectedCellCount = productItemsList.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                int row = productItemsList.SelectedCells[0].RowIndex;
                DataGridViewRow r = productItemsList.Rows[row];
                try
                {
                    int id = Int32.Parse(r.Cells[0].Value.ToString());
                    bool result = DBOperations.DeleteProductItem(id);
                    if (result)
                    {
                        MessageBox.Show("Item deleted succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        productItemsList.Rows.Remove(r);
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

        private void UpdateProductItem()
        {
            try
            {
                string description = txtProdName.Text;
                string notes = txtProdNotes.Text;
                string technology = txtProdTech.Text;
                int id = Int32.Parse(txtProdID.Text);
                bool result = DBOperations.UpdateProductItem(id, description, notes, technology);
                if (result)
                {
                    MessageBox.Show("Item updated succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataRow r = table.Rows[productItemsList.SelectedCells[0].RowIndex];
                    r[1] = description;
                    r[2] = notes;
                    r[3] = technology;
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

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table.Clear();
            productItemsList.DataSource = null;
            InitializeItems();
        }
    }
}
