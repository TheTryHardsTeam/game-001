using System;
using Microsoft.Xna.Framework;
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

  private FNAGame() {
    GraphicsDeviceManager graphicsDeviceManager = new GraphicsDeviceManager(this);

    graphicsDeviceManager.PreferredBackBufferWidth = 1920;
    graphicsDeviceManager.PreferredBackBufferHeight = 1080;
    graphicsDeviceManager.IsFullScreen = false;
    graphicsDeviceManager.SynchronizeWithVerticalRetrace = true;
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
        // Load textures, sounds, and so on in here...
        base.LoadContent();
    }

    protected override void UnloadContent()
    {
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
        base.Draw(gameTime);
    }
}
