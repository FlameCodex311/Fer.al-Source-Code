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

public class WorldEvent_Bridge : WorldEvent // TypeDefIndex: 11434
{
	// Fields
	public float bridgeFxDelay; // 0x58
	public GameObject bridgeFx; // 0x60
	private Animation _animation; // 0x68

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <PlayBridgeFx>d__7 : IEnumerator<object> // TypeDefIndex: 11435
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public WorldEvent_Bridge <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <PlayBridgeFx>d__7(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001805DC800-0x00000001805DC900
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001805DC900-0x00000001805DD1C0
	}

	// Constructors
	public WorldEvent_Bridge(); // 0x00000001805E6E70-0x00000001805E6ED0

	// Methods
	public override void MStart(); // 0x00000001805E6A00-0x00000001805E6AE0
	protected override void OnWorldEvent(WorldEventMessage inWorldEventMessage); // 0x00000001805E6AE0-0x00000001805E6DE0
	private void ActivateBridge(); // 0x00000001805E6890-0x00000001805E6960
	private void DeactivateBridge(); // 0x00000001805E6960-0x00000001805E6A00
	[IteratorStateMachine] // 0x00000001801E0300-0x00000001801E0350
	private IEnumerator PlayBridgeFx(); // 0x00000001805E6DE0-0x00000001805E6E40
	private void StopBridgeFx(); // 0x00000001805E6E40-0x00000001805E6E70
}

