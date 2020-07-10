/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 61: DeInspektor.dll - Assembly: DeInspektor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7500-7517

namespace DG.DeInspektor.Attributes
{
	public struct DeCondition // TypeDefIndex: 7511
	{
		// Fields
		internal string propertyToCompare; // 0x00
		internal bool boolValue; // 0x08
		internal string stringValue; // 0x10
		internal float numValue; // 0x18
		internal Condition conditionType; // 0x1C
	
		// Constructors
		public DeCondition(string propertyToCompare, bool value); // 0x000000018002DAA0-0x000000018002DAC0
		public DeCondition(string propertyToCompare, int value, Condition conditionType = Condition.Is /* Metadata: 0x00741A7D */); // 0x000000018002DAC0-0x0000000180030580
		public DeCondition(string propertyToCompare, Condition conditionType = Condition.IsNotNullOrEmpty /* Metadata: 0x00741A81 */); // 0x000000018002DA80-0x000000018002DAA0
	}
}
