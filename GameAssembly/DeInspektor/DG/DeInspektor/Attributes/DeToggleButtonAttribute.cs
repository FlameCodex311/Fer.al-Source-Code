/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 61: DeInspektor.dll - Assembly: DeInspektor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7500-7517

namespace DG.DeInspektor.Attributes
{
	[AttributeUsage] // 0x00000001800C23C0-0x00000001800C23E0
	public class DeToggleButtonAttribute : PropertyAttribute // TypeDefIndex: 7517
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
		public DeToggleButtonAttribute(string text, DePosition position = DePosition.HExtended /* Metadata: 0x00741AB5 */, string bgOffColor = null, string bgOnColor = null, string labelOffColor = null, string labelOnColor = null); // 0x0000000180E026D0-0x0000000180E028A0
	}
}
