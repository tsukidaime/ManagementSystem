namespace ManagementSystem
{
    partial class UserControlMainMenu
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlMainMenu));
            this.complexityToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.priorityToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.deadlineToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.reCreationToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.labelPosition = new MaterialSkin.Controls.MaterialLabel();
            this.labelFullName = new MaterialSkin.Controls.MaterialLabel();
            this.menuTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.TabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.TabPageNewTask = new System.Windows.Forms.TabPage();
            this.reCreateComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.complexityComboBox = new System.Windows.Forms.ComboBox();
            this.deadlineTimePicker = new System.Windows.Forms.DateTimePicker();
            this.createTaskButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.createRequestButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.StandartTaskButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.priorityNumeric = new System.Windows.Forms.NumericUpDown();
            this.descriptionTaskTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.nameOfTaskTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.AutomaticTaskButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.TabPageCurrentTasks = new System.Windows.Forms.TabPage();
            this.labelNoTasks = new MaterialSkin.Controls.MaterialLabel();
            this.ListViewTasks = new MaterialSkin.Controls.MaterialListView();
            this.columnTaskName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTaskDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPriority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDeadline = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isDoneContextMenuStrip = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.doneToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.isReadyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabPageMonitoring = new System.Windows.Forms.TabPage();
            this.statisticTabPage = new System.Windows.Forms.TabPage();
            this.ratingMaterialLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ListDoneTask = new MaterialSkin.Controls.MaterialListView();
            this.numberOfTask = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameOfTask = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.complexity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textRatingMaterialLabel = new MaterialSkin.Controls.MaterialLabel();
            this.labelDoneTasks = new System.Windows.Forms.Label();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.buttonSignOut = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonChangeColor = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonChangeTheme = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelColors = new MaterialSkin.Controls.MaterialLabel();
            this.tabPageInfo = new System.Windows.Forms.TabPage();
            this.incorrectTelephoneLabel = new MaterialSkin.Controls.MaterialLabel();
            this.incorrectEmailLabel = new MaterialSkin.Controls.MaterialLabel();
            this.tooShortPasswordLabel = new MaterialSkin.Controls.MaterialLabel();
            this.passwordsAreNotEqualLabel = new MaterialSkin.Controls.MaterialLabel();
            this.incorrectPasswordLabel = new MaterialSkin.Controls.MaterialLabel();
            this.telephoneSaveButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.emailSaveButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.telephoneNumberTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.emailTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.changePasswordButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.newPasswordConfirmationTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.newPasswordTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.oldPasswordTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.addEmployeeButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.userMenuPanel = new System.Windows.Forms.Panel();
            this.addCategoryButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.deleteEmployeeButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TabControl.SuspendLayout();
            this.TabPageNewTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priorityNumeric)).BeginInit();
            this.TabPageCurrentTasks.SuspendLayout();
            this.isDoneContextMenuStrip.SuspendLayout();
            this.statisticTabPage.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.tabPageInfo.SuspendLayout();
            this.userMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPosition
            // 
            this.labelPosition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPosition.AutoSize = true;
            this.labelPosition.BackColor = System.Drawing.Color.Transparent;
            this.labelPosition.Depth = 0;
            this.labelPosition.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPosition.Location = new System.Drawing.Point(464, 173);
            this.labelPosition.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPosition.MaximumSize = new System.Drawing.Size(500, 0);
            this.labelPosition.MinimumSize = new System.Drawing.Size(500, 39);
            this.labelPosition.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(500, 39);
            this.labelPosition.TabIndex = 11;
            this.labelPosition.Text = "Position";
            // 
            // labelFullName
            // 
            this.labelFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFullName.AutoSize = true;
            this.labelFullName.BackColor = System.Drawing.Color.Transparent;
            this.labelFullName.Depth = 0;
            this.labelFullName.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelFullName.Location = new System.Drawing.Point(464, 91);
            this.labelFullName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelFullName.MinimumSize = new System.Drawing.Size(500, 39);
            this.labelFullName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(500, 39);
            this.labelFullName.TabIndex = 10;
            this.labelFullName.Text = "Full Name";
            // 
            // menuTabSelector
            // 
            this.menuTabSelector.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuTabSelector.BaseTabControl = this.TabControl;
            this.menuTabSelector.Depth = 0;
            this.menuTabSelector.Location = new System.Drawing.Point(126, 283);
            this.menuTabSelector.Margin = new System.Windows.Forms.Padding(6);
            this.menuTabSelector.MinimumSize = new System.Drawing.Size(1600, 97);
            this.menuTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.menuTabSelector.Name = "menuTabSelector";
            this.menuTabSelector.Size = new System.Drawing.Size(1600, 97);
            this.menuTabSelector.TabIndex = 7;
            // 
            // TabControl
            // 
            this.TabControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TabControl.Controls.Add(this.TabPageNewTask);
            this.TabControl.Controls.Add(this.TabPageCurrentTasks);
            this.TabControl.Controls.Add(this.TabPageMonitoring);
            this.TabControl.Controls.Add(this.statisticTabPage);
            this.TabControl.Controls.Add(this.tabPageSettings);
            this.TabControl.Controls.Add(this.tabPageInfo);
            this.TabControl.Depth = 0;
            this.TabControl.Location = new System.Drawing.Point(126, 391);
            this.TabControl.Margin = new System.Windows.Forms.Padding(6);
            this.TabControl.MaximumSize = new System.Drawing.Size(1600, 769);
            this.TabControl.MinimumSize = new System.Drawing.Size(1380, 634);
            this.TabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1600, 769);
            this.TabControl.TabIndex = 0;
            // 
            // TabPageNewTask
            // 
            this.TabPageNewTask.BackColor = System.Drawing.Color.White;
            this.TabPageNewTask.Controls.Add(this.reCreateComboBox);
            this.TabPageNewTask.Controls.Add(this.categoryComboBox);
            this.TabPageNewTask.Controls.Add(this.complexityComboBox);
            this.TabPageNewTask.Controls.Add(this.deadlineTimePicker);
            this.TabPageNewTask.Controls.Add(this.createTaskButton);
            this.TabPageNewTask.Controls.Add(this.createRequestButton);
            this.TabPageNewTask.Controls.Add(this.StandartTaskButton);
            this.TabPageNewTask.Controls.Add(this.priorityNumeric);
            this.TabPageNewTask.Controls.Add(this.descriptionTaskTextField);
            this.TabPageNewTask.Controls.Add(this.nameOfTaskTextField);
            this.TabPageNewTask.Controls.Add(this.AutomaticTaskButton);
            this.TabPageNewTask.Location = new System.Drawing.Point(8, 39);
            this.TabPageNewTask.Margin = new System.Windows.Forms.Padding(6);
            this.TabPageNewTask.Name = "TabPageNewTask";
            this.TabPageNewTask.Padding = new System.Windows.Forms.Padding(6);
            this.TabPageNewTask.Size = new System.Drawing.Size(1584, 722);
            this.TabPageNewTask.TabIndex = 0;
            this.TabPageNewTask.Text = global::ManagementSystem.Properties.Resources.CreateNewTask;
            // 
            // reCreateComboBox
            // 
            this.reCreateComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reCreateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reCreateComboBox.Enabled = false;
            this.reCreateComboBox.FormattingEnabled = true;
            this.reCreateComboBox.Location = new System.Drawing.Point(898, 341);
            this.reCreateComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.reCreateComboBox.MinimumSize = new System.Drawing.Size(396, 0);
            this.reCreateComboBox.Name = "reCreateComboBox";
            this.reCreateComboBox.Size = new System.Drawing.Size(396, 33);
            this.reCreateComboBox.TabIndex = 0;
            this.reCreateComboBox.TabStop = false;
            this.reCreateComboBox.Visible = false;
            this.reCreateComboBox.SelectedIndexChanged += new System.EventHandler(this.ReCreateComboBox_SelectedIndexChanged);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.Enabled = false;
            this.categoryComboBox.Location = new System.Drawing.Point(114, 341);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.categoryComboBox.MinimumSize = new System.Drawing.Size(396, 0);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(396, 33);
            this.categoryComboBox.TabIndex = 0;
            this.categoryComboBox.TabStop = false;
            // 
            // complexityComboBox
            // 
            this.complexityComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.complexityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.complexityComboBox.Enabled = false;
            this.complexityComboBox.FormattingEnabled = true;
            this.complexityComboBox.Location = new System.Drawing.Point(114, 425);
            this.complexityComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.complexityComboBox.MinimumSize = new System.Drawing.Size(396, 0);
            this.complexityComboBox.Name = "complexityComboBox";
            this.complexityComboBox.Size = new System.Drawing.Size(396, 33);
            this.complexityComboBox.TabIndex = 0;
            this.complexityComboBox.TabStop = false;
            // 
            // deadlineTimePicker
            // 
            this.deadlineTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deadlineTimePicker.Enabled = false;
            this.deadlineTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deadlineTimePicker.Location = new System.Drawing.Point(898, 231);
            this.deadlineTimePicker.Margin = new System.Windows.Forms.Padding(6);
            this.deadlineTimePicker.MinimumSize = new System.Drawing.Size(496, 30);
            this.deadlineTimePicker.Name = "deadlineTimePicker";
            this.deadlineTimePicker.ShowUpDown = true;
            this.deadlineTimePicker.Size = new System.Drawing.Size(544, 38);
            this.deadlineTimePicker.TabIndex = 0;
            this.deadlineTimePicker.TabStop = false;
            this.deadlineTimePicker.ValueChanged += new System.EventHandler(this.DeadlineTimePicker_ValueChanged);
            // 
            // createTaskButton
            // 
            this.createTaskButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createTaskButton.AutoSize = true;
            this.createTaskButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createTaskButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createTaskButton.Depth = 0;
            this.createTaskButton.Icon = global::ManagementSystem.Properties.Resources.addtaskicon;
            this.createTaskButton.Location = new System.Drawing.Point(898, 569);
            this.createTaskButton.Margin = new System.Windows.Forms.Padding(6);
            this.createTaskButton.MinimumSize = new System.Drawing.Size(400, 77);
            this.createTaskButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.createTaskButton.Name = "createTaskButton";
            this.createTaskButton.Primary = true;
            this.createTaskButton.Size = new System.Drawing.Size(400, 77);
            this.createTaskButton.TabIndex = 0;
            this.createTaskButton.TabStop = false;
            this.createTaskButton.Text = global::ManagementSystem.Properties.Resources.CreateTask;
            this.createTaskButton.UseVisualStyleBackColor = true;
            this.createTaskButton.Click += new System.EventHandler(this.CreateTaskButton_ClickAsync);
            // 
            // createRequestButton
            // 
            this.createRequestButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createRequestButton.AutoSize = true;
            this.createRequestButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createRequestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createRequestButton.Depth = 0;
            this.createRequestButton.Icon = global::ManagementSystem.Properties.Resources.createrequesticon;
            this.createRequestButton.Location = new System.Drawing.Point(296, 569);
            this.createRequestButton.Margin = new System.Windows.Forms.Padding(6);
            this.createRequestButton.MinimumSize = new System.Drawing.Size(400, 77);
            this.createRequestButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.createRequestButton.Name = "createRequestButton";
            this.createRequestButton.Primary = true;
            this.createRequestButton.Size = new System.Drawing.Size(400, 77);
            this.createRequestButton.TabIndex = 0;
            this.createRequestButton.TabStop = false;
            this.createRequestButton.Text = global::ManagementSystem.Properties.Resources.CreateRequest;
            this.createRequestButton.UseVisualStyleBackColor = true;
            this.createRequestButton.Click += new System.EventHandler(this.CreateTaskButton_ClickAsync);
            // 
            // StandartTaskButton
            // 
            this.StandartTaskButton.AutoSize = true;
            this.StandartTaskButton.Depth = 0;
            this.StandartTaskButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.StandartTaskButton.Location = new System.Drawing.Point(898, 34);
            this.StandartTaskButton.Margin = new System.Windows.Forms.Padding(0);
            this.StandartTaskButton.MinimumSize = new System.Drawing.Size(340, 58);
            this.StandartTaskButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.StandartTaskButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.StandartTaskButton.Name = "StandartTaskButton";
            this.StandartTaskButton.Ripple = true;
            this.StandartTaskButton.Size = new System.Drawing.Size(340, 58);
            this.StandartTaskButton.TabIndex = 0;
            this.StandartTaskButton.Text = global::ManagementSystem.Properties.Resources.CreateTask;
            this.StandartTaskButton.UseVisualStyleBackColor = true;
            this.StandartTaskButton.CheckedChanged += new System.EventHandler(this.StandartTaskButton_CheckedChanged);
            // 
            // priorityNumeric
            // 
            this.priorityNumeric.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priorityNumeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priorityNumeric.Enabled = false;
            this.priorityNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.priorityNumeric.Location = new System.Drawing.Point(898, 133);
            this.priorityNumeric.Margin = new System.Windows.Forms.Padding(6);
            this.priorityNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.priorityNumeric.MinimumSize = new System.Drawing.Size(400, 0);
            this.priorityNumeric.Name = "priorityNumeric";
            this.priorityNumeric.Size = new System.Drawing.Size(500, 34);
            this.priorityNumeric.TabIndex = 0;
            this.priorityNumeric.TabStop = false;
            this.priorityNumeric.ValueChanged += new System.EventHandler(this.PriorityNumeric_ValueChanged);
            // 
            // descriptionTaskTextField
            // 
            this.descriptionTaskTextField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionTaskTextField.Depth = 0;
            this.descriptionTaskTextField.Enabled = false;
            this.descriptionTaskTextField.Hint = global::ManagementSystem.Properties.Resources.DescriptionOfTask;
            this.descriptionTaskTextField.Location = new System.Drawing.Point(114, 216);
            this.descriptionTaskTextField.Margin = new System.Windows.Forms.Padding(6);
            this.descriptionTaskTextField.MaxLength = 32767;
            this.descriptionTaskTextField.MinimumSize = new System.Drawing.Size(400, 58);
            this.descriptionTaskTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.descriptionTaskTextField.Name = "descriptionTaskTextField";
            this.descriptionTaskTextField.PasswordChar = '\0';
            this.descriptionTaskTextField.SelectedText = "";
            this.descriptionTaskTextField.SelectionLength = 0;
            this.descriptionTaskTextField.SelectionStart = 0;
            this.descriptionTaskTextField.Size = new System.Drawing.Size(400, 58);
            this.descriptionTaskTextField.TabIndex = 2;
            this.descriptionTaskTextField.TabStop = false;
            this.descriptionTaskTextField.UseSystemPasswordChar = false;
            // 
            // nameOfTaskTextField
            // 
            this.nameOfTaskTextField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameOfTaskTextField.Depth = 0;
            this.nameOfTaskTextField.Enabled = false;
            this.nameOfTaskTextField.Hint = global::ManagementSystem.Properties.Resources.NameOfTask;
            this.nameOfTaskTextField.Location = new System.Drawing.Point(114, 128);
            this.nameOfTaskTextField.Margin = new System.Windows.Forms.Padding(6);
            this.nameOfTaskTextField.MaxLength = 32767;
            this.nameOfTaskTextField.MinimumSize = new System.Drawing.Size(400, 58);
            this.nameOfTaskTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.nameOfTaskTextField.Name = "nameOfTaskTextField";
            this.nameOfTaskTextField.PasswordChar = '\0';
            this.nameOfTaskTextField.SelectedText = "";
            this.nameOfTaskTextField.SelectionLength = 0;
            this.nameOfTaskTextField.SelectionStart = 0;
            this.nameOfTaskTextField.Size = new System.Drawing.Size(400, 58);
            this.nameOfTaskTextField.TabIndex = 0;
            this.nameOfTaskTextField.TabStop = false;
            this.nameOfTaskTextField.UseSystemPasswordChar = false;
            // 
            // AutomaticTaskButton
            // 
            this.AutomaticTaskButton.AutoSize = true;
            this.AutomaticTaskButton.Depth = 0;
            this.AutomaticTaskButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.AutomaticTaskButton.Location = new System.Drawing.Point(296, 34);
            this.AutomaticTaskButton.Margin = new System.Windows.Forms.Padding(0);
            this.AutomaticTaskButton.MinimumSize = new System.Drawing.Size(340, 58);
            this.AutomaticTaskButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AutomaticTaskButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AutomaticTaskButton.Name = "AutomaticTaskButton";
            this.AutomaticTaskButton.Ripple = true;
            this.AutomaticTaskButton.Size = new System.Drawing.Size(340, 58);
            this.AutomaticTaskButton.TabIndex = 0;
            this.AutomaticTaskButton.Text = global::ManagementSystem.Properties.Resources.CreateAutomaticTask;
            this.AutomaticTaskButton.UseVisualStyleBackColor = true;
            this.AutomaticTaskButton.CheckedChanged += new System.EventHandler(this.StandartTaskButton_CheckedChanged);
            // 
            // TabPageCurrentTasks
            // 
            this.TabPageCurrentTasks.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabPageCurrentTasks.Controls.Add(this.labelNoTasks);
            this.TabPageCurrentTasks.Controls.Add(this.ListViewTasks);
            this.TabPageCurrentTasks.Location = new System.Drawing.Point(8, 39);
            this.TabPageCurrentTasks.Margin = new System.Windows.Forms.Padding(6);
            this.TabPageCurrentTasks.Name = "TabPageCurrentTasks";
            this.TabPageCurrentTasks.Padding = new System.Windows.Forms.Padding(6);
            this.TabPageCurrentTasks.Size = new System.Drawing.Size(1584, 722);
            this.TabPageCurrentTasks.TabIndex = 1;
            this.TabPageCurrentTasks.Text = "My Tasks";
            this.TabPageCurrentTasks.UseVisualStyleBackColor = true;
            // 
            // labelNoTasks
            // 
            this.labelNoTasks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNoTasks.AutoSize = true;
            this.labelNoTasks.BackColor = System.Drawing.Color.White;
            this.labelNoTasks.Depth = 0;
            this.labelNoTasks.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelNoTasks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelNoTasks.Location = new System.Drawing.Point(574, 278);
            this.labelNoTasks.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNoTasks.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelNoTasks.Name = "labelNoTasks";
            this.labelNoTasks.Size = new System.Drawing.Size(0, 37);
            this.labelNoTasks.TabIndex = 1;
            this.labelNoTasks.Visible = false;
            // 
            // ListViewTasks
            // 
            this.ListViewTasks.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ListViewTasks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ListViewTasks.BackColor = System.Drawing.Color.White;
            this.ListViewTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListViewTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTaskName,
            this.columnTaskDescription,
            this.columnPriority,
            this.columnCategory,
            this.columnDeadline,
            this.columnType});
            this.ListViewTasks.ContextMenuStrip = this.isDoneContextMenuStrip;
            this.ListViewTasks.Depth = 0;
            this.ListViewTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.ListViewTasks.FullRowSelect = true;
            this.ListViewTasks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListViewTasks.HideSelection = false;
            this.ListViewTasks.HoverSelection = true;
            this.ListViewTasks.Location = new System.Drawing.Point(6, 6);
            this.ListViewTasks.Margin = new System.Windows.Forms.Padding(6);
            this.ListViewTasks.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ListViewTasks.MouseState = MaterialSkin.MouseState.OUT;
            this.ListViewTasks.Name = "ListViewTasks";
            this.ListViewTasks.OwnerDraw = true;
            this.ListViewTasks.Size = new System.Drawing.Size(1572, 708);
            this.ListViewTasks.TabIndex = 1;
            this.ListViewTasks.UseCompatibleStateImageBehavior = false;
            this.ListViewTasks.View = System.Windows.Forms.View.Details;
            this.ListViewTasks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListViewTasks_MouseClick);
            // 
            // columnTaskName
            // 
            this.columnTaskName.Text = "TaskName";
            this.columnTaskName.Width = 150;
            // 
            // columnTaskDescription
            // 
            this.columnTaskDescription.Text = "Description";
            this.columnTaskDescription.Width = 220;
            // 
            // columnPriority
            // 
            this.columnPriority.Text = "Priority";
            this.columnPriority.Width = 100;
            // 
            // columnCategory
            // 
            this.columnCategory.Text = "Category";
            this.columnCategory.Width = 110;
            // 
            // columnDeadline
            // 
            this.columnDeadline.Text = "Deadline";
            this.columnDeadline.Width = 110;
            // 
            // columnType
            // 
            this.columnType.Text = "Type";
            this.columnType.Width = 100;
            // 
            // isDoneContextMenuStrip
            // 
            this.isDoneContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.isDoneContextMenuStrip.Depth = 0;
            this.isDoneContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.isDoneContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doneToolStripMenuItem,
            this.isReadyToolStripMenuItem});
            this.isDoneContextMenuStrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.isDoneContextMenuStrip.Name = "isDoneContextMenuStrip";
            this.isDoneContextMenuStrip.Size = new System.Drawing.Size(76, 64);
            // 
            // doneToolStripMenuItem
            // 
            this.doneToolStripMenuItem.AutoSize = false;
            this.doneToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.doneToolStripMenuItem.Name = "doneToolStripMenuItem";
            this.doneToolStripMenuItem.Size = new System.Drawing.Size(120, 30);
            this.doneToolStripMenuItem.Click += new System.EventHandler(this.DoneToolStripMenuItem_ClickAsync);
            // 
            // isReadyToolStripMenuItem
            // 
            this.isReadyToolStripMenuItem.AutoSize = false;
            this.isReadyToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.isReadyToolStripMenuItem.Name = "isReadyToolStripMenuItem";
            this.isReadyToolStripMenuItem.Size = new System.Drawing.Size(150, 30);
            this.isReadyToolStripMenuItem.Visible = false;
            this.isReadyToolStripMenuItem.Click += new System.EventHandler(this.DoneToolStripMenuItem_ClickAsync);
            // 
            // TabPageMonitoring
            // 
            this.TabPageMonitoring.Location = new System.Drawing.Point(8, 39);
            this.TabPageMonitoring.Margin = new System.Windows.Forms.Padding(6);
            this.TabPageMonitoring.Name = "TabPageMonitoring";
            this.TabPageMonitoring.Size = new System.Drawing.Size(1584, 722);
            this.TabPageMonitoring.TabIndex = 2;
            this.TabPageMonitoring.Text = global::ManagementSystem.Properties.Resources.Monitoring;
            this.TabPageMonitoring.UseVisualStyleBackColor = true;
            // 
            // statisticTabPage
            // 
            this.statisticTabPage.Controls.Add(this.ratingMaterialLabel);
            this.statisticTabPage.Controls.Add(this.ListDoneTask);
            this.statisticTabPage.Controls.Add(this.textRatingMaterialLabel);
            this.statisticTabPage.Controls.Add(this.labelDoneTasks);
            this.statisticTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statisticTabPage.Location = new System.Drawing.Point(8, 39);
            this.statisticTabPage.Margin = new System.Windows.Forms.Padding(6);
            this.statisticTabPage.Name = "statisticTabPage";
            this.statisticTabPage.Padding = new System.Windows.Forms.Padding(6);
            this.statisticTabPage.Size = new System.Drawing.Size(1584, 722);
            this.statisticTabPage.TabIndex = 3;
            this.statisticTabPage.Text = global::ManagementSystem.Properties.Resources.Statistic;
            this.statisticTabPage.UseVisualStyleBackColor = true;
            // 
            // ratingMaterialLabel
            // 
            this.ratingMaterialLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ratingMaterialLabel.AutoSize = true;
            this.ratingMaterialLabel.Depth = 0;
            this.ratingMaterialLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.ratingMaterialLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ratingMaterialLabel.Location = new System.Drawing.Point(282, 656);
            this.ratingMaterialLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ratingMaterialLabel.MinimumSize = new System.Drawing.Size(200, 0);
            this.ratingMaterialLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ratingMaterialLabel.Name = "ratingMaterialLabel";
            this.ratingMaterialLabel.Size = new System.Drawing.Size(200, 37);
            this.ratingMaterialLabel.TabIndex = 15;
            // 
            // ListDoneTask
            // 
            this.ListDoneTask.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ListDoneTask.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ListDoneTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListDoneTask.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numberOfTask,
            this.nameOfTask,
            this.description,
            this.complexity});
            this.ListDoneTask.Depth = 0;
            this.ListDoneTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.ListDoneTask.FullRowSelect = true;
            this.ListDoneTask.GridLines = true;
            this.ListDoneTask.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListDoneTask.Location = new System.Drawing.Point(-2, 108);
            this.ListDoneTask.Margin = new System.Windows.Forms.Padding(6);
            this.ListDoneTask.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ListDoneTask.MouseState = MaterialSkin.MouseState.OUT;
            this.ListDoneTask.Name = "ListDoneTask";
            this.ListDoneTask.OwnerDraw = true;
            this.ListDoneTask.Size = new System.Drawing.Size(1592, 550);
            this.ListDoneTask.TabIndex = 2;
            this.ListDoneTask.UseCompatibleStateImageBehavior = false;
            this.ListDoneTask.View = System.Windows.Forms.View.Details;
            // 
            // numberOfTask
            // 
            this.numberOfTask.Text = "№";
            this.numberOfTask.Width = 40;
            // 
            // nameOfTask
            // 
            this.nameOfTask.Text = global::ManagementSystem.Properties.Resources.NameOfTask;
            this.nameOfTask.Width = 200;
            // 
            // description
            // 
            this.description.Text = global::ManagementSystem.Properties.Resources.DescriptionOfTask;
            this.description.Width = 400;
            // 
            // complexity
            // 
            this.complexity.Text = global::ManagementSystem.Properties.Resources.Complexity;
            this.complexity.Width = 130;
            // 
            // textRatingMaterialLabel
            // 
            this.textRatingMaterialLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textRatingMaterialLabel.AutoSize = true;
            this.textRatingMaterialLabel.Depth = 0;
            this.textRatingMaterialLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.textRatingMaterialLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textRatingMaterialLabel.Location = new System.Drawing.Point(46, 656);
            this.textRatingMaterialLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.textRatingMaterialLabel.MinimumSize = new System.Drawing.Size(300, 39);
            this.textRatingMaterialLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.textRatingMaterialLabel.Name = "textRatingMaterialLabel";
            this.textRatingMaterialLabel.Size = new System.Drawing.Size(300, 39);
            this.textRatingMaterialLabel.TabIndex = 14;
            this.textRatingMaterialLabel.Text = "Ваш рейтинг:";
            // 
            // labelDoneTasks
            // 
            this.labelDoneTasks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDoneTasks.AutoSize = true;
            this.labelDoneTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDoneTasks.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelDoneTasks.Location = new System.Drawing.Point(24, 8);
            this.labelDoneTasks.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDoneTasks.Name = "labelDoneTasks";
            this.labelDoneTasks.Size = new System.Drawing.Size(221, 44);
            this.labelDoneTasks.TabIndex = 1;
            this.labelDoneTasks.Text = "Done Tasks";
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.BackColor = System.Drawing.Color.White;
            this.tabPageSettings.Controls.Add(this.buttonSignOut);
            this.tabPageSettings.Controls.Add(this.buttonChangeColor);
            this.tabPageSettings.Controls.Add(this.buttonChangeTheme);
            this.tabPageSettings.Controls.Add(this.labelColors);
            this.tabPageSettings.Location = new System.Drawing.Point(8, 39);
            this.tabPageSettings.Margin = new System.Windows.Forms.Padding(6);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(6);
            this.tabPageSettings.Size = new System.Drawing.Size(1584, 722);
            this.tabPageSettings.TabIndex = 4;
            this.tabPageSettings.Text = "Settings";
            // 
            // buttonSignOut
            // 
            this.buttonSignOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSignOut.AutoSize = true;
            this.buttonSignOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSignOut.Depth = 0;
            this.buttonSignOut.Icon = global::ManagementSystem.Properties.Resources.signouticon;
            this.buttonSignOut.Location = new System.Drawing.Point(620, 581);
            this.buttonSignOut.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSignOut.MinimumSize = new System.Drawing.Size(300, 77);
            this.buttonSignOut.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSignOut.Name = "buttonSignOut";
            this.buttonSignOut.Primary = true;
            this.buttonSignOut.Size = new System.Drawing.Size(300, 77);
            this.buttonSignOut.TabIndex = 23;
            this.buttonSignOut.UseVisualStyleBackColor = true;
            this.buttonSignOut.Click += new System.EventHandler(this.ButtonSignOut_Click);
            // 
            // buttonChangeColor
            // 
            this.buttonChangeColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonChangeColor.AutoSize = true;
            this.buttonChangeColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonChangeColor.Depth = 0;
            this.buttonChangeColor.Icon = global::ManagementSystem.Properties.Resources.paleteicon;
            this.buttonChangeColor.Location = new System.Drawing.Point(1120, 269);
            this.buttonChangeColor.Margin = new System.Windows.Forms.Padding(6);
            this.buttonChangeColor.MinimumSize = new System.Drawing.Size(300, 77);
            this.buttonChangeColor.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonChangeColor.Name = "buttonChangeColor";
            this.buttonChangeColor.Primary = true;
            this.buttonChangeColor.Size = new System.Drawing.Size(300, 77);
            this.buttonChangeColor.TabIndex = 22;
            this.buttonChangeColor.UseVisualStyleBackColor = true;
            this.buttonChangeColor.Click += new System.EventHandler(this.ButtonChangeColor_Click);
            // 
            // buttonChangeTheme
            // 
            this.buttonChangeTheme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonChangeTheme.AutoSize = true;
            this.buttonChangeTheme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonChangeTheme.Depth = 0;
            this.buttonChangeTheme.Icon = global::ManagementSystem.Properties.Resources.coloricon;
            this.buttonChangeTheme.Location = new System.Drawing.Point(132, 269);
            this.buttonChangeTheme.Margin = new System.Windows.Forms.Padding(6);
            this.buttonChangeTheme.MinimumSize = new System.Drawing.Size(300, 77);
            this.buttonChangeTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonChangeTheme.Name = "buttonChangeTheme";
            this.buttonChangeTheme.Primary = true;
            this.buttonChangeTheme.Size = new System.Drawing.Size(300, 77);
            this.buttonChangeTheme.TabIndex = 1;
            this.buttonChangeTheme.UseVisualStyleBackColor = true;
            this.buttonChangeTheme.Click += new System.EventHandler(this.ButtonChangeTheme_Click);
            // 
            // labelColors
            // 
            this.labelColors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelColors.AutoSize = true;
            this.labelColors.Depth = 0;
            this.labelColors.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelColors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelColors.Location = new System.Drawing.Point(506, 122);
            this.labelColors.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelColors.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelColors.Name = "labelColors";
            this.labelColors.Size = new System.Drawing.Size(501, 37);
            this.labelColors.TabIndex = 0;
            this.labelColors.Text = "Push buttons to change color theme";
            // 
            // tabPageInfo
            // 
            this.tabPageInfo.BackColor = System.Drawing.Color.White;
            this.tabPageInfo.Controls.Add(this.incorrectTelephoneLabel);
            this.tabPageInfo.Controls.Add(this.incorrectEmailLabel);
            this.tabPageInfo.Controls.Add(this.tooShortPasswordLabel);
            this.tabPageInfo.Controls.Add(this.passwordsAreNotEqualLabel);
            this.tabPageInfo.Controls.Add(this.incorrectPasswordLabel);
            this.tabPageInfo.Controls.Add(this.telephoneSaveButton);
            this.tabPageInfo.Controls.Add(this.emailSaveButton);
            this.tabPageInfo.Controls.Add(this.telephoneNumberTextField);
            this.tabPageInfo.Controls.Add(this.emailTextField);
            this.tabPageInfo.Controls.Add(this.changePasswordButton);
            this.tabPageInfo.Controls.Add(this.newPasswordConfirmationTextField);
            this.tabPageInfo.Controls.Add(this.newPasswordTextField);
            this.tabPageInfo.Controls.Add(this.oldPasswordTextField);
            this.tabPageInfo.Location = new System.Drawing.Point(8, 39);
            this.tabPageInfo.Margin = new System.Windows.Forms.Padding(6);
            this.tabPageInfo.Name = "tabPageInfo";
            this.tabPageInfo.Padding = new System.Windows.Forms.Padding(6);
            this.tabPageInfo.Size = new System.Drawing.Size(1584, 722);
            this.tabPageInfo.TabIndex = 5;
            this.tabPageInfo.Text = "Info";
            // 
            // incorrectTelephoneLabel
            // 
            this.incorrectTelephoneLabel.AutoSize = true;
            this.incorrectTelephoneLabel.Depth = 0;
            this.incorrectTelephoneLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.incorrectTelephoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.incorrectTelephoneLabel.Location = new System.Drawing.Point(332, 611);
            this.incorrectTelephoneLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.incorrectTelephoneLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.incorrectTelephoneLabel.Name = "incorrectTelephoneLabel";
            this.incorrectTelephoneLabel.Size = new System.Drawing.Size(285, 37);
            this.incorrectTelephoneLabel.TabIndex = 43;
            this.incorrectTelephoneLabel.Text = "Incorrect Telephone";
            this.incorrectTelephoneLabel.Visible = false;
            // 
            // incorrectEmailLabel
            // 
            this.incorrectEmailLabel.AutoSize = true;
            this.incorrectEmailLabel.Depth = 0;
            this.incorrectEmailLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.incorrectEmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.incorrectEmailLabel.Location = new System.Drawing.Point(352, 458);
            this.incorrectEmailLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.incorrectEmailLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.incorrectEmailLabel.Name = "incorrectEmailLabel";
            this.incorrectEmailLabel.Size = new System.Drawing.Size(217, 37);
            this.incorrectEmailLabel.TabIndex = 42;
            this.incorrectEmailLabel.Text = "Incorrect Email";
            this.incorrectEmailLabel.Visible = false;
            // 
            // tooShortPasswordLabel
            // 
            this.tooShortPasswordLabel.AutoSize = true;
            this.tooShortPasswordLabel.Depth = 0;
            this.tooShortPasswordLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.tooShortPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tooShortPasswordLabel.Location = new System.Drawing.Point(590, 247);
            this.tooShortPasswordLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.tooShortPasswordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.tooShortPasswordLabel.Name = "tooShortPasswordLabel";
            this.tooShortPasswordLabel.Size = new System.Drawing.Size(148, 37);
            this.tooShortPasswordLabel.TabIndex = 41;
            this.tooShortPasswordLabel.Text = "Too Short";
            this.tooShortPasswordLabel.Visible = false;
            // 
            // passwordsAreNotEqualLabel
            // 
            this.passwordsAreNotEqualLabel.AutoSize = true;
            this.passwordsAreNotEqualLabel.Depth = 0;
            this.passwordsAreNotEqualLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.passwordsAreNotEqualLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.passwordsAreNotEqualLabel.Location = new System.Drawing.Point(590, 247);
            this.passwordsAreNotEqualLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.passwordsAreNotEqualLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordsAreNotEqualLabel.Name = "passwordsAreNotEqualLabel";
            this.passwordsAreNotEqualLabel.Size = new System.Drawing.Size(344, 37);
            this.passwordsAreNotEqualLabel.TabIndex = 40;
            this.passwordsAreNotEqualLabel.Text = "Passwords are not equal";
            this.passwordsAreNotEqualLabel.Visible = false;
            // 
            // incorrectPasswordLabel
            // 
            this.incorrectPasswordLabel.AutoSize = true;
            this.incorrectPasswordLabel.Depth = 0;
            this.incorrectPasswordLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.incorrectPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.incorrectPasswordLabel.Location = new System.Drawing.Point(136, 209);
            this.incorrectPasswordLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.incorrectPasswordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.incorrectPasswordLabel.Name = "incorrectPasswordLabel";
            this.incorrectPasswordLabel.Size = new System.Drawing.Size(266, 37);
            this.incorrectPasswordLabel.TabIndex = 39;
            this.incorrectPasswordLabel.Text = "Incorect Password";
            this.incorrectPasswordLabel.Visible = false;
            // 
            // telephoneSaveButton
            // 
            this.telephoneSaveButton.AutoSize = true;
            this.telephoneSaveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.telephoneSaveButton.Depth = 0;
            this.telephoneSaveButton.Icon = global::ManagementSystem.Properties.Resources.savepictureicon;
            this.telephoneSaveButton.Location = new System.Drawing.Point(860, 527);
            this.telephoneSaveButton.Margin = new System.Windows.Forms.Padding(6);
            this.telephoneSaveButton.MinimumSize = new System.Drawing.Size(310, 0);
            this.telephoneSaveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.telephoneSaveButton.Name = "telephoneSaveButton";
            this.telephoneSaveButton.Primary = true;
            this.telephoneSaveButton.Size = new System.Drawing.Size(310, 36);
            this.telephoneSaveButton.TabIndex = 38;
            this.telephoneSaveButton.Text = "Save";
            this.telephoneSaveButton.UseVisualStyleBackColor = true;
            // 
            // emailSaveButton
            // 
            this.emailSaveButton.AutoSize = true;
            this.emailSaveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.emailSaveButton.Depth = 0;
            this.emailSaveButton.Icon = global::ManagementSystem.Properties.Resources.savepictureicon;
            this.emailSaveButton.Location = new System.Drawing.Point(860, 372);
            this.emailSaveButton.Margin = new System.Windows.Forms.Padding(6);
            this.emailSaveButton.MinimumSize = new System.Drawing.Size(310, 0);
            this.emailSaveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailSaveButton.Name = "emailSaveButton";
            this.emailSaveButton.Primary = true;
            this.emailSaveButton.Size = new System.Drawing.Size(310, 36);
            this.emailSaveButton.TabIndex = 37;
            this.emailSaveButton.Text = "Save";
            this.emailSaveButton.UseVisualStyleBackColor = true;
            // 
            // telephoneNumberTextField
            // 
            this.telephoneNumberTextField.Depth = 0;
            this.telephoneNumberTextField.Hint = "";
            this.telephoneNumberTextField.Location = new System.Drawing.Point(314, 544);
            this.telephoneNumberTextField.Margin = new System.Windows.Forms.Padding(6);
            this.telephoneNumberTextField.MaxLength = 32767;
            this.telephoneNumberTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.telephoneNumberTextField.Name = "telephoneNumberTextField";
            this.telephoneNumberTextField.PasswordChar = '\0';
            this.telephoneNumberTextField.SelectedText = "";
            this.telephoneNumberTextField.SelectionLength = 0;
            this.telephoneNumberTextField.SelectionStart = 0;
            this.telephoneNumberTextField.Size = new System.Drawing.Size(330, 41);
            this.telephoneNumberTextField.TabIndex = 36;
            this.telephoneNumberTextField.TabStop = false;
            this.telephoneNumberTextField.UseSystemPasswordChar = false;
            // 
            // emailTextField
            // 
            this.emailTextField.Depth = 0;
            this.emailTextField.Hint = "";
            this.emailTextField.Location = new System.Drawing.Point(314, 389);
            this.emailTextField.Margin = new System.Windows.Forms.Padding(6);
            this.emailTextField.MaxLength = 32767;
            this.emailTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailTextField.Name = "emailTextField";
            this.emailTextField.PasswordChar = '\0';
            this.emailTextField.SelectedText = "";
            this.emailTextField.SelectionLength = 0;
            this.emailTextField.SelectionStart = 0;
            this.emailTextField.Size = new System.Drawing.Size(286, 41);
            this.emailTextField.TabIndex = 35;
            this.emailTextField.TabStop = false;
            this.emailTextField.UseSystemPasswordChar = false;
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.AutoSize = true;
            this.changePasswordButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.changePasswordButton.Depth = 0;
            this.changePasswordButton.Icon = global::ManagementSystem.Properties.Resources.redacticon;
            this.changePasswordButton.Location = new System.Drawing.Point(1144, 119);
            this.changePasswordButton.Margin = new System.Windows.Forms.Padding(6);
            this.changePasswordButton.MinimumSize = new System.Drawing.Size(310, 0);
            this.changePasswordButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Primary = true;
            this.changePasswordButton.Size = new System.Drawing.Size(317, 36);
            this.changePasswordButton.TabIndex = 34;
            this.changePasswordButton.Text = "Change Password";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            // 
            // newPasswordConfirmationTextField
            // 
            this.newPasswordConfirmationTextField.Depth = 0;
            this.newPasswordConfirmationTextField.Hint = "";
            this.newPasswordConfirmationTextField.Location = new System.Drawing.Point(598, 144);
            this.newPasswordConfirmationTextField.Margin = new System.Windows.Forms.Padding(6);
            this.newPasswordConfirmationTextField.MaxLength = 32767;
            this.newPasswordConfirmationTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.newPasswordConfirmationTextField.Name = "newPasswordConfirmationTextField";
            this.newPasswordConfirmationTextField.PasswordChar = '\0';
            this.newPasswordConfirmationTextField.SelectedText = "";
            this.newPasswordConfirmationTextField.SelectionLength = 0;
            this.newPasswordConfirmationTextField.SelectionStart = 0;
            this.newPasswordConfirmationTextField.Size = new System.Drawing.Size(458, 41);
            this.newPasswordConfirmationTextField.TabIndex = 33;
            this.newPasswordConfirmationTextField.TabStop = false;
            this.newPasswordConfirmationTextField.UseSystemPasswordChar = false;
            // 
            // newPasswordTextField
            // 
            this.newPasswordTextField.Depth = 0;
            this.newPasswordTextField.Hint = "";
            this.newPasswordTextField.Location = new System.Drawing.Point(598, 59);
            this.newPasswordTextField.Margin = new System.Windows.Forms.Padding(6);
            this.newPasswordTextField.MaxLength = 32767;
            this.newPasswordTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.newPasswordTextField.Name = "newPasswordTextField";
            this.newPasswordTextField.PasswordChar = '\0';
            this.newPasswordTextField.SelectedText = "";
            this.newPasswordTextField.SelectionLength = 0;
            this.newPasswordTextField.SelectionStart = 0;
            this.newPasswordTextField.Size = new System.Drawing.Size(458, 41);
            this.newPasswordTextField.TabIndex = 32;
            this.newPasswordTextField.TabStop = false;
            this.newPasswordTextField.UseSystemPasswordChar = false;
            // 
            // oldPasswordTextField
            // 
            this.oldPasswordTextField.Depth = 0;
            this.oldPasswordTextField.Hint = "";
            this.oldPasswordTextField.Location = new System.Drawing.Point(112, 84);
            this.oldPasswordTextField.Margin = new System.Windows.Forms.Padding(6);
            this.oldPasswordTextField.MaxLength = 32767;
            this.oldPasswordTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.oldPasswordTextField.Name = "oldPasswordTextField";
            this.oldPasswordTextField.PasswordChar = '\0';
            this.oldPasswordTextField.SelectedText = "";
            this.oldPasswordTextField.SelectionLength = 0;
            this.oldPasswordTextField.SelectionStart = 0;
            this.oldPasswordTextField.Size = new System.Drawing.Size(292, 41);
            this.oldPasswordTextField.TabIndex = 31;
            this.oldPasswordTextField.TabStop = false;
            this.oldPasswordTextField.UseSystemPasswordChar = false;
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addEmployeeButton.AutoSize = true;
            this.addEmployeeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addEmployeeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addEmployeeButton.BackgroundImage")));
            this.addEmployeeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addEmployeeButton.Depth = 0;
            this.addEmployeeButton.Icon = global::ManagementSystem.Properties.Resources.addusericon;
            this.addEmployeeButton.Location = new System.Drawing.Point(1226, 23);
            this.addEmployeeButton.Margin = new System.Windows.Forms.Padding(6);
            this.addEmployeeButton.MinimumSize = new System.Drawing.Size(500, 77);
            this.addEmployeeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Primary = true;
            this.addEmployeeButton.Size = new System.Drawing.Size(500, 77);
            this.addEmployeeButton.TabIndex = 12;
            this.addEmployeeButton.Text = global::ManagementSystem.Properties.Resources.AddEmployee;
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // userMenuPanel
            // 
            this.userMenuPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userMenuPanel.Controls.Add(this.addCategoryButton);
            this.userMenuPanel.Controls.Add(this.profilePictureBox);
            this.userMenuPanel.Controls.Add(this.deleteEmployeeButton);
            this.userMenuPanel.Controls.Add(this.addEmployeeButton);
            this.userMenuPanel.Controls.Add(this.menuTabSelector);
            this.userMenuPanel.Controls.Add(this.labelPosition);
            this.userMenuPanel.Controls.Add(this.labelFullName);
            this.userMenuPanel.Controls.Add(this.TabControl);
            this.userMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.userMenuPanel.Margin = new System.Windows.Forms.Padding(6);
            this.userMenuPanel.MinimumSize = new System.Drawing.Size(1800, 1303);
            this.userMenuPanel.Name = "userMenuPanel";
            this.userMenuPanel.Size = new System.Drawing.Size(1800, 1303);
            this.userMenuPanel.TabIndex = 15;
            this.userMenuPanel.TabStop = true;
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addCategoryButton.AutoSize = true;
            this.addCategoryButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addCategoryButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addCategoryButton.BackgroundImage")));
            this.addCategoryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addCategoryButton.Depth = 0;
            this.addCategoryButton.Icon = global::ManagementSystem.Properties.Resources.addcategoryicon;
            this.addCategoryButton.Location = new System.Drawing.Point(1226, 200);
            this.addCategoryButton.Margin = new System.Windows.Forms.Padding(6);
            this.addCategoryButton.MaximumSize = new System.Drawing.Size(200, 77);
            this.addCategoryButton.MinimumSize = new System.Drawing.Size(500, 77);
            this.addCategoryButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Primary = true;
            this.addCategoryButton.Size = new System.Drawing.Size(500, 77);
            this.addCategoryButton.TabIndex = 15;
            this.addCategoryButton.Text = "Add Category";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            this.addCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.profilePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.profilePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profilePictureBox.ErrorImage = null;
            this.profilePictureBox.Image = global::ManagementSystem.Properties.Resources.faceicon;
            this.profilePictureBox.InitialImage = null;
            this.profilePictureBox.Location = new System.Drawing.Point(190, 48);
            this.profilePictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.profilePictureBox.MaximumSize = new System.Drawing.Size(210, 202);
            this.profilePictureBox.MinimumSize = new System.Drawing.Size(210, 202);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(210, 202);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 9;
            this.profilePictureBox.TabStop = false;
            this.profilePictureBox.Click += new System.EventHandler(this.ProfilePictureBox_Click);
            // 
            // deleteEmployeeButton
            // 
            this.deleteEmployeeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteEmployeeButton.AutoSize = true;
            this.deleteEmployeeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteEmployeeButton.Depth = 0;
            this.deleteEmployeeButton.Icon = global::ManagementSystem.Properties.Resources.deleteicon;
            this.deleteEmployeeButton.Location = new System.Drawing.Point(1226, 111);
            this.deleteEmployeeButton.Margin = new System.Windows.Forms.Padding(6);
            this.deleteEmployeeButton.MinimumSize = new System.Drawing.Size(500, 77);
            this.deleteEmployeeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteEmployeeButton.Name = "deleteEmployeeButton";
            this.deleteEmployeeButton.Primary = true;
            this.deleteEmployeeButton.Size = new System.Drawing.Size(500, 77);
            this.deleteEmployeeButton.TabIndex = 13;
            this.deleteEmployeeButton.Text = global::ManagementSystem.Properties.Resources.DeleteEmployee;
            this.deleteEmployeeButton.UseVisualStyleBackColor = true;
            this.deleteEmployeeButton.Click += new System.EventHandler(this.DeleteEmployeeButton_Click);
            // 
            // UserControlMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userMenuPanel);
            this.Location = new System.Drawing.Point(0, 64);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1800, 1303);
            this.Name = "UserControlMainMenu";
            this.Size = new System.Drawing.Size(1800, 1303);
            this.TabControl.ResumeLayout(false);
            this.TabPageNewTask.ResumeLayout(false);
            this.TabPageNewTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priorityNumeric)).EndInit();
            this.TabPageCurrentTasks.ResumeLayout(false);
            this.TabPageCurrentTasks.PerformLayout();
            this.isDoneContextMenuStrip.ResumeLayout(false);
            this.statisticTabPage.ResumeLayout(false);
            this.statisticTabPage.PerformLayout();
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            this.tabPageInfo.ResumeLayout(false);
            this.tabPageInfo.PerformLayout();
            this.userMenuPanel.ResumeLayout(false);
            this.userMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private MaterialSkin.Controls.MaterialLabel labelPosition;
        private MaterialSkin.Controls.MaterialLabel labelFullName;
        private System.Windows.Forms.Panel userMenuPanel;
        private MaterialSkin.Controls.MaterialTabSelector menuTabSelector;
        private System.Windows.Forms.ToolTip complexityToolTip;
        private System.Windows.Forms.ToolTip priorityToolTip;
        private System.Windows.Forms.ToolTip deadlineToolTip;
        private System.Windows.Forms.ToolTip reCreationToolTip;
        private MaterialSkin.Controls.MaterialRaisedButton addEmployeeButton;
        private MaterialSkin.Controls.MaterialRaisedButton deleteEmployeeButton;
        private MaterialSkin.Controls.MaterialTabControl TabControl;
        private System.Windows.Forms.TabPage TabPageNewTask;
        private System.Windows.Forms.ComboBox reCreateComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox complexityComboBox;
        private System.Windows.Forms.DateTimePicker deadlineTimePicker;
        private MaterialSkin.Controls.MaterialRaisedButton createTaskButton;
        private MaterialSkin.Controls.MaterialRaisedButton createRequestButton;
        private MaterialSkin.Controls.MaterialRadioButton StandartTaskButton;
        private System.Windows.Forms.NumericUpDown priorityNumeric;
        private MaterialSkin.Controls.MaterialSingleLineTextField descriptionTaskTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField nameOfTaskTextField;
        private MaterialSkin.Controls.MaterialRadioButton AutomaticTaskButton;
        private System.Windows.Forms.TabPage TabPageCurrentTasks;
        private MaterialSkin.Controls.MaterialLabel labelNoTasks;
        private MaterialSkin.Controls.MaterialListView ListViewTasks;
        private System.Windows.Forms.TabPage TabPageMonitoring;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.TabPage statisticTabPage;
        private MaterialSkin.Controls.MaterialRaisedButton buttonChangeColor;
        private MaterialSkin.Controls.MaterialRaisedButton buttonChangeTheme;
        private MaterialSkin.Controls.MaterialLabel labelColors;
        private MaterialSkin.Controls.MaterialRaisedButton buttonSignOut; 
        private System.Windows.Forms.Label labelDoneTasks;
        private MaterialSkin.Controls.MaterialListView ListDoneTask;
        private System.Windows.Forms.ColumnHeader numberOfTask;
        private System.Windows.Forms.ColumnHeader nameOfTask;
        private System.Windows.Forms.ColumnHeader complexity;
        private System.Windows.Forms.TabPage tabPageInfo;
        private MaterialSkin.Controls.MaterialRaisedButton telephoneSaveButton;
        private MaterialSkin.Controls.MaterialRaisedButton emailSaveButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField telephoneNumberTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField emailTextField;
        private MaterialSkin.Controls.MaterialRaisedButton changePasswordButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField newPasswordConfirmationTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField newPasswordTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField oldPasswordTextField;
        private MaterialSkin.Controls.MaterialLabel passwordsAreNotEqualLabel;
        private MaterialSkin.Controls.MaterialLabel incorrectPasswordLabel;
        private MaterialSkin.Controls.MaterialLabel tooShortPasswordLabel;
        private MaterialSkin.Controls.MaterialLabel incorrectTelephoneLabel;
        private MaterialSkin.Controls.MaterialLabel incorrectEmailLabel;
        private System.Windows.Forms.ColumnHeader columnTaskName;
        private System.Windows.Forms.ColumnHeader columnTaskDescription;
        private System.Windows.Forms.ColumnHeader columnPriority;
        private System.Windows.Forms.ColumnHeader columnCategory;
        private System.Windows.Forms.ColumnHeader columnDeadline;
        private MaterialSkin.Controls.MaterialLabel ratingMaterialLabel;
        private MaterialSkin.Controls.MaterialLabel textRatingMaterialLabel;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private MaterialSkin.Controls.MaterialContextMenuStrip isDoneContextMenuStrip;
        private MaterialSkin.Controls.MaterialToolStripMenuItem doneToolStripMenuItem;
        private MaterialSkin.Controls.MaterialRaisedButton addCategoryButton;
        private System.Windows.Forms.ToolStripMenuItem isReadyToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.ColumnHeader description;
    }
}
