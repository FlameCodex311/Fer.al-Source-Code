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
	public class DeCommentAttribute : PropertyAttribute // TypeDefIndex: 7508
	{
		// Fields
		public int fontSize; // 0x18
		public int marginBottom; // 0x1C
		public TextAnchor textAnchor; // 0x20
		internal string text; // 0x28
		internal DeCondition condition; // 0x30
		internal ConditionalBehaviour behaviour; // 0x50
	
		// Constructors
		public DeCommentAttribute(string text, int marginBottom = 3 /* Metadata: 0x00741A49 */); // 0x0000000180E024B0-0x0000000180E02500
		public DeCommentAttribute(string text, string propertyToCompare, int value, Condition conditionType = Condition.Is /* Metadata: 0x00741A4D */, ConditionalBehaviour behaviour = ConditionalBehaviour.Hide /* Metadata: 0x00741A51 */); // 0x0000000180E02410-0x0000000180E024B0
	}
}
