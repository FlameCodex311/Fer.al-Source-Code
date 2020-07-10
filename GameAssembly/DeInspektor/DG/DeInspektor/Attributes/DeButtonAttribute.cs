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
	[AttributeUsage] // 0x00000001800C6BE0-0x00000001800C6C10
	public class DeButtonAttribute : PropertyAttribute // TypeDefIndex: 7505
	{
		// Fields
		internal Type targetType; // 0x18
		internal string text; // 0x20
		internal string methodName; // 0x28
		internal object[] parameters; // 0x30
		internal DePosition position; // 0x38
	
		// Constructors
		public DeButtonAttribute(string buttonText, Type targetType, string methodName, params /* 0x00000001800B36B0-0x00000001800B36C0 */ object[] parameters); // 0x0000000180E023B0-0x0000000180E02410
	}
}
