using System;
using RamilH.ECS;
using Microsoft.Xna.Framework;

namespace RamilH.Framework
{
	/// <summary>
	/// This is an entity object with predefined Components: Transform, SpriteRenderer
	/// </summary>
	public class GameObject : Entity
	{
		public GameObject(string Id, Transform transform, Sprite sprite)
		{
			this.Id = Id;

			//Add Component Transform
			Transform _transform = AddGetComponent<Transform>();
			_transform = transform;


			//Add Component Sprite
			Sprite _sprite = AddGetComponent<Sprite>();
			_sprite = sprite;

			//_sprite.size = sprite.size;
			//_sprite.texture = sprite.texture;
		}
	}
}
