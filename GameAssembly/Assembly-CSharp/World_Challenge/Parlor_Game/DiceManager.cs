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

namespace World_Challenge.Parlor_Game
{
	public class DiceManager : ManagedBehaviour // TypeDefIndex: 14689
	{
		// Fields
		[Header] // 0x000000018028DDF0-0x000000018028DE20
		public Dice[] dice; // 0x50
		[Tooltip] // 0x000000018028E010-0x000000018028E040
		public Transform[] spawnLocations; // 0x58
		public GameObject shuffleContainerPlayer; // 0x60
		public GameObject shuffleContainerOpponent; // 0x68
		[Tooltip] // 0x000000018028E120-0x000000018028E150
		public float spawnOffset; // 0x70
		public float shootMagnitude; // 0x74
		public float shootHeightForce; // 0x78
		public float rollWaitTime; // 0x7C
		[Tooltip] // 0x000000018028E200-0x000000018028E230
		public float rollDelay; // 0x80
		public float diceScale; // 0x84
		public float diceShuffleSpeed; // 0x88
		public float diceResetTime; // 0x8C
		internal Dice selectedDice; // 0x90
		internal List<Dice[]> diceHolder; // 0x98
		private Vector3 _offset; // 0xA0
		private float _offsetDegrees; // 0xAC
		private bool _shufflingDice; // 0xB0
		public float setDiceBumpHeight; // 0xB4
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShuffleDice>d__19 : IEnumerator<object> // TypeDefIndex: 14690
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DiceManager <>4__this; // 0x20
			private Vector3 <rotateDirP>5__2; // 0x28
			private Vector3 <rotateDirO>5__3; // 0x34
			private float <td>5__4; // 0x40
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShuffleDice>d__19(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E82310-0x0000000180E828A0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E828A0-0x0000000180E828F0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <RollDice>d__22 : IEnumerator<object> // TypeDefIndex: 14691
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DiceManager <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <RollDice>d__22(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E812D0-0x0000000180E81600
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E81600-0x0000000180E81650
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ResetDice>d__23 : IEnumerator<object> // TypeDefIndex: 14692
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DiceManager <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ResetDice>d__23(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E7FEE0-0x0000000180E80180
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E80180-0x0000000180E801D0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <PickNew>d__24 : IEnumerator<object> // TypeDefIndex: 14693
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Dice inDice; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <PickNew>d__24(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E7D960-0x0000000180E7DF50
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E7DF50-0x0000000180E7DFA0
		}
	
		// Constructors
		public DiceManager(); // 0x0000000180E6EAD0-0x0000000180E6EBA0
	
		// Methods
		internal void SpawnDice(); // 0x0000000180E6E4B0-0x0000000180E6EAD0
		private void Chq(Dice die); // 0x0000000180E6D3A0-0x0000000180E6DFF0
		[IteratorStateMachine] // 0x000000018028E420-0x000000018028E470
		private IEnumerator ShuffleDice(); // 0x0000000180E6E450-0x0000000180E6E4B0
		private void DiceCollision(bool inIgnore); // 0x0000000180E6DFF0-0x0000000180E6E2E0
		private void ShuffleContainersToggle(bool inOn); // 0x0000000180E6E400-0x0000000180E6E450
		[IteratorStateMachine] // 0x000000018028E720-0x000000018028E770
		internal IEnumerator RollDice(); // 0x0000000180E6E3A0-0x0000000180E6E400
		[IteratorStateMachine] // 0x000000018028E9B0-0x000000018028EA00
		internal IEnumerator ResetDice(); // 0x0000000180E6E340-0x0000000180E6E3A0
		[IteratorStateMachine] // 0x000000018028EC40-0x000000018028EC90
		internal IEnumerator PickNew(Dice inDice); // 0x0000000180E6E2E0-0x0000000180E6E340
	}
}
