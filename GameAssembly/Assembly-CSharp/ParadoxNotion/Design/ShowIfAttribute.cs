/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion.Design
{
	[AttributeUsage] // 0x00000001801D0B50-0x00000001801D0B70
	public class ShowIfAttribute : DrawerAttribute // TypeDefIndex: 15962
	{
		// Fields
		public readonly string fieldName; // 0x10
		public readonly int checkValue; // 0x18
	
		// Properties
		public override bool isDecorator { get; } // 0x0000000180380B60-0x0000000180380B70 
		public override int priority { get; } // 0x000000018058C710-0x000000018058C720 
	
		// Constructors
		public ShowIfAttribute(string fieldName, int checkValue); // 0x00000001803F4670-0x00000001803F46B0
	}
}
