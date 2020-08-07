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

namespace Rewired.UI
{
	public struct UIPivot // TypeDefIndex: 5949
	{
		// Fields
		public float min; // 0x00
		public float max; // 0x04
	
		// Properties
		public static UIPivot TopLeft { get; } // 0x00000001810A9490-0x00000001810A94B0 
		public static UIPivot TopCenter { get; } // 0x00000001810A9460-0x00000001810A9490 
		public static UIPivot TopRight { get; } // 0x00000001810A94B0-0x00000001810A94E0 
		public static UIPivot MiddleLeft { get; } // 0x00000001810A9410-0x00000001810A9430 
		public static UIPivot MiddleCenter { get; } // 0x00000001810A93F0-0x00000001810A9410 
		public static UIPivot MiddleRight { get; } // 0x00000001810A9430-0x00000001810A9460 
		public static UIPivot BottomLeft { get; } // 0x00000001810A93B0-0x00000001810A93D0 
		public static UIPivot BottomCenter { get; } // 0x00000001810A9390-0x00000001810A93B0 
		public static UIPivot BottomRight { get; } // 0x00000001810A93D0-0x00000001810A93F0 
	
		// Constructors
		public UIPivot(float min, float max); // 0x00000001800B5870-0x00000001800B5890
	
		// Methods
		public static implicit operator Vector2(UIPivot x); // 0x0000000180AA8680-0x0000000180AA86C0
		public static implicit operator UIPivot(Vector2 x); // 0x00000001810A94E0-0x00000001810A9510
	}
}
