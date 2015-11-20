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
        private bool is_dead;

        public form_game()
        {
            InitializeComponent();
            
            board = new Board(menuStrip1.Height, this.Width, this.Height);
            is_dead = false;

            //Timer and pause button should both be disabled upon creating the form.
            timer_game.Enabled = false;
            startGameToolStripMenuItem.Enabled = false;
        }

        private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
        {//Timer should start ticking here. Also, disable the start game button.
            timer_game.Enabled = true;
            startGameToolStripMenuItem.Enabled = false;
            is_dead = false;
        }

        private void pauseGameToolStripMenuItem_Click(object sender, EventArgs e)
        {//Timer should stop ticking here. Also, disable the pause game button.
            timer_game.Enabled = false;
            startGameToolStripMenuItem.Enabled = false;
        }

        private void quitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer_game_Tick(object sender, EventArgs e)
        {//Only tick if not dead.
            if (!is_dead)
            {//Update the board and draw it.
                board.update();
                draw();
            }
        }

        private void draw()
        {//Draw the board according to the current state.

        }
    }
}
