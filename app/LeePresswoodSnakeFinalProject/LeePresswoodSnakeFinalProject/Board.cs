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
        public Direction next_direction;

        public Board()
        {
            next_direction = Direction.Left;
        }
    }
}
