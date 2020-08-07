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
	public class DeBeginDisabledAttribute : PropertyAttribute // TypeDefIndex: 7667
	{
		// Fields
		internal DeCondition condition; // 0x18
	
		// Constructors
		public DeBeginDisabledAttribute(string propertyToCompare, bool value); // 0x00000001820E69A0-0x00000001820E69F0
		public DeBeginDisabledAttribute(string propertyToCompare, int value, Condition conditionType = Condition.Is /* Metadata: 0x00776733 */); // 0x00000001820E6920-0x00000001820E69A0
	}
}
