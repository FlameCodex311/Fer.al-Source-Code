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

namespace Rewired.Utils.Classes.Data
{
	[Serializable]
	public struct ScreenRect // TypeDefIndex: 7006
	{
		// Fields
		public float xMin; // 0x00
		public float yMin; // 0x04
		public float width; // 0x08
		public float height; // 0x0C
	
		// Properties
		public float xMax { get; set; } // 0x00000001800B5640-0x00000001800B5650 0x00000001800B5660-0x00000001800B5670
		public float yMax { get; set; } // 0x00000001800B5650-0x00000001800B5660 0x00000001800B5670-0x00000001800B5680
		public Vector2 center { get; } // 0x00000001800B55F0-0x00000001800B5640 
	
		// Constructors
		public ScreenRect(float left, float bottom, float width, float height); // 0x0000000180007650-0x0000000180007670
	
		// Methods
		public static implicit operator Rect(ScreenRect o); // 0x000000018109BB40-0x000000018109BB90
		public static implicit operator ScreenRect(Rect o); // 0x000000018109BAB0-0x000000018109BB40
	}
}
