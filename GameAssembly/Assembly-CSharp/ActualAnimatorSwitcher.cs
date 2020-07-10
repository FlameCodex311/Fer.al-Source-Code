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

public class ActualAnimatorSwitcher : ManagedBehaviour // TypeDefIndex: 10037
{
	// Fields
	private Animator _animator; // 0x50
	public RuntimeAnimatorController runtimeAnimatorController; // 0x58

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <AnimCoroutine>d__5 : IEnumerator<object> // TypeDefIndex: 10038
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ActualAnimatorSwitcher <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <AnimCoroutine>d__5(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181411FC0-0x00000001814120C0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001814120C0-0x0000000181412110
	}

	// Constructors
	public ActualAnimatorSwitcher(); // 0x000000018140FD90-0x000000018140FDF0

	// Methods
	public override void MOnEnable(); // 0x000000018140FCC0-0x000000018140FD30
	public override void MOnDisable(); // 0x000000018103CC80-0x000000018103CCA0
	private void SetAnimator(); // 0x000000018140FD30-0x000000018140FD90
	[IteratorStateMachine] // 0x000000018013AD60-0x000000018013ADB0
	private IEnumerator AnimCoroutine(); // 0x000000018140FC60-0x000000018140FCC0
}

