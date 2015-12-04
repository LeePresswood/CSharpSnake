namespace LeePresswoodSnakeFinalProject
{
    partial class form_game
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textbox_score = new System.Windows.Forms.ToolStripTextBox();
            this.timer_game = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.speedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useSpecialApplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difficultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.impossibleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.textbox_score,
            this.speedToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(301, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startGameToolStripMenuItem,
            this.pauseGameToolStripMenuItem,
            this.resumeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 23);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // startGameToolStripMenuItem
            // 
            this.startGameToolStripMenuItem.Name = "startGameToolStripMenuItem";
            this.startGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.startGameToolStripMenuItem.Text = "(F1) Start";
            this.startGameToolStripMenuItem.Click += new System.EventHandler(this.startGameToolStripMenuItem_Click);
            // 
            // resumeToolStripMenuItem
            // 
            this.resumeToolStripMenuItem.Name = "resumeToolStripMenuItem";
            this.resumeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.resumeToolStripMenuItem.Text = "(F2) Resume";
            this.resumeToolStripMenuItem.Click += new System.EventHandler(this.resumeToolStripMenuItem_Click);
            // 
            // pauseGameToolStripMenuItem
            // 
            this.pauseGameToolStripMenuItem.Name = "pauseGameToolStripMenuItem";
            this.pauseGameToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.pauseGameToolStripMenuItem.Text = "(F3) Pause";
            this.pauseGameToolStripMenuItem.Click += new System.EventHandler(this.pauseGameToolStripMenuItem_Click);
            // 
            // textbox_score
            // 
            this.textbox_score.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.textbox_score.Enabled = false;
            this.textbox_score.Name = "textbox_score";
            this.textbox_score.ReadOnly = true;
            this.textbox_score.Size = new System.Drawing.Size(100, 23);
            this.textbox_score.Text = "Segments: ";
            // 
            // timer_game
            // 
            this.timer_game.Interval = 75;
            this.timer_game.Tick += new System.EventHandler(this.timer_game_Tick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 300);
            this.panel1.TabIndex = 1;
            // 
            // speedToolStripMenuItem
            // 
            this.speedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.difficultyToolStripMenuItem,
            this.useSpecialApplesToolStripMenuItem});
            this.speedToolStripMenuItem.Name = "speedToolStripMenuItem";
            this.speedToolStripMenuItem.Size = new System.Drawing.Size(61, 23);
            this.speedToolStripMenuItem.Text = "Settings";
            this.speedToolStripMenuItem.Click += new System.EventHandler(this.speedToolStripMenuItem_Click);
            // 
            // useSpecialApplesToolStripMenuItem
            // 
            this.useSpecialApplesToolStripMenuItem.Name = "useSpecialApplesToolStripMenuItem";
            this.useSpecialApplesToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.useSpecialApplesToolStripMenuItem.Text = "Use Special Apples";
            this.useSpecialApplesToolStripMenuItem.Click += new System.EventHandler(this.useSpecialApplesToolStripMenuItem_Click);
            // 
            // difficultyToolStripMenuItem
            // 
            this.difficultyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem1,
            this.mediumToolStripMenuItem1,
            this.hardToolStripMenuItem1,
            this.impossibleToolStripMenuItem1});
            this.difficultyToolStripMenuItem.Name = "difficultyToolStripMenuItem";
            this.difficultyToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.difficultyToolStripMenuItem.Text = "Difficulty";
            // 
            // easyToolStripMenuItem1
            // 
            this.easyToolStripMenuItem1.Name = "easyToolStripMenuItem1";
            this.easyToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.easyToolStripMenuItem1.Text = "Easy";
            this.easyToolStripMenuItem1.Click += new System.EventHandler(this.easyToolStripMenuItem1_Click);
            // 
            // mediumToolStripMenuItem1
            // 
            this.mediumToolStripMenuItem1.Checked = true;
            this.mediumToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mediumToolStripMenuItem1.Name = "mediumToolStripMenuItem1";
            this.mediumToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.mediumToolStripMenuItem1.Text = "Medium";
            this.mediumToolStripMenuItem1.Click += new System.EventHandler(this.mediumToolStripMenuItem1_Click);
            // 
            // hardToolStripMenuItem1
            // 
            this.hardToolStripMenuItem1.Name = "hardToolStripMenuItem1";
            this.hardToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.hardToolStripMenuItem1.Text = "Hard";
            this.hardToolStripMenuItem1.Click += new System.EventHandler(this.hardToolStripMenuItem1_Click);
            // 
            // impossibleToolStripMenuItem1
            // 
            this.impossibleToolStripMenuItem1.Name = "impossibleToolStripMenuItem1";
            this.impossibleToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.impossibleToolStripMenuItem1.Text = "Impossible";
            this.impossibleToolStripMenuItem1.Click += new System.EventHandler(this.impossibleToolStripMenuItem1_Click);
            // 
            // form_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(301, 327);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "form_game";
            this.ShowIcon = false;
            this.Text = "Snake";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseGameToolStripMenuItem;
        private System.Windows.Forms.Timer timer_game;
        private System.Windows.Forms.ToolStripMenuItem resumeToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripTextBox textbox_score;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem speedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useSpecialApplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem difficultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem impossibleToolStripMenuItem1;
    }
}

