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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.timer_game = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.textbox_score});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startGameToolStripMenuItem,
            this.resumeToolStripMenuItem,
            this.pauseGameToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // startGameToolStripMenuItem
            // 
            this.startGameToolStripMenuItem.Name = "startGameToolStripMenuItem";
            this.startGameToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.startGameToolStripMenuItem.Text = "Start";
            this.startGameToolStripMenuItem.Click += new System.EventHandler(this.startGameToolStripMenuItem_Click);
            // 
            // resumeToolStripMenuItem
            // 
            this.resumeToolStripMenuItem.Name = "resumeToolStripMenuItem";
            this.resumeToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.resumeToolStripMenuItem.Text = "Resume";
            this.resumeToolStripMenuItem.Click += new System.EventHandler(this.resumeToolStripMenuItem_Click);
            // 
            // pauseGameToolStripMenuItem
            // 
            this.pauseGameToolStripMenuItem.Name = "pauseGameToolStripMenuItem";
            this.pauseGameToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.pauseGameToolStripMenuItem.Text = "Pause";
            this.pauseGameToolStripMenuItem.Click += new System.EventHandler(this.pauseGameToolStripMenuItem_Click);
            // 
            // textbox_score
            // 
            this.textbox_score.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.textbox_score.Name = "textbox_score";
            this.textbox_score.ReadOnly = true;
            this.textbox_score.Size = new System.Drawing.Size(100, 23);
            this.textbox_score.Text = "Segments: ";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 27);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 408);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // timer_game
            // 
            this.timer_game.Tick += new System.EventHandler(this.timer_game_Tick);
            // 
            // form_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 435);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.menuStrip1);
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
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Timer timer_game;
        private System.Windows.Forms.ToolStripMenuItem resumeToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripTextBox textbox_score;
    }
}

