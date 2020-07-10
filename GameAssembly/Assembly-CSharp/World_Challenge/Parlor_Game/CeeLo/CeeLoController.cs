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

namespace World_Challenge.Parlor_Game.CeeLo
{
	public class CeeLoController : ParlorGame // TypeDefIndex: 15588
	{
		// Fields
		public GameObject diceCannonPrefab; // 0x80
		public Transform playerCannonLocator; // 0x88
		public Transform dealerCannonLocator; // 0x90
		public int maxRollsPerPlayer; // 0x98
		public CanvasGroup hudCanvasGroup; // 0xA0
		public UnityEngine.UI.Text playerScoreText; // 0xA8
		public UnityEngine.UI.Text dealerScoreText; // 0xB0
		private bool updatingScore; // 0xB8
		private float scoreUpdateTime; // 0xBC
		private float elapsedScoreUpdateTime; // 0xC0
		private bool comparingRolls; // 0xC4
		private float scoreCompareTime; // 0xC8
		private float elapsedScoreCompareTime; // 0xCC
		private bool playerWon; // 0xD0
		private CeeLoStep currentStep; // 0xD4
		private PlayerState playerState; // 0xD8
		private PlayerState dealerState; // 0xE0
		private GameObject playerCannon; // 0xE8
		private GameObject dealerCannon; // 0xF0
		private int dealerScore; // 0xF8
		private int playerScore; // 0xFC
		private float revealTime; // 0x100
		private float elapsedRevealTime; // 0x104
		private Color startColor; // 0x108
		private Color endColor; // 0x118
		private UnityEngine.UI.Text winningText; // 0x128
		private UnityEngine.UI.Text losingText; // 0x130
	
		// Nested types
		public enum CeeLoStep // TypeDefIndex: 15589
		{
			PRE_GAME = 0,
			DEALER_PRE_ROLL = 1,
			DEALER_ROLL = 2,
			DEALER_ROLL_INVALID = 3,
			DEALER_ROLL_VALID = 4,
			DEALER_ROLL_OUT = 5,
			SHOW_DEALER_ROLL = 6,
			PLAYER_PRE_ROLL = 7,
			PLAYER_ROLL = 8,
			PLAYER_ROLL_VALID = 9,
			PLAYER_ROLL_INVALID = 10,
			PLAYER_ROLL_OUT = 11,
			SHOW_PLAYER_ROLL = 12,
			COMPARE_ROLL = 13,
			GAME_OVER = 14
		}
	
		public enum DieValue // TypeDefIndex: 15590
		{
			ONE = 0,
			TWO = 1,
			THREE = 2,
			FOUR = 3,
			FIVE = 4,
			SIX = 5
		}
	
		private class PlayerState // TypeDefIndex: 15591
		{
			// Fields
			public bool isDealer; // 0x10
			public bool isRolling; // 0x11
			public bool rolledOut; // 0x12
			public int numRolls; // 0x14
			public int maxRolls; // 0x18
			public CeeLoScore score; // 0x20
			public bool hasValidRoll; // 0x28
			public DiceCannonController cannonController; // 0x30
	
			// Constructors
			public PlayerState(int maxRolls, bool isDealer); // 0x000000018170CDA0-0x000000018170CDE0
	
			// Methods
			public void RollComplete(int v1, int v2, int v3); // 0x000000018170C780-0x000000018170C880
			public void StartRolling(); // 0x000000018170C880-0x000000018170C930
			public void Update(); // 0x000000018170C930-0x000000018170CDA0
			public void Reset(bool saveScore = false /* Metadata: 0x00784D2C */, bool complete = false /* Metadata: 0x00784D2D */); // 0x000000018170C720-0x000000018170C780
		}
	
		public class CeeLoScore // TypeDefIndex: 15592
		{
			// Fields
			public int v1; // 0x10
			public int v2; // 0x14
			public int v3; // 0x18
			public bool isValid; // 0x1C
			public bool isAutoWin; // 0x1D
			public bool isAutoLose; // 0x1E
			public bool isTriple; // 0x1F
			public bool rolledOut; // 0x20
			private int evaluatedScore; // 0x24
	
			// Constructors
			public CeeLoScore(int v1, int v2, int v3); // 0x0000000181707670-0x00000001817076D0
	
			// Methods
			public void Update(int v1, int v2, int v3); // 0x0000000181707640-0x0000000181707670
			public int GetValue(); // 0x0000000181707330-0x0000000181707360
			public override string ToString(); // 0x0000000181707360-0x0000000181707640
			private void EvaluateRoll(); // 0x00000001817070D0-0x0000000181707330
			public static int CompareScores(CeeLoScore a, CeeLoScore b); // 0x0000000181706F80-0x00000001817070D0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <StartGame>d__29 : IEnumerator<object> // TypeDefIndex: 15593
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CeeLoController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <StartGame>d__29(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001817205D0-0x00000001817207E0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001817207E0-0x0000000181720830
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <RevealHUD>d__33 : IEnumerator<object> // TypeDefIndex: 15594
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CeeLoController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <RevealHUD>d__33(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018171D980-0x000000018171DAC0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018171DAC0-0x000000018171DB10
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <UpdateScore>d__36 : IEnumerator<object> // TypeDefIndex: 15595
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CeeLoController <>4__this; // 0x20
			public bool dealer; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <UpdateScore>d__36(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181721130-0x0000000181721580
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181721580-0x00000001817215D0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <AnimateScore_Dealer>d__37 : IEnumerator<object> // TypeDefIndex: 15596
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CeeLoController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <AnimateScore_Dealer>d__37(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001817145C0-0x0000000181714700
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181714700-0x0000000181714750
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <AnimateScore_Player>d__38 : IEnumerator<object> // TypeDefIndex: 15597
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CeeLoController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <AnimateScore_Player>d__38(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181714750-0x0000000181714890
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181714890-0x00000001817148E0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <CompareRolls>d__42 : IEnumerator<object> // TypeDefIndex: 15598
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CeeLoController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <CompareRolls>d__42(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181717070-0x0000000181717320
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181717320-0x0000000181717370
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <AnimateScoreCompare>d__43 : IEnumerator<object> // TypeDefIndex: 15599
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CeeLoController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <AnimateScoreCompare>d__43(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001817143B0-0x0000000181714570
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181714570-0x00000001817145C0
		}
	
		// Constructors
		public CeeLoController(); // 0x0000000181706EF0-0x0000000181706F80
	
		// Methods
		public override void MStart(); // 0x0000000181706470-0x00000001817064A0
		private void ResetGame(bool newGame); // 0x0000000181706A50-0x0000000181706DB0
		public override void MUpdate(); // 0x00000001817064A0-0x0000000181706A50
		internal override void Intro(); // 0x0000000181706400-0x0000000181706470
		internal override void ResultsDone(); // 0x0000000181706DB0-0x0000000181706DC0
		[IteratorStateMachine] // 0x000000018012E790-0x000000018012E7E0
		private IEnumerator StartGame(); // 0x0000000181706E20-0x0000000181706E80
		private void EndGame(); // 0x00000001817063B0-0x0000000181706400
		[IteratorStateMachine] // 0x000000018012EA90-0x000000018012EAE0
		private IEnumerator RevealHUD(); // 0x0000000181706DC0-0x0000000181706E20
		[IteratorStateMachine] // 0x000000018012ED90-0x000000018012EDE0
		private IEnumerator UpdateScore(bool dealer); // 0x0000000181706E80-0x0000000181706EF0
		[IteratorStateMachine] // 0x000000018012F050-0x000000018012F0A0
		private IEnumerator AnimateScore_Dealer(); // 0x0000000181706290-0x00000001817062F0
		[IteratorStateMachine] // 0x000000018012F180-0x000000018012F1D0
		private IEnumerator AnimateScore_Player(); // 0x00000001817062F0-0x0000000181706350
		private void AdvanceStep(bool isValid = true /* Metadata: 0x00784CD6 */, bool isOut = false /* Metadata: 0x00784CD7 */); // 0x0000000181706120-0x0000000181706230
		[IteratorStateMachine] // 0x000000018012F340-0x000000018012F390
		private IEnumerator CompareRolls(); // 0x0000000181706350-0x00000001817063B0
		[IteratorStateMachine] // 0x000000018012F630-0x000000018012F680
		private IEnumerator AnimateScoreCompare(); // 0x0000000181706230-0x0000000181706290
	}
}
