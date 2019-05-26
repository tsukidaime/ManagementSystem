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
    public partial class AddCategoryControl : UserControl
    {
        private Department category;
        private DepartmentManager departmentManager;

        public AddCategoryControl()
        {
            InitializeComponent();
            departmentManager = new DepartmentManager();
            category = new Department();
            categoryTextField.Hint = Properties.Resources.NewCategory;
            backToMainMenuButton.Text = Properties.Resources.Back;
            addCategoryButton.Text = Properties.Resources.Add;
            deleteCategoryButton.Text = Properties.Resources.Delete;
            categoryComboBox.DataSource = departmentManager.GetDepartments();
        }

        public void Translate()
        {
            categoryTextField.Hint = Properties.Resources.NewCategory;
            backToMainMenuButton.Text = Properties.Resources.Back;
            addCategoryButton.Text = Properties.Resources.Add;
            deleteCategoryButton.Text = Properties.Resources.Delete;
        }

        private void BackToMainMenuButton_Click(object sender, EventArgs e)
        {
            categoryTextField.Text = "";
            (Form.ActiveForm as ManagementSystemForm).MainPanel.Controls.Remove((Form.ActiveForm as ManagementSystemForm).CategoryControl);
            (Form.ActiveForm as ManagementSystemForm).MainPanel.Controls.Add((Form.ActiveForm as ManagementSystemForm).UserControlMainMenu);
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(categoryTextField.Text)) {
            }
        }

        private void DeleteCategoryButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(categoryComboBox.Text))
            {
            }
        }
    }
}
