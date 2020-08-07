/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion
{
	public static class ColorUtils // TypeDefIndex: 15839
	{
		// Fields
		private static Dictionary<Color32, string> colorHexCache; // 0x00
		private static Dictionary<string, Color> hexColorCache; // 0x08
	
		// Constructors
		static ColorUtils(); // 0x00000001806C47D0-0x00000001806C48E0
	
		// Methods
		public static Color Grey(float value); // 0x00000001806C4530-0x00000001806C4570
		public static string ColorToHex(Color32 color); // 0x00000001806C43A0-0x00000001806C4530
		public static Color HexToColor(string hex); // 0x00000001806C4570-0x00000001806C47B0
	
		// Extension methods
		public static Color WithAlpha(this Color color, float alpha); // 0x00000001806C47B0-0x00000001806C47D0
	}
}
