using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace COMP231
{
    class Creep
    {
        private Rectangle positionRectangle;
        private Rectangle imageFrame;
        private int type;
        public int health;
        public double speed;
        private double time = 0;
        public int coins;

        public Creep(int type, double zoom)
        {
            this.type = type;

            switch (type)
            {
                case 0:
                    //first creep type
                    health = 5;
                    speed = 250;
                    coins = 1;
                    imageFrame = new Rectangle(0,0,5,5);
                    positionRectangle = new Rectangle((int)(5 * zoom), (int)(-5 * zoom), (int)(imageFrame.Width * zoom), (int)(imageFrame.Height * zoom));
                    break;
                case 1:
                    //first boss type
                    health = 50;
                    speed = 250;
                    coins = 10;
                    imageFrame = new Rectangle(5,0,5,5);
                    positionRectangle = new Rectangle((int)(5 * zoom), (int)(-5 * zoom), (int)(imageFrame.Width * zoom), (int)(imageFrame.Height * zoom));
                    break;
            }
        }

        public void Update(GameTime gameTime, Rectangle[] path, double zoom)
        {
            time += gameTime.ElapsedGameTime.TotalMilliseconds;
            if (time >= speed)
            {
                if (positionRectangle.Contains(path[0]))
                {
                    positionRectangle.Y += (int)(1 * zoom);
                }
                else if (positionRectangle.Contains(path[1]))
                {
                    positionRectangle.X += (int)(1 * zoom);
                }
                else if (positionRectangle.Contains(path[2]))
                {
                    positionRectangle.Y -= (int)(1 * zoom);
                }
                else if (positionRectangle.Contains(path[3]))
                {
                    positionRectangle.X += (int)(1 * zoom);
                }
                else if (positionRectangle.Contains(path[4]))
                {
                    positionRectangle.Y += (int)(1 * zoom);
                }
                else if (positionRectangle.Contains(path[5]))
                {
                    positionRectangle.X += (int)(1 * zoom);
                }
                else if (positionRectangle.Contains(path[6]))
                {
                    positionRectangle.Y -= (int)(1 * zoom);
                }
                else if (positionRectangle.Contains(path[7]))
                {
                    positionRectangle.X += (int)(1 * zoom);
                }
                else if (positionRectangle.Contains(path[8]))
                {
                    positionRectangle.Y += (int)(1 * zoom);
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch, Texture2D creepImage)
        {
            spriteBatch.Draw(creepImage, positionRectangle, imageFrame, Color.White);
        }

        public Vector3 getCreepCircle()
        {
            return new Vector3(
                (positionRectangle.X + (positionRectangle.Width / 2)),
                (positionRectangle.Y + (positionRectangle.Height / 2)),
                (positionRectangle.Width / 2));
        }
    }
}
