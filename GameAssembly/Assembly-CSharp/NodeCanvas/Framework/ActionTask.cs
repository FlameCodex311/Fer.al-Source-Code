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
	public abstract class ActionTask : Task // TypeDefIndex: 14588
	{
		// Fields
		[NonSerialized]
		private Status status; // 0x58
		[NonSerialized]
		private float startedTime; // 0x5C
		[NonSerialized]
		private float pausedTime; // 0x60
		[NonSerialized]
		private bool latch; // 0x64
		[NonSerialized]
		private bool _isPaused; // 0x65
	
		// Properties
		public float elapsedTime { get; } // 0x000000018155E910-0x000000018155E950 
		public bool isRunning { get; } // 0x000000018155E950-0x000000018155E960 
		public bool isPaused { get; private set; } // 0x0000000181051B50-0x0000000181051B60 0x0000000181051B70-0x0000000181051B80
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ActionUpdater>d__13 : IEnumerator<object> // TypeDefIndex: 14589
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ActionTask <>4__this; // 0x20
			public Component agent; // 0x28
			public IBlackboard blackboard; // 0x30
			public Action<bool> callback; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ActionUpdater>d__13(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181574A20-0x0000000181574AD0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181574AD0-0x0000000181574B20
		}
	
		// Constructors
		protected ActionTask(); // 0x000000018155E900-0x000000018155E910
	
		// Methods
		public void ExecuteAction(Component agent, IBlackboard blackboard, Action<bool> callback); // 0x000000018155E700-0x000000018155E7C0
		[IteratorStateMachine] // 0x0000000180160AB0-0x0000000180160B00
		private IEnumerator ActionUpdater(Component agent, IBlackboard blackboard, Action<bool> callback); // 0x000000018155E510-0x000000018155E5A0
		public Status ExecuteAction(Component agent, IBlackboard blackboard); // 0x000000018155E7C0-0x000000018155E8C0
		public void EndAction(); // 0x000000018155E610-0x000000018155E670
		public void EndAction(bool success); // 0x000000018155E5A0-0x000000018155E610
		public void EndAction(bool? success); // 0x000000018155E670-0x000000018155E700
		public void PauseAction(); // 0x000000018155E8C0-0x000000018155E900
		protected virtual void OnExecute(); // 0x00000001803581E0-0x00000001803581F0
		protected virtual void OnUpdate(); // 0x00000001803581E0-0x00000001803581F0
		protected virtual void OnStop(bool interrupted); // 0x000000018090E380-0x000000018090E3A0
		protected virtual void OnStop(); // 0x00000001803581E0-0x00000001803581F0
		protected virtual void OnPause(); // 0x00000001803581E0-0x00000001803581F0
	}
}
