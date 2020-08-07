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
	[Category] // 0x0000000180241AB0-0x0000000180241B10
	[Description] // 0x0000000180241AB0-0x0000000180241B10
	public class CheckCraftableItemCount : ConditionTask // TypeDefIndex: 15278
	{
		// Fields
		public BBParameter<string> craftableItemDefId; // 0x68
		public CompareMethod checkType; // 0x70
		public BBParameter<int> valueB; // 0x78
	
		// Properties
		private int valueA { get; } // 0x0000000180798770-0x0000000180798810 
		protected override string info { get; } // 0x0000000180798670-0x0000000180798770 
	
		// Constructors
		public CheckCraftableItemCount(); // 0x0000000180792480-0x0000000180792490
	
		// Methods
		protected override bool OnCheck(); // 0x0000000180798600-0x0000000180798670
	}
}
