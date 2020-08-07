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
	[AttributeUsage] // 0x000000018022A830-0x000000018022A860
	public class DeHeaderAttribute : PropertyAttribute // TypeDefIndex: 7680
	{
		// Fields
		public int marginTop; // 0x18
		public int marginBottom; // 0x1C
		internal string text; // 0x20
		internal string textColor; // 0x28
		internal string bgColor; // 0x30
		internal TextAnchor textAnchor; // 0x38
		internal FontStyle fontStyle; // 0x3C
		internal int fontSize; // 0x40
	
		// Constructors
		public DeHeaderAttribute(string text, string textColor = null, string bgColor = null, FontStyle fontStyle = FontStyle.Bold /* Metadata: 0x0077677B */, int fontSize = 11 /* Metadata: 0x0077677F */); // 0x00000001820E6C00-0x00000001820E6C70
	}
}
