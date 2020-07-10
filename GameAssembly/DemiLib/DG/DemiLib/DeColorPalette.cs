/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 49: DemiLib.dll - Assembly: DemiLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5702-5711

namespace DG.DemiLib
{
	[Serializable]
	public class DeColorPalette // TypeDefIndex: 5703
	{
		// Fields
		public DeColorGlobal global; // 0x10
		public DeColorBG bg; // 0x18
		public DeColorContent content; // 0x20
	
		// Constructors
		public DeColorPalette(); // 0x0000000180DFF630-0x0000000180DFF850
	
		// Methods
		public static Color HexToColor(string hex); // 0x0000000180DFF150-0x0000000180DFF600
		private static int HexToInt(char hexVal); // 0x0000000180DFF600-0x0000000180DFF630
	}
}
