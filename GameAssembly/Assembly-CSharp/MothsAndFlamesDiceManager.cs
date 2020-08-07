/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class MothsAndFlamesDiceManager : MonoBehaviour // TypeDefIndex: 10748
{
	// Fields
	public MothsAndFlamesDice[] allDice; // 0x20
	internal int numDiceRolling; // 0x28
	private MothsAndFlamesGame _game; // 0x30

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <StartShake>d__8 : IEnumerator<object> // TypeDefIndex: 10749
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MothsAndFlamesDiceManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <StartShake>d__8(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807DA640-0x00000001807DA880
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807DA880-0x00000001807DA8D0
	}

	// Constructors
	public MothsAndFlamesDiceManager(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	internal void Init(); // 0x00000001807C5DD0-0x00000001807C5E70
	internal void RequestRollValues(); // 0x00000001807C5F30-0x00000001807C6190
	internal void ReceiveRollValues(string inRollResults); // 0x00000001807C5E70-0x00000001807C5F30
	private void ResultCheck(MothsAndFlamesDice.EDiceFaceValue inFaceValue, ref int refM, ref int refF); // 0x00000001807C6190-0x00000001807C61A0
	internal MothsAndFlamesGame.EBetTypes GetResults(); // 0x00000001807C5CA0-0x00000001807C5DD0
	[IteratorStateMachine] // 0x0000000180276A20-0x0000000180276A70
	internal IEnumerator StartShake(); // 0x00000001807C61A0-0x00000001807C6200
	internal void Unload(); // 0x00000001807C6200-0x00000001807C6280
}

