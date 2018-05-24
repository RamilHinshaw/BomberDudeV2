using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace RamilH.Framework
{
	public static class Input
	{
		static private KeyboardState CurrentKeyboardState = Keyboard.GetState();
		static private KeyboardState PreviousKeyboardState = Keyboard.GetState();
		//static private Keys previousKey;

		public static void GetButton(string InputReference) { }
		public static void GetButtonUp(string InputReference) { }
		public static void GetButtonDown(string InputReference) { }

		public static bool GetKey(Keys key) 
		{
			UpdateCurrentState();

			return CurrentKeyboardState.IsKeyDown(key);
		}

		public static bool GetKeyUp(Keys key) 
		{ 


			UpdateCurrentState();
			bool buttonState;

			buttonState = (CurrentKeyboardState.IsKeyUp(key) && PreviousKeyboardState.IsKeyDown(key)) ? true : false;

			//UpdatePrevState();

			return buttonState;
		}

		public static bool GetKeyDown(Keys key) 
		{

			UpdateCurrentState();	//Called from GetKey Inst
			bool buttonState = false;

			buttonState = (CurrentKeyboardState.IsKeyDown(key) && PreviousKeyboardState.IsKeyUp(key) )? true : false;

			//UpdatePrevState();

			return buttonState;
		}

		public static void GetMouseButton(int mouseBtnIdx) { }
		public static void GetMouseButtonUp(int mouseBtnIdx) { }
		public static void GetMouseButtonDown(int mouseBtnIdx) { }

		public static void GetAxis(string InputReference) { }
		public static void GetRawAxis(string InputReference) { }


		//Helper
		public static Vector2 GetMousePosition() { return new Vector2(0, 0); }
		public static bool AnyKey() { return false; }

		//private static void InitializeKeyInstance()

		//For Multiple Controller Types Here

		//CALL THIS AS LAST INPUT
		public static void End() { UpdatePrevState(); }

		private static void UpdateCurrentState()
		{
			CurrentKeyboardState = Keyboard.GetState();
			//Gamepad Controller HERE...
		}

		private static void UpdatePrevState()
		{
			PreviousKeyboardState = CurrentKeyboardState;
			//Gamepad Controller HERE...
		}

	}
}
