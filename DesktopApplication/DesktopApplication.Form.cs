using GameLogic;
using System.Windows.Forms;

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
        private void FightButtonClick(object sender, System.EventArgs e)
        {
            UIHelper.FightButtonClick(sender, e);
        }

        private void loadToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a Cursor.  
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //openFileDialog1.Filter = "Cursor Files|*.cur";
            //openFileDialog1.Title = "Select a Cursor File";

            // Show the Dialog.  
            // If the user clicked OK in the dialog and  
            // a .CUR file was selected, open it.  
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Assign the cursor in the Stream to the Form's Cursor property.  
                SaveLoad.LoadGame(openFileDialog1.FileName);
                MessageBox.Show("Loaded.");
                //this.Cursor = new Cursor(openFileDialog1.OpenFile());
            }
            mapPanel.Controls.Clear();
            UIHelper.CreateButtonGrid();
            UIHelper.RefreshDisplay();
        }

        private void saveToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.ShowDialog();
            if (s.FileName != "")
            {
                SaveLoad.SaveGame(s.FileName);
            }
        }
    }
}
