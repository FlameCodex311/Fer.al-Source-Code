/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x0000000180241710-0x0000000180241770
	[Description] // 0x0000000180241710-0x0000000180241770
	public class CheckAttribute : ConditionTask // TypeDefIndex: 15277
	{
		// Fields
		public BBParameter<string> attributeDefId; // 0x68
		public CompareMethod checkType; // 0x70
		public BBParameter<int> valueB; // 0x78
	
		// Properties
		public int valueA { get; } // 0x0000000180796410-0x00000001807964A0 
		protected override string info { get; } // 0x00000001807963C0-0x0000000180796410 
	
		// Constructors
		public CheckAttribute(); // 0x0000000180792480-0x0000000180792490
	
		// Methods
		protected override bool OnCheck(); // 0x00000001807962F0-0x00000001807963C0
	}
}
