using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementSystemClassLibrary;

namespace ManagementSystem
{
    public partial class UserDeleteControl : UserControl
    {
        private User[] users;
        private int amountOfUsersOnScreen = 8;
        private int page;
        private long chosedID;
        public UserDeleteControl()
        {
            InitializeComponent();
            page = 1;
            chosedID = -1;
            deleteUserButton.Text = Properties.Resources.Delete;
            cancelFromDeleteUserButton.Text = Properties.Resources.Cancel;
            backButton.Text = Properties.Resources.Back;
            nextButton.Text = Properties.Resources.Next;
            pageLabel.Text = page.ToString();

            users = new User[amountOfUsersOnScreen];
        }

        public void Translate()
        {
            deleteUserButton.Text = Properties.Resources.Delete;
            cancelFromDeleteUserButton.Text = Properties.Resources.Cancel;
            backButton.Text = Properties.Resources.Back;
            nextButton.Text = Properties.Resources.Next;
        }

       
    }
}
