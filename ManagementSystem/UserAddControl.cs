using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using ManagementSystemClassLibrary;

namespace ManagementSystem
{
    public partial class UserAddControl : UserControl
    {
        public int numberForParsing;
        private UserManager serviceUserAdd;
        private readonly MaterialSkinManager materialSkinManager;
        private DepartmentManager departmentManager;
        public UserAddControl()
        {
            InitializeComponent();
            departmentManager = new DepartmentManager();
            materialSkinManager = MaterialSkinManager.Instance;
            categoryComboBox.Font = materialSkinManager.ROBOTO_MEDIUM_11;
            categoryLabel.Font = materialSkinManager.ROBOTO_MEDIUM_11;
            dateOfBirthLabel.Font = materialSkinManager.ROBOTO_MEDIUM_11;
            dateOfBirthPicker.Font= materialSkinManager.ROBOTO_MEDIUM_11;
            categoryComboBox.DataSource = departmentManager.GetDepartments();
            
            
            serviceUserAdd = new UserManager();
            fullNameLineTextField.Hint = Properties.Resources.FullName;
            //ageLineTextField.Hint = Properties.Resources.Age;
            dateOfBirthLabel.Text = Properties.Resources.DateOfBirth;
            accessLevelLineTextField.Hint = Properties.Resources.AccessLevel;
            loginLineTextField.Hint = Properties.Resources.Login;
            //passwordLineTextField.Hint = Properties.Resources.Password;
            positionLineTextField.Hint = Properties.Resources.Position;
            ratingLineTextField.Hint = Properties.Resources.Rating;
            fillErrorLabel.Text = Properties.Resources.FillError;
            fillInputErrorLabel.Text = Properties.Resources.IncorrectValue;
            fillLoginErrorLabel.Text = Properties.Resources.LoginError;
            addUserButton.Text = Properties.Resources.Add;
            CancelFromAddUserButton.Text = Properties.Resources.Cancel;
            categoryLabel.Text = Properties.Resources.Category;
        }

        public void Translate()
        {
            fullNameLineTextField.Hint = Properties.Resources.FullName;
            //ageLineTextField.Hint = Properties.Resources.Age;
            dateOfBirthLabel.Text = Properties.Resources.DateOfBirth;
            accessLevelLineTextField.Hint = Properties.Resources.AccessLevel;
            loginLineTextField.Hint = Properties.Resources.Login;
            //passwordLineTextField.Hint = Properties.Resources.Password;
            positionLineTextField.Hint = Properties.Resources.Position;
            ratingLineTextField.Hint = Properties.Resources.Rating;
            fillErrorLabel.Text = Properties.Resources.FillError;
            fillInputErrorLabel.Text = Properties.Resources.IncorrectValue;
            fillLoginErrorLabel.Text = Properties.Resources.LoginError;
            addUserButton.Text = Properties.Resources.Add;
            CancelFromAddUserButton.Text = Properties.Resources.Cancel;
            categoryLabel.Text = Properties.Resources.Category;
        }

        private void AddUserButton_ClickAsync(object sender, EventArgs e)
        {
            if (
                !(fullNameLineTextField.Text == "") &&
                //!(ageLineTextField.Text == "") &&
                !(accessLevelLineTextField.Text == "") &&
                !(loginLineTextField.Text == "") &&
                //!(passwordLineTextField.Text == "") &&
                !(positionLineTextField.Text == "") &&
                !(ratingLineTextField.Text == "")
                )
            {
                if (//Int32.TryParse(ageLineTextField.Text, out numberForParsing) &&
                    Int32.TryParse(accessLevelLineTextField.Text, out numberForParsing) &&
                    Int32.TryParse(ratingLineTextField.Text, out numberForParsing)
                    )
                {
                    if (//Int32.Parse(ageLineTextField.Text)>14 && 
                        //Int32.Parse(ageLineTextField.Text) < 100 &&
                       Int32.Parse(accessLevelLineTextField.Text) > 0 &&
                       Int32.Parse(accessLevelLineTextField.Text) < 4)
                    {
                        User user = new User();
                        user.FirstName = fullNameLineTextField.Text;
                        //user.Age = Int32.Parse(ageLineTextField.Text);
                        user.AccessModifier = Int32.Parse(accessLevelLineTextField.Text);
                        user.Email = loginLineTextField.Text;
                        user.Password = "1111";
                        user.Position = positionLineTextField.Text;
                        user.Rating = Int32.Parse(ratingLineTextField.Text);
                        user.BirthDate = dateOfBirthPicker.Value;
                        user.Department = categoryComboBox.SelectedItem as Department;
                        serviceUserAdd.CreateUser(user);

                        fillLoginErrorLabel.Visible = false;
                        fillInputErrorLabel.Visible = false;
                        fillErrorLabel.Visible = false;

                        fullNameLineTextField.Text = "";
                        accessLevelLineTextField.Text = "";
                        loginLineTextField.Text = "";
                        positionLineTextField.Text = "";
                        ratingLineTextField.Text = "";

                        (Form.ActiveForm as ManagementSystemForm).MainPanel.Controls.Remove((Form.ActiveForm as ManagementSystemForm).AddControl);
                        (Form.ActiveForm as ManagementSystemForm).MainPanel.Controls.Add((Form.ActiveForm as ManagementSystemForm).UserControlMainMenu);
                    }

                    else
                    {
                        fillInputErrorLabel.Visible = true;
                    }
                }

                else
                {
                    fillInputErrorLabel.Visible = true;
                }
            }
            else
            {
                fillErrorLabel.Visible = true;
            }
        }

        private void CancelFromAddUserButton_Click(object sender, EventArgs e)
        {
            fullNameLineTextField.Text = "";
            accessLevelLineTextField.Text = "";
            loginLineTextField.Text = "";
            positionLineTextField.Text = "";
            ratingLineTextField.Text = "";

            (Form.ActiveForm as ManagementSystemForm).MainPanel.Controls.Remove((Form.ActiveForm as ManagementSystemForm).AddControl);
            (Form.ActiveForm as ManagementSystemForm).MainPanel.Controls.Add((Form.ActiveForm as ManagementSystemForm).UserControlMainMenu);
        }

    }
}
