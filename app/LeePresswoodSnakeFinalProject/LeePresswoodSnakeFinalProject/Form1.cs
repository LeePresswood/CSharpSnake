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
        private Button[] buttons;

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
                if (board.getLastDirection() != Direction.Right)
                {
                    board.setDirection(Direction.Left);
                }

                return true;
            }
            else if (keyData == Keys.Right)
            {
                //You can only set this direction if not moving in the opposite direction.
                if (board.getLastDirection() != Direction.Left)
                {
                    board.setDirection(Direction.Right);
                }

                return true;
            }
            else if (keyData == Keys.Up)
            {
                //You can only set this direction if not moving in the opposite direction.
                if (board.getLastDirection() != Direction.Down)
                {
                    board.setDirection(Direction.Up);
                }

                return true;
            }
            else if (keyData == Keys.Down)
            {
                //You can only set this direction if not moving in the opposite direction.
                if (board.getLastDirection() != Direction.Up)
                {
                    board.setDirection(Direction.Down);
                }

                return true;
            }

            //Control keys.
            else if (keyData == Keys.F1)
            {
                start();
            }
            else if (keyData == Keys.F2)
            {
                pause();
            }
            else if (keyData == Keys.F3)
            {
                resume();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
        {//Timer should start ticking here. Also, disable the resume game button.
            start();
        }

        private void start()
        {
            if (startGameToolStripMenuItem.Enabled)
            {
                timer_game.Enabled = true;
                resumeToolStripMenuItem.Enabled = false;
                pauseGameToolStripMenuItem.Enabled = true;
                board = new Board(panel1.Width);

                //Upon creating the board, we want to create a grid of buttons.
                buttons = new Button[Board.BLOCKS_ACROSS * Board.BLOCKS_ACROSS];
                for (int i = 0; i < Board.BLOCKS_ACROSS * Board.BLOCKS_ACROSS; i++)
                {
                    buttons[i] = new Button();
                    buttons[i].Visible = false;
                    buttons[i].TabStop = false;
                    buttons[i].BackColor = Color.White;
                    buttons[i].FlatStyle = FlatStyle.Flat;
                    buttons[i].FlatAppearance.BorderSize = 0;

                    //Setting the bounds will depend upon the location in the array.
                    int x = (i % Board.BLOCKS_ACROSS) * board.block_size;
                    int y = (i / Board.BLOCKS_ACROSS) * board.block_size;
                    buttons[i].SetBounds(x, y, board.block_size, board.block_size);

                    panel1.Controls.Add(buttons[i]);
                }
            }
        }

        private void resumeToolStripMenuItem_Click(object sender, EventArgs e)
        {//Timer should start ticking here. Also, disable the resume game button.
            resume();
        }

        private void resume()
        {
            if (resumeToolStripMenuItem.Enabled)
            {
                timer_game.Enabled = true;
                resumeToolStripMenuItem.Enabled = false;
                pauseGameToolStripMenuItem.Enabled = true;
            }
        }

        private void pauseGameToolStripMenuItem_Click(object sender, EventArgs e)
        {//Timer should stop ticking here. Also, disable the pause game button.
            pause();
        }

        private void pause()
        {
            if (pauseGameToolStripMenuItem.Enabled)
            {
                timer_game.Enabled = false;
                resumeToolStripMenuItem.Enabled = true;
                pauseGameToolStripMenuItem.Enabled = false;
            }
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
            //Make all buttons invisible.
            for (int i = 0; i < Board.BLOCKS_ACROSS * Board.BLOCKS_ACROSS; i++)
            {
                buttons[i].Visible = false;
                buttons[i].BackColor = Color.White;
            }

            //Draw board by turning on buttons where they exist.
            for (int i = 0; i < board.segments.Count(); i++)
            {
                int coordinate_segment = board.segments[i].y * Board.BLOCKS_ACROSS + board.segments[i].x;
                buttons[coordinate_segment].BackColor = Color.Black;
            }

            //Draw apple.
            int coordinate_apple = board.apple_y * Board.BLOCKS_ACROSS + board.apple_x;
            buttons[coordinate_apple].BackColor = Color.Red;

            //Draw score.
            if(!textbox_score.Text.Equals("Segments: " + board.segments.Count()))
            {
                textbox_score.Text = "Segments: " + board.segments.Count();
            }
        }
    }
}
