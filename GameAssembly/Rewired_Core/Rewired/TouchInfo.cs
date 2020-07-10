/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001800C3C10-0x00000001800C3C60
	[CustomObfuscation] // 0x00000001800C3C10-0x00000001800C3C60
	internal struct TouchInfo // TypeDefIndex: 5777
	{
		// Fields
		private bool fgNnLmrmmahxmiDfYojqjhBnGlga; // 0x00
		private int ZEYBWejJajkVVRxBknymzlRqgQM; // 0x04
		private Vector2 rANEqcGxQittTaJRrjJKcBGeueSS; // 0x08
		private Vector2 FxvyoNGZwjOsbsOIjfinRqTpDWmc; // 0x10
		private Vector2 TUatoTNpweCwdggRysafVYdGzhk; // 0x18
		private Vector2 LPJlHirladyEkFBUCRPLhUleZjv; // 0x20
		private float RKNslOXWkZCLqerUpfATrGhbjZtb; // 0x28
		private int PQnJoGdPOhfxNTjJBkVqZPNnLyx; // 0x2C
	
		// Properties
		public bool isValid { get; internal set; } // 0x000000018000A660-0x000000018000A670 0x000000018000A690-0x000000018000A6A0
		public int touchId { get; internal set; } // 0x0000000180002FD0-0x0000000180003310 0x0000000180004CC0-0x0000000180004CD0
		public Vector2 touchPos { get; internal set; } // 0x0000000180011030-0x0000000180011050 0x0000000180006F30-0x0000000180006F40
		public Vector2 touchPosRaw { get; internal set; } // 0x0000000180011010-0x0000000180011030 0x0000000180011060-0x0000000180011150
		public Vector2 deltaPos { get; internal set; } // 0x0000000180010FE0-0x0000000180011000 0x0000000180004CE0-0x0000000180004CF0
		public Vector2 deltaPosRaw { get; internal set; } // 0x0000000180010FC0-0x0000000180010FE0 0x000000018000D1C0-0x000000018000D1D0
		public float deltaTime { get; internal set; } // 0x0000000180011000-0x0000000180011010 0x0000000180011050-0x0000000180011060
		public int tapCount { get; internal set; } // 0x000000018000A100-0x000000018000A110 0x000000018000A1A0-0x000000018000A1B0
		internal static TouchInfo Invalid { get; } // 0x00000001807B3EE0-0x00000001807B3FC0 
	
		// Constructors
		internal TouchInfo(bool isValid, int touchId, Vector2 touchPos, Vector2 touchPosRaw, Vector2 deltaPos, Vector2 deltaPosRaw, float deltaTime, int tapCount); // 0x0000000180010F80-0x0000000180010FC0
	}
}
