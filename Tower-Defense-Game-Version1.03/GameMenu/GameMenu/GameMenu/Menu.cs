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


namespace GameMenu
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public class Menu : DrawableGameComponent
    {
        
        SpriteBatch spriteBatch;

        public Intro intro;
        public Map map;
        Rectangle easyRectangle;
        Rectangle normalRectangle;
        Rectangle hardRectangle;
        Rectangle marathonRectangle;
        
        Texture2D menu;

        Rectangle mouse;
        
        ButtonState oldState;
        public Menu(Game game): base (game)
        {
           
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        public override void Initialize()
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

            menu = Game.Content.Load<Texture2D>(@"Images\Difficulty");
            
            easyRectangle = new Rectangle(250, 160, 300, 40);
            normalRectangle = new Rectangle(250, 220, 300, 40);
            hardRectangle = new Rectangle(250, 280, 300, 40);
            marathonRectangle = new Rectangle(250, 340, 300, 40);

            // TODO: use this.Content to load your game content here
            base.LoadContent();
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


        public override void Update(GameTime gameTime)
        { 
            MouseState mouseState = Mouse.GetState();
            
            // Allows the game to exit
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
        {
        }
                        
        mouse = new Rectangle(mouseState.X, mouseState.Y, 1, 1);
            
        if (easyRectangle.Contains(mouse) && mouseState.LeftButton == ButtonState.Pressed && oldState == ButtonState.Released)
        {
            this.Visible = false;
            this.Enabled = false;            
        }
        if (normalRectangle.Contains(mouse) && mouseState.LeftButton == ButtonState.Pressed && oldState != ButtonState.Pressed)
        {
            this.Visible = false;
            this.Enabled = false;
        }
        if (hardRectangle.Contains(mouse) && mouseState.LeftButton == ButtonState.Pressed && oldState != ButtonState.Pressed)
        {
            this.Visible = false;
            this.Enabled = false;
        }
        if (marathonRectangle.Contains(mouse) && mouseState.LeftButton == ButtonState.Pressed && oldState != ButtonState.Pressed)
        {
            this.Visible = false;
            this.Enabled = false;
        }
        oldState = mouseState.LeftButton;
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            spriteBatch.Begin();
            spriteBatch.Draw(menu, GraphicsDevice.Viewport.Bounds, Color.White);            
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
