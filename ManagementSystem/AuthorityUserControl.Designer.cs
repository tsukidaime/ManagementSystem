namespace ManagementSystem
{
    partial class AuthorityUserControl
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
            this.authorityPanel = new System.Windows.Forms.Panel();
            this.incorrectLabel = new MaterialSkin.Controls.MaterialLabel();
            this.submitAuthorization = new MaterialSkin.Controls.MaterialRaisedButton();
            this.passwordLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.loginLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.languagePickButtonEN = new MaterialSkin.Controls.MaterialRaisedButton();
            this.languagePickButtonRU = new MaterialSkin.Controls.MaterialRaisedButton();
            this.languagePickButtonKZ = new MaterialSkin.Controls.MaterialRaisedButton();
            this.authorityPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // authorityPanel
            // 
            this.authorityPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.authorityPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.authorityPanel.Controls.Add(this.incorrectLabel);
            this.authorityPanel.Controls.Add(this.submitAuthorization);
            this.authorityPanel.Controls.Add(this.passwordLineTextField);
            this.authorityPanel.Controls.Add(this.loginLineTextField);
            this.authorityPanel.Controls.Add(this.languagePickButtonEN);
            this.authorityPanel.Controls.Add(this.languagePickButtonRU);
            this.authorityPanel.Controls.Add(this.languagePickButtonKZ);
            this.authorityPanel.Location = new System.Drawing.Point(0, 0);
            this.authorityPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.authorityPanel.MinimumSize = new System.Drawing.Size(1800, 1304);
            this.authorityPanel.Name = "authorityPanel";
            this.authorityPanel.Size = new System.Drawing.Size(1800, 1304);
            this.authorityPanel.TabIndex = 7;
            // 
            // incorrectLabel
            // 
            this.incorrectLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.incorrectLabel.AutoSize = true;
            this.incorrectLabel.BackColor = System.Drawing.Color.Transparent;
            this.incorrectLabel.Depth = 0;
            this.incorrectLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.incorrectLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.incorrectLabel.Image = global::ManagementSystem.Properties.Resources.accessdeniedicon;
            this.incorrectLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.incorrectLabel.Location = new System.Drawing.Point(580, 388);
            this.incorrectLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.incorrectLabel.MinimumSize = new System.Drawing.Size(400, 38);
            this.incorrectLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.incorrectLabel.Name = "incorrectLabel";
            this.incorrectLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.incorrectLabel.Size = new System.Drawing.Size(436, 38);
            this.incorrectLabel.TabIndex = 6;
            this.incorrectLabel.Text = "        Incorrect login or password";
            this.incorrectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.incorrectLabel.Visible = false;
            // 
            // submitAuthorization
            // 
            this.submitAuthorization.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submitAuthorization.AutoSize = true;
            this.submitAuthorization.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.submitAuthorization.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitAuthorization.Depth = 0;
            this.submitAuthorization.Icon = global::ManagementSystem.Properties.Resources.signinicon;
            this.submitAuthorization.Location = new System.Drawing.Point(760, 744);
            this.submitAuthorization.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.submitAuthorization.MinimumSize = new System.Drawing.Size(200, 77);
            this.submitAuthorization.MouseState = MaterialSkin.MouseState.HOVER;
            this.submitAuthorization.Name = "submitAuthorization";
            this.submitAuthorization.Primary = true;
            this.submitAuthorization.Size = new System.Drawing.Size(200, 77);
            this.submitAuthorization.TabIndex = 3;
            this.submitAuthorization.Text = global::ManagementSystem.Properties.Resources.SignIn;
            this.submitAuthorization.UseVisualStyleBackColor = true;
            this.submitAuthorization.Click += new System.EventHandler(this.SubmitAuthorization_ClickAsync);
            // 
            // passwordLineTextField
            // 
            this.passwordLineTextField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLineTextField.Depth = 0;
            this.passwordLineTextField.Hint = global::ManagementSystem.Properties.Resources.Password;
            this.passwordLineTextField.Location = new System.Drawing.Point(724, 615);
            this.passwordLineTextField.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.passwordLineTextField.MaxLength = 32767;
            this.passwordLineTextField.MinimumSize = new System.Drawing.Size(300, 48);
            this.passwordLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordLineTextField.Name = "passwordLineTextField";
            this.passwordLineTextField.PasswordChar = '\0';
            this.passwordLineTextField.SelectedText = "";
            this.passwordLineTextField.SelectionLength = 0;
            this.passwordLineTextField.SelectionStart = 0;
            this.passwordLineTextField.Size = new System.Drawing.Size(300, 48);
            this.passwordLineTextField.TabIndex = 2;
            this.passwordLineTextField.TabStop = false;
            this.passwordLineTextField.UseSystemPasswordChar = true;
            this.passwordLineTextField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordLineTextField_KeyDownAsync);
            // 
            // loginLineTextField
            // 
            this.loginLineTextField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginLineTextField.Depth = 0;
            this.loginLineTextField.Hint = global::ManagementSystem.Properties.Resources.Login;
            this.loginLineTextField.Location = new System.Drawing.Point(724, 523);
            this.loginLineTextField.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.loginLineTextField.MaxLength = 32767;
            this.loginLineTextField.MinimumSize = new System.Drawing.Size(300, 48);
            this.loginLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginLineTextField.Name = "loginLineTextField";
            this.loginLineTextField.PasswordChar = '\0';
            this.loginLineTextField.SelectedText = "";
            this.loginLineTextField.SelectionLength = 0;
            this.loginLineTextField.SelectionStart = 0;
            this.loginLineTextField.Size = new System.Drawing.Size(300, 48);
            this.loginLineTextField.TabIndex = 1;
            this.loginLineTextField.TabStop = false;
            this.loginLineTextField.UseSystemPasswordChar = false;
            // 
            // languagePickButtonEN
            // 
            this.languagePickButtonEN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.languagePickButtonEN.AutoSize = true;
            this.languagePickButtonEN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.languagePickButtonEN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.languagePickButtonEN.Depth = 0;
            this.languagePickButtonEN.Icon = null;
            this.languagePickButtonEN.Location = new System.Drawing.Point(1054, 896);
            this.languagePickButtonEN.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.languagePickButtonEN.MinimumSize = new System.Drawing.Size(100, 96);
            this.languagePickButtonEN.MouseState = MaterialSkin.MouseState.HOVER;
            this.languagePickButtonEN.Name = "languagePickButtonEN";
            this.languagePickButtonEN.Primary = true;
            this.languagePickButtonEN.Size = new System.Drawing.Size(100, 96);
            this.languagePickButtonEN.TabIndex = 2;
            this.languagePickButtonEN.Text = "EN";
            this.languagePickButtonEN.UseVisualStyleBackColor = true;
            this.languagePickButtonEN.Click += new System.EventHandler(this.LanguagePickButtonEN_Click);
            // 
            // languagePickButtonRU
            // 
            this.languagePickButtonRU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.languagePickButtonRU.AutoSize = true;
            this.languagePickButtonRU.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.languagePickButtonRU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.languagePickButtonRU.Depth = 0;
            this.languagePickButtonRU.Icon = null;
            this.languagePickButtonRU.Location = new System.Drawing.Point(822, 896);
            this.languagePickButtonRU.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.languagePickButtonRU.MinimumSize = new System.Drawing.Size(100, 96);
            this.languagePickButtonRU.MouseState = MaterialSkin.MouseState.HOVER;
            this.languagePickButtonRU.Name = "languagePickButtonRU";
            this.languagePickButtonRU.Primary = true;
            this.languagePickButtonRU.Size = new System.Drawing.Size(100, 96);
            this.languagePickButtonRU.TabIndex = 1;
            this.languagePickButtonRU.Text = "RU";
            this.languagePickButtonRU.UseVisualStyleBackColor = true;
            this.languagePickButtonRU.Click += new System.EventHandler(this.LanguagePickButtonRU_Click);
            // 
            // languagePickButtonKZ
            // 
            this.languagePickButtonKZ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.languagePickButtonKZ.AutoSize = true;
            this.languagePickButtonKZ.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.languagePickButtonKZ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.languagePickButtonKZ.Depth = 0;
            this.languagePickButtonKZ.Icon = null;
            this.languagePickButtonKZ.Location = new System.Drawing.Point(590, 896);
            this.languagePickButtonKZ.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.languagePickButtonKZ.MinimumSize = new System.Drawing.Size(100, 96);
            this.languagePickButtonKZ.MouseState = MaterialSkin.MouseState.HOVER;
            this.languagePickButtonKZ.Name = "languagePickButtonKZ";
            this.languagePickButtonKZ.Primary = true;
            this.languagePickButtonKZ.Size = new System.Drawing.Size(100, 96);
            this.languagePickButtonKZ.TabIndex = 0;
            this.languagePickButtonKZ.Text = "KZ";
            this.languagePickButtonKZ.UseVisualStyleBackColor = true;
            this.languagePickButtonKZ.Click += new System.EventHandler(this.LanguagePickButtonKZ_Click);
            // 
            // AuthorityUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.authorityPanel);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinimumSize = new System.Drawing.Size(1800, 1304);
            this.Name = "AuthorityUserControl";
            this.Size = new System.Drawing.Size(1800, 1304);
            this.authorityPanel.ResumeLayout(false);
            this.authorityPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton languagePickButtonKZ;
        private MaterialSkin.Controls.MaterialRaisedButton languagePickButtonRU;
        private MaterialSkin.Controls.MaterialRaisedButton languagePickButtonEN;
        private MaterialSkin.Controls.MaterialSingleLineTextField loginLineTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordLineTextField;
        private MaterialSkin.Controls.MaterialRaisedButton submitAuthorization;
        private MaterialSkin.Controls.MaterialLabel incorrectLabel;
        private System.Windows.Forms.Panel authorityPanel;
    }
}
    