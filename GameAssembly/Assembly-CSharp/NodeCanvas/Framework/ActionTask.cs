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
	public abstract class ActionTask : Task // TypeDefIndex: 15722
	{
		// Fields
		private Status status; // 0x58
		private float timeStarted; // 0x5C
		private bool latch; // 0x60
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <isPaused>k__BackingField; // 0x61
	
		// Properties
		public float elapsedTime { get; } // 0x000000018089EF70-0x000000018089EFD0 
		public bool isRunning { get; } // 0x000000018089EFD0-0x000000018089EFE0 
		public bool isPaused { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180459DB0-0x0000000180459DC0 0x000000018045A0B0-0x000000018045A0C0
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <IndependentActionUpdater>d__12 : IEnumerator<object> // TypeDefIndex: 15723
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ActionTask <>4__this; // 0x20
			public Component agent; // 0x28
			public IBlackboard blackboard; // 0x30
			public Action<Status> callback; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <IndependentActionUpdater>d__12(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001808B6920-0x00000001808B69D0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001808B69D0-0x00000001808B6A20
		}
	
		// Constructors
		protected ActionTask(); // 0x000000018089EF60-0x000000018089EF70
	
		// Methods
		public void ExecuteIndependent(Component agent, IBlackboard blackboard, Action<Status> callback); // 0x000000018089ECB0-0x000000018089ED70
		[IteratorStateMachine] // 0x000000018021AA10-0x000000018021AA60
		private IEnumerator IndependentActionUpdater(Component agent, IBlackboard blackboard, Action<Status> callback); // 0x000000018089EEB0-0x000000018089EF40
		[Obsolete] // 0x000000018021AD00-0x000000018021AD30
		public Status ExecuteAction(Component agent, IBlackboard blackboard); // 0x000000018089ECA0-0x000000018089ECB0
		public Status Execute(Component agent, IBlackboard blackboard); // 0x000000018089ED70-0x000000018089EEB0
		public void EndAction(); // 0x000000018089EBB0-0x000000018089EC10
		public void EndAction(bool success); // 0x000000018089EB40-0x000000018089EBB0
		public void EndAction(bool? success); // 0x000000018089EC10-0x000000018089ECA0
		public void Pause(); // 0x000000018089EF40-0x000000018089EF60
		protected virtual void OnExecute(); // 0x00000001803774A0-0x00000001803774B0
		protected virtual void OnUpdate(); // 0x00000001803774A0-0x00000001803774B0
		protected virtual void OnStop(bool interrupted); // 0x00000001804F1140-0x00000001804F1160
		protected virtual void OnStop(); // 0x00000001803774A0-0x00000001803774B0
		protected virtual void OnPause(); // 0x00000001803774A0-0x00000001803774B0
		protected virtual void OnResume(); // 0x00000001803774A0-0x00000001803774B0
	}
}
