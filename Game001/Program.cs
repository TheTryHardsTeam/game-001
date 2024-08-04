using System;
using Microsoft.Xna.Framework;

class FNAGame: Game {
  [STAThread]
  static void Main(string[] args) {
    using (FNAGame game = new FNAGame())
    {
      game.Run();
    }
  }

  private FNAGame() {
    GraphicsDeviceManager graphicsDeviceManager = new GraphicsDeviceManager(this);

    graphicsDeviceManager.PreferredBackBufferWidth = 1280;
    graphicsDeviceManager.PreferredBackBufferHeight = 720;
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
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        // Render stuff in here. Do NOT run game logic in here!
        GraphicsDevice.Clear(Color.CornflowerBlue);
        base.Draw(gameTime);
    }
}
