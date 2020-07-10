/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Framework
{
	public abstract class ConditionTask : Task // TypeDefIndex: 14594
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _invert; // 0x58
		[NonSerialized]
		private int yieldReturn; // 0x5C
		private int yields; // 0x60
	
		// Properties
		public bool invert { get; set; } // 0x0000000180369BC0-0x0000000180369BD0 0x00000001803A27C0-0x00000001803A27D0
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Flip>d__13 : IEnumerator<object> // TypeDefIndex: 14595
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ConditionTask <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Flip>d__13(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181760B80-0x0000000181760BF0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181760BF0-0x0000000181760C40
		}
	
		// Constructors
		protected ConditionTask(); // 0x000000018174BC20-0x000000018174BC30
	
		// Methods
		public void Enable(Component agent, IBlackboard bb); // 0x000000018174BAF0-0x000000018174BB30
		public void Disable(); // 0x000000018174BAD0-0x000000018174BAF0
		public bool CheckCondition(Component agent, IBlackboard blackboard); // 0x000000018174BA30-0x000000018174BAD0
		protected void YieldReturn(bool value); // 0x000000018174BB90-0x000000018174BC20
		protected virtual void OnEnable(); // 0x00000001803581E0-0x00000001803581F0
		protected virtual void OnDisable(); // 0x00000001803581E0-0x00000001803581F0
		protected virtual bool OnCheck(); // 0x00000001803C29F0-0x00000001803C2A00
		[IteratorStateMachine] // 0x0000000180161B40-0x0000000180161B90
		private IEnumerator Flip(); // 0x000000018174BB30-0x000000018174BB90
	}
}
