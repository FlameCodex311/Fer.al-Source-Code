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

public class FXController : MonoBehaviour // TypeDefIndex: 11394
{
	// Fields
	public FXInfo[] fxList; // 0x20
	private Dictionary<Transform, FXInfo> _fxDictionay; // 0x28

	// Nested types
	public enum FXType // TypeDefIndex: 11395
	{
		NONE = 0,
		SWIRL = 1
	}

	[Serializable]
	public class FXInfo // TypeDefIndex: 11396
	{
		// Fields
		public FXType type; // 0x10
		public FXObject prefab; // 0x18

		// Constructors
		public FXInfo(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 11397
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__5_0; // 0x08

		// Constructors
		static <>c(); // 0x000000018086C1A0-0x000000018086C200
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <SpawnFXToPlayer>b__5_0(); // 0x000000018086BDF0-0x000000018086BE60
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <SpawnFXToPlayer>d__5 : IEnumerator<object> // TypeDefIndex: 11398
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FXController <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <SpawnFXToPlayer>d__5(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018086B730-0x000000018086B8A0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018086B8A0-0x000000018086B8F0
	}

	// Constructors
	public FXController(); // 0x0000000180861C60-0x0000000180861CC0

	// Methods
	private void Start(); // 0x0000000180861BF0-0x0000000180861C60
	[IteratorStateMachine] // 0x00000001801D44D0-0x00000001801D4520
	private IEnumerator SpawnFXToPlayer(FXType inType); // 0x0000000180861B90-0x0000000180861BF0
	public void SetFXToObject(FXType inType, Transform target); // 0x0000000180861810-0x00000001808619A0
	private void SpawnFXObject(FXInfo inFXInfo, Transform inTransform); // 0x00000001808619A0-0x0000000180861B90
}

