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
        private const int BLOCKS_ACROSS = 30;
        public int block_size;

        //Locations of the snake.
        public List<GameTile> segments;
        public int apple_x, apple_y;

        //The direction the snake will move in the next tick.
        private Direction next_direction;

        public Board(int width)
        {
            block_size = width / BLOCKS_ACROSS;
            next_direction = Direction.Right;

            segments = new List<GameTile>();
            segments.Add(new GameTile(2, 2));
        }

        public void update()
        {//Game tick happened, so move the snake forward according to the next_direction variable.
            //For all snake segments behind the head, move.
            if (segments.Count() > 1)
            {
                for (int i = 1; i < segments.Count(); i++)
                {
                    segments[i].x = segments[i - 1].x;
                    segments[i].y = segments[i - 1].y;
                }
            }

            //Move head based upon the direction.
            switch (next_direction)
            {
                case Direction.Left:
                    segments[0].x -= 1;
                    break;
                case Direction.Right:
                    segments[0].x += 1;
                    break;
                case Direction.Up:
                    segments[0].y -= 1;
                    break;
                case Direction.Down:
                    segments[0].y += 1;
                    break;
            }
        }

        public void setDirection(Direction d)
        {
            next_direction = d;
        }

        public Direction getDirection()
        {
            return next_direction;
        }

        public void collectApple()
        {

        }

        public void placeRandomApple()
        {//Place an apple on the board. The apple is guaranteed to not be located on top of the snake.
            bool is_bad;
            
            do
            {
                is_bad = false;

                //Get an X and Y.
                int a_x = new Random().Next(BLOCKS_ACROSS);
                int a_y = new Random().Next(BLOCKS_ACROSS);

                //Check.
                foreach (GameTile segment in segments)
                {
                    if (segment.x == a_x && segment.y == a_y)
                    {
                        is_bad = true;
                    }
                }
            } while (is_bad);
        }

        public bool isDead()
        {
            return false;
        }
    }
}
