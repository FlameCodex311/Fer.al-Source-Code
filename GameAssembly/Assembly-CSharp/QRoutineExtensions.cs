/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public static class QRoutineExtensions // TypeDefIndex: 11222
{
	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <StartQRoutineAsync>d__2 : IAsyncStateMachine // TypeDefIndex: 11223
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<QRoutine> <>t__builder; // 0x08
		public GameObject inGameObject; // 0x20
		public IEnumerator inRoutine; // 0x28
		public Action<QRoutine> inFinishedAction; // 0x30
		public Action<QRoutine> inCanceledAction; // 0x38
		private QRoutine <qRoutine>5__2; // 0x40
		private TaskAwaiter <>u__1; // 0x48

		// Methods
		private void MoveNext(); // 0x0000000180030940-0x0000000180030950
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180030950-0x00000001800309A0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <StartQRoutineAsync>d__4<T> : IAsyncStateMachine // TypeDefIndex: 11224
	{
		// Fields
		public int <>1__state;
		public AsyncTaskMethodBuilder<T> <>t__builder;
		public GameObject inGameObject;
		public IEnumerator inRoutine;
		public Action<QRoutine> inFinishedAction;
		public Action<QRoutine> inCanceledAction;
		private QRoutine<T> <qRoutine>5__2;
		private TaskAwaiter <>u__1;

		// Methods
		private void MoveNext();
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine);
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <StartQRoutineAndWait>d__5 : IEnumerator<object> // TypeDefIndex: 11225
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public GameObject inGameObject; // 0x20
		public IEnumerator inRoutine; // 0x28
		public Action<QRoutine> inFinishedAction; // 0x30
		public Action<QRoutine> inCanceledAction; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <StartQRoutineAndWait>d__5(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180A42B20-0x0000000180A42C60
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180A42C60-0x0000000180A42CB0
	}

	// Extension methods
	public static bool IsValid(this QRoutineGroup inGroup); // 0x0000000180A2CF00-0x0000000180A2CF10
	public static QRoutine StartQRoutine(this GameObject inGameObject, IEnumerator inRoutine, Action<QRoutine> inFinishedAction = null, Action<QRoutine> inCanceledAction = null); // 0x0000000180A2D0C0-0x0000000180A2D180
	[AsyncStateMachine] // 0x000000018025F880-0x000000018025F8F0
	public static Task<QRoutine> StartQRoutineAsync(this GameObject inGameObject, IEnumerator inRoutine, Action<QRoutine> inFinishedAction = null, Action<QRoutine> inCanceledAction = null); // 0x0000000180A2CFA0-0x0000000180A2D0C0
	public static QRoutine<T> StartQRoutine<T>(this GameObject inGameObject, IEnumerator inRoutine, Action<QRoutine> inFinishedAction = null, Action<QRoutine> inCanceledAction = null);
	[AsyncStateMachine] // 0x000000018025FCE0-0x000000018025FD50
	public static Task<T> StartQRoutineAsync<T>(this GameObject inGameObject, IEnumerator inRoutine, Action<QRoutine> inFinishedAction = null, Action<QRoutine> inCanceledAction = null);
	[IteratorStateMachine] // 0x000000018025FF00-0x000000018025FF70
	public static IEnumerator StartQRoutineAndWait(this GameObject inGameObject, IEnumerator inRoutine, Action<QRoutine> inFinishedAction = null, Action<QRoutine> inCanceledAction = null); // 0x0000000180A2CF10-0x0000000180A2CFA0
	public static QRoutine OnFinish(this QRoutine inQRoutine, Action<QRoutine> inFinishedAction = null); // 0x0000000180803C50-0x0000000180803C70
	public static QRoutine OnCancel(this QRoutine inQRoutine, Action<QRoutine> inCanceledAction = null); // 0x0000000180803AA0-0x0000000180803AC0
}

