/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Utils.Classes.Data
{
	[Serializable]
	public class IntRect // TypeDefIndex: 6998
	{
		// Fields
		public int x; // 0x10
		public int y; // 0x14
		public int width; // 0x18
		public int height; // 0x1C
	
		// Properties
		public int yMin { get; set; } // 0x00000001803FD2F0-0x00000001803FD300 0x00000001803FD620-0x00000001803FD630
		public int yMax { get; set; } // 0x0000000181092FA0-0x0000000181092FB0 0x0000000181092FC0-0x0000000181092FD0
		public int xMin { get; set; } // 0x0000000180387590-0x0000000180387930 0x00000001803FEB70-0x00000001803FEB80
		public int xMax { get; set; } // 0x0000000181092FB0-0x0000000181092FC0 0x0000000181092FD0-0x0000000181092FE0
		public int top { get; set; } // 0x00000001803FD2F0-0x00000001803FD300 0x00000001803FD620-0x00000001803FD630
		public int bottom { get; set; } // 0x0000000181092FA0-0x0000000181092FB0 0x0000000181092FC0-0x0000000181092FD0
		public int left { get; set; } // 0x0000000180387590-0x0000000180387930 0x00000001803FEB70-0x00000001803FEB80
		public int right { get; set; } // 0x0000000181092FB0-0x0000000181092FC0 0x0000000181092FD0-0x0000000181092FE0
	
		// Constructors
		public IntRect(); // 0x0000000180373240-0x0000000180373250
		public IntRect(int inX, int inY, int inWidth, int inHeight); // 0x000000018041B210-0x000000018041B260
	
		// Methods
		public IntRect Clone(); // 0x0000000181092E70-0x0000000181092F00
		public static IntRect Clone(IntRect intRect); // 0x0000000181092F00-0x0000000181092FA0
	}
}
