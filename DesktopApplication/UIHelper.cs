using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapLogic;

namespace DesktopApplication
{
    [System.ComponentModel.DesignerCategory("Code")]//This makes it so Visual Studio doesn't try to open this file in the Designer

    public class UIHelper : DesktopApplicationForm
    {
        /// <summary>
        /// Re-uses the arrow image resource by 
        /// flipping the appropriate bitmaps on the buttons.
        /// </summary>
        public static void FlipDirectionalArrows()
        {
            form.northBtn.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            form.eastBtn.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            form.southBtn.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipY);
        }

        /// <summary>
        /// Uses Buttons as a way to display a visual map.
        /// An array of buttons gives an easy interface since
        /// the data structure is an array of objects as well.
        /// </summary>
        public static void CreateButtonGrid()
        {
            int rows = MapManager.GridRowSize;
            int cols = MapManager.GridColumnSize;
            form.buttonArray = new Button[rows, cols];
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    form.buttonArray[r, c] = new Button
                    {
                        Dock = DockStyle.Fill,
                        Name = "buttonArray" + r + "_" + c,
                        BackgroundImageLayout = ImageLayout.Zoom,
                        UseVisualStyleBackColor = true,
                        Enabled = false
                    };
                    form.mapPanel.Controls.Add(form.buttonArray[r, c], c, r);//TableLayoutPanel is x,y unlike arrays which are y,x
                }
            }
        }

        /// <summary>
        /// Refreshes the text, title, and map
        /// </summary>
        public static void RefreshDisplay()
        {
            form.roomNameLabel.Text = MapManager.CurrentRoomName;
            form.descriptionBox.Text = MapManager.CurrentRoomDescription;
            form.buttonArray[MapManager.CurrentRow, MapManager.CurrentColumn].BackgroundImage = Properties.Resources.star1;
            if (MapManager.CurrentIsDiscovered) form.buttonArray[MapManager.CurrentRow, MapManager.CurrentColumn].BackColor = System.Drawing.Color.Gray;
        }

        /// <summary>
        /// Handles the event of any of the directional buttons being pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void DirButtonClick(object sender, EventArgs e)
        {
            form.buttonArray[MapManager.CurrentRow, MapManager.CurrentColumn].BackgroundImage = null;
            LocationUpdateHelper a = MapManager.AttemptMove((sender as Button).Name);
            if (a.Blocked == true)
            {
                form.buttonArray[a.Row, a.Column].BackgroundImage = Properties.Resources.X;
            }
            RefreshDisplay();
        }
    }
}
