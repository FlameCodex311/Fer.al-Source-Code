/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 62: DeInspektor.dll - Assembly: DeInspektor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7666-7683

namespace DG.DeInspektor.Attributes
{
	public struct DeCondition // TypeDefIndex: 7677
	{
		// Fields
		internal string propertyToCompare; // 0x00
		internal bool boolValue; // 0x08
		internal string stringValue; // 0x10
		internal float numValue; // 0x18
		internal Condition conditionType; // 0x1C
	
		// Constructors
		public DeCondition(string propertyToCompare, bool value); // 0x0000000180145AB0-0x0000000180145AD0
		public DeCondition(string propertyToCompare, int value, Condition conditionType = Condition.Is /* Metadata: 0x0077676B */); // 0x0000000180145AD0-0x000000018014A4E0
		public DeCondition(string propertyToCompare, Condition conditionType = Condition.IsNotNullOrEmpty /* Metadata: 0x0077676F */); // 0x0000000180145A90-0x0000000180145AB0
	}
}
