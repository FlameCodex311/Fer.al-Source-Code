/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	[CustomObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	internal struct TouchInfo // TypeDefIndex: 5936
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
		public bool isValid { get; internal set; } // 0x00000001800A1FA0-0x00000001800A2000 0x00000001800A2E00-0x00000001800A2E10
		public int touchId { get; internal set; } // 0x0000000180003CA0-0x0000000180003FD0 0x00000001800215B0-0x00000001800215C0
		public Vector2 touchPos { get; internal set; } // 0x0000000180051C00-0x0000000180051C20 0x000000018001A900-0x000000018001A910
		public Vector2 touchPosRaw { get; internal set; } // 0x0000000180035270-0x000000018003F710 0x000000018001A910-0x000000018001AA00
		public Vector2 deltaPos { get; internal set; } // 0x00000001800B56E0-0x00000001800B5700 0x00000001800215D0-0x0000000180021790
		public Vector2 deltaPosRaw { get; internal set; } // 0x00000001800B56C0-0x00000001800B56E0 0x00000001800AE910-0x00000001800AE920
		public float deltaTime { get; internal set; } // 0x00000001800B5700-0x00000001800B5710 0x00000001800B5710-0x00000001800B5800
		public int tapCount { get; internal set; } // 0x00000001800A2860-0x00000001800A2870 0x00000001800A28E0-0x00000001800A28F0
		internal static TouchInfo Invalid { get; } // 0x00000001810A8B50-0x00000001810A8C30 
	
		// Constructors
		internal TouchInfo(bool isValid, int touchId, Vector2 touchPos, Vector2 touchPosRaw, Vector2 deltaPos, Vector2 deltaPosRaw, float deltaTime, int tapCount); // 0x00000001800B5680-0x00000001800B56C0
	}
}
