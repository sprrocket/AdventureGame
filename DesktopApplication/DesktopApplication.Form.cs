using System.Drawing;
using System.Windows.Forms;
using MapLogic;

namespace DesktopApplication
{
    public partial class DesktopApplicationForm : Form
    {
        public static DesktopApplicationForm form;
        
        public Button[,] buttonArray;

        public DesktopApplicationForm()
        {
            form = this;//lets us access this form from static methods
            InitializeComponent();
        }

        private void DesktopApplicationForm_Load(object sender, System.EventArgs e)
        {
            MapManager.SetupGameData();
            UIHelper.FlipDirectionalArrows();
            UIHelper.CreateButtonGrid();
            UIHelper.RefreshDisplay();
        }
        private void DirButtonClick(object sender, System.EventArgs e)
        {
            UIHelper.DirButtonClick(sender, e);
        }
    }
}
