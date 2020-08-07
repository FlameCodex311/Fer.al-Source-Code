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
	[Category] // 0x00000001802173B0-0x0000000180217470
	[Description] // 0x00000001802173B0-0x0000000180217470
	[Icon] // 0x00000001802173B0-0x0000000180217470
	[Name] // 0x00000001802173B0-0x0000000180217470
	public class Interruptor : BTDecorator, ITaskAssignable<ConditionTask> // TypeDefIndex: 15167
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ConditionTask _condition; // 0x88
	
		// Properties
		public ConditionTask condition { get; set; } // 0x0000000180476CE0-0x0000000180476CF0 0x00000001804794C0-0x00000001804794D0
		public Task task { get; set; } // 0x0000000180476CE0-0x0000000180476CF0 0x00000001808AFBF0-0x00000001808AFC80
	
		// Constructors
		public Interruptor(); // 0x00000001808A8120-0x00000001808A8130
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001808AFA50-0x00000001808AFBA0
		protected override void OnReset(); // 0x00000001808AFBA0-0x00000001808AFBF0
	}
}
