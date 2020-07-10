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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.BehaviourTrees
{
	[Category] // 0x0000000180165330-0x0000000180165400
	[Color] // 0x0000000180165330-0x0000000180165400
	[Description] // 0x0000000180165330-0x0000000180165400
	[Icon] // 0x0000000180165330-0x0000000180165400
	public class Switch : BTComposite // TypeDefIndex: 14039
	{
		// Fields
		public bool dynamic; // 0x78
		public CaseSelectionMode selectionMode; // 0x7C
		[ShowIf] // 0x00000001801657E0-0x0000000180165810
		public BBParameter<int> intCase; // 0x80
		[ShowIf] // 0x00000001801657E0-0x0000000180165810
		public OutOfRangeMode outOfRangeMode; // 0x88
		[BlackboardOnly] // 0x0000000180165BC0-0x0000000180165C10
		[ShowIf] // 0x0000000180165BC0-0x0000000180165C10
		public BBObjectParameter enumCase; // 0x90
		private int current; // 0x98
		private int runningIndex; // 0x9C
	
		// Nested types
		public enum CaseSelectionMode // TypeDefIndex: 14040
		{
			IndexBased = 0,
			EnumBased = 1
		}
	
		public enum OutOfRangeMode // TypeDefIndex: 14041
		{
			ReturnFailure = 0,
			LoopIndex = 1
		}
	
		// Constructors
		public Switch(); // 0x0000000181574790-0x0000000181574840
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x0000000181574530-0x0000000181574790
	}
}
