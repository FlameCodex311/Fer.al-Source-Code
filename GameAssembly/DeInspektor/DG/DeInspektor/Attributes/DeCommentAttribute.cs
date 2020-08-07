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
	public class DeCommentAttribute : PropertyAttribute // TypeDefIndex: 7674
	{
		// Fields
		public int fontSize; // 0x18
		public int marginBottom; // 0x1C
		public TextAnchor textAnchor; // 0x20
		internal string text; // 0x28
		internal DeCondition condition; // 0x30
		internal ConditionalBehaviour behaviour; // 0x50
	
		// Constructors
		public DeCommentAttribute(string text, int marginBottom = 3 /* Metadata: 0x00776737 */); // 0x00000001820E6AF0-0x00000001820E6B40
		public DeCommentAttribute(string text, string propertyToCompare, int value, Condition conditionType = Condition.Is /* Metadata: 0x0077673B */, ConditionalBehaviour behaviour = ConditionalBehaviour.Hide /* Metadata: 0x0077673F */); // 0x00000001820E6A50-0x00000001820E6AF0
	}
}
