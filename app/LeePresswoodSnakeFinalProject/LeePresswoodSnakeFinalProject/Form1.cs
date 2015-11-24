using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeePresswoodSnakeFinalProject
{
    public partial class form_game : Form
    {
        private Board board;

        public form_game()
        {
            InitializeComponent();
            
            //Timer and pause button should both be disabled upon creating the form.
            timer_game.Enabled = false;
            resumeToolStripMenuItem.Enabled = false;
            pauseGameToolStripMenuItem.Enabled = false;
        }

        private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
        {//Timer should start ticking here. Also, disable the resume game button.
            timer_game.Enabled = true;
            resumeToolStripMenuItem.Enabled = false;
            pauseGameToolStripMenuItem.Enabled = true;
            board = new Board(menuStrip1.Height, this.Width, this.Height);
        }

        private void resumeToolStripMenuItem_Click(object sender, EventArgs e)
        {//Timer should start ticking here. Also, disable the resume game button.
            timer_game.Enabled = true;
            resumeToolStripMenuItem.Enabled = false;
            pauseGameToolStripMenuItem.Enabled = true;
        }

        private void pauseGameToolStripMenuItem_Click(object sender, EventArgs e)
        {//Timer should stop ticking here. Also, disable the pause game button.
            timer_game.Enabled = false;
            resumeToolStripMenuItem.Enabled = true;
            pauseGameToolStripMenuItem.Enabled = false;
        }

        private void timer_game_Tick(object sender, EventArgs e)
        {//Only tick if not dead.
            if (!board.isDead())
            {//Update the board and draw it.
                board.update();
                draw();
            }
        }

        private void draw()
        {//Draw the board according to the current state.
            //Remove old buttons.


            //Draw board.
            Button[] buttons = new Button[board.segments.Count()];
            foreach(Button b in buttons)
            {
                b.SetBounds(1, 1, board.block_size, board.block_size);
            }

            //Draw score.
            textbox_score.Text = "Segments: " + board.segments.Count();
        }
    }
}
