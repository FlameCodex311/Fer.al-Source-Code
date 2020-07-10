/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using World_Challenge.Parlor_Game;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace World_Challenge.Parlor_Game.DiceTest
{
	public class DiceTest : ParlorGame // TypeDefIndex: 15586
	{
		// Fields
		[Header] // 0x0000000180107350-0x0000000180107380
		public Transform diceLocator; // 0x80
		public GameObject die; // 0x88
		private List<GameObject> dice; // 0x90
		private int numDice; // 0x98
		private List<int> countedDice; // 0xA0
		private bool allDiceCounted; // 0xA8
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <RollDice>d__10 : IEnumerator<object> // TypeDefIndex: 15587
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DiceTest <>4__this; // 0x20
			private int <i>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <RollDice>d__10(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018171DC30-0x000000018171DF10
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018171DF10-0x000000018171DF60
		}
	
		// Constructors
		public DiceTest(); // 0x000000018170A930-0x000000018170A9A0
	
		// Methods
		public override void MStart(); // 0x000000018170A360-0x000000018170A390
		private void ResetGame(bool newGame); // 0x000000018170A4D0-0x000000018170A710
		public override void MUpdate(); // 0x000000018170A390-0x000000018170A4D0
		internal override void Intro(); // 0x000000018170A2F0-0x000000018170A360
		[IteratorStateMachine] // 0x000000018012DB00-0x000000018012DB50
		private IEnumerator RollDice(); // 0x000000018170A720-0x000000018170A780
		private void Shoot(GameObject d); // 0x000000018170A780-0x000000018170A930
		private int GetDieValue(GameObject dieObject); // 0x0000000181709E80-0x000000018170A2F0
		internal override void ResultsDone(); // 0x000000018170A710-0x000000018170A720
	}
}
