/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001800DDAE0-0x00000001800DDB40
	[Description] // 0x00000001800DDAE0-0x00000001800DDB40
	public class CheckAttribute : ConditionTask // TypeDefIndex: 14174
	{
		// Fields
		public BBParameter<string> attributeDefId; // 0x68
		public CompareMethod checkType; // 0x70
		public BBParameter<int> valueB; // 0x78
	
		// Properties
		public int valueA { get; } // 0x000000018124E750-0x000000018124E7E0 
		protected override string info { get; } // 0x000000018124E700-0x000000018124E750 
	
		// Constructors
		public CheckAttribute(); // 0x000000018124D940-0x000000018124D950
	
		// Methods
		protected override bool OnCheck(); // 0x000000018124E630-0x000000018124E700
	}
}
