/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.iOS.Xcode
{
	internal class ImageResizing // TypeDefIndex: 16114
	{
		// Fields
		public SlicingType type; // 0x10
		public int left; // 0x14
		public int right; // 0x18
		public int top; // 0x1C
		public int bottom; // 0x20
		public ResizeMode centerResizeMode; // 0x24
		public int centerWidth; // 0x28
		public int centerHeight; // 0x2C
	
		// Nested types
		public enum SlicingType // TypeDefIndex: 16115
		{
			Horizontal = 0,
			Vertical = 1,
			HorizontalAndVertical = 2
		}
	
		public enum ResizeMode // TypeDefIndex: 16116
		{
			Stretch = 0,
			Tile = 1
		}
	
		// Constructors
		public ImageResizing(); // 0x0000000180971A40-0x0000000180971A50
	}
}
