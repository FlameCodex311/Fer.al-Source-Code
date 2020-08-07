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

public class MoonPhasesTokenManager : MonoBehaviour // TypeDefIndex: 10729
{
	// Fields
	public float maxMoveTime; // 0x20
	public float minMoveTime; // 0x24
	internal float moveTime; // 0x28
	public Transform playerToken; // 0x30
	public Transform dealerToken; // 0x38
	public Transform playerStart; // 0x40
	public Transform dealerStart; // 0x48
	public Transform[] crescentLocations; // 0x50
	public Transform[] gibbousLocations; // 0x58
	public Transform[] fullLocations; // 0x60
	public Transform[] playerTokenLocations; // 0x68
	public Transform[] dealerTokenLocations; // 0x70
	private MoonPhasesGame _game; // 0x78

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <MoveTokens>d__14 : IEnumerator<object> // TypeDefIndex: 10730
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MoonPhasesTokenManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <MoveTokens>d__14(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180C15C20-0x0000000180C15E10
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180C15E10-0x0000000180C15E60
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <MoveToken>d__16 : IEnumerator<object> // TypeDefIndex: 10731
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Transform inTrans; // 0x20
		public MoonPhasesTokenManager <>4__this; // 0x28
		public Vector3[] inEndPos; // 0x30
		private Vector3 <startPos>5__2; // 0x38
		private float <moveSlices>5__3; // 0x44
		private Vector3 <endPos>5__4; // 0x48
		private int <i>5__5; // 0x54
		private int <l>5__6; // 0x58
		private float <t>5__7; // 0x5C

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <MoveToken>d__16(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180C158F0-0x0000000180C15BD0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180C15BD0-0x0000000180C15C20
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <ResetTokens>d__17 : IEnumerator<object> // TypeDefIndex: 10732
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MoonPhasesTokenManager <>4__this; // 0x20
		public bool inImmediate; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <ResetTokens>d__17(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180C16640-0x0000000180C16860
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180C16860-0x0000000180C168B0
	}

	// Constructors
	public MoonPhasesTokenManager(); // 0x0000000180C10C60-0x0000000180C10C80

	// Methods
	private void Start(); // 0x0000000180C10C20-0x0000000180C10C60
	[IteratorStateMachine] // 0x0000000180269810-0x0000000180269860
	internal IEnumerator MoveTokens(); // 0x0000000180C10B50-0x0000000180C10BB0
	private Vector3[] GetPositions(MoonPhasesGame.Player inPlayer, Transform[] inTrans, bool inIsPlayer); // 0x0000000180C10590-0x0000000180C10AD0
	[IteratorStateMachine] // 0x00000001802699A0-0x00000001802699F0
	private IEnumerator MoveToken(Transform inTrans, Vector3[] inEndPos); // 0x0000000180C10AD0-0x0000000180C10B50
	[IteratorStateMachine] // 0x0000000180269B80-0x0000000180269BD0
	internal IEnumerator ResetTokens(bool inImmediate); // 0x0000000180C10BB0-0x0000000180C10C20
}

