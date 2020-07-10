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

public class AttachToNPC : ManagedBehaviour // TypeDefIndex: 10041
{
	// Fields
	public Transform parentTransform; // 0x50
	public string attachName; // 0x58
	public Vector3 positionOffset; // 0x60
	public Vector3 rotationOffset; // 0x6C
	private Transform foundTransform; // 0x78

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <AttachCoroutine>d__8 : IEnumerator<object> // TypeDefIndex: 10042
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public AttachToNPC <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <AttachCoroutine>d__8(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018104A480-0x000000018104A6A0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018104A6A0-0x000000018104A6F0
	}

	// Constructors
	public AttachToNPC(); // 0x000000018103DCE0-0x000000018103DD40

	// Methods
	public override void MOnEnable(); // 0x000000018103DC70-0x000000018103DCE0
	public override void MOnDisable(); // 0x000000018103CC80-0x000000018103CCA0
	private void FindAttachTransform(); // 0x000000018103DBE0-0x000000018103DC70
	[IteratorStateMachine] // 0x000000018013C970-0x000000018013C9C0
	private IEnumerator AttachCoroutine(); // 0x000000018103DB80-0x000000018103DBE0
}

