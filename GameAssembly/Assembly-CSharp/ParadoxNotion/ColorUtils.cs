/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ParadoxNotion
{
	public static class ColorUtils // TypeDefIndex: 14692
	{
		// Fields
		private static Dictionary<Color32, string> colorHexCache; // 0x00
		private static Dictionary<string, Color> hexColorCache; // 0x08
	
		// Constructors
		static ColorUtils(); // 0x0000000180E87E10-0x0000000180E87F20
	
		// Methods
		public static string ColorToHex(Color32 color); // 0x0000000180E87A20-0x0000000180E87BB0
		public static Color HexToColor(string hex); // 0x0000000180E87BB0-0x0000000180E87DF0
	
		// Extension methods
		public static Color WithAlpha(this Color color, float alpha); // 0x0000000180E87DF0-0x0000000180E87E10
	}
}
