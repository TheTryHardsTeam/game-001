using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

class FNAGame: Game {
  [STAThread]
  static void Main(string[] args) {
    using (FNAGame game = new FNAGame())
    {
      game.Run();
    }
  }

  private KeyboardState keyboardPrevious = new KeyboardState();
  private MouseState mousePrevious = new MouseState();

  private SpriteBatch batch;
  private Texture2D texture;

  private SoundEffect sound;

  private FNAGame() {
    GraphicsDeviceManager graphicsDeviceManager = new GraphicsDeviceManager(this);

    graphicsDeviceManager.PreferredBackBufferWidth = 1920;
    graphicsDeviceManager.PreferredBackBufferHeight = 1080;
    graphicsDeviceManager.IsFullScreen = false;
    graphicsDeviceManager.SynchronizeWithVerticalRetrace = true;

    Content.RootDirectory = "Content";
  }

    protected override void Initialize()
    {
        /* This is a nice place to start up the engine, after
         * loading configuration stuff in the constructor
         */
        base.Initialize(); 
    }

    protected override void LoadContent()
    {
        batch = new SpriteBatch(GraphicsDevice);

        texture = Content.Load<Texture2D>("amadeus");

        sound = Content.Load<SoundEffect>("jump");


        // Load textures, sounds, and so on in here...
        base.LoadContent();
    }

    protected override void UnloadContent()
    {
        batch.Dispose();
        texture.Dispose();
        sound.Dispose();

        // Clean Up
        base.UnloadContent();
    }

    protected override void Update(GameTime gameTime)
    {
        // Run Game logic here, don't render anything here
        KeyboardState keyboardCurrent = Keyboard.GetState();
        MouseState mouseCurrent = Mouse.GetState();

        if (keyboardCurrent.IsKeyDown(Keys.Space) && keyboardPrevious.IsKeyUp(Keys.Space)) {
          System.Console.WriteLine("Space bar was pressed!!");
          sound.Play();
        }

        if (mouseCurrent.RightButton == ButtonState.Released && mousePrevious.RightButton == ButtonState.Pressed) {
          System.Console.WriteLine("Right Mouse Button was released!");
        }

        keyboardPrevious = keyboardCurrent;
        mousePrevious = mouseCurrent;

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        // Render stuff in here. Do NOT run game logic in here!
        GraphicsDevice.Clear(Color.CornflowerBlue);

        batch.Begin();
        batch.Draw(texture, Vector2.Zero, Color.White);
        batch.End();

        base.Draw(gameTime);
    }
}
