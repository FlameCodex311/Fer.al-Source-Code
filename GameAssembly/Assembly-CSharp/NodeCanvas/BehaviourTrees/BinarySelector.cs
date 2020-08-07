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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.BehaviourTrees
{
	[Category] // 0x000000018020FE20-0x000000018020FEF0
	[Color] // 0x000000018020FE20-0x000000018020FEF0
	[Description] // 0x000000018020FE20-0x000000018020FEF0
	[Icon] // 0x000000018020FE20-0x000000018020FEF0
	public class BinarySelector : BTNode, ITaskAssignable<ConditionTask> // TypeDefIndex: 15148
	{
		// Fields
		public bool dynamic; // 0x88
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ConditionTask _condition; // 0x90
		private int succeedIndex; // 0x98
	
		// Properties
		public override int maxOutConnections { get; } // 0x0000000180411150-0x0000000180411160 
		public override Alignment2x2 commentsAlignment { get; } // 0x0000000180411150-0x0000000180411160 
		public override string name { get; } // 0x00000001807C41C0-0x00000001807C41F0 
		public Task task { get; set; } // 0x00000001803D6D80-0x00000001803D6D90 0x00000001807C5130-0x00000001807C51C0
		private ConditionTask condition { get; set; } // 0x00000001803D6D80-0x00000001803D6D90 0x000000018072D660-0x000000018072D670
	
		// Constructors
		public BinarySelector(); // 0x00000001807C41B0-0x00000001807C41C0
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001807C4F90-0x00000001807C5110
		protected override void OnReset(); // 0x00000001807C5110-0x00000001807C5130
	}
}
