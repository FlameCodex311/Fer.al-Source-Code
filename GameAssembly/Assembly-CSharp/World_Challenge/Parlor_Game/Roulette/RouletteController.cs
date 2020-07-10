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

namespace World_Challenge.Parlor_Game.Roulette
{
	public class RouletteController : ParlorGame // TypeDefIndex: 15557
	{
		// Fields
		public GameObject wheelPrefab; // 0x80
		public GameObject ballPrefab; // 0x88
		private GameObject board; // 0x90
		private GameObject wheel; // 0x98
		private GameObject ball; // 0xA0
		private Rigidbody wheelBody; // 0xA8
		private Rigidbody ballBody; // 0xB0
		private Vector3 ballStartPos; // 0xB8
		private float spinUpTime; // 0xC4
		private float spinUpForce; // 0xC8
		private float spinFreeTime; // 0xCC
		private float spinDownTime; // 0xD0
		private float spinDownForce; // 0xD4
		private float elapsedStepTime; // 0xD8
		private bool stepComplete; // 0xDC
		private int currentStep; // 0xE0
		private int targetColorId; // 0xE4
		private int enteredColorId; // 0xE8
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <PerformSpinUp>d__24 : IEnumerator<object> // TypeDefIndex: 15558
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RouletteController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <PerformSpinUp>d__24(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181F38290-0x0000000181F38360
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181F38360-0x0000000181F383B0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <SpinUp>d__25 : IEnumerator<object> // TypeDefIndex: 15559
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RouletteController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <SpinUp>d__25(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181F39DC0-0x0000000181F39F20
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181F39F20-0x0000000181F39F70
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <PerformSpinFree>d__26 : IEnumerator<object> // TypeDefIndex: 15560
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RouletteController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <PerformSpinFree>d__26(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181F38140-0x0000000181F38240
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181F38240-0x0000000181F38290
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <PerformSpinDown>d__27 : IEnumerator<object> // TypeDefIndex: 15561
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RouletteController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <PerformSpinDown>d__27(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181F38020-0x0000000181F380F0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181F380F0-0x0000000181F38140
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <SpinDown>d__28 : IEnumerator<object> // TypeDefIndex: 15562
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RouletteController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <SpinDown>d__28(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181F39C80-0x0000000181F39D70
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181F39D70-0x0000000181F39DC0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <FinishGame>d__29 : IEnumerator<object> // TypeDefIndex: 15563
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RouletteController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <FinishGame>d__29(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181717AE0-0x0000000181717BC0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181717BC0-0x0000000181717C10
		}
	
		// Constructors
		public RouletteController(); // 0x000000018170E810-0x000000018170E8B0
	
		// Methods
		public override void MStart(); // 0x000000018170E040-0x000000018170E070
		private void ResetGame(bool newGame); // 0x000000018170E410-0x000000018170E720
		public override void MUpdate(); // 0x000000018170E070-0x000000018170E2C0
		public void BallEnteredColor(int colorId); // 0x00000001810BB870-0x00000001810BB880
		internal override void Intro(); // 0x000000018170DFA0-0x000000018170E040
		private void DropBall(); // 0x000000018170DE10-0x000000018170DF40
		[IteratorStateMachine] // 0x0000000180117210-0x0000000180117260
		private IEnumerator PerformSpinUp(); // 0x000000018170E3A0-0x000000018170E410
		[IteratorStateMachine] // 0x0000000180117480-0x00000001801174D0
		private IEnumerator SpinUp(); // 0x000000018170E7A0-0x000000018170E810
		[IteratorStateMachine] // 0x00000001801177B0-0x0000000180117800
		private IEnumerator PerformSpinFree(); // 0x000000018170E330-0x000000018170E3A0
		[IteratorStateMachine] // 0x0000000180117AA0-0x0000000180117AF0
		private IEnumerator PerformSpinDown(); // 0x000000018170E2C0-0x000000018170E330
		[IteratorStateMachine] // 0x0000000180117C90-0x0000000180117CE0
		private IEnumerator SpinDown(); // 0x000000018170E730-0x000000018170E7A0
		[IteratorStateMachine] // 0x0000000180117E30-0x0000000180117E80
		private IEnumerator FinishGame(); // 0x000000018170DF40-0x000000018170DFA0
		internal override void ResultsDone(); // 0x000000018170E720-0x000000018170E730
	}
}
