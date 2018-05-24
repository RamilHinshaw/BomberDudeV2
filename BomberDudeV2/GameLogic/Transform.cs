using System;
using Microsoft.Xna.Framework;
using RamilH.ECS;

namespace RamilH.Framework
{
	public class Transform : Component
	{
		public Vector2 Position { get; set; }
		public Vector2 Rotation { get; set; }
		public Vector2 Scale 	{ get; set; }

		//Constructor
		public Transform() { Scale = Vector2.One;}

		//public override bool Equals(object obj)
		//{
		//	return base.Equals(obj);
		//}

		//Use Extend method for this!
		//public void Zero() { Position.Zero(); Rotation.Zero(); Scale.Change(1f, 1f); }
	}
}
