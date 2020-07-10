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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ManagedBehaviourManager] // 0x00000001800F4A00-0x00000001800F4A30
public class FeralAudioEmitter : ManagedBehaviour // TypeDefIndex: 13694
{
	// Fields
	public FeralEmitterGameEvent playEvent; // 0x50
	public FeralEmitterGameEvent stopEvent; // 0x54
	public FeralAudioInfo audioInfo; // 0x58
	public string collisionTag; // 0x60
	private bool _isQuitting; // 0x68

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass20_0 // TypeDefIndex: 13695
	{
		// Fields
		public FeralAudioEmitter <>4__this; // 0x10
		public GameObject inParent; // 0x18
		public Action<bool> <>9__2; // 0x20

		// Constructors
		public <>c__DisplayClass20_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <Play>b__0(QRoutine c); // 0x0000000181115150-0x0000000181115230
		internal void <Play>b__2(bool cb); // 0x0000000181115230-0x0000000181115270
		internal void <Play>b__1(bool cb); // 0x0000000181115230-0x0000000181115270
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <WaitForFeralAudioManager>d__23 : IEnumerator<object> // TypeDefIndex: 13696
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <WaitForFeralAudioManager>d__23(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001811155F0-0x0000000181115690
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181115690-0x00000001811156E0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass24_0 // TypeDefIndex: 13697
	{
		// Fields
		public FeralAudioEmitter <>4__this; // 0x10
		public ParamRef[] inParameters; // 0x18
		public Action<bool> <>9__2; // 0x20

		// Constructors
		public <>c__DisplayClass24_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <SetParameters>b__0(QRoutine c); // 0x0000000181115270-0x0000000181115350
		internal void <SetParameters>b__2(bool cb); // 0x0000000181115350-0x00000001811153B0
		internal void <SetParameters>b__1(bool cb); // 0x0000000181115350-0x00000001811153B0
	}

	// Constructors
	public FeralAudioEmitter(); // 0x00000001810F96A0-0x00000001810F9700

	// Methods
	public override void MStart(); // 0x00000001810F9880-0x00000001810F98C0
	private void OnApplicationQuit(); // 0x0000000180751D80-0x0000000180751D90
	public override void MOnDestroy(); // 0x00000001810F97E0-0x00000001810F9820
	public override void MOnEnable(); // 0x00000001810F9850-0x00000001810F9880
	public override void MOnDisable(); // 0x00000001810F9820-0x00000001810F9850
	private void OnTriggerEnter(Collider other); // 0x00000001810F99F0-0x00000001810F9A60
	private void OnTriggerExit(Collider other); // 0x00000001810F9AD0-0x00000001810F9B40
	private void OnTriggerEnter2D(Collider2D other); // 0x00000001810F9980-0x00000001810F99F0
	private void OnTriggerExit2D(Collider2D other); // 0x00000001810F9A60-0x00000001810F9AD0
	private void OnCollisionEnter(); // 0x00000001810F98F0-0x00000001810F9920
	private void OnCollisionExit(); // 0x00000001810F9950-0x00000001810F9980
	private void OnCollisionEnter2D(); // 0x00000001810F98C0-0x00000001810F98F0
	private void OnCollisionExit2D(); // 0x00000001810F9920-0x00000001810F9950
	public void HandleGameEvent(FeralEmitterGameEvent gameEvent); // 0x00000001810F97B0-0x00000001810F97E0
	public void HandleGameEvent(FeralEmitterGameEvent gameEvent, GameObject inParent); // 0x00000001810F9700-0x00000001810F97B0
	private void Play(GameObject inParent); // 0x00000001810F9B40-0x00000001810F9D10
	public void Play(); // 0x00000001810F9D10-0x00000001810F9D40
	public void Stop(GameObject inParent = null); // 0x00000001810F9F10-0x00000001810F9FA0
	[IteratorStateMachine] // 0x00000001800F4AD0-0x00000001800F4B20
	private IEnumerator WaitForFeralAudioManager(); // 0x00000001810F9FA0-0x00000001810F9FF0
	public void SetParameters(ParamRef[] inParameters); // 0x00000001810F9D40-0x00000001810F9F10
}

