/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.BehaviourTrees
{
	[Category] // 0x000000018021D420-0x000000018021D4C0
	[Description] // 0x000000018021D420-0x000000018021D4C0
	[Icon] // 0x000000018021D420-0x000000018021D4C0
	public class WaitUntil : BTDecorator, ITaskAssignable<ConditionTask> // TypeDefIndex: 15183
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ConditionTask _condition; // 0x88
		private bool accessed; // 0x90
	
		// Properties
		public Task task { get; set; } // 0x0000000180476CE0-0x0000000180476CF0 0x00000001808B7F40-0x00000001808B7FD0
		private ConditionTask condition { get; set; } // 0x0000000180476CE0-0x0000000180476CF0 0x00000001804794C0-0x00000001804794D0
	
		// Constructors
		public WaitUntil(); // 0x00000001808A8120-0x00000001808A8130
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001808B7CF0-0x00000001808B7ED0
		protected override void OnReset(); // 0x00000001808B7ED0-0x00000001808B7F40
	}
}
