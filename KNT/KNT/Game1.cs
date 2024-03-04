using System;
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
  ArrayList AlBallsX;
  ArrayList AlBallsY;

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
    AlBallsX = new ArrayList();
    AlBallsY = new ArrayList();

    AlBallsX.Add((float)100.0);
    AlBallsY.Add((float)100.0);

    AlBallsX.Add((float)120.0);
    AlBallsY.Add((float)120.0);
    //_graphics.PreferredBackBufferHeight = 768;
    //_graphics.PreferredBackBufferWidth = 1024;
    //_graphics.ApplyChanges();

    base.Initialize();
  }

  protected override void LoadContent()
  {
  // Create a new SpriteBatch, which can be used to draw textures.
  _spriteBatch = new SpriteBatch(GraphicsDevice);
  ballTexture  = Content.Load<Texture2D>("ball");
  }

  protected override void Update(GameTime gameTime)
  {
  float val;

  for (int i = 0;i<=AlBallsX.Count - 1; i=i+1)
  {
    val = (float)AlBallsX[i];
    val = (float)(val - 1.5);
    AlBallsX[i] = val;

    val =(float) AlBallsY[i];
    val = (float)(val - 1.5);
    AlBallsY[i] = val;
  }
  base.Update(gameTime);
  }

  protected override void Draw(GameTime gameTime)
  {
    _graphics.GraphicsDevice.Clear(Color.CornflowerBlue);

    // TODO: Add your drawing code here
    _spriteBatch.Begin();

    for (int i = 0;i<=AlBallsX.Count - 1; i=i+1)
    {
      _spriteBatch.Draw(ballTexture, new Vector2((float)AlBallsX[i],(float)AlBallsY[i]), Color.White);
    }

    _spriteBatch.End();
    base.Draw(gameTime);
  }
}
