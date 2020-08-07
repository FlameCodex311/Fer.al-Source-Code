/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using World_Challenge.Parlor_Game;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace World_Challenge.Parlor_Game.BallFall
{
	public class BallFallController : ParlorGame // TypeDefIndex: 14760
	{
		// Fields
		[Header] // 0x00000001801F9500-0x00000001801F9530
		public GameObject boardPrefab; // 0x80
		public GameObject ballPrefab; // 0x88
		public GameObject spawnerPrefab; // 0x90
		public CanvasGroup uiCanvasGroup; // 0x98
		public UnityEngine.UI.Text yellowCount; // 0xA0
		public UnityEngine.UI.Text redCount; // 0xA8
		public UnityEngine.UI.Text greenCount; // 0xB0
		public UnityEngine.UI.Text blueCount; // 0xB8
		private List<GameObject> balls; // 0xC0
		private GameObject spawner; // 0xC8
		private BallFallSpawnerController spawnerController; // 0xD0
		private Transform spawnLocator; // 0xD8
		private int numBalls; // 0xE0
		private int ballsUsed; // 0xE4
		private int ballsCounted; // 0xE8
		private TriggerColor targetColor; // 0xEC
		private Dictionary<TriggerColor, int> colorCount; // 0xF0
		private bool isBurstDropping; // 0xF8
		private float burstWaitTime; // 0xFC
		private float elapsedTime; // 0x100
		private float revealTime; // 0x104
	
		// Nested types
		public enum TriggerColor // TypeDefIndex: 14761
		{
			YELLOW = 0,
			RED = 1,
			GREEN = 2,
			BLUE = 3
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <BurstDrop>d__25 : IEnumerator<object> // TypeDefIndex: 14762
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public BallFallController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <BurstDrop>d__25(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E79B30-0x0000000180E79D20
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E79D20-0x0000000180E79D70
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <StartGame>d__27 : IEnumerator<object> // TypeDefIndex: 14763
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public BallFallController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <StartGame>d__27(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E82F90-0x0000000180E83180
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E83180-0x0000000180E831D0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <RevealUI>d__30 : IEnumerator<object> // TypeDefIndex: 14764
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public BallFallController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <RevealUI>d__30(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E80E90-0x0000000180E80F60
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E80F60-0x0000000180E80FB0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <FinishGame>d__31 : IEnumerator<object> // TypeDefIndex: 14765
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public BallFallController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <FinishGame>d__31(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E7B690-0x0000000180E7BDE0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E7BDE0-0x0000000180E7BE30
		}
	
		// Constructors
		public BallFallController(); // 0x0000000180E6A440-0x0000000180E6A4D0
	
		// Methods
		public override void MStart(); // 0x0000000180E69C70-0x0000000180E69CA0
		private void ResetGame(bool newGame); // 0x0000000180E69D20-0x0000000180E6A1B0
		public override void MUpdate(); // 0x0000000180E69CA0-0x0000000180E69D20
		internal override void Intro(); // 0x0000000180E69C00-0x0000000180E69C70
		internal override void ResultsDone(); // 0x0000000180E6A1B0-0x0000000180E6A1C0
		[IteratorStateMachine] // 0x00000001801F9620-0x00000001801F9670
		private IEnumerator BurstDrop(); // 0x0000000180E699F0-0x0000000180E69A50
		private void DropBall(); // 0x0000000180E69A50-0x0000000180E69BA0
		[IteratorStateMachine] // 0x00000001801F9800-0x00000001801F9850
		private IEnumerator StartGame(); // 0x0000000180E6A220-0x0000000180E6A280
		[IteratorStateMachine] // 0x00000001801F9B00-0x00000001801F9B50
		private IEnumerator RevealUI(); // 0x0000000180E6A1C0-0x0000000180E6A220
		[IteratorStateMachine] // 0x00000001801F9F30-0x00000001801F9F80
		private IEnumerator FinishGame(); // 0x0000000180E69BA0-0x0000000180E69C00
		public void BallEnteredTrigger(TriggerColor color); // 0x0000000180E69770-0x0000000180E699F0
		private void UpdateScoreUI(); // 0x0000000180E6A280-0x0000000180E6A440
	}
}
