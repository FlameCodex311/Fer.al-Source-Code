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
	public class IntPadding // TypeDefIndex: 6999
	{
		// Fields
		public int top; // 0x10
		public int right; // 0x14
		public int bottom; // 0x18
		public int left; // 0x1C
	
		// Constructors
		public IntPadding(); // 0x00000001810924F0-0x0000000181092510
		public IntPadding(int inTop, int inRight, int inBottom, int inLeft); // 0x000000018041B210-0x000000018041B260
	
		// Methods
		public IntPadding Clone(); // 0x0000000181092460-0x00000001810924F0
		public static IntPadding operator +(IntPadding value1, IntPadding value2); // 0x0000000181092640-0x0000000181092730
		public static IntPadding operator -(IntPadding value1, IntPadding value2); // 0x0000000181092B90-0x0000000181092C80
		public static IntPadding operator *(IntPadding value1, IntPadding value2); // 0x00000001810929F0-0x0000000181092AE0
		public static IntPadding operator /(IntPadding value1, IntPadding value2); // 0x00000001810927F0-0x00000001810928F0
		public static IntPadding operator +(IntPadding value1, int value2); // 0x0000000181092510-0x00000001810925C0
		public static IntPadding operator -(IntPadding value1, int value2); // 0x0000000181092C80-0x0000000181092D30
		public static IntPadding operator *(IntPadding value1, int value2); // 0x0000000181092AE0-0x0000000181092B90
		public static IntPadding operator /(IntPadding value1, int value2); // 0x0000000181092730-0x00000001810927F0
		public static Vector4 operator +(IntPadding value1, float value2); // 0x00000001810925C0-0x0000000181092640
		public static Vector4 operator -(IntPadding value1, float value2); // 0x0000000181092D30-0x0000000181092DB0
		public static Vector4 operator *(IntPadding value1, float value2); // 0x0000000181092970-0x00000001810929F0
		public static Vector4 operator /(IntPadding value1, float value2); // 0x00000001810928F0-0x0000000181092970
	}
}
