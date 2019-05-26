using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Reflection;
using System.IO;
using System.Text;

namespace ManagementSystem
{
    public partial class ManagementSystemForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public Panel MainPanel { get => mainPanel; set => mainPanel = value; }
        public ManagementSystemForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            AuthorityUserControl = new AuthorityUserControl();
            UserControlMainMenu = new UserControlMainMenu();
            AddControl = new UserAddControl();
            //DeleteControl = new UserDeleteControl();
            CategoryControl = new AddCategoryControl();
        }
        private void ManagementSystemForm_Load(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Add(AuthorityUserControl);
        }
        
    }
}
