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
	public class DeButtonAttribute : PropertyAttribute // TypeDefIndex: 7671
	{
		// Fields
		internal Type targetType; // 0x18
		internal string text; // 0x20
		internal string methodName; // 0x28
		internal object[] parameters; // 0x30
		internal DePosition position; // 0x38
	
		// Constructors
		public DeButtonAttribute(string buttonText, Type targetType, string methodName, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ object[] parameters); // 0x00000001820E69F0-0x00000001820E6A50
	}
}
