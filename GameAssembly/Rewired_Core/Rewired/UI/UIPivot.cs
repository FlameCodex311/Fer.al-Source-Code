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

namespace Rewired.UI
{
	public struct UIPivot // TypeDefIndex: 5790
	{
		// Fields
		public float min; // 0x00
		public float max; // 0x04
	
		// Properties
		public static UIPivot TopLeft { get; } // 0x00000001807B4820-0x00000001807B4840 
		public static UIPivot TopCenter { get; } // 0x00000001807B47F0-0x00000001807B4820 
		public static UIPivot TopRight { get; } // 0x00000001807B4840-0x00000001807B4870 
		public static UIPivot MiddleLeft { get; } // 0x00000001807B47A0-0x00000001807B47C0 
		public static UIPivot MiddleCenter { get; } // 0x00000001807B4780-0x00000001807B47A0 
		public static UIPivot MiddleRight { get; } // 0x00000001807B47C0-0x00000001807B47F0 
		public static UIPivot BottomLeft { get; } // 0x00000001807B4740-0x00000001807B4760 
		public static UIPivot BottomCenter { get; } // 0x00000001807B4720-0x00000001807B4740 
		public static UIPivot BottomRight { get; } // 0x00000001807B4760-0x00000001807B4780 
	
		// Constructors
		public UIPivot(float min, float max); // 0x00000001800111C0-0x00000001800111E0
	
		// Methods
		public static implicit operator Vector2(UIPivot x); // 0x000000018079BD50-0x000000018079BD90
		public static implicit operator UIPivot(Vector2 x); // 0x00000001807B4870-0x00000001807B48A0
	}
}
