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

namespace World_Challenge.Parlor_Game
{
	public class DiceManager : ManagedBehaviour // TypeDefIndex: 15534
	{
		// Fields
		[Header] // 0x0000000180108D10-0x0000000180108D40
		public Dice[] dice; // 0x50
		[Tooltip] // 0x0000000180108F00-0x0000000180108F30
		public Transform[] spawnLocations; // 0x58
		public GameObject shuffleContainerPlayer; // 0x60
		public GameObject shuffleContainerOpponent; // 0x68
		[Tooltip] // 0x0000000180109210-0x0000000180109240
		public float spawnOffset; // 0x70
		public float shootMagnitude; // 0x74
		public float shootHeightForce; // 0x78
		public float rollWaitTime; // 0x7C
		[Tooltip] // 0x000000018010A4C0-0x000000018010A4F0
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
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShuffleDice>d__19 : IEnumerator<object> // TypeDefIndex: 15535
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DiceManager <>4__this; // 0x20
			private Vector3 <rotateDirP>5__2; // 0x28
			private Vector3 <rotateDirO>5__3; // 0x34
			private float <td>5__4; // 0x40
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShuffleDice>d__19(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018171F6A0-0x000000018171FC50
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018171FC50-0x000000018171FCA0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <RollDice>d__22 : IEnumerator<object> // TypeDefIndex: 15536
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DiceManager <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <RollDice>d__22(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018171DF60-0x000000018171E2A0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018171E2A0-0x000000018171E2F0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ResetDice>d__23 : IEnumerator<object> // TypeDefIndex: 15537
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DiceManager <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ResetDice>d__23(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018171C960-0x000000018171CC10
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018171CC10-0x000000018171CC60
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <PickNew>d__24 : IEnumerator<object> // TypeDefIndex: 15538
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Dice inDice; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <PickNew>d__24(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018171A2F0-0x000000018171A910
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018171A910-0x000000018171A960
		}
	
		// Constructors
		public DiceManager(); // 0x0000000181709DB0-0x0000000181709E80
	
		// Methods
		internal void SpawnDice(); // 0x0000000181709770-0x0000000181709DB0
		private void Chq(Dice die); // 0x00000001817085B0-0x0000000181709290
		[IteratorStateMachine] // 0x000000018010A660-0x000000018010A6B0
		private IEnumerator ShuffleDice(); // 0x0000000181709710-0x0000000181709770
		private void DiceCollision(bool inIgnore); // 0x0000000181709290-0x00000001817095A0
		private void ShuffleContainersToggle(bool inOn); // 0x00000001817096C0-0x0000000181709710
		[IteratorStateMachine] // 0x000000018010A840-0x000000018010A890
		internal IEnumerator RollDice(); // 0x0000000181709660-0x00000001817096C0
		[IteratorStateMachine] // 0x000000018010A9B0-0x000000018010AA00
		internal IEnumerator ResetDice(); // 0x0000000181709600-0x0000000181709660
		[IteratorStateMachine] // 0x000000018010ADB0-0x000000018010AE00
		internal IEnumerator PickNew(Dice inDice); // 0x00000001817095A0-0x0000000181709600
	}
}
