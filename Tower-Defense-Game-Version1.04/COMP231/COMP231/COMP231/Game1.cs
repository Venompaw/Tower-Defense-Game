using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace COMP231
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        TowerCreepManager manager;
        Rectangle[] path;
        double zoom;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            path = new Rectangle[9];
            path[0] = new Rectangle((int)(5 * zoom), (int)(-5 * zoom), (int)(5 * zoom), (int)(35 * zoom));
            path[1] = new Rectangle((int)(5 * zoom), (int)(35 * zoom), (int)(15 * zoom), (int)(5 * zoom));
            path[2] = new Rectangle((int)(20 * zoom), (int)(10 * zoom), (int)(5 * zoom), (int)(30 * zoom));
            path[3] = new Rectangle((int)(20 * zoom), (int)(5 * zoom), (int)(15 * zoom), (int)(5 * zoom));
            path[4] = new Rectangle((int)(35 * zoom), (int)(5 * zoom), (int)(5 * zoom), (int)(30 * zoom));
            path[5] = new Rectangle((int)(35 * zoom), (int)(35 * zoom), (int)(15 * zoom), (int)(5 * zoom));
            path[6] = new Rectangle((int)(50 * zoom), (int)(10 * zoom), (int)(5 * zoom), (int)(30 * zoom));
            path[7] = new Rectangle((int)(50 * zoom), (int)(5 * zoom), (int)(15 * zoom), (int)(5 * zoom));
            path[8] = new Rectangle((int)(65 * zoom), (int)(5 * zoom), (int)(5 * zoom), (int)(40 * zoom));

            manager = new TowerCreepManager(Content.Load<Texture2D>(@"Sprites\CreepSprites"), Content.Load<Texture2D>(@"Sprites\TowerSprites"), path);
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
