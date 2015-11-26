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
            panel1.TabStop = false;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left)
            {
                //You can only set this direction if not moving in the opposite direction.
                if (board.getDirection() != Direction.Right)
                {
                    board.setDirection(Direction.Left);
                }

                return true;
            }
            else if (keyData == Keys.Right)
            {
                //You can only set this direction if not moving in the opposite direction.
                if (board.getDirection() != Direction.Left)
                {
                    board.setDirection(Direction.Right);
                }

                return true;
            }
            else if (keyData == Keys.Up)
            {
                //You can only set this direction if not moving in the opposite direction.
                if (board.getDirection() != Direction.Down)
                {
                    board.setDirection(Direction.Up);
                }

                return true;
            }
            else if (keyData == Keys.Down)
            {
                //You can only set this direction if not moving in the opposite direction.
                if (board.getDirection() != Direction.Up)
                {
                    board.setDirection(Direction.Down);
                }

                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
        {//Timer should start ticking here. Also, disable the resume game button.
            timer_game.Enabled = true;
            resumeToolStripMenuItem.Enabled = false;
            pauseGameToolStripMenuItem.Enabled = true;
            board = new Board(panel1.Width);
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

                //Check death. Stop timer if dead.
                if (board.isDead())
                {
                    timer_game.Stop();
                }
            }
        }

        private void draw()
        {//Draw the board according to the current state.
            //Remove old buttons
            while (panel1.Controls.Count > 0)
            {
                panel1.Controls.Clear();
            }

            //Draw board
            Button[] buttons = new Button[board.segments.Count()];
            for (int i = 0; i < board.segments.Count(); i++)
            {
                buttons[i] = new Button();
                buttons[i].BackColor = Color.Black;
                buttons[i].TabStop = false;
                buttons[i].FlatStyle = FlatStyle.Flat;
                buttons[i].FlatAppearance.BorderSize = 0;
                buttons[i].SetBounds(board.block_size * board.segments[i].x, board.block_size * board.segments[i].y, board.block_size, board.block_size);
                
                panel1.Controls.Add(buttons[i]);
            }

            //Draw apple.
            Button apple = new Button();
            apple.BackColor = Color.Red;
            apple.TabStop = false;
            apple.FlatStyle = FlatStyle.Flat;
            apple.FlatAppearance.BorderSize = 0;
            apple.SetBounds(board.block_size * board.apple_x, board.block_size * board.apple_y, board.block_size, board.block_size);

            panel1.Controls.Add(apple);

            //Draw score.
            textbox_score.Text = "Segments: " + board.segments.Count();
        }
    }
}
