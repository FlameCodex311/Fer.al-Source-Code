/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Framework
{
	public abstract class ConditionTask : Task // TypeDefIndex: 15727
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _invert; // 0x58
		private int yieldReturn; // 0x5C
		private int yields; // 0x60
		private bool isRuntimeEnabled; // 0x64
	
		// Properties
		public bool invert { get; set; } // 0x0000000180379F00-0x0000000180379F10 0x00000001805FC5A0-0x00000001805FC5B0
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Flip>d__13 : IEnumerator<object> // TypeDefIndex: 15728
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ConditionTask <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Flip>d__13(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001808B6860-0x00000001808B68D0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001808B68D0-0x00000001808B6920
		}
	
		// Constructors
		protected ConditionTask(); // 0x00000001808A2A20-0x00000001808A2A30
	
		// Methods
		public void Enable(Component agent, IBlackboard bb); // 0x00000001808A28D0-0x00000001808A2940
		public void Disable(); // 0x00000001808A2890-0x00000001808A28D0
		[Obsolete] // 0x000000018021C040-0x000000018021C070
		public bool CheckCondition(Component agent, IBlackboard blackboard); // 0x00000001808A26E0-0x00000001808A26F0
		public bool Check(Component agent, IBlackboard blackboard); // 0x00000001808A27A0-0x00000001808A2890
		public bool CheckOnce(Component agent, IBlackboard blackboard); // 0x00000001808A26F0-0x00000001808A27A0
		protected void YieldReturn(bool value); // 0x00000001808A29A0-0x00000001808A2A20
		[IteratorStateMachine] // 0x000000018021C1E0-0x000000018021C230
		private IEnumerator Flip(); // 0x00000001808A2940-0x00000001808A29A0
		protected virtual void OnEnable(); // 0x00000001803774A0-0x00000001803774B0
		protected virtual void OnDisable(); // 0x00000001803774A0-0x00000001803774B0
		protected virtual bool OnCheck(); // 0x0000000180380B60-0x0000000180380B70
	}
}
