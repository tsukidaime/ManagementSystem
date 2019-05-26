namespace ManagementSystem
{
    partial class UserAddControl
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
            this.fullNameLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.accessLevelLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.addUserButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ratingLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.positionLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.loginLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CancelFromAddUserButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.fillErrorLabel = new MaterialSkin.Controls.MaterialLabel();
            this.dateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.fillInputErrorLabel = new MaterialSkin.Controls.MaterialLabel();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.fillLoginErrorLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // fullNameLineTextField
            // 
            this.fullNameLineTextField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fullNameLineTextField.Depth = 0;
            this.fullNameLineTextField.Hint = "";
            this.fullNameLineTextField.Location = new System.Drawing.Point(48, 64);
            this.fullNameLineTextField.MaxLength = 32767;
            this.fullNameLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.fullNameLineTextField.Name = "fullNameLineTextField";
            this.fullNameLineTextField.PasswordChar = '\0';
            this.fullNameLineTextField.SelectedText = "";
            this.fullNameLineTextField.SelectionLength = 0;
            this.fullNameLineTextField.SelectionStart = 0;
            this.fullNameLineTextField.Size = new System.Drawing.Size(297, 23);
            this.fullNameLineTextField.TabIndex = 0;
            this.fullNameLineTextField.TabStop = false;
            this.fullNameLineTextField.UseSystemPasswordChar = false;
            // 
            // accessLevelLineTextField
            // 
            this.accessLevelLineTextField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accessLevelLineTextField.Depth = 0;
            this.accessLevelLineTextField.Hint = "";
            this.accessLevelLineTextField.Location = new System.Drawing.Point(48, 93);
            this.accessLevelLineTextField.MaxLength = 32767;
            this.accessLevelLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.accessLevelLineTextField.Name = "accessLevelLineTextField";
            this.accessLevelLineTextField.PasswordChar = '\0';
            this.accessLevelLineTextField.SelectedText = "";
            this.accessLevelLineTextField.SelectionLength = 0;
            this.accessLevelLineTextField.SelectionStart = 0;
            this.accessLevelLineTextField.Size = new System.Drawing.Size(297, 23);
            this.accessLevelLineTextField.TabIndex = 6;
            this.accessLevelLineTextField.TabStop = false;
            this.accessLevelLineTextField.UseSystemPasswordChar = false;
            // 
            // addUserButton
            // 
            this.addUserButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addUserButton.AutoSize = true;
            this.addUserButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addUserButton.Depth = 0;
            this.addUserButton.Icon = global::ManagementSystem.Properties.Resources.addusericon;
            this.addUserButton.Location = new System.Drawing.Point(50, 401);
            this.addUserButton.MinimumSize = new System.Drawing.Size(100, 36);
            this.addUserButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Primary = true;
            this.addUserButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addUserButton.Size = new System.Drawing.Size(100, 36);
            this.addUserButton.TabIndex = 9;
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.AddUserButton_ClickAsync);
            // 
            // ratingLineTextField
            // 
            this.ratingLineTextField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ratingLineTextField.Depth = 0;
            this.ratingLineTextField.Hint = "";
            this.ratingLineTextField.Location = new System.Drawing.Point(50, 183);
            this.ratingLineTextField.MaxLength = 32767;
            this.ratingLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.ratingLineTextField.Name = "ratingLineTextField";
            this.ratingLineTextField.PasswordChar = '\0';
            this.ratingLineTextField.SelectedText = "";
            this.ratingLineTextField.SelectionLength = 0;
            this.ratingLineTextField.SelectionStart = 0;
            this.ratingLineTextField.Size = new System.Drawing.Size(297, 23);
            this.ratingLineTextField.TabIndex = 16;
            this.ratingLineTextField.TabStop = false;
            this.ratingLineTextField.UseSystemPasswordChar = false;
            // 
            // positionLineTextField
            // 
            this.positionLineTextField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.positionLineTextField.Depth = 0;
            this.positionLineTextField.Hint = "";
            this.positionLineTextField.Location = new System.Drawing.Point(48, 154);
            this.positionLineTextField.MaxLength = 32767;
            this.positionLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.positionLineTextField.Name = "positionLineTextField";
            this.positionLineTextField.PasswordChar = '\0';
            this.positionLineTextField.SelectedText = "";
            this.positionLineTextField.SelectionLength = 0;
            this.positionLineTextField.SelectionStart = 0;
            this.positionLineTextField.Size = new System.Drawing.Size(297, 23);
            this.positionLineTextField.TabIndex = 14;
            this.positionLineTextField.TabStop = false;
            this.positionLineTextField.UseSystemPasswordChar = false;
            // 
            // loginLineTextField
            // 
            this.loginLineTextField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginLineTextField.Depth = 0;
            this.loginLineTextField.Hint = "";
            this.loginLineTextField.Location = new System.Drawing.Point(48, 125);
            this.loginLineTextField.MaxLength = 32767;
            this.loginLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginLineTextField.Name = "loginLineTextField";
            this.loginLineTextField.PasswordChar = '\0';
            this.loginLineTextField.SelectedText = "";
            this.loginLineTextField.SelectionLength = 0;
            this.loginLineTextField.SelectionStart = 0;
            this.loginLineTextField.Size = new System.Drawing.Size(297, 23);
            this.loginLineTextField.TabIndex = 10;
            this.loginLineTextField.TabStop = false;
            this.loginLineTextField.UseSystemPasswordChar = false;
            // 
            // CancelFromAddUserButton
            // 
            this.CancelFromAddUserButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelFromAddUserButton.AutoSize = true;
            this.CancelFromAddUserButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelFromAddUserButton.Depth = 0;
            this.CancelFromAddUserButton.Icon = global::ManagementSystem.Properties.Resources.cancelicon;
            this.CancelFromAddUserButton.Location = new System.Drawing.Point(243, 401);
            this.CancelFromAddUserButton.MinimumSize = new System.Drawing.Size(100, 36);
            this.CancelFromAddUserButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelFromAddUserButton.Name = "CancelFromAddUserButton";
            this.CancelFromAddUserButton.Primary = true;
            this.CancelFromAddUserButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CancelFromAddUserButton.Size = new System.Drawing.Size(100, 36);
            this.CancelFromAddUserButton.TabIndex = 18;
            this.CancelFromAddUserButton.UseVisualStyleBackColor = true;
            this.CancelFromAddUserButton.Click += new System.EventHandler(this.CancelFromAddUserButton_Click);
            // 
            // fillErrorLabel
            // 
            this.fillErrorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fillErrorLabel.AutoSize = true;
            this.fillErrorLabel.Depth = 0;
            this.fillErrorLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.fillErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fillErrorLabel.Location = new System.Drawing.Point(46, 270);
            this.fillErrorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.fillErrorLabel.Name = "fillErrorLabel";
            this.fillErrorLabel.Size = new System.Drawing.Size(0, 19);
            this.fillErrorLabel.TabIndex = 19;
            this.fillErrorLabel.Visible = false;
            // 
            // dateOfBirthPicker
            // 
            this.dateOfBirthPicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateOfBirthPicker.Location = new System.Drawing.Point(192, 212);
            this.dateOfBirthPicker.Name = "dateOfBirthPicker";
            this.dateOfBirthPicker.Size = new System.Drawing.Size(153, 20);
            this.dateOfBirthPicker.TabIndex = 20;
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(44, 212);
            this.dateOfBirthLabel.MinimumSize = new System.Drawing.Size(100, 2);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(100, 20);
            this.dateOfBirthLabel.TabIndex = 21;
            this.dateOfBirthLabel.Text = "Date of birth";
            // 
            // fillInputErrorLabel
            // 
            this.fillInputErrorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fillInputErrorLabel.AutoSize = true;
            this.fillInputErrorLabel.Depth = 0;
            this.fillInputErrorLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.fillInputErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fillInputErrorLabel.Location = new System.Drawing.Point(46, 310);
            this.fillInputErrorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.fillInputErrorLabel.Name = "fillInputErrorLabel";
            this.fillInputErrorLabel.Size = new System.Drawing.Size(0, 19);
            this.fillInputErrorLabel.TabIndex = 22;
            this.fillInputErrorLabel.Visible = false;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(192, 238);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(153, 21);
            this.categoryComboBox.TabIndex = 23;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.categoryLabel.Location = new System.Drawing.Point(44, 238);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(0, 20);
            this.categoryLabel.TabIndex = 24;
            // 
            // fillLoginErrorLabel
            // 
            this.fillLoginErrorLabel.AutoSize = true;
            this.fillLoginErrorLabel.Depth = 0;
            this.fillLoginErrorLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.fillLoginErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fillLoginErrorLabel.Location = new System.Drawing.Point(46, 349);
            this.fillLoginErrorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.fillLoginErrorLabel.Name = "fillLoginErrorLabel";
            this.fillLoginErrorLabel.Size = new System.Drawing.Size(0, 19);
            this.fillLoginErrorLabel.TabIndex = 25;
            this.fillLoginErrorLabel.Visible = false;
            // 
            // UserAddControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fillLoginErrorLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.fillInputErrorLabel);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.dateOfBirthPicker);
            this.Controls.Add(this.fillErrorLabel);
            this.Controls.Add(this.CancelFromAddUserButton);
            this.Controls.Add(this.ratingLineTextField);
            this.Controls.Add(this.positionLineTextField);
            this.Controls.Add(this.loginLineTextField);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.accessLevelLineTextField);
            this.Controls.Add(this.fullNameLineTextField);
            this.Name = "UserAddControl";
            this.Size = new System.Drawing.Size(400, 560);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField fullNameLineTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField accessLevelLineTextField;
        private MaterialSkin.Controls.MaterialRaisedButton addUserButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField ratingLineTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField positionLineTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField loginLineTextField;
        private MaterialSkin.Controls.MaterialRaisedButton CancelFromAddUserButton;
        private MaterialSkin.Controls.MaterialLabel fillErrorLabel;
        private System.Windows.Forms.DateTimePicker dateOfBirthPicker;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private MaterialSkin.Controls.MaterialLabel fillInputErrorLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label categoryLabel;
        private MaterialSkin.Controls.MaterialLabel fillLoginErrorLabel;
    }
}
