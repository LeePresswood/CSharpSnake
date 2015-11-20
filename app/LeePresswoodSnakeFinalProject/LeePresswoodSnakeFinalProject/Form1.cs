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
        

        public form_game()
        {
            InitializeComponent();

            //Timer and pause button should both be disabled upon creating the form.
            timer_game.Enabled = false;
            startGameToolStripMenuItem.Enabled = false;
        }

        private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
        {//Timer should start ticking here. Also, disable the start game button.
            timer_game.Enabled = true;
            startGameToolStripMenuItem.Enabled = false;
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
    }
}
