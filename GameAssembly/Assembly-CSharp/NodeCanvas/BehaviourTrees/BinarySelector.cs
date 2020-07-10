/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.BehaviourTrees
{
	[Category] // 0x0000000180162600-0x00000001801626D0
	[Color] // 0x0000000180162600-0x00000001801626D0
	[Description] // 0x0000000180162600-0x00000001801626D0
	[Icon] // 0x0000000180162600-0x00000001801626D0
	public class BinarySelector : BTNode, ITaskAssignable<ConditionTask> // TypeDefIndex: 14030
	{
		// Fields
		public bool dynamic; // 0x78
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ConditionTask _condition; // 0x80
		private int succeedIndex; // 0x88
	
		// Properties
		public override int maxOutConnections { get; } // 0x0000000180362180-0x0000000180362190 
		public override Alignment2x2 commentsAlignment { get; } // 0x0000000180362180-0x0000000180362190 
		public override string name { get; } // 0x000000018155E3C0-0x000000018155E3F0 
		public Task task { get; set; } // 0x000000018035FCB0-0x000000018035FCC0 0x0000000181560D60-0x0000000181560DF0
		private ConditionTask condition { get; set; } // 0x000000018035FCB0-0x000000018035FCC0 0x00000001803D8ED0-0x00000001803D8EE0
	
		// Constructors
		public BinarySelector(); // 0x000000018155E370-0x000000018155E380
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x0000000181560C00-0x0000000181560D60
	}
}
