using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace COMP231
{
    class TowerCreepManager
    {
        private Texture2D creepImage, towerImage;
        private Rectangle[] path;
        private List<Creep> creeps;
        private List<Tower> towers;

        public TowerCreepManager(Texture2D creepSprites, Texture2D towerSprites, Rectangle[] path)
        {
            this.creepImage = creepSprites;
            this.towerImage = towerSprites;
            this.path = path;
        }

        public void Update(GameTime gameTime, double zoom, Rectangle[] path)
        {
            foreach (Tower t in towers)
            {
                t.Update(creeps, gameTime);
            }

            foreach (Creep c in creeps)
            {
                c.Update(gameTime, path, zoom);
            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (Tower t in towers)
            {
                t.Draw(spriteBatch, towerImage);
            }

            foreach (Creep c in creeps)
            {
                c.Draw(spriteBatch, creepImage);
            }
        }
    }
}
