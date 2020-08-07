/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class AnimatorSwitcher : ManagedBehaviour // TypeDefIndex: 12378
{
	// Fields
	public StateInfo[] stateInfos; // 0x50
	public bool repeatForever; // 0x58
	public int repeats; // 0x5C
	private int repeatsSoFar; // 0x60
	private Animator _animator; // 0x68
	private int _stateIndex; // 0x70

	// Nested types
	[Serializable]
	public class StateInfo // TypeDefIndex: 12379
	{
		// Fields
		public string stateName; // 0x10
		public float waitMin; // 0x18
		public float waitMax; // 0x1C
		public bool looped; // 0x20
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public bool isLooping; // 0x21
		public UnityEvent OnState; // 0x28

		// Constructors
		public StateInfo(); // 0x000000018215D160-0x000000018215D1B0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <AnimCoroutine>d__10 : IEnumerator<object> // TypeDefIndex: 12380
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public AnimatorSwitcher <>4__this; // 0x20
		private StateInfo <cStateInfo>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <AnimCoroutine>d__10(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018215D1B0-0x000000018215D590
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018215D590-0x000000018215D5E0
	}

	// Constructors
	public AnimatorSwitcher(); // 0x0000000182155F60-0x0000000182155FC0

	// Methods
	public override void MOnEnable(); // 0x0000000182155E80-0x0000000182155F00
	public override void MOnDisable(); // 0x000000018214D950-0x000000018214D970
	private void SetAnimator(); // 0x0000000182155F00-0x0000000182155F60
	[IteratorStateMachine] // 0x0000000180287300-0x0000000180287350
	private IEnumerator AnimCoroutine(); // 0x0000000182155E20-0x0000000182155E80
}

