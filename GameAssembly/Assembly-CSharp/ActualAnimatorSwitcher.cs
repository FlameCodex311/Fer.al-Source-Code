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

public class ActualAnimatorSwitcher : ManagedBehaviour // TypeDefIndex: 11528
{
	// Fields
	private Animator _animator; // 0x50
	public RuntimeAnimatorController runtimeAnimatorController; // 0x58

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <AnimCoroutine>d__5 : IEnumerator<object> // TypeDefIndex: 11529
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ActualAnimatorSwitcher <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <AnimCoroutine>d__5(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018215D5E0-0x000000018215D6E0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018215D6E0-0x000000018215D730
	}

	// Constructors
	public ActualAnimatorSwitcher(); // 0x000000018214DA40-0x000000018214DAA0

	// Methods
	public override void MOnEnable(); // 0x000000018214D970-0x000000018214D9E0
	public override void MOnDisable(); // 0x000000018214D950-0x000000018214D970
	private void SetAnimator(); // 0x000000018214D9E0-0x000000018214DA40
	[IteratorStateMachine] // 0x0000000180214E90-0x0000000180214EE0
	private IEnumerator AnimCoroutine(); // 0x000000018214D8F0-0x000000018214D950
}

