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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace World_Challenge.Parlor_Game.DiceTest
{
	public class DiceTest : ParlorGame // TypeDefIndex: 14741
	{
		// Fields
		[Header] // 0x00000001801EA050-0x00000001801EA080
		public Transform diceLocator; // 0x80
		public GameObject die; // 0x88
		private List<GameObject> dice; // 0x90
		private int numDice; // 0x98
		private List<int> countedDice; // 0xA0
		private bool allDiceCounted; // 0xA8
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <RollDice>d__10 : IEnumerator<object> // TypeDefIndex: 14742
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DiceTest <>4__this; // 0x20
			private int <i>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <RollDice>d__10(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E80FB0-0x0000000180E81280
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E81280-0x0000000180E812D0
		}
	
		// Constructors
		public DiceTest(); // 0x0000000180E6F640-0x0000000180E6F6B0
	
		// Methods
		public override void MStart(); // 0x0000000180E6F080-0x0000000180E6F0B0
		private void ResetGame(bool newGame); // 0x0000000180E6F1F0-0x0000000180E6F430
		public override void MUpdate(); // 0x0000000180E6F0B0-0x0000000180E6F1F0
		internal override void Intro(); // 0x0000000180E6F010-0x0000000180E6F080
		[IteratorStateMachine] // 0x00000001801EA290-0x00000001801EA2E0
		private IEnumerator RollDice(); // 0x0000000180E6F440-0x0000000180E6F4A0
		private void Shoot(GameObject d); // 0x0000000180E6F4A0-0x0000000180E6F640
		private int GetDieValue(GameObject dieObject); // 0x0000000180E6EBA0-0x0000000180E6F010
		internal override void ResultsDone(); // 0x0000000180E6F430-0x0000000180E6F440
	}
}
