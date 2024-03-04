using System.Collections;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace KNT;

public class Game1 : Game
{
     Texture2D ballTexture;
    
     GraphicsDeviceManager _graphics;
     SpriteBatch _spriteBatch;
  
ArrayList ALEnemies;

    public Game1()
    {
            _graphics = new GraphicsDeviceManager(this);
    _graphics.GraphicsProfile = GraphicsProfile.HiDef;
    Content.RootDirectory = "Content";
    IsMouseVisible = true;

    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here
        ALEnemies = new ArrayList();

        _graphics.PreferredBackBufferHeight = 768;
_graphics.PreferredBackBufferWidth = 1024;
_graphics.ApplyChanges();

        base.Initialize();
    }

    protected override void LoadContent()
    {
   // Create a new SpriteBatch, which can be used to draw textures.
    _spriteBatch = new SpriteBatch(GraphicsDevice);

    // TODO: use this.Content to load your game content here

    ballTexture  = Content.Load<Texture2D>("ball");

    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
    _graphics.GraphicsDevice.Clear(Color.CornflowerBlue);

    // TODO: Add your drawing code here
    _spriteBatch.Begin();
    _spriteBatch.Draw(ballTexture, new Vector2(0, 0), Color.White);
    _spriteBatch.End();

    base.Draw(gameTime);
    }
}
