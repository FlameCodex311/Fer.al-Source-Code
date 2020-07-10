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
	public class DeRangeAttribute : PropertyAttribute // TypeDefIndex: 7507
	{
		// Fields
		internal float min; // 0x18
		internal float max; // 0x1C
		internal string label; // 0x20
	
		// Constructors
		public DeRangeAttribute(float min, float max, string label = null); // 0x0000000180E02680-0x0000000180E026D0
	}
}
