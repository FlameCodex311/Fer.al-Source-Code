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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace World_Challenge.Parlor_Game.BallFall
{
	public class BallFallController : ParlorGame // TypeDefIndex: 15605
	{
		// Fields
		[Header] // 0x0000000180138090-0x00000001801380C0
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
		public enum TriggerColor // TypeDefIndex: 15606
		{
			YELLOW = 0,
			RED = 1,
			GREEN = 2,
			BLUE = 3
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <BurstDrop>d__25 : IEnumerator<object> // TypeDefIndex: 15607
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public BallFallController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <BurstDrop>d__25(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181716030-0x0000000181716230
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181716230-0x0000000181716280
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <StartGame>d__27 : IEnumerator<object> // TypeDefIndex: 15608
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public BallFallController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <StartGame>d__27(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181720390-0x0000000181720580
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181720580-0x00000001817205D0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <RevealUI>d__30 : IEnumerator<object> // TypeDefIndex: 15609
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public BallFallController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <RevealUI>d__30(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018171DB10-0x000000018171DBE0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018171DBE0-0x000000018171DC30
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <FinishGame>d__31 : IEnumerator<object> // TypeDefIndex: 15610
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public BallFallController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <FinishGame>d__31(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181717C10-0x00000001817183B0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001817183B0-0x0000000181718400
		}
	
		// Constructors
		public BallFallController(); // 0x00000001817055C0-0x0000000181705650
	
		// Methods
		public override void MStart(); // 0x0000000181704DD0-0x0000000181704E00
		private void ResetGame(bool newGame); // 0x0000000181704E80-0x0000000181705320
		public override void MUpdate(); // 0x0000000181704E00-0x0000000181704E80
		internal override void Intro(); // 0x0000000181704D60-0x0000000181704DD0
		internal override void ResultsDone(); // 0x0000000181705320-0x0000000181705330
		[IteratorStateMachine] // 0x00000001801382F0-0x0000000180138340
		private IEnumerator BurstDrop(); // 0x0000000181704B40-0x0000000181704BA0
		private void DropBall(); // 0x0000000181704BA0-0x0000000181704D00
		[IteratorStateMachine] // 0x00000001801384B0-0x0000000180138500
		private IEnumerator StartGame(); // 0x0000000181705390-0x00000001817053F0
		[IteratorStateMachine] // 0x00000001801398C0-0x0000000180139910
		private IEnumerator RevealUI(); // 0x0000000181705330-0x0000000181705390
		[IteratorStateMachine] // 0x0000000180139B50-0x0000000180139BA0
		private IEnumerator FinishGame(); // 0x0000000181704D00-0x0000000181704D60
		public void BallEnteredTrigger(TriggerColor color); // 0x00000001817048C0-0x0000000181704B40
		private void UpdateScoreUI(); // 0x00000001817053F0-0x00000001817055C0
	}
}
