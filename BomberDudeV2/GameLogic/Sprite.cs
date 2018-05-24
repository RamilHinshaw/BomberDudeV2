using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RamilH.ECS;
//using Microsoft.Xna.Framework.Content.;

namespace RamilH.Framework
{
	public class Sprite : Component
	{
		public bool isSpriteSheet = false;
		public Texture2D texture;
		public Vector2 size { get; set; }   //Width & Height in pixels

		public Sprite() { }
		public Sprite(Texture2D texture, Vector2 msize)
		{

			//Load Sprite To MonoGame Here ...
			this.texture = texture;
			this.size = msize;

		}

		public Sprite(Texture2D texture, Vector2 size, bool isSpriteSheet) {}


		public void SetSprite(Texture2D texture, Vector2 size)
		{
			this.texture = texture;
			this.size = size;
		}

		//private Texture2D LoadTexture(Texture2D texture)
		//{
		//	return null;
		//}


		//For SpriteSheets

	}
}
