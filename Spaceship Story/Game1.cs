using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Spaceship_Story
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D BackgroundImage;
        Texture2D HUDImage;
        Texture2D MenuButton;
        MouseState mouseState = Mouse.GetState();
        int X;
        int Y;
        private Song BackgroundMusic;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            IsMouseVisible = true;
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

            // TODO: use this.Content to load your game content here
            BackgroundImage = Content.Load<Texture2D>("Space[1]");
            HUDImage = Content.Load<Texture2D>("NoButtonPressedMenu");
            Song BackgroundMusic = Content.Load<Song>("05 Come and Find Me");
            MenuButton = Content.Load<Texture2D>("MenuButtonUnpressed");
            MediaPlayer.Volume = 0.15f;
            MediaPlayer.Play(BackgroundMusic);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
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
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            if (mouseState.LeftButton == ButtonState.Pressed)
            {
                MenuButton = Content.Load<Texture2D>("MenuButtonPressed");
                GraphicsDevice.Clear(Color.Blue);
            }
                base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.BlueViolet);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            spriteBatch.Draw(BackgroundImage, new Vector2 (150, 57));
            spriteBatch.Draw(HUDImage, new Vector2(150, 298));
            spriteBatch.Draw(MenuButton, new Vector2(555, 305));
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
