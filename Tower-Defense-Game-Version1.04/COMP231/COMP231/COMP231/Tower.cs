using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace COMP231
{
    class Tower
    {
        private int type;
        private int subType;
        private int damage;
        public int cost;
        private double fireSpeed;
        private double time = 0;
        private int range;
        private Rectangle positionRectangle;
        private Rectangle imageFrame;

        public Tower(int type, double zoom)
        {
            this.type = type;
            this.subType = 0;

            switch (type)
            {
                case 0:
                    damage = 2;
                    fireSpeed = 500;
                    range =(int) (10 * zoom);
                    cost = 50;
                    break;
                case 1:
                    damage = 1;
                    fireSpeed = 250;
                    range = (int)(10 * zoom);
                    cost = 50;
                    break;
            }
        }

        public void Update(List<Creep> creeps, GameTime gameTime)
        {
            time += gameTime.ElapsedGameTime.TotalMilliseconds;
            if (time >= fireSpeed)
            {
                time = 0;
                switch (type)
                {
                    case 0:
                    case 1:
                        foreach (Creep creep in creeps)
                        {
                            if (this.inRangeOf(creep.getCreepCircle()))
                            {
                                creep.health -= damage;
                                break;
                            }
                        }
                        break;
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch, Texture2D towerImage)
        {
            spriteBatch.Draw( towerImage, positionRectangle, imageFrame, Color.White);
        }

        public bool inRangeOf(Vector3 creepCircle)
        {
            int dx = (positionRectangle.X + (positionRectangle.Width / 2)) - (int) creepCircle.X;
            int dy = (positionRectangle.Y + (positionRectangle.Height / 2)) - (int) creepCircle.Y;
            int radii = range + (int) creepCircle.Z;
            if ((dx * dx) + (dy * dy) < radii * radii)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
