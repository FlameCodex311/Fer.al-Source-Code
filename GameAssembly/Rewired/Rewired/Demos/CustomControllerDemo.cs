/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;

// Image 78: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9189-9271

namespace Rewired.Demos
{
	[AddComponentMenu] // 0x00000001800B75F0-0x00000001800B7620
	public class CustomControllerDemo : UnityEngine.MonoBehaviour // TypeDefIndex: 9229
	{
		// Fields
		public int playerId; // 0x18
		public string controllerTag; // 0x20
		public bool useUpdateCallbacks; // 0x28
		private int buttonCount; // 0x2C
		private int axisCount; // 0x30
		private float[] axisValues; // 0x38
		private bool[] buttonValues; // 0x40
		private TouchJoystickExample[] joysticks; // 0x48
		private TouchButtonExample[] buttons; // 0x50
		private CustomController controller; // 0x58
		[NonSerialized]
		private bool initialized; // 0x60
	
		// Constructors
		public CustomControllerDemo(); // 0x0000000180407560-0x0000000180407570
	
		// Methods
		private void Awake(); // 0x00000001815B18D0-0x00000001815B1910
		private void Initialize(); // 0x00000001815B1BF0-0x00000001815B1ED0
		private void Update(); // 0x00000001815B2860-0x00000001815B2920
		private void OnInputSourceUpdate(); // 0x00000001815B1ED0-0x00000001815B20E0
		private void GetSourceAxisValues(); // 0x00000001815B19D0-0x00000001815B1B30
		private void GetSourceButtonValues(); // 0x00000001815B1B30-0x00000001815B1BF0
		private void SetControllerAxisValues(); // 0x00000001815B2720-0x00000001815B27C0
		private void SetControllerButtonValues(); // 0x00000001815B27C0-0x00000001815B2860
		private float GetAxisValueCallback(int index); // 0x00000001815B1910-0x00000001815B1970
		private bool GetButtonValueCallback(int index); // 0x00000001815B1970-0x00000001815B19D0
	}
}
