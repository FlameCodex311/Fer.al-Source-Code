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
	public class DeBeginDisabledAttribute : PropertyAttribute // TypeDefIndex: 7501
	{
		// Fields
		internal DeCondition condition; // 0x18
	
		// Constructors
		public DeBeginDisabledAttribute(string propertyToCompare, bool value); // 0x0000000180E02360-0x0000000180E023B0
		public DeBeginDisabledAttribute(string propertyToCompare, int value, Condition conditionType = Condition.Is /* Metadata: 0x00741A45 */); // 0x0000000180E022E0-0x0000000180E02360
	}
}
