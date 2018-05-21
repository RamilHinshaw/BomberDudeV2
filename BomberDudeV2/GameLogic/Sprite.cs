using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
//using Microsoft.Xna.Framework.Content.;

namespace RamilH.Framework
{
	public class Sprite
	{
		public bool isSpriteSheet = false;
		private Texture2D sprite;

		public Sprite(Texture2D texture)
		{
			
			//Load Sprite To MonoGame Here ...
			sprite = LoadTexture(texture);


		}

		public Sprite(Texture2D texture, bool isSpriteSheet) {}


		private Texture2D LoadTexture(Texture2D texture)
		{
			return null;
		}


		//For SpriteSheets

	}
}
