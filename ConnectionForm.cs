using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BugTracker
{
    public partial class ConnectionForm : Form
    {
        public ConnectionForm()
        {
            InitializeComponent();
            if (DBOperations.GetSetting("type") == "sql" || DBOperations.GetSetting("type") == "" || DBOperations.GetSetting("type") == null)
            {
                rbtnEmbed.Checked = true;
                btnBrowse.Enabled = true;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ofDialog.Filter = "Database files(*.db) | *.db";
            if (ofDialog.ShowDialog() == DialogResult.OK)
            {
                txtString.Text = ofDialog.FileName;
            }
        }

        private void chkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox.Checked)
            {
                txtDBEncrypt.ReadOnly = false;
            }
            else
            {
                txtDBEncrypt.ReadOnly = true;
            }
        }

        private void rbtnMongo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMongo.Checked)
            {
                btnBrowse.Enabled = false;
                txtString.ReadOnly = false;
                rbtnEmbed.Checked = false;
            }
            else
            {
                btnBrowse.Enabled = true;
                txtString.ReadOnly = true;
                rbtnEmbed.Checked = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DBOperations.SetSetting("database", txtString.Text);
            DBOperations.SetSetting("type", rbtnMongo.Checked ? "mongo" : "sql");
            MessageBox.Show("Bug tracker needs to restart", "App restart required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Windows.Forms.Application.Restart();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (rbtnEmbed.Checked)
            {
                if (DBOperations.ConnectToDB())
                {
                    MessageBox.Show("Successfully connected to the database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSave.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Database Connection Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSave.Enabled = false;
                }
            }
            else
            {
                if (DBOperations.ConnectToMongoDB())
                {
                    MessageBox.Show("Database Connection Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSave.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Database Connection Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSave.Enabled = false;
                }
            }
        }

        private void txtString_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }
    }
}
