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
    public partial class Guide : Form
    {
        public Guide()
        {
            InitializeComponent();
        }

        private void listBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxMenu.SelectedIndex == 0)
            {
                txtDescription.Text = "There are 7 main components of the navigation bar.\r\n\r\n" +
                    "App button -  allows the user to sign out or exit the app.\r\n\r\n" +
                    "View - allows the user to create or manage custom views using graphic interface which is then translated to a language the database is able to interpret." +
                    "This feature is current disabled as it is under development.\r\n\r\n" +
                    "Config offers several options: \r\n" +
                    "   * Settings - the database connection can be changed from this page\r\n" +
                    "   * User Management - the user management like password reset, create new user and access level can be managed here. This option is currently disabled.\r\n" +
                    "   * Product Management - this screen allows the user to add/delete products. This product will then be selectable through the bugs / enhancements tab when logging a new item.\r\n" +
                    "   * Version Management - this screen allows the user to add versions to a product\r\n\r\n" +
                    "Help - About and Guide sections can be found here.";
                pbGuide.BackgroundImage = Image.FromFile(@"Guide\nav.JPG");
                pbGuide.SizeMode = PictureBoxSizeMode.Zoom;
            }

            if (listBoxMenu.SelectedIndex == 1)
            {
                txtDescription.Text = "The app loads the items from the database and displays them in a table.\r\n" +
                    "When the selection changes, the text in the textboxes updates with the values from the table.\r\n" +
                    "The user can update the notes, status and priority and saved to the database after hitting Save.\r\n\r\n" +
                    "To insert a new item right click on the table and select New Item. This will enable the text fields and allow a new record to be saved.\n\n" +
                    "Use the filter on top to filter through records in the database.\r\n\r\n" +
                    "This screen is identical to the Enhancement screen where instead of logging a bug with a product it is a whiteboard for potential enhancement working the same way.";
                pbGuide.BackgroundImage = Image.FromFile(@"Guide\bugs.JPG");
                pbGuide.SizeMode = PictureBoxSizeMode.Zoom;
            }

            if (listBoxMenu.SelectedIndex == 2)
            {
                txtDescription.Text = "Allows the user (if admin) to run sql / mongodb commands. Update, delete, union and drop are not allowed.\r\n\r\n" +
                    "The output will be shown in the table on the right. The query can be saved and the table can be exported via the buttons under Run.";
                pbGuide.BackgroundImage = Image.FromFile(@"Guide\reports.JPG");
                pbGuide.SizeMode = PictureBoxSizeMode.Zoom;
            }

            if (listBoxMenu.SelectedIndex == 3)
            {
                txtDescription.Text = "Allows the user to manage products, versions, users and database connections.";
                pbGuide.BackgroundImage = Image.FromFile(@"Guide\config.JPG");
                pbGuide.SizeMode = PictureBoxSizeMode.Zoom;
            }

            if(listBoxMenu.SelectedIndex == -1)
            {
                pbGuide.BackgroundImage = Image.FromFile(@"Guide\splash.png");
                pbGuide.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
