using System;
using Microsoft.Xna.Framework;

static class Program {
  [STAThread]
  static void Main(string[] args) {
    using (Game game = new Game())
    {
      new GraphicsDeviceManager(game);
      game.Run();
    }
  }
}
