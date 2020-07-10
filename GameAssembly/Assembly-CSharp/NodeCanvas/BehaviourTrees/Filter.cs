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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.BehaviourTrees
{
	[Category] // 0x0000000180167880-0x0000000180167940
	[Description] // 0x0000000180167880-0x0000000180167940
	[Icon] // 0x0000000180167880-0x0000000180167940
	[Name] // 0x0000000180167880-0x0000000180167940
	public class Filter : BTDecorator // TypeDefIndex: 14043
	{
		// Fields
		public FilterMode filterMode; // 0x78
		[Name] // 0x0000000180167B40-0x0000000180167BA0
		[ShowIf] // 0x0000000180167B40-0x0000000180167BA0
		public BBParameter<int> maxCount; // 0x80
		[Name] // 0x0000000180167F30-0x0000000180167F90
		[ShowIf] // 0x0000000180167F30-0x0000000180167F90
		public Policy policy; // 0x88
		[ShowIf] // 0x00000001801682F0-0x0000000180168320
		public BBParameter<float> coolDownTime; // 0x90
		public bool inactiveWhenLimited; // 0x98
		private int executedCount; // 0x9C
		private float currentTime; // 0xA0
	
		// Nested types
		public enum FilterMode // TypeDefIndex: 14044
		{
			LimitNumberOfTimes = 0,
			CoolDown = 1
		}
	
		public enum Policy // TypeDefIndex: 14045
		{
			SuccessOrFailure = 0,
			SuccessOnly = 1,
			FailureOnly = 2
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Cooldown>d__11 : IEnumerator<object> // TypeDefIndex: 14046
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Filter <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Cooldown>d__11(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181575060-0x0000000181575150
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181575150-0x00000001815751A0
		}
	
		// Constructors
		public Filter(); // 0x0000000181567780-0x0000000181567800
	
		// Methods
		public override void OnGraphStarted(); // 0x00000001803581E0-0x00000001803581F0
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x0000000181567570-0x0000000181567780
		[IteratorStateMachine] // 0x00000001801684C0-0x0000000180168510
		private IEnumerator Cooldown(); // 0x0000000181567510-0x0000000181567570
	}
}
