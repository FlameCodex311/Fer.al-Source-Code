/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FMODUnity;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ManagedBehaviourManager] // 0x00000001801CE8E0-0x00000001801CE910
public class FeralAudioEmitter : ManagedBehaviour // TypeDefIndex: 11367
{
	// Fields
	public FeralEmitterGameEvent playEvent; // 0x50
	public FeralEmitterGameEvent stopEvent; // 0x54
	public FeralAudioInfo audioInfo; // 0x58
	public string collisionTag; // 0x60
	private bool _isQuitting; // 0x68

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass20_0 // TypeDefIndex: 11368
	{
		// Fields
		public FeralAudioEmitter <>4__this; // 0x10
		public GameObject inParent; // 0x18
		public Action<bool> <>9__2; // 0x20

		// Constructors
		public <>c__DisplayClass20_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <Play>b__0(QRoutine c); // 0x0000000180E3A8D0-0x0000000180E3A9B0
		internal void <Play>b__2(bool cb); // 0x0000000180E3A9B0-0x0000000180E3A9F0
		internal void <Play>b__1(bool cb); // 0x0000000180E3A9B0-0x0000000180E3A9F0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <WaitForFeralAudioManager>d__23 : IEnumerator<object> // TypeDefIndex: 11369
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <WaitForFeralAudioManager>d__23(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180E3AE30-0x0000000180E3AED0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180E3AED0-0x0000000180E3AF20
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass24_0 // TypeDefIndex: 11370
	{
		// Fields
		public FeralAudioEmitter <>4__this; // 0x10
		public ParamRef[] inParameters; // 0x18
		public Action<bool> <>9__2; // 0x20

		// Constructors
		public <>c__DisplayClass24_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <SetParameters>b__0(QRoutine c); // 0x0000000180E3A9F0-0x0000000180E3AAD0
		internal void <SetParameters>b__2(bool cb); // 0x0000000180E3AB30-0x0000000180E3AB90
		internal void <SetParameters>b__1(bool cb); // 0x0000000180E3AAD0-0x0000000180E3AB30
	}

	// Constructors
	public FeralAudioEmitter(); // 0x0000000180E388A0-0x0000000180E38900

	// Methods
	public override void MStart(); // 0x0000000180E38A80-0x0000000180E38AC0
	private void OnApplicationQuit(); // 0x0000000180E38AC0-0x0000000180E38AD0
	public override void MOnDestroy(); // 0x0000000180E389E0-0x0000000180E38A20
	public override void MOnEnable(); // 0x0000000180E38A50-0x0000000180E38A80
	public override void MOnDisable(); // 0x0000000180E38A20-0x0000000180E38A50
	private void OnTriggerEnter(Collider other); // 0x0000000180E38C00-0x0000000180E38C70
	private void OnTriggerExit(Collider other); // 0x0000000180E38CE0-0x0000000180E38D50
	private void OnTriggerEnter2D(Collider2D other); // 0x0000000180E38B90-0x0000000180E38C00
	private void OnTriggerExit2D(Collider2D other); // 0x0000000180E38C70-0x0000000180E38CE0
	private void OnCollisionEnter(); // 0x0000000180E38B00-0x0000000180E38B30
	private void OnCollisionExit(); // 0x0000000180E38B60-0x0000000180E38B90
	private void OnCollisionEnter2D(); // 0x0000000180E38AD0-0x0000000180E38B00
	private void OnCollisionExit2D(); // 0x0000000180E38B30-0x0000000180E38B60
	public void HandleGameEvent(FeralEmitterGameEvent gameEvent); // 0x0000000180E389B0-0x0000000180E389E0
	public void HandleGameEvent(FeralEmitterGameEvent gameEvent, GameObject inParent); // 0x0000000180E38900-0x0000000180E389B0
	private void Play(GameObject inParent); // 0x0000000180E38D50-0x0000000180E38F20
	public void Play(); // 0x0000000180E38F20-0x0000000180E38F50
	public void Stop(GameObject inParent = null); // 0x0000000180E39120-0x0000000180E391B0
	[IteratorStateMachine] // 0x0000000180295430-0x0000000180295480
	private IEnumerator WaitForFeralAudioManager(); // 0x0000000180E391B0-0x0000000180E39200
	public void SetParameters(ParamRef[] inParameters); // 0x0000000180E38F50-0x0000000180E39120
}

