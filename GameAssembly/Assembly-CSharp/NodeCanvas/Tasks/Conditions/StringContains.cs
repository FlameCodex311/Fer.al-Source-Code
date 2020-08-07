/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001802236C0-0x00000001802236F0
	public class StringContains : ConditionTask // TypeDefIndex: 15214
	{
		// Fields
		[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
		[RequiredField] // 0x00000001801CDDD0-0x00000001801CDE00
		public BBParameter<string> targetString; // 0x68
		public BBParameter<string> checkString; // 0x70
	
		// Properties
		protected override string info { get; } // 0x00000001808072A0-0x00000001808072E0 
	
		// Constructors
		public StringContains(); // 0x0000000180792480-0x0000000180792490
	
		// Methods
		protected override bool OnCheck(); // 0x0000000180807210-0x00000001808072A0
	}
}
