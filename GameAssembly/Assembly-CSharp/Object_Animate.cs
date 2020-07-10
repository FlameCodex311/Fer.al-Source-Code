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

public class Object_Animate : ManagedBehaviour // TypeDefIndex: 12686
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private ObjectAnimItem defaultAnimation; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private ObjectAnimItem[] animations; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform animSoundTransform; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Animator _animator; // 0x68

	// Nested types
	[Serializable]
	public class ObjectAnimItem // TypeDefIndex: 12687
	{
		// Fields
		public string animClipName; // 0x10
		public FeralAudioInfo startSound; // 0x18
		public float animDelayMin; // 0x20
		public float animDelayMax; // 0x24

		// Constructors
		public ObjectAnimItem(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <PlayLoopAnim>d__6 : IEnumerator<object> // TypeDefIndex: 12688
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Object_Animate <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <PlayLoopAnim>d__6(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180E9A550-0x0000000180E9A7B0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180E9A7B0-0x0000000180E9A800
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <PlayAnimation>d__7 : IEnumerator<object> // TypeDefIndex: 12689
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Object_Animate <>4__this; // 0x20
		public ObjectAnimItem inObjectAnimItem; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <PlayAnimation>d__7(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180E9A280-0x0000000180E9A500
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180E9A500-0x0000000180E9A550
	}

	// Constructors
	public Object_Animate(); // 0x0000000180E968C0-0x0000000180E96920

	// Methods
	public override void MStart(); // 0x0000000180E96720-0x0000000180E967F0
	[IteratorStateMachine] // 0x000000018010D320-0x000000018010D370
	private IEnumerator PlayLoopAnim(); // 0x0000000180E96860-0x0000000180E968C0
	[IteratorStateMachine] // 0x000000018010D660-0x000000018010D6B0
	private IEnumerator PlayAnimation(ObjectAnimItem inObjectAnimItem); // 0x0000000180E967F0-0x0000000180E96860
}

