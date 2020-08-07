/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 62: DeInspektor.dll - Assembly: DeInspektor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7666-7683

namespace DG.DeInspektor.Attributes
{
	[AttributeUsage] // 0x00000001801D0B50-0x00000001801D0B70
	public class DeToggleButtonAttribute : PropertyAttribute // TypeDefIndex: 7683
	{
		// Fields
		public string offText; // 0x18
		internal string text; // 0x20
		internal DePosition position; // 0x28
		internal Color? bgOffColor; // 0x2C
		internal Color? bgOnColor; // 0x40
		internal Color? labelOffColor; // 0x54
		internal Color? labelOnColor; // 0x68
	
		// Constructors
		public DeToggleButtonAttribute(string text, DePosition position = DePosition.HExtended /* Metadata: 0x007767A3 */, string bgOffColor = null, string bgOnColor = null, string labelOffColor = null, string labelOnColor = null); // 0x00000001820E6D10-0x00000001820E6EE0
	}
}
