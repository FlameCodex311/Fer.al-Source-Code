/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.BehaviourTrees
{
	[Category] // 0x00000001802154D0-0x0000000180215590
	[Description] // 0x00000001802154D0-0x0000000180215590
	[Icon] // 0x00000001802154D0-0x0000000180215590
	[Name] // 0x00000001802154D0-0x0000000180215590
	public class Filter : BTDecorator // TypeDefIndex: 15161
	{
		// Fields
		public FilterMode filterMode; // 0x88
		[Name] // 0x0000000180215870-0x00000001802158D0
		[ShowIf] // 0x0000000180215870-0x00000001802158D0
		public BBParameter<int> maxCount; // 0x90
		[Name] // 0x0000000180215B90-0x0000000180215BF0
		[ShowIf] // 0x0000000180215B90-0x0000000180215BF0
		public Policy policy; // 0x98
		[ShowIf] // 0x0000000180215ED0-0x0000000180215F00
		public BBParameter<float> coolDownTime; // 0xA0
		public bool inactiveWhenLimited; // 0xA8
		private int executedCount; // 0xAC
		private float currentTime; // 0xB0
	
		// Nested types
		public enum FilterMode // TypeDefIndex: 15162
		{
			LimitNumberOfTimes = 0,
			CoolDown = 1
		}
	
		public enum Policy // TypeDefIndex: 15163
		{
			SuccessOrFailure = 0,
			SuccessOnly = 1,
			FailureOnly = 2
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Cooldown>d__11 : IEnumerator<object> // TypeDefIndex: 15164
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Filter <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Cooldown>d__11(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001808B64B0-0x00000001808B65A0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001808B65A0-0x00000001808B65F0
		}
	
		// Constructors
		public Filter(); // 0x00000001808A7E00-0x00000001808A7E80
	
		// Methods
		public override void OnGraphStoped(); // 0x00000001808A7DF0-0x00000001808A7E00
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001808A7BC0-0x00000001808A7DF0
		[IteratorStateMachine] // 0x00000001802160A0-0x00000001802160F0
		private IEnumerator Cooldown(); // 0x00000001808A7B60-0x00000001808A7BC0
	}
}
