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
        public const int BLOCKS_ACROSS = 30;
        public int block_size;

        //Locations of the snake.
        public List<GameTile> segments;
        public GameTile old_tail;
        public int apple_x, apple_y;
        public bool just_spawned;

        //The direction the snake will move in the next tick.
        private Direction next_direction;
        private Direction last_direction;

        public Board(int width)
        {
            block_size = width / BLOCKS_ACROSS;
            next_direction = Direction.Right;

            segments = new List<GameTile>();
            segments.Add(new GameTile(2, 2));

            placeRandomApple();
        }

        public void update()
        {//Game tick happened, so move the snake forward according to the next_direction variable.
            //Store the old locations of the snake.
            old_tail = new GameTile(segments.Last().x, segments.Last().y);
            
            //For all snake segments behind the head, move.
            if (segments.Count() > 1)
            {
                for (int i = segments.Count() - 1; i != 0; i--)
                {
                    if (i == segments.Count() - 1 && just_spawned)
                    {//After eating an apple, the new segment will be added to the list at the location of the tail of the snake. This segment should not move until one update later to show growth.
                        just_spawned = false;
                    }
                    else
                    {
                        segments[i].x = segments[i - 1].x;
                        segments[i].y = segments[i - 1].y;
                    }
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
            last_direction = next_direction;

            //Check apple collect.
            if (segments[0].x == apple_x && segments[0].y == apple_y)
            {
                collectApple();
            }
        }

        public void setDirection(Direction d)
        {
            next_direction = d;
        }

        public Direction getLastDirection()
        {
            return last_direction;
        }

        public void collectApple()
        {
            //Add to the length of the snake. The new segment should be located on top of the tail of the snake.
            segments.Add(new GameTile(segments.Last().x, segments.Last().y)); 
            just_spawned = true;
            
            //Spawn a new apple.
            placeRandomApple();
        }

        public void placeRandomApple()
        {//Place an apple on the board. The apple is guaranteed to not be located on top of the snake.
            bool is_bad;
            Random randomizer = new Random(DateTime.Now.Millisecond);
            do
            {
                is_bad = false;

                //Get an X and Y.
                int a_x = randomizer.Next(BLOCKS_ACROSS);
                int a_y = randomizer.Next(BLOCKS_ACROSS);

                //Check.
                foreach (GameTile segment in segments)
                {
                    if (segment.x == a_x && segment.y == a_y)
                    {
                        is_bad = true;
                    }
                }

                //Store if the values are good.
                if (is_bad == false)
                {
                    apple_x = a_x;
                    apple_y = a_y;
                }
            } while (is_bad);
        }

        public bool isDead()
        {
            bool border_check = segments.First().x < 0 || segments.First().x >= BLOCKS_ACROSS || segments.First().y < 0 || segments.First().y >= BLOCKS_ACROSS;
            
            bool segment_check = false;
            for (int i = 2; i < segments.Count(); i++)
            {
                segment_check |= segments.First().x == segments[i].x && segments.First().y == segments[i].y;
            }

            return border_check || segment_check;
        }
    }
}
