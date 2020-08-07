/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.BehaviourTrees
{
	[Category] // 0x0000000180213F50-0x0000000180214020
	[Color] // 0x0000000180213F50-0x0000000180214020
	[Description] // 0x0000000180213F50-0x0000000180214020
	[Icon] // 0x0000000180213F50-0x0000000180214020
	public class Switch : BTComposite // TypeDefIndex: 15157
	{
		// Fields
		public bool dynamic; // 0x88
		public CaseSelectionMode selectionMode; // 0x8C
		[ShowIf] // 0x0000000180214390-0x00000001802143C0
		public BBParameter<int> intCase; // 0x90
		[ShowIf] // 0x0000000180214390-0x00000001802143C0
		public OutOfRangeMode outOfRangeMode; // 0x98
		[BlackboardOnly] // 0x0000000180214800-0x0000000180214850
		[ShowIf] // 0x0000000180214800-0x0000000180214850
		public BBObjectParameter enumCase; // 0xA0
		private int current; // 0xA8
		private int runningIndex; // 0xAC
	
		// Nested types
		public enum CaseSelectionMode // TypeDefIndex: 15158
		{
			IndexBased = 0,
			EnumBased = 1
		}
	
		public enum OutOfRangeMode // TypeDefIndex: 15159
		{
			ReturnFailure = 0,
			LoopIndex = 1
		}
	
		// Constructors
		public Switch(); // 0x00000001808B5D20-0x00000001808B5DD0
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001808B5A70-0x00000001808B5D20
	}
}
