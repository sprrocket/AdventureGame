using System.Windows.Forms;

namespace DesktopApplication
{
    partial class DesktopApplicationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mapPanel = new System.Windows.Forms.TableLayoutPanel();
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.roomNameLabel = new System.Windows.Forms.Label();
            this.legendBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.eastBtn = new System.Windows.Forms.Button();
            this.southBtn = new System.Windows.Forms.Button();
            this.westBtn = new System.Windows.Forms.Button();
            this.FightButton = new System.Windows.Forms.Button();
            this.northBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapPanel
            // 
            this.mapPanel.ColumnCount = 3;
            this.mapPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mapPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mapPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33331F));
            this.mapPanel.Location = new System.Drawing.Point(13, 29);
            this.mapPanel.Name = "mapPanel";
            this.mapPanel.RowCount = 4;
            this.mapPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mapPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mapPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mapPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mapPanel.Size = new System.Drawing.Size(428, 523);
            this.mapPanel.TabIndex = 0;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.descriptionBox.Location = new System.Drawing.Point(447, 29);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ReadOnly = true;
            this.descriptionBox.Size = new System.Drawing.Size(307, 220);
            this.descriptionBox.TabIndex = 1;
            this.descriptionBox.TabStop = false;
            this.descriptionBox.Text = "";
            // 
            // roomNameLabel
            // 
            this.roomNameLabel.AutoSize = true;
            this.roomNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNameLabel.Location = new System.Drawing.Point(447, 9);
            this.roomNameLabel.Name = "roomNameLabel";
            this.roomNameLabel.Size = new System.Drawing.Size(0, 20);
            this.roomNameLabel.TabIndex = 3;
            this.roomNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // legendBtn
            // 
            this.legendBtn.BackColor = System.Drawing.Color.Gray;
            this.legendBtn.Enabled = false;
            this.legendBtn.Location = new System.Drawing.Point(451, 534);
            this.legendBtn.Name = "legendBtn";
            this.legendBtn.Size = new System.Drawing.Size(20, 20);
            this.legendBtn.TabIndex = 4;
            this.legendBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 538);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "= Visited";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 519);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "= Blocked";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::DesktopApplication.Properties.Resources.X;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(451, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // eastBtn
            // 
            this.eastBtn.BackgroundImage = global::DesktopApplication.Properties.Resources.arrow;
            this.eastBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eastBtn.Location = new System.Drawing.Point(650, 370);
            this.eastBtn.Name = "eastBtn";
            this.eastBtn.Size = new System.Drawing.Size(70, 70);
            this.eastBtn.TabIndex = 2;
            this.eastBtn.TabStop = false;
            this.eastBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.eastBtn.UseVisualStyleBackColor = true;
            this.eastBtn.Click += new System.EventHandler(this.DirButtonClick);
            // 
            // southBtn
            // 
            this.southBtn.BackgroundImage = global::DesktopApplication.Properties.Resources.arrow;
            this.southBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.southBtn.Location = new System.Drawing.Point(574, 446);
            this.southBtn.Name = "southBtn";
            this.southBtn.Size = new System.Drawing.Size(70, 70);
            this.southBtn.TabIndex = 2;
            this.southBtn.TabStop = false;
            this.southBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.southBtn.UseVisualStyleBackColor = true;
            this.southBtn.Click += new System.EventHandler(this.DirButtonClick);
            // 
            // westBtn
            // 
            this.westBtn.BackgroundImage = global::DesktopApplication.Properties.Resources.arrow;
            this.westBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.westBtn.Location = new System.Drawing.Point(498, 370);
            this.westBtn.Name = "westBtn";
            this.westBtn.Size = new System.Drawing.Size(70, 70);
            this.westBtn.TabIndex = 2;
            this.westBtn.TabStop = false;
            this.westBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.westBtn.UseVisualStyleBackColor = true;
            this.westBtn.Click += new System.EventHandler(this.DirButtonClick);
            // 
            // FightButton
            // 
            this.FightButton.BackgroundImage = global::DesktopApplication.Properties.Resources.swords;
            this.FightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FightButton.Enabled = false;
            this.FightButton.Location = new System.Drawing.Point(574, 370);
            this.FightButton.Name = "FightButton";
            this.FightButton.Size = new System.Drawing.Size(70, 70);
            this.FightButton.TabIndex = 2;
            this.FightButton.TabStop = false;
            this.FightButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FightButton.UseVisualStyleBackColor = true;
            this.FightButton.Click += new System.EventHandler(this.FightButtonClick);
            // 
            // northBtn
            // 
            this.northBtn.BackgroundImage = global::DesktopApplication.Properties.Resources.arrow;
            this.northBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.northBtn.Location = new System.Drawing.Point(574, 294);
            this.northBtn.Name = "northBtn";
            this.northBtn.Size = new System.Drawing.Size(70, 70);
            this.northBtn.TabIndex = 2;
            this.northBtn.TabStop = false;
            this.northBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.northBtn.UseVisualStyleBackColor = true;
            this.northBtn.Click += new System.EventHandler(this.DirButtonClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 48);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(766, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(0, 24);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(766, 24);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(766, 24);
            this.menuStrip3.TabIndex = 8;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // DesktopApplicationForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(766, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.legendBtn);
            this.Controls.Add(this.roomNameLabel);
            this.Controls.Add(this.eastBtn);
            this.Controls.Add(this.southBtn);
            this.Controls.Add(this.westBtn);
            this.Controls.Add(this.FightButton);
            this.Controls.Add(this.northBtn);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.mapPanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "DesktopApplicationForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "AdventureGame";
            this.Load += new System.EventHandler(this.DesktopApplicationForm_Load);
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel mapPanel;
        public System.Windows.Forms.RichTextBox descriptionBox;
        public Label roomNameLabel;
        public Button northBtn;
        public Button westBtn;
        public Button eastBtn;
        public Button southBtn;
        public Button legendBtn;
        private Label label1;
        public Button button1;
        private Label label2;
        public Button FightButton;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private MenuStrip menuStrip3;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
    }
}

