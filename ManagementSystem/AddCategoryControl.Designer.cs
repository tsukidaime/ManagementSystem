namespace ManagementSystem
{
    partial class AddCategoryControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategoryControl));
            this.backToMainMenuButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.addCategoryButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.categoryTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.deleteCategoryButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // backToMainMenuButton
            // 
            this.backToMainMenuButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backToMainMenuButton.AutoSize = true;
            this.backToMainMenuButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backToMainMenuButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backToMainMenuButton.BackgroundImage")));
            this.backToMainMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backToMainMenuButton.Depth = 0;
            this.backToMainMenuButton.Icon = global::ManagementSystem.Properties.Resources.lefticon;
            this.backToMainMenuButton.Location = new System.Drawing.Point(177, 281);
            this.backToMainMenuButton.MinimumSize = new System.Drawing.Size(100, 40);
            this.backToMainMenuButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.backToMainMenuButton.Name = "backToMainMenuButton";
            this.backToMainMenuButton.Primary = true;
            this.backToMainMenuButton.Size = new System.Drawing.Size(100, 40);
            this.backToMainMenuButton.TabIndex = 13;
            this.backToMainMenuButton.Text = "Back";
            this.backToMainMenuButton.UseVisualStyleBackColor = true;
            this.backToMainMenuButton.Click += new System.EventHandler(this.BackToMainMenuButton_Click);
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
            this.addCategoryButton.Location = new System.Drawing.Point(306, 71);
            this.addCategoryButton.MinimumSize = new System.Drawing.Size(100, 30);
            this.addCategoryButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Primary = true;
            this.addCategoryButton.Size = new System.Drawing.Size(100, 36);
            this.addCategoryButton.TabIndex = 14;
            this.addCategoryButton.Text = "Add";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            this.addCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // categoryTextField
            // 
            this.categoryTextField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoryTextField.Depth = 0;
            this.categoryTextField.Hint = "New Category";
            this.categoryTextField.Location = new System.Drawing.Point(59, 77);
            this.categoryTextField.MaxLength = 32767;
            this.categoryTextField.MinimumSize = new System.Drawing.Size(200, 30);
            this.categoryTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.categoryTextField.Name = "categoryTextField";
            this.categoryTextField.PasswordChar = '\0';
            this.categoryTextField.SelectedText = "";
            this.categoryTextField.SelectionLength = 0;
            this.categoryTextField.SelectionStart = 0;
            this.categoryTextField.Size = new System.Drawing.Size(200, 30);
            this.categoryTextField.TabIndex = 16;
            this.categoryTextField.TabStop = false;
            this.categoryTextField.UseSystemPasswordChar = false;
            // 
            // deleteCategoryButton
            // 
            this.deleteCategoryButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteCategoryButton.AutoSize = true;
            this.deleteCategoryButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteCategoryButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteCategoryButton.BackgroundImage")));
            this.deleteCategoryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteCategoryButton.Depth = 0;
            this.deleteCategoryButton.Icon = global::ManagementSystem.Properties.Resources.deleteicon;
            this.deleteCategoryButton.Location = new System.Drawing.Point(306, 170);
            this.deleteCategoryButton.MinimumSize = new System.Drawing.Size(100, 30);
            this.deleteCategoryButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteCategoryButton.Name = "deleteCategoryButton";
            this.deleteCategoryButton.Primary = true;
            this.deleteCategoryButton.Size = new System.Drawing.Size(100, 36);
            this.deleteCategoryButton.TabIndex = 41;
            this.deleteCategoryButton.Text = "Delete";
            this.deleteCategoryButton.UseVisualStyleBackColor = true;
            this.deleteCategoryButton.Click += new System.EventHandler(this.DeleteCategoryButton_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(59, 179);
            this.categoryComboBox.MinimumSize = new System.Drawing.Size(200, 0);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(200, 21);
            this.categoryComboBox.TabIndex = 15;
            this.categoryComboBox.TabStop = false;
            // 
            // AddCategoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteCategoryButton);
            this.Controls.Add(this.categoryTextField);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.addCategoryButton);
            this.Controls.Add(this.backToMainMenuButton);
            this.Name = "AddCategoryControl";
            this.Size = new System.Drawing.Size(468, 370);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton backToMainMenuButton;
        private MaterialSkin.Controls.MaterialRaisedButton addCategoryButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField categoryTextField;
        private MaterialSkin.Controls.MaterialRaisedButton deleteCategoryButton;
        private System.Windows.Forms.ComboBox categoryComboBox;
    }
}
