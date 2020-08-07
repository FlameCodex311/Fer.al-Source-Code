/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 50: DemiLib.dll - Assembly: DemiLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5861-5870

namespace DG.DemiLib
{
	[Serializable]
	public class DeColorPalette // TypeDefIndex: 5862
	{
		// Fields
		public DeColorGlobal global; // 0x10
		public DeColorBG bg; // 0x18
		public DeColorContent content; // 0x20
	
		// Constructors
		public DeColorPalette(); // 0x00000001820E1990-0x00000001820E1BB0
	
		// Methods
		public static Color HexToColor(string hex); // 0x00000001820E14B0-0x00000001820E1960
		private static int HexToInt(char hexVal); // 0x00000001820E1960-0x00000001820E1990
	}
}
