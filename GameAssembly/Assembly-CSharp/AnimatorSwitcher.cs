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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class AnimatorSwitcher : ManagedBehaviour // TypeDefIndex: 11441
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
	public class StateInfo // TypeDefIndex: 11442
	{
		// Fields
		public string stateName; // 0x10
		public float waitMin; // 0x18
		public float waitMax; // 0x1C
		public bool looped; // 0x20
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public bool isLooping; // 0x21
		public UnityEvent OnState; // 0x28

		// Constructors
		public StateInfo(); // 0x0000000181049FF0-0x000000018104A040
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <AnimCoroutine>d__10 : IEnumerator<object> // TypeDefIndex: 11443
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public AnimatorSwitcher <>4__this; // 0x20
		private StateInfo <cStateInfo>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <AnimCoroutine>d__10(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018104A040-0x000000018104A430
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018104A430-0x000000018104A480
	}

	// Constructors
	public AnimatorSwitcher(); // 0x000000018103CD80-0x000000018103CDE0

	// Methods
	public override void MOnEnable(); // 0x000000018103CCA0-0x000000018103CD20
	public override void MOnDisable(); // 0x000000018103CC80-0x000000018103CCA0
	private void SetAnimator(); // 0x000000018103CD20-0x000000018103CD80
	[IteratorStateMachine] // 0x00000001800B6040-0x00000001800B6090
	private IEnumerator AnimCoroutine(); // 0x000000018103CC20-0x000000018103CC80
}

