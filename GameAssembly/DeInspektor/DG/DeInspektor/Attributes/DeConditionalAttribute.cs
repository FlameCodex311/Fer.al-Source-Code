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
	public class DeConditionalAttribute : PropertyAttribute // TypeDefIndex: 7512
	{
		// Fields
		internal DeCondition condition; // 0x18
		internal ConditionalBehaviour behaviour; // 0x38
	
		// Constructors
		public DeConditionalAttribute(string propertyToCompare, bool value, ConditionalBehaviour behaviour = ConditionalBehaviour.Disable /* Metadata: 0x00741A85 */); // 0x0000000180E02500-0x0000000180E02560
	}
}
