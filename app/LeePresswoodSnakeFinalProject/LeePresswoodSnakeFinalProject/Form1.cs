﻿using System;
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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left)
            {
                board.setDirection(Direction.Left);
                return true;
            }
            else if (keyData == Keys.Right)
            {
                board.setDirection(Direction.Right);
                return true;
            }
            else if (keyData == Keys.Up)
            {
                board.setDirection(Direction.Up);
                return true;
            }
            else if (keyData == Keys.Down)
            {
                board.setDirection(Direction.Down);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
        {//Timer should start ticking here. Also, disable the resume game button.
            timer_game.Enabled = true;
            resumeToolStripMenuItem.Enabled = false;
            pauseGameToolStripMenuItem.Enabled = true;
            board = new Board(menuStrip1.Height, this.Width);
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
            //Remove old buttons
            while (Controls.Count > 1)
            {//First child is the menu bar. Otherwise, everything is a snake.
                Controls.RemoveAt(1);
            }

            //Draw board
            Button[] buttons = new Button[board.segments.Count()];
            for (int i = 0; i < board.segments.Count(); i++)
            {
                buttons[i] = new Button();
                buttons[i].BackColor = Color.Red;
                buttons[i].TabStop = false;
                buttons[i].FlatStyle = FlatStyle.Flat;
                buttons[i].FlatAppearance.BorderSize = 0;
                buttons[i].SetBounds(board.block_size * board.segments[i].x, menuStrip1.Height + board.block_size * board.segments[i].y, board.block_size, board.block_size);
                Controls.Add(buttons[i]);
            }

            //Draw score.
            textbox_score.Text = "Segments: " + board.segments.Count();
        }
    }
}
