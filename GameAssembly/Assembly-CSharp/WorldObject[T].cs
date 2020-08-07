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

public class WorldObject<T> : WorldObject // TypeDefIndex: 12973
	where T : WorldObjectInfo
{
	// Fields
	private T _info;
	private string _worldObjectDefID;
	[TupleElementNames] // 0x0000000180258050-0x00000001802580D0
	private Queue<ValueTuple<T, Action<GameObject, T>>> _newInfos;
	private T _currentSettingInfo;

	// Properties
	public T Info { get; private set; }
	public string WorldObjectDefID { get; private set; }
	public virtual QRoutineGroup BuildQRoutineGroup { get; }

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <SetNewInfoRoutine>d__13 : IEnumerator<object> // TypeDefIndex: 12974
	{
		// Fields
		private int <>1__state;
		private object <>2__current;
		public WorldObject<T> <>4__this;
		[TupleElementNames] // 0x0000000180258B70-0x0000000180258BF0
		private ValueTuple<T, Action<GameObject, T>> <newInfoTuple>5__2;

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <SetNewInfoRoutine>d__13(int <>1__state);

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose();
		private bool MoveNext();
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset();
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Build>d__16 : IEnumerator<object> // TypeDefIndex: 12975
	{
		// Fields
		private int <>1__state;
		private object <>2__current;

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Build>d__16(int <>1__state);

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose();
		private bool MoveNext();
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset();
	}

	// Constructors
	public WorldObject();

	// Methods
	public static WorldObject<T> Instantiate(string inWorldObjectInstanceID, string inWorldObjectDefID, Vector3 inPosition, Quaternion inRotation);
	public virtual void OnCreate(T inInfo, Action<GameObject, T> inFinishedCallback);
	public QRoutine SetNewInfo(T inInfo, Action<GameObject, T> inFinishedCallback);
	[IteratorStateMachine] // 0x0000000180258510-0x0000000180258560
	private IEnumerator SetNewInfoRoutine();
	[IteratorStateMachine] // 0x0000000180258880-0x00000001802588D0
	public virtual IEnumerator Build();
}

