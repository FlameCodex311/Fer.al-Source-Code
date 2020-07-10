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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public static class QRoutineExtensions // TypeDefIndex: 13551
{
	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <StartQRoutineAsync>d__2 : IAsyncStateMachine // TypeDefIndex: 13552
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
		private void MoveNext(); // 0x000000018022ED40-0x000000018022ED50
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018022ED50-0x000000018022EDA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <StartQRoutineAsync>d__4<T> : IAsyncStateMachine // TypeDefIndex: 13553
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
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine);
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <StartQRoutineAndWait>d__5 : IEnumerator<object> // TypeDefIndex: 13554
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public GameObject inGameObject; // 0x20
		public IEnumerator inRoutine; // 0x28
		public Action<QRoutine> inFinishedAction; // 0x30
		public Action<QRoutine> inCanceledAction; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <StartQRoutineAndWait>d__5(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181606110-0x0000000181606250
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181606250-0x00000001816062A0
	}

	// Extension methods
	public static bool IsValid(this QRoutineGroup inGroup); // 0x00000001815EF330-0x00000001815EF340
	public static QRoutine StartQRoutine(this GameObject inGameObject, IEnumerator inRoutine, Action<QRoutine> inFinishedAction = null, Action<QRoutine> inCanceledAction = null); // 0x00000001815EF4F0-0x00000001815EF5B0
	[AsyncStateMachine] // 0x00000001800C37B0-0x00000001800C3820
	public static Task<QRoutine> StartQRoutineAsync(this GameObject inGameObject, IEnumerator inRoutine, Action<QRoutine> inFinishedAction = null, Action<QRoutine> inCanceledAction = null); // 0x00000001815EF3D0-0x00000001815EF4F0
	public static QRoutine<T> StartQRoutine<T>(this GameObject inGameObject, IEnumerator inRoutine, Action<QRoutine> inFinishedAction = null, Action<QRoutine> inCanceledAction = null);
	[AsyncStateMachine] // 0x00000001800C3C60-0x00000001800C3CD0
	public static Task<T> StartQRoutineAsync<T>(this GameObject inGameObject, IEnumerator inRoutine, Action<QRoutine> inFinishedAction = null, Action<QRoutine> inCanceledAction = null);
	[IteratorStateMachine] // 0x00000001800C51A0-0x00000001800C5210
	public static IEnumerator StartQRoutineAndWait(this GameObject inGameObject, IEnumerator inRoutine, Action<QRoutine> inFinishedAction = null, Action<QRoutine> inCanceledAction = null); // 0x00000001815EF340-0x00000001815EF3D0
	public static QRoutine OnFinish(this QRoutine inQRoutine, Action<QRoutine> inFinishedAction = null); // 0x0000000180E95BD0-0x0000000180E95BF0
	public static QRoutine OnCancel(this QRoutine inQRoutine, Action<QRoutine> inCanceledAction = null); // 0x0000000180E95A20-0x0000000180E95A40
}

