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
	public class DeConditionalAttribute : PropertyAttribute // TypeDefIndex: 7678
	{
		// Fields
		internal DeCondition condition; // 0x18
		internal ConditionalBehaviour behaviour; // 0x38
	
		// Constructors
		public DeConditionalAttribute(string propertyToCompare, bool value, ConditionalBehaviour behaviour = ConditionalBehaviour.Disable /* Metadata: 0x00776773 */); // 0x00000001820E6B40-0x00000001820E6BA0
	}
}
