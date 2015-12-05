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

            startGameToolStripMenuItem.ShortcutKeys = Keys.F1;
            pauseGameToolStripMenuItem.ShortcutKeys = Keys.F2;
            resumeToolStripMenuItem.ShortcutKeys = Keys.F3;

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

                //Pressing start again after the first time the game is started will lead to multiple games being on the screen. Clear these.
                panel1.Controls.Clear();

                //Upon creating the board, we want to create a grid of buttons.
                buttons = new Button[Board.BLOCKS_ACROSS * Board.BLOCKS_ACROSS];
                for (int i = 0; i < Board.BLOCKS_ACROSS * Board.BLOCKS_ACROSS; i++)
                {
                    buttons[i] = new Button();
                    buttons[i].Visible = true;
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
                
                //Check death. Stop timer if dead. Draw otherwise.
                if (board.isDead())
                {
                    timer_game.Stop();
                    textbox_score.Text = "Died with " + board.segments.Count() + " Segments";
                }
                else
                {
                    draw();
                }
            }
        }

        private void draw()
        {//Draw the board according to the current state.
            //Make all old segments invisible.
            foreach (GameTile old_segment in board.old_segments)
            {
                int coordinate_old_segment = old_segment.y * Board.BLOCKS_ACROSS + old_segment.x;
                buttons[coordinate_old_segment].BackColor = Color.White;
            }

            //Draw apple.
            int coordinate_apple = board.apple_y * Board.BLOCKS_ACROSS + board.apple_x;
            buttons[coordinate_apple].BackColor = Color.Red;

            //Draw board by turning on buttons where they exist.
            for (int i = 0; i < board.segments.Count(); i++)
            {
                int coordinate_segment = board.segments[i].y * Board.BLOCKS_ACROSS + board.segments[i].x;
                buttons[coordinate_segment].BackColor = Color.Black;
            }

            //Draw score.
            if(!textbox_score.Text.Equals("Segments: " + board.segments.Count()))
            {
                textbox_score.Text = "Segments: " + board.segments.Count();
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pause();
        }

        private void speedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pause();
        }

        private void easyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            easyToolStripMenuItem1.Checked = true;
            mediumToolStripMenuItem1.Checked = false;
            hardToolStripMenuItem1.Checked = false;
            impossibleToolStripMenuItem1.Checked = false;

            changeDifficulty(125);
        }

        private void mediumToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            easyToolStripMenuItem1.Checked = false;
            mediumToolStripMenuItem1.Checked = true;
            hardToolStripMenuItem1.Checked = false;
            impossibleToolStripMenuItem1.Checked = false;

            changeDifficulty(75);
        }

        private void hardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            easyToolStripMenuItem1.Checked = false;
            mediumToolStripMenuItem1.Checked = false;
            hardToolStripMenuItem1.Checked = true;
            impossibleToolStripMenuItem1.Checked = false;

            changeDifficulty(40);
        }

        private void impossibleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            easyToolStripMenuItem1.Checked = false;
            mediumToolStripMenuItem1.Checked = false;
            hardToolStripMenuItem1.Checked = false;
            impossibleToolStripMenuItem1.Checked = true;

            changeDifficulty(20);
        }

        private void changeDifficulty(int speed)
        {
            timer_game.Interval = speed;
            start();
        }
    }
}
