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

namespace World_Challenge.Parlor_Game.CeeLo
{
	public class CeeLoController : ParlorGame // TypeDefIndex: 14743
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
		public enum CeeLoStep // TypeDefIndex: 14744
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
	
		public enum DieValue // TypeDefIndex: 14745
		{
			ONE = 0,
			TWO = 1,
			THREE = 2,
			FOUR = 3,
			FIVE = 4,
			SIX = 5
		}
	
		private class PlayerState // TypeDefIndex: 14746
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
			public PlayerState(int maxRolls, bool isDealer); // 0x0000000180E719F0-0x0000000180E71A30
	
			// Methods
			public void RollComplete(int v1, int v2, int v3); // 0x0000000180E713F0-0x0000000180E714F0
			public void StartRolling(); // 0x0000000180E714F0-0x0000000180E715A0
			public void Update(); // 0x0000000180E715A0-0x0000000180E719F0
			public void Reset(bool saveScore = false /* Metadata: 0x007BAF2A */, bool complete = false /* Metadata: 0x007BAF2B */); // 0x0000000180E71390-0x0000000180E713F0
		}
	
		public class CeeLoScore // TypeDefIndex: 14747
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
			public CeeLoScore(int v1, int v2, int v3); // 0x0000000180E6C450-0x0000000180E6C4B0
	
			// Methods
			public void Update(int v1, int v2, int v3); // 0x0000000180E6C420-0x0000000180E6C450
			public int GetValue(); // 0x0000000180E6C140-0x0000000180E6C170
			public override string ToString(); // 0x0000000180E6C170-0x0000000180E6C420
			private void EvaluateRoll(); // 0x0000000180E6BF00-0x0000000180E6C140
			public static int CompareScores(CeeLoScore a, CeeLoScore b); // 0x0000000180E6BDC0-0x0000000180E6BF00
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <StartGame>d__29 : IEnumerator<object> // TypeDefIndex: 14748
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CeeLoController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <StartGame>d__29(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E831D0-0x0000000180E833E0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E833E0-0x0000000180E83430
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <RevealHUD>d__33 : IEnumerator<object> // TypeDefIndex: 14749
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CeeLoController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <RevealHUD>d__33(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E80D00-0x0000000180E80E40
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E80E40-0x0000000180E80E90
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <UpdateScore>d__36 : IEnumerator<object> // TypeDefIndex: 14750
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CeeLoController <>4__this; // 0x20
			public bool dealer; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <UpdateScore>d__36(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E83CF0-0x0000000180E84140
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E84140-0x0000000180E84190
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <AnimateScore_Dealer>d__37 : IEnumerator<object> // TypeDefIndex: 14751
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CeeLoController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <AnimateScore_Dealer>d__37(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E78180-0x0000000180E782B0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E782B0-0x0000000180E78300
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <AnimateScore_Player>d__38 : IEnumerator<object> // TypeDefIndex: 14752
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CeeLoController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <AnimateScore_Player>d__38(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E78300-0x0000000180E78430
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E78430-0x0000000180E78480
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <CompareRolls>d__42 : IEnumerator<object> // TypeDefIndex: 14753
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CeeLoController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <CompareRolls>d__42(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E7AB10-0x0000000180E7AEE0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E7AEE0-0x0000000180E7AF30
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <AnimateScoreCompare>d__43 : IEnumerator<object> // TypeDefIndex: 14754
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CeeLoController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <AnimateScoreCompare>d__43(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E77F80-0x0000000180E78130
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E78130-0x0000000180E78180
		}
	
		// Constructors
		public CeeLoController(); // 0x0000000180E6BD30-0x0000000180E6BDC0
	
		// Methods
		public override void MStart(); // 0x0000000180E6B2D0-0x0000000180E6B300
		private void ResetGame(bool newGame); // 0x0000000180E6B8A0-0x0000000180E6BBF0
		public override void MUpdate(); // 0x0000000180E6B300-0x0000000180E6B8A0
		internal override void Intro(); // 0x0000000180E6B260-0x0000000180E6B2D0
		internal override void ResultsDone(); // 0x0000000180E6BBF0-0x0000000180E6BC00
		[IteratorStateMachine] // 0x00000001801EAE20-0x00000001801EAE70
		private IEnumerator StartGame(); // 0x0000000180E6BC60-0x0000000180E6BCC0
		private void EndGame(); // 0x0000000180E6B210-0x0000000180E6B260
		[IteratorStateMachine] // 0x00000001801EB0C0-0x00000001801EB110
		private IEnumerator RevealHUD(); // 0x0000000180E6BC00-0x0000000180E6BC60
		[IteratorStateMachine] // 0x00000001801EB3F0-0x00000001801EB440
		private IEnumerator UpdateScore(bool dealer); // 0x0000000180E6BCC0-0x0000000180E6BD30
		[IteratorStateMachine] // 0x00000001801EB6C0-0x00000001801EB710
		private IEnumerator AnimateScore_Dealer(); // 0x0000000180E6B0F0-0x0000000180E6B150
		[IteratorStateMachine] // 0x00000001801EB9B0-0x00000001801EBA00
		private IEnumerator AnimateScore_Player(); // 0x0000000180E6B150-0x0000000180E6B1B0
		private void AdvanceStep(bool isValid = true /* Metadata: 0x007BAED4 */, bool isOut = false /* Metadata: 0x007BAED5 */); // 0x0000000180E6AF80-0x0000000180E6B090
		[IteratorStateMachine] // 0x00000001801EBCB0-0x00000001801EBD00
		private IEnumerator CompareRolls(); // 0x0000000180E6B1B0-0x0000000180E6B210
		[IteratorStateMachine] // 0x00000001801EC160-0x00000001801EC1B0
		private IEnumerator AnimateScoreCompare(); // 0x0000000180E6B090-0x0000000180E6B0F0
	}
}
