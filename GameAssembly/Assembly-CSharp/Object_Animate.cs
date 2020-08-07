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

public class Object_Animate : ManagedBehaviour // TypeDefIndex: 14255
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private ObjectAnimItem defaultAnimation; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private ObjectAnimItem[] animations; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform animSoundTransform; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Animator _animator; // 0x68

	// Nested types
	[Serializable]
	public class ObjectAnimItem // TypeDefIndex: 14256
	{
		// Fields
		public string animClipName; // 0x10
		public FeralAudioInfo startSound; // 0x18
		public float animDelayMin; // 0x20
		public float animDelayMax; // 0x24

		// Constructors
		public ObjectAnimItem(); // 0x0000000180373240-0x0000000180373250
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <PlayLoopAnim>d__6 : IEnumerator<object> // TypeDefIndex: 14257
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Object_Animate <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <PlayLoopAnim>d__6(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180808230-0x0000000180808470
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180808470-0x00000001808084C0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <PlayAnimation>d__7 : IEnumerator<object> // TypeDefIndex: 14258
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Object_Animate <>4__this; // 0x20
		public ObjectAnimItem inObjectAnimItem; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <PlayAnimation>d__7(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180807F70-0x00000001808081E0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001808081E0-0x0000000180808230
	}

	// Constructors
	public Object_Animate(); // 0x0000000180804900-0x0000000180804960

	// Methods
	public override void MStart(); // 0x0000000180804760-0x0000000180804830
	[IteratorStateMachine] // 0x00000001801FA250-0x00000001801FA2A0
	private IEnumerator PlayLoopAnim(); // 0x00000001808048A0-0x0000000180804900
	[IteratorStateMachine] // 0x00000001801FA550-0x00000001801FA5A0
	private IEnumerator PlayAnimation(ObjectAnimItem inObjectAnimItem); // 0x0000000180804830-0x00000001808048A0
}

