using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MaterialSkin;
using MS.Core.ViewModels;
using System.Threading.Tasks;
using ManagementSystemClassLibrary;

namespace ManagementSystem
{
    public partial class UserControlMainMenu : UserControl
    {
        private readonly MaterialSkinManager materialSkinManager;
        private TaskManager taskManager;
        private DepartmentManager departmentManager;
        public User CurrentUser { get; set; }
        public Label NameLabel { get => labelFullName; set => labelFullName = (MaterialSkin.Controls.MaterialLabel)value; }
        public Label PositionLabel { get => labelPosition; set => labelPosition = (MaterialSkin.Controls.MaterialLabel)value; }
        public Label RatingLabel { get => ratingMaterialLabel; set => ratingMaterialLabel = (MaterialSkin.Controls.MaterialLabel)value; }
        private int colorSchemeIndex;
        private int themeIndex;
        private int lenghtOfTelephoneNumber = 10;
        private int minLenghtOfEmail = 7;
        private int minLenghtOfPassword = 6;
        private ListViewItem selectedItem;
        private string emailSubject;
        private Job task;

        public UserControlMainMenu()
        {
            InitializeComponent();
            taskManager = new TaskManager();
            departmentManager = new DepartmentManager();
            #region Config
            materialSkinManager = MaterialSkinManager.Instance;
            complexityComboBox.Font = materialSkinManager.ROBOTO_MEDIUM_11;
            priorityNumeric.Font = materialSkinManager.ROBOTO_MEDIUM_11;
            reCreateComboBox.Font = materialSkinManager.ROBOTO_MEDIUM_11;
            deadlineTimePicker.Font = materialSkinManager.ROBOTO_MEDIUM_11;
            categoryComboBox.Font = materialSkinManager.ROBOTO_MEDIUM_11;
            categoryComboBox.DataSource = departmentManager.GetDepartments();
            complexityToolTip.SetToolTip(complexityComboBox, Properties.Resources.Complexity);
            reCreationToolTip.SetToolTip(reCreateComboBox, Properties.Resources.Recreation);
            priorityToolTip.SetToolTip(priorityNumeric, Properties.Resources.Priotiry);
            deadlineToolTip.SetToolTip(deadlineTimePicker, Properties.Resources.Deadline);
            complexityComboBox.Items.AddRange(new string[]{
                Properties.Resources.Eazy,
                Properties.Resources.Medium,
                Properties.Resources.Hard
            });
            reCreateComboBox.Items.AddRange(new string[]{
                Properties.Resources.OnceADay,
                Properties.Resources.OnceAWeek,
                Properties.Resources.OnceATwoWeeks,
                Properties.Resources.OnceAMonth,
            });
            nameOfTaskTextField.Hint = Properties.Resources.NameOfTask;
            descriptionTaskTextField.Hint = Properties.Resources.DescriptionOfTask;
            createRequestButton.Text = Properties.Resources.CreateRequest;
            createTaskButton.Text = Properties.Resources.CreateTask;
            TabPageNewTask.Text = Properties.Resources.CreateNewTask;
            TabPageCurrentTasks.Text = Properties.Resources.CurrentTasks;
            TabPageMonitoring.Text = Properties.Resources.Monitoring;
            tabPageSettings.Text = Properties.Resources.Settings;
            tabPageInfo.Text = Properties.Resources.Profile;
            statisticTabPage.Text = Properties.Resources.Statistic;
            AutomaticTaskButton.Text = Properties.Resources.CreateAutomaticTask;
            StandartTaskButton.Text = Properties.Resources.CreateTask;
            addEmployeeButton.Text = Properties.Resources.AddEmployee;
            deleteEmployeeButton.Text = Properties.Resources.DeleteEmployee;
            addCategoryButton.Text = Properties.Resources.AddCategory;
            complexityComboBox.Text = Properties.Resources.Complexity;
            categoryComboBox.Text = Properties.Resources.Category;
            reCreateComboBox.Text = Properties.Resources.Cyclicity;
            buttonChangeColor.Text = Properties.Resources.ChangeColorScheme;
            buttonChangeTheme.Text = Properties.Resources.ChangeTheme;
            buttonSignOut.Text = Properties.Resources.SignOut;
            oldPasswordTextField.Hint = Properties.Resources.OldPassword;
            newPasswordTextField.Hint = Properties.Resources.NewPassword;
            newPasswordConfirmationTextField.Hint = Properties.Resources.NewPasswordConfirmation;
            changePasswordButton.Text = Properties.Resources.ChangePassword;
            incorrectPasswordLabel.Text = Properties.Resources.IncorrectPassword;
            passwordsAreNotEqualLabel.Text = Properties.Resources.PasswordNotEqual;
            tooShortPasswordLabel.Text = Properties.Resources.PasswordTooShort;
            emailTextField.Hint = Properties.Resources.Email;
            incorrectEmailLabel.Text = Properties.Resources.IncorrectEmail;
            emailSaveButton.Text = Properties.Resources.Save;
            telephoneSaveButton.Text = Properties.Resources.Save;
            telephoneNumberTextField.Hint = Properties.Resources.TelephoneNumber;
            incorrectTelephoneLabel.Text = Properties.Resources.IncorrectTelephone;
            doneToolStripMenuItem.Text = Properties.Resources.Done;
            emailSubject = Properties.Resources.NewTask;
            isReadyToolStripMenuItem.Text = Properties.Resources.CreateTask;
            tabPageSettings.Text = Properties.Resources.Settings;
            tabPageInfo.Text = Properties.Resources.Profile;
            columnCategory.Text = Properties.Resources.Category;
            columnDeadline.Text = Properties.Resources.Deadline;
            columnTaskName.Text =nameOfTask.Text= Properties.Resources.NameOfTask;
            columnTaskDescription.Text =description.Text= Properties.Resources.DescriptionOfTask;
            columnPriority.Text = Properties.Resources.Priotiry;
            complexity.Text = Properties.Resources.Complexity;
            labelColors.Text = Properties.Resources.PushToChangeColor;
            labelDoneTasks.Text = Properties.Resources.DoneTasks;
            ratingMaterialLabel.Text = Properties.Resources.YourRate;
            addCategoryButton.Text = Properties.Resources.AddCategory;
            columnType.Text = Properties.Resources.Type;
            #endregion
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        public async Task SeedListViewAsync()
        {
            try
            {
                bool Contains = false;
                ListViewTasks.Items.Clear();
                foreach (Job task in await taskManager.GetJobs())
                { 
                        foreach (ListViewItem item in ListViewTasks.Items)
                        {
                            if (item.Text == task.Name)
                            {
                                Contains = true;
                            }
                        }
                        if (!Contains)
                        {
                            if (task.State != State.Done)
                            {
                                var item = new ListViewItem(task.Name);
                                item.SubItems.Add(task.Description);
                                item.SubItems.Add(task.Priority.ToString());
                                item.SubItems.Add(task.Department.Name);
                                item.SubItems.Add(task.Deadline.Date.ToString());
                                ListViewTasks.Items.Add(item);
                                Contains = false;
                            }
                        }
                    }
            }
            catch
            {
                labelNoTasks.Visible = true;
            }
        }

        private void MaterialRaisedButtonCurrentTasks_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab(1);
        }

        private void MaterialRaisedButtonMonitoring_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab(2);
        }

        private void MaterialRaisedButtonNewTask_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab("TabPageNewTask");
        }

        private void StandartTaskButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == StandartTaskButton)
                reCreateComboBox.Visible = false;
            else if (sender == AutomaticTaskButton)
                reCreateComboBox.Visible = true;
            reCreateComboBox.Enabled = true;
            task = new Job();
            nameOfTaskTextField.Enabled = true;
            descriptionTaskTextField.Enabled = true;
            complexityComboBox.Enabled = true;
            categoryComboBox.Enabled = true;
            priorityNumeric.Enabled = true;
        }

        public void Translate()
        {
            complexityToolTip.SetToolTip(complexityComboBox, Properties.Resources.Complexity);
            reCreationToolTip.SetToolTip(reCreateComboBox, Properties.Resources.Recreation);
            priorityToolTip.SetToolTip(priorityNumeric, Properties.Resources.Priotiry);
            deadlineToolTip.SetToolTip(deadlineTimePicker, Properties.Resources.Deadline);
            if (complexityComboBox.Items.Count > 0)
            {
                complexityComboBox.Items.Clear();
            }
            complexityComboBox.Items.AddRange(new string[]{
                Properties.Resources.Eazy,
                Properties.Resources.Medium,
                Properties.Resources.Hard
            });
            if (reCreateComboBox.Items.Count > 0)
            {
                reCreateComboBox.Items.Clear();
            }
            reCreateComboBox.Items.AddRange(new string[]{
                Properties.Resources.OnceADay,
                Properties.Resources.OnceAWeek,
                Properties.Resources.OnceATwoWeeks,
                Properties.Resources.OnceAMonth,
            });
            nameOfTaskTextField.Hint = Properties.Resources.NameOfTask;
            descriptionTaskTextField.Hint = Properties.Resources.DescriptionOfTask;
            createRequestButton.Text = Properties.Resources.CreateRequest;
            createTaskButton.Text = Properties.Resources.CreateTask;
            TabPageNewTask.Text = Properties.Resources.CreateNewTask;
            TabPageCurrentTasks.Text = Properties.Resources.CurrentTasks;
            TabPageMonitoring.Text = Properties.Resources.Monitoring;
            statisticTabPage.Text = Properties.Resources.Statistic;
            AutomaticTaskButton.Text = Properties.Resources.CreateAutomaticTask;
            StandartTaskButton.Text = Properties.Resources.CreateTask;
            addEmployeeButton.Text = Properties.Resources.Add;
            deleteEmployeeButton.Text = Properties.Resources.Delete;
            complexityComboBox.Text = Properties.Resources.Complexity;
            categoryComboBox.Text = Properties.Resources.Category;
            reCreateComboBox.Text = Properties.Resources.Cyclicity;
            buttonChangeColor.Text = Properties.Resources.ChangeColorScheme;
            buttonChangeTheme.Text = Properties.Resources.ChangeTheme;
            buttonSignOut.Text = Properties.Resources.SignOut;
            oldPasswordTextField.Hint = Properties.Resources.OldPassword;
            newPasswordTextField.Hint = Properties.Resources.NewPassword;
            newPasswordConfirmationTextField.Hint = Properties.Resources.NewPasswordConfirmation;
            changePasswordButton.Text = Properties.Resources.ChangePassword;
            incorrectPasswordLabel.Text = Properties.Resources.IncorrectPassword;
            passwordsAreNotEqualLabel.Text = Properties.Resources.PasswordNotEqual;
            tooShortPasswordLabel.Text = Properties.Resources.PasswordTooShort;
            emailTextField.Hint = Properties.Resources.Email;
            incorrectEmailLabel.Text = Properties.Resources.IncorrectEmail;
            emailSaveButton.Text = Properties.Resources.Save;
            telephoneSaveButton.Text = Properties.Resources.Save;
            telephoneNumberTextField.Hint = Properties.Resources.TelephoneNumber;
            incorrectTelephoneLabel.Text = Properties.Resources.IncorrectTelephone;
            labelDoneTasks.Text = Properties.Resources.DoneTasks;
            ratingMaterialLabel.Text = Properties.Resources.Rating;
            doneToolStripMenuItem.Text = Properties.Resources.Done;
            emailSubject = Properties.Resources.NewTask;
            isReadyToolStripMenuItem.Text = Properties.Resources.CreateTask;
            tabPageSettings.Text = Properties.Resources.Settings;
            tabPageInfo.Text = Properties.Resources.Profile;
            columnCategory.Text = Properties.Resources.Category;
            columnDeadline.Text = Properties.Resources.Deadline;
            columnTaskName.Text = nameOfTask.Text = Properties.Resources.NameOfTask;
            columnTaskDescription.Text = description.Text = Properties.Resources.DescriptionOfTask;
            columnPriority.Text = Properties.Resources.Priotiry;
            complexity.Text = Properties.Resources.Complexity;
            labelColors.Text = Properties.Resources.PushToChangeColor;
            labelDoneTasks.Text = Properties.Resources.DoneTasks;
            ratingMaterialLabel.Text = Properties.Resources.YourRate;
            addCategoryButton.Text = Properties.Resources.AddCategory;
            columnType.Text = Properties.Resources.Type;
        }

        private void CreateTaskButton_ClickAsync(object sender, EventArgs e)
        {
            task.State = State.NotSelected;
            if (AutomaticTaskButton.Checked == true)
            {
                task = new Job();
                string time = reCreateComboBox.SelectedItem as string;
                switch (time) {
                    case "OnceADay":
                        task.ReCreationTime = ReCreationTime.OnceADay;
                        break;
                    case "OnceAWeek":
                        task.ReCreationTime = ReCreationTime.OnceAWeek;
                        break;
                    case "OnceAMonth":
                        task.ReCreationTime = ReCreationTime.OnceAMonth;
                        break;
                }
               
            }
            if (!String.IsNullOrEmpty((complexityComboBox.SelectedItem as string)))
            {
                if ((complexityComboBox.SelectedItem as string) == Properties.Resources.Eazy)
                {
                    task.Complexity = 1;
                }
                else if ((complexityComboBox.SelectedItem as string) == Properties.Resources.Medium)
                {
                    task.Complexity = 2;
                }
                else if ((complexityComboBox.SelectedItem as string) == Properties.Resources.Hard)
                {
                    task.Complexity = 3;
                }
            }
            if (!String.IsNullOrEmpty(nameOfTaskTextField.Text))
                task.Name = nameOfTaskTextField.Text;
            if (!String.IsNullOrEmpty(descriptionTaskTextField.Text))
                task.Description = descriptionTaskTextField.Text;
            if (!String.IsNullOrEmpty(categoryComboBox.Text))
                task.Department = categoryComboBox.SelectedItem as Department;
            task.Priority = (Priority)(priorityNumeric.Value);
            task.Deadline = deadlineTimePicker.Value;
            if (task != null)
                taskManager.DisributeTask(CurrentUser.Department,task);
            SeedListViewAsync();
            nameOfTask.Text = "";
            description.Text = "";
            deadlineTimePicker.Value = DateTime.Today;
            priorityNumeric.Value = 0;
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            (Form.ActiveForm as ManagementSystemForm).MainPanel.Controls.Remove((Form.ActiveForm as ManagementSystemForm).UserControlMainMenu);
            (Form.ActiveForm as ManagementSystemForm).MainPanel.Controls.Add((Form.ActiveForm as ManagementSystemForm).AddControl);
            (Form.ActiveForm as ManagementSystemForm).AddControl.Translate();
        }

        private void ButtonChangeTheme_Click(object sender, EventArgs e)
        {
            themeIndex++;
            if (themeIndex > 1) themeIndex = 0;

            switch (themeIndex)
            {
                case 0:
                    materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                    labelFullName.ForeColor = labelPosition.ForeColor = System.Drawing.Color.Black;
                    break;
                case 1:
                    materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                    labelFullName.ForeColor = labelPosition.ForeColor = System.Drawing.Color.White;
                    break;
            }
        }
        private void ButtonChangeColor_Click(object sender, EventArgs e)
        {
            colorSchemeIndex++;
            if (colorSchemeIndex > 3) colorSchemeIndex = 0;

            switch (colorSchemeIndex)
            {
                case 0:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
                    break;
                case 1:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan700, Primary.Cyan900, Primary.Cyan100, Accent.Pink200, TextShade.WHITE);
                    break;
                case 2:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple600, Primary.DeepPurple700, Primary.DeepPurple200, Accent.DeepPurple100, TextShade.WHITE);
                    break;
                case 3:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal700, Primary.Teal900, Primary.Teal100, Accent.Pink200, TextShade.WHITE);
                    break;
            }
        }

        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            (Form.ActiveForm as ManagementSystemForm).MainPanel.Controls.Remove((Form.ActiveForm as ManagementSystemForm).UserControlMainMenu);
            (Form.ActiveForm as ManagementSystemForm).MainPanel.Controls.Add((Form.ActiveForm as ManagementSystemForm).DeleteControl);
            (Form.ActiveForm as ManagementSystemForm).DeleteControl.Translate();
        }

        private void ButtonSignOut_Click(object sender, EventArgs e)
        {
            (Form.ActiveForm as ManagementSystemForm).MainPanel.Controls.Add((Form.ActiveForm as ManagementSystemForm).AuthorityUserControl);
            (Form.ActiveForm as ManagementSystemForm).MainPanel.Controls.Remove((Form.ActiveForm as ManagementSystemForm).UserControlMainMenu);
            (Form.ActiveForm as ManagementSystemForm).AuthorityUserControl.Visible = true;

        }

        private void DeadlineTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if ((sender as DateTimePicker).Value.Year < DateTime.Today.Year)
            {
                (sender as DateTimePicker).Value = DateTime.Today;
            }
            else if ((sender as DateTimePicker).Value.Month < DateTime.Today.Month && (sender as DateTimePicker).Value.Year == DateTime.Today.Year)
            {
                (sender as DateTimePicker).Value = DateTime.Today;
            }
        }

        private void ReCreateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty((reCreateComboBox.SelectedItem as string)))
            {
                deadlineTimePicker.Value = DateTime.Today;
                if ((reCreateComboBox.SelectedItem as string) == Properties.Resources.OnceADay)
                {
                    deadlineTimePicker.Value = deadlineTimePicker.Value.AddDays(1);
                }
                else if ((reCreateComboBox.SelectedItem as string) == Properties.Resources.OnceAWeek)
                {
                    deadlineTimePicker.Value = deadlineTimePicker.Value.AddDays(7);
                }
                else if ((reCreateComboBox.SelectedItem as string) == Properties.Resources.OnceATwoWeeks)
                {
                    deadlineTimePicker.Value = deadlineTimePicker.Value.AddDays(14);
                }
                else if ((reCreateComboBox.SelectedItem as string) == Properties.Resources.OnceAMonth)
                {
                    deadlineTimePicker.Value = deadlineTimePicker.Value.AddMonths(1);
                }
            }
        }

        private void PriorityNumeric_ValueChanged(object sender, EventArgs e)
        {
            task.Priority = (Priority)priorityNumeric.Value;
        }

        public void ListDoneTaskView()
        {
            if (CurrentUser.Jobs != null)
            {
                ListDoneTask.Items.Clear();
                int count = 0;
                bool Contains = false;
                foreach (var task in CurrentUser.Jobs.TakeWhile(x=>x.State == State.Done))
                {
                        foreach (ListViewItem item in ListDoneTask.Items)
                        {
                            if (item.Text == task.Name)
                            {
                                Contains = true;
                            }
                        }
                        if (!Contains)
                        {
                            count++;
                            ListViewItem newitem = new ListViewItem(count.ToString());
                            newitem.SubItems.Add(task.Name);
                            newitem.SubItems.Add(task.Description);
                            newitem.SubItems.Add(task.Complexity.ToString());
                            ListDoneTask.Items.Add(newitem);
                            Contains = false;
                        }
                }
            }
        }

        private void ProfilePictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.BMP; *.JPG; *.JPEG; *.GIF; *.PNG)| *.BMP; *.JPG; *.JPEG; *.GIF; *.PNG | All files (*.*)|*.*";
            Bitmap image;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image = new Bitmap(openFileDialog.FileName);
                    profilePictureBox.Size = image.Size;
                    profilePictureBox.Image = image;
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void AccessContoll(int accessLevel)
        {
            switch (accessLevel)
            {
                case 1:
                    addEmployeeButton.Visible = false;
                    deleteEmployeeButton.Visible = false;
                    addCategoryButton.Visible = false;
                    createTaskButton.Visible = false;
                    TabControl.TabPages.Remove(TabPageMonitoring);
                    break;
                case 2:
                    addEmployeeButton.Visible = false;
                    deleteEmployeeButton.Visible = false;
                    addCategoryButton.Visible = false;
                    createTaskButton.Visible = true;
                    TabControl.TabPages.Remove(TabPageMonitoring);
                    break;
                case 3:
                    addEmployeeButton.Visible = true;
                    deleteEmployeeButton.Visible = true;
                    addCategoryButton.Visible = true;
                    createTaskButton.Visible = true;
                    isReadyToolStripMenuItem.Visible = true;
                    TabControl.TabPages.Remove(TabPageMonitoring);
                    break;
            }
        }

        private void ListViewTasks_MouseClick(object sender, MouseEventArgs e)
        {
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    selectedItem = (sender as ListView).GetItemAt(e.X, e.Y);
                    if (selectedItem != null)
                    {
                        selectedItem.Selected = true;
                        isDoneContextMenuStrip.Show((sender as ListView), e.Location);
                    }
                }
            
        }

        private void DoneToolStripMenuItem_ClickAsync(object sender, EventArgs e)
        {
            foreach(var task in CurrentUser.Jobs)
            {
                if (task.Name == selectedItem.Text)
                {
                    if (task.State == State.NotSelected)
                    {
                        taskManager.DisributeTask(CurrentUser.Department,task);
                    }
                    task.State = State.Done;
                    ListDoneTaskView();
                    SeedListViewAsync();
                    break;
                }
            }
        }
    
        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            (Form.ActiveForm as ManagementSystemForm).MainPanel.Controls.Remove((Form.ActiveForm as ManagementSystemForm).UserControlMainMenu);
            (Form.ActiveForm as ManagementSystemForm).MainPanel.Controls.Add((Form.ActiveForm as ManagementSystemForm).CategoryControl);
            (Form.ActiveForm as ManagementSystemForm).CategoryControl.Translate();
        }

    }
}
