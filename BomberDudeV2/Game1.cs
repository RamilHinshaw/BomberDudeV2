using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using RamilH.ECS;
using RamilH.Framework;

namespace BomberDudeV2
{
	/// <summary>
	/// This is the main type for your game.
	/// </summary>
	public class Game1 : Game
	{
		GraphicsDeviceManager graphics;
		SpriteBatch spriteBatch;

		public static float delta;



		//GameObject TEST
		GameObject crate;


		private Texture2D test;
		private Texture2D tex_crate;
		private SpriteFont font;


		public Game1()
		{
			graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";

			//Resolution Option and Fullscreen
			graphics.IsFullScreen = false;
			graphics.PreferredBackBufferWidth = 1280;
			graphics.PreferredBackBufferHeight = 720;
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

			crate = new GameObject("crate1", new Transform(), new Sprite(tex_crate, new Vector2(32, 32) ));


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


			tex_crate = Content.Load<Texture2D>("crate");
			test = Content.Load<Texture2D>("explosiveBarrel");
			font = Content.Load<SpriteFont>("default");



		}

		/// <summary>
		/// Allows the game to run logic such as updating the world,
		/// checking for collisions, gathering input, and playing audio.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Update(GameTime gameTime)
		{
			// For Mobile devices, this logic will close the Game when the Back button is pressed
			// Exit() is obsolete on iOS
#if !__IOS__ && !__TVOS__
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
				Exit();
#endif
			delta = (float)gameTime.ElapsedGameTime.TotalSeconds;

			// TODO: Add your update logic here


			//Horizontal
			if (Input.GetKey(Keys.Left)) Camera.Position.X++;
			if (Input.GetKey(Keys.Right)) Camera.Position.X--;

			//Vertical
			if (Input.GetKey(Keys.Up)) Camera.Position.Y++;
			if (Input.GetKey(Keys.Down)) Camera.Position.Y--;

			//Zoom
			if (Input.GetKey(Keys.Z)) Camera.Position.Z++;
			if (Input.GetKey(Keys.X)) Camera.Position.Z--;




			Input.End();	//MUST CALL THIS at the End
			base.Update(gameTime);
		}

		/// <summary>
		/// This is called when the game should draw itself.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Draw(GameTime gameTime)
		{
			graphics.GraphicsDevice.Clear(Color.CornflowerBlue);

			//TODO: Add your drawing code here
			spriteBatch.Begin(SpriteSortMode.Deferred,
			  BlendState.AlphaBlend,
			  SamplerState.PointClamp,
			  null, null, null, null);


			//spriteBatch.Draw(test, new Rectangle(0 - (int)Camera.Position.X, 0 - (int)Camera.Position.Y,
			//							 32 + (int)Camera.Position.Z, 32 + (int)Camera.Position.Z),
			//							 Camera.Tint);





			//Test
			Sprite sprite = crate.GetComponent<Sprite>();
			Texture2D texture = sprite.texture;
			Transform transform = crate.GetComponent<Transform>();
			Vector2 spriteSize = sprite.size;

			float sizeCalcX = (spriteSize.X * transform.Scale.X) + (int)Camera.Position.Z ;
			float sizeCalcY = (spriteSize.Y * transform.Scale.Y) + (int)Camera.Position.Z;

			float posCalcX = transform.Position.X - (int)Camera.Position.X;
			float posCalcY = transform.Position.Y - (int)Camera.Position.Y;

			Point size = new Point( (int) sizeCalcX, (int) sizeCalcY);
			Point pos = new Point((int)posCalcX, (int)posCalcY);

			Debug.WriteLine(sizeCalcX);
			Debug.WriteLine(sizeCalcY);

			spriteBatch.Draw(tex_crate, new Rectangle( pos, size), Camera.Tint);

			spriteBatch.DrawString(font, "SizeX: " + sizeCalcX + 
			                       		"\nSizeY: " + sizeCalcY +
			                       		"\nPosX: " + posCalcX +
			                       		"\nPosY: " + posCalcY 
			                       , new Vector2( 800, 20), Color.Black);


			spriteBatch.End();


			base.Draw(gameTime);
		}
	}
}
