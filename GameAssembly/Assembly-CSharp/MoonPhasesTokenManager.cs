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

public class MoonPhasesTokenManager : MonoBehaviour // TypeDefIndex: 13064
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
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <MoveTokens>d__14 : IEnumerator<object> // TypeDefIndex: 13065
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MoonPhasesTokenManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <MoveTokens>d__14(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812EEF00-0x00000001812EF100
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812EF100-0x00000001812EF150
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <MoveToken>d__16 : IEnumerator<object> // TypeDefIndex: 13066
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <MoveToken>d__16(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812EE860-0x00000001812EEB50
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812EEB50-0x00000001812EEBA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <ResetTokens>d__17 : IEnumerator<object> // TypeDefIndex: 13067
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MoonPhasesTokenManager <>4__this; // 0x20
		public bool inImmediate; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <ResetTokens>d__17(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812EF970-0x00000001812EFBA0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812EFBA0-0x00000001812EFBF0
	}

	// Constructors
	public MoonPhasesTokenManager(); // 0x00000001812DDA60-0x00000001812DDA80

	// Methods
	private void Start(); // 0x00000001812DDA20-0x00000001812DDA60
	[IteratorStateMachine] // 0x00000001800D34F0-0x00000001800D3540
	internal IEnumerator MoveTokens(); // 0x00000001812DD950-0x00000001812DD9B0
	private Vector3[] GetPositions(MoonPhasesGame.Player inPlayer, Transform[] inTrans, bool inIsPlayer); // 0x00000001812DD340-0x00000001812DD8D0
	[IteratorStateMachine] // 0x00000001800D3880-0x00000001800D38D0
	private IEnumerator MoveToken(Transform inTrans, Vector3[] inEndPos); // 0x00000001812DD8D0-0x00000001812DD950
	[IteratorStateMachine] // 0x00000001800D3BA0-0x00000001800D3BF0
	internal IEnumerator ResetTokens(bool inImmediate); // 0x00000001812DD9B0-0x00000001812DDA20
}

