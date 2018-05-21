﻿using System;

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

		private Texture2D test;
		private SpriteFont font;

		private int zoomModifier = 1;


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

			// TODO: Add your update logic here



			//DEBUG ZOOM TEST
			//KeyboardState state = Keyboard.GetState();
			//if (state.IsKeyDown(Keys.Left)) zoomModifier++;
			//if (state.IsKeyDown(Keys.Right)) zoomModifier--;

			if (Input.GetKeyDown(Keys.Left)) zoomModifier++;
			if (Input.GetKeyDown(Keys.Right)) zoomModifier--;
			//if (Input.GetKey(Keys.Left)) zoomModifier++;




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


			spriteBatch.Draw(test, new Rectangle(0, 0, 32 * zoomModifier  , 32 * zoomModifier), Color.White);

			spriteBatch.DrawString(font, "Test String!", new Vector2(100, 100), Color.Black);




			spriteBatch.End();


			base.Draw(gameTime);
		}
	}
}
