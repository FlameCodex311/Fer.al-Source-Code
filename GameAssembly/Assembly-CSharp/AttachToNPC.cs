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

public class AttachToNPC : ManagedBehaviour // TypeDefIndex: 11532
{
	// Fields
	public Transform parentTransform; // 0x50
	public string attachName; // 0x58
	public Vector3 positionOffset; // 0x60
	public Vector3 rotationOffset; // 0x6C
	private Transform foundTransform; // 0x78

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <AttachCoroutine>d__8 : IEnumerator<object> // TypeDefIndex: 11533
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public AttachToNPC <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <AttachCoroutine>d__8(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018215D730-0x000000018215D940
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018215D940-0x000000018215D990
	}

	// Constructors
	public AttachToNPC(); // 0x0000000182156D40-0x0000000182156DA0

	// Methods
	public override void MOnEnable(); // 0x0000000182156CD0-0x0000000182156D40
	public override void MOnDisable(); // 0x000000018214D950-0x000000018214D970
	private void FindAttachTransform(); // 0x0000000182156C40-0x0000000182156CD0
	[IteratorStateMachine] // 0x00000001802158D0-0x0000000180215920
	private IEnumerator AttachCoroutine(); // 0x0000000182156BE0-0x0000000182156C40
}

