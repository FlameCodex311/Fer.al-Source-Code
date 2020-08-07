/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;

// Image 79: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9355-9437

namespace Rewired.Demos
{
	[AddComponentMenu] // 0x0000000180213020-0x0000000180213050
	public class CustomControllerDemo : UnityEngine.MonoBehaviour // TypeDefIndex: 9395
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
		public CustomControllerDemo(); // 0x0000000180568C50-0x0000000180569020
	
		// Methods
		private void Awake(); // 0x0000000180DCBDE0-0x0000000180DCBE20
		private void Initialize(); // 0x0000000180DCC0B0-0x0000000180DCC390
		private void Update(); // 0x0000000180DCCE10-0x0000000180DCCED0
		private void OnInputSourceUpdate(); // 0x0000000180DCC390-0x0000000180DCC6C0
		private void GetSourceAxisValues(); // 0x0000000180DCBEC0-0x0000000180DCC000
		private void GetSourceButtonValues(); // 0x0000000180DCC000-0x0000000180DCC0B0
		private void SetControllerAxisValues(); // 0x0000000180DCCCF0-0x0000000180DCCD80
		private void SetControllerButtonValues(); // 0x0000000180DCCD80-0x0000000180DCCE10
		private float GetAxisValueCallback(int index); // 0x0000000180DCBE20-0x0000000180DCBE70
		private bool GetButtonValueCallback(int index); // 0x0000000180DCBE70-0x0000000180DCBEC0
	}
}
