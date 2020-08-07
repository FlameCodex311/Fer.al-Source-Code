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
	[Description] // 0x000000018021E120-0x000000018021E1C0
	[Icon] // 0x000000018021E120-0x000000018021E1C0
	[Name] // 0x000000018021E120-0x000000018021E1C0
	public class ConditionNode : BTNode, ITaskAssignable<ConditionTask> // TypeDefIndex: 15185
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ConditionTask _condition; // 0x88
	
		// Properties
		public Task task { get; set; } // 0x0000000180476CE0-0x0000000180476CF0 0x00000001807C59A0-0x00000001807C5A30
		public ConditionTask condition { get; set; } // 0x0000000180476CE0-0x0000000180476CF0 0x00000001804794C0-0x00000001804794D0
		public override string name { get; } // 0x00000001807C41C0-0x00000001807C41F0 
	
		// Constructors
		public ConditionNode(); // 0x00000001807C41B0-0x00000001807C41C0
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001807C5900-0x00000001807C5980
		protected override void OnReset(); // 0x00000001807C5980-0x00000001807C59A0
	}
}
