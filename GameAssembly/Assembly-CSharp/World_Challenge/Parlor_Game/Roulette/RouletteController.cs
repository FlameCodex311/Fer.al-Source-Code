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

namespace World_Challenge.Parlor_Game.Roulette
{
	public class RouletteController : ParlorGame // TypeDefIndex: 14712
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
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <PerformSpinUp>d__24 : IEnumerator<object> // TypeDefIndex: 14713
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RouletteController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <PerformSpinUp>d__24(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000181984E80-0x0000000181984F90
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181984F90-0x0000000181984FE0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <SpinUp>d__25 : IEnumerator<object> // TypeDefIndex: 14714
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RouletteController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <SpinUp>d__25(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000181987170-0x00000001819872D0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001819872D0-0x0000000181987320
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <PerformSpinFree>d__26 : IEnumerator<object> // TypeDefIndex: 14715
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RouletteController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <PerformSpinFree>d__26(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000181984D30-0x0000000181984E30
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181984E30-0x0000000181984E80
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <PerformSpinDown>d__27 : IEnumerator<object> // TypeDefIndex: 14716
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RouletteController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <PerformSpinDown>d__27(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000181984BD0-0x0000000181984CE0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181984CE0-0x0000000181984D30
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <SpinDown>d__28 : IEnumerator<object> // TypeDefIndex: 14717
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RouletteController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <SpinDown>d__28(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000181987040-0x0000000181987120
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181987120-0x0000000181987170
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <FinishGame>d__29 : IEnumerator<object> // TypeDefIndex: 14718
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RouletteController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <FinishGame>d__29(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001819824C0-0x0000000181982580
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181982580-0x00000001819825D0
		}
	
		// Constructors
		public RouletteController(); // 0x000000018197F210-0x000000018197F250
	
		// Methods
		public override void MStart(); // 0x000000018197EAC0-0x000000018197EAF0
		private void ResetGame(bool newGame); // 0x000000018197EE20-0x000000018197F120
		public override void MUpdate(); // 0x000000018197EAF0-0x000000018197ED00
		public void BallEnteredColor(int colorId); // 0x00000001807C7A90-0x00000001807C7AA0
		internal override void Intro(); // 0x000000018197EA20-0x000000018197EAC0
		private void DropBall(); // 0x000000018197E890-0x000000018197E9C0
		[IteratorStateMachine] // 0x00000001801D4430-0x00000001801D4480
		private IEnumerator PerformSpinUp(); // 0x000000018197EDC0-0x000000018197EE20
		[IteratorStateMachine] // 0x00000001801D4790-0x00000001801D47E0
		private IEnumerator SpinUp(); // 0x000000018197F1B0-0x000000018197F210
		[IteratorStateMachine] // 0x00000001801D4AD0-0x00000001801D4B20
		private IEnumerator PerformSpinFree(); // 0x000000018197ED60-0x000000018197EDC0
		[IteratorStateMachine] // 0x00000001801D4E30-0x00000001801D4E80
		private IEnumerator PerformSpinDown(); // 0x000000018197ED00-0x000000018197ED60
		[IteratorStateMachine] // 0x00000001801D5150-0x00000001801D51A0
		private IEnumerator SpinDown(); // 0x000000018197F150-0x000000018197F1B0
		[IteratorStateMachine] // 0x00000001801D5340-0x00000001801D5390
		private IEnumerator FinishGame(); // 0x000000018197E9C0-0x000000018197EA20
		internal override void ResultsDone(); // 0x000000018197F120-0x000000018197F150
	}
}
