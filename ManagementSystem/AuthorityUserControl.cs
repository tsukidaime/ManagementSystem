using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using MaterialSkin;
using MaterialSkin.Controls;
using ManagementSystemClassLibrary;
using System.Threading.Tasks;

namespace ManagementSystem
{
    public partial class AuthorityUserControl : UserControl
    {
        private readonly MaterialSkinManager materialSkinManager;
        private AuthManager serviceAuthorization;
        public AuthorityUserControl()
        {
            InitializeComponent();
            loginLineTextField.Focus();
            materialSkinManager = MaterialSkinManager.Instance;
            this.incorrectLabel.Font = materialSkinManager.ROBOTO_MEDIUM_11;
            serviceAuthorization = new AuthManager();
        }
        public void Translate()
        {
            loginLineTextField.Hint = Properties.Resources.Login;
            passwordLineTextField.Hint = Properties.Resources.Password;
            submitAuthorization.Text = Properties.Resources.SignIn;
            incorrectLabel.Text = Properties.Resources.IncorrectLoginOrPassword;
        }
        private void LanguagePickButtonKZ_Click(object sender, EventArgs e)
        {
            CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo("kk-KZ");
            (Form.ActiveForm as ManagementSystemForm).UserControlMainMenu.Translate();
            Translate();
        }

        private void LanguagePickButtonRU_Click(object sender, EventArgs e)
        {
            CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo("ru-RU");
            (Form.ActiveForm as ManagementSystemForm).UserControlMainMenu.Translate();
            Translate();
        }

        private void LanguagePickButtonEN_Click(object sender, EventArgs e)
        {
            CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            (Form.ActiveForm as ManagementSystemForm).UserControlMainMenu.Translate();
            Translate();
        }

        private void SubmitAuthorization_ClickAsync(object sender, EventArgs e)
        {
            if (!((loginLineTextField.Text == "") || (passwordLineTextField.Text == "")))
            {
                if (loginLineTextField.Text[0] >= '0' && loginLineTextField.Text[0] <= '9')
                {
                    loginLineTextField.Text = "";
                    passwordLineTextField.Text = "";
                    incorrectLabel.ForeColor = Color.Red;
                    incorrectLabel.Visible = true;
                }
                 var res =serviceAuthorization.AuthorityVerify(loginLineTextField.Text, passwordLineTextField.Text);
                (Form.ActiveForm as ManagementSystemForm).UserControlMainMenu.CurrentUser = res.Result;
                if ((Form.ActiveForm as ManagementSystemForm).UserControlMainMenu.CurrentUser!=null)
                {
                    (Form.ActiveForm as ManagementSystemForm).UserControlMainMenu.NameLabel.Text = (Form.ActiveForm as ManagementSystemForm).UserControlMainMenu.CurrentUser.FirstName;
                    (Form.ActiveForm as ManagementSystemForm).UserControlMainMenu.PositionLabel.Text = (Form.ActiveForm as ManagementSystemForm).UserControlMainMenu.CurrentUser.Position;
                    (Form.ActiveForm as ManagementSystemForm).UserControlMainMenu.RatingLabel.Text = (Form.ActiveForm as ManagementSystemForm).UserControlMainMenu.CurrentUser.Rating.ToString();
                    (Form.ActiveForm as ManagementSystemForm).UserControlMainMenu.AccessContoll((Form.ActiveForm as ManagementSystemForm).UserControlMainMenu.CurrentUser.AccessModifier);
                    (Form.ActiveForm as ManagementSystemForm).UserControlMainMenu.SeedListViewAsync();
                    (Form.ActiveForm as ManagementSystemForm).UserControlMainMenu.ListDoneTaskView();
                    (Form.ActiveForm as ManagementSystemForm).AuthorityUserControl.Visible = false;
                    (Form.ActiveForm as ManagementSystemForm).MainPanel.Controls.Add((Form.ActiveForm as ManagementSystemForm).UserControlMainMenu);
                    (Form.ActiveForm as ManagementSystemForm).MainPanel.Controls.Remove((Form.ActiveForm as ManagementSystemForm).AuthorityUserControl);
                }
                else
                {
                    loginLineTextField.Text = "";
                    passwordLineTextField.Text = "";
                    incorrectLabel.Visible = true;
                }
            }
        }

        private void PasswordLineTextField_KeyDownAsync(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SubmitAuthorization_ClickAsync(sender, e);
            }
        }
    }
}
