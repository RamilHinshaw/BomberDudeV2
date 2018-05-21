using System;
using Microsoft.Xna.Framework;

namespace RamilH.Framework
{
	public class Transform
	{
		public Vector2 Position { get; set; }
		public Vector2 Rotation { get; set; }
		public Vector2 Scale 	{ get; set; }

		//Constructor
		public Transform(){}

		//Use Extend method for this!
		//public void Zero() { Position.Zero(); Rotation.Zero(); Scale.Change(1f, 1f); }
	}
}
