/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class MothsAndFlamesDiceManager : MonoBehaviour // TypeDefIndex: 13083
{
	// Fields
	public MothsAndFlamesDice[] allDice; // 0x20
	internal int numDiceRolling; // 0x28
	private MothsAndFlamesGame _game; // 0x30

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <StartShake>d__8 : IEnumerator<object> // TypeDefIndex: 13084
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MothsAndFlamesDiceManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <StartShake>d__8(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812F2060-0x00000001812F2350
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812F2350-0x00000001812F23A0
	}

	// Constructors
	public MothsAndFlamesDiceManager(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	internal void Init(); // 0x00000001812DEC20-0x00000001812DEE60
	internal void RequestRollValues(); // 0x00000001812DEF20-0x00000001812DF1A0
	internal void ReceiveRollValues(string inRollResults); // 0x00000001812DEE60-0x00000001812DEF20
	private void ResultCheck(MothsAndFlamesDice.EDiceFaceValue inFaceValue, ref int refM, ref int refF); // 0x00000001812DF1A0-0x00000001812DF1B0
	internal MothsAndFlamesGame.EBetTypes GetResults(); // 0x00000001812DEAF0-0x00000001812DEC20
	[IteratorStateMachine] // 0x00000001800DD160-0x00000001800DD1B0
	internal IEnumerator StartShake(); // 0x00000001812DF1B0-0x00000001812DF210
	internal void Unload(); // 0x00000001812DF210-0x00000001812DF430
}

