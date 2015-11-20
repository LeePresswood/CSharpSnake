using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeePresswoodSnakeFinalProject
{
    //The direction the snake is moving.
    enum Direction 
    { 
        Left, Right, Up, Down 
    }

    class Board
    {
        //Size of blocks.
        private const int BLOCKS_ACROSS = 10;
        public int block_size;

        //Locations of the snake.
        public List<Segment> segments;

        //The direction the snake will move in the next tick.
        private Direction next_direction;

        public Board(int start, int width, int height)
        {
            block_size = width / BLOCKS_ACROSS;
            next_direction = Direction.Left;
        }

        public void update()
        {//Game tick happened, so move the snake forward according to the next_direction variable.

        }

        public bool isDead()
        {
            return false;
        }
    }
}
