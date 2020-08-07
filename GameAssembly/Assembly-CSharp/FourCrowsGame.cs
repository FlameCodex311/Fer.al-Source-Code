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

public class FourCrowsGame : ParlorGameBase // TypeDefIndex: 10698
{
	// Fields
	public FourCrowsDeckManager deckManager; // 0xA8
	public FourCrowsUIManager uiManager; // 0xB0
	public float minMoveDistance; // 0xB8
	public float showWaitDeck; // 0xBC
	public float showWaitTree; // 0xC0
	public float treeGrowTime; // 0xC4
	public float revealWait; // 0xC8
	[Tooltip] // 0x0000000180258D20-0x0000000180258D50
	public float crowsFlyBranchBreaksDelay; // 0xCC
	[Tooltip] // 0x0000000180258F20-0x0000000180258F50
	public float treeBreakFXDelay; // 0xD0
	[Tooltip] // 0x0000000180259130-0x0000000180259160
	public float snapAfterCrackleAudioDelay; // 0xD4
	[Tooltip] // 0x0000000180259250-0x0000000180259280
	public float branchReattachAudioDeleay; // 0xD8
	public Animator treeAnimator; // 0xE0
	public FourCrowsCrow[] theCrows; // 0xE8
	public ParticleSystem treeBreakEffect; // 0xF0
	internal bool canClickCard; // 0xF8
	internal bool canPlay; // 0xF9
	internal bool skipCompare; // 0xFA
	internal int _playerTurnIndex; // 0xFC
	internal int _dealerTurnIndex; // 0x100
	internal static FourCrowsGame instance; // 0x00
	internal Dealer dealer; // 0x108
	internal Player player; // 0x110
	private EgameState _gameState; // 0x118
	private int _gameScore; // 0x11C
	private Vector3 _lastPosition; // 0x120
	private Plane _intersectPlane; // 0x12C
	private Ray _dragRay; // 0x13C
	private Camera _camera; // 0x158
	private bool _doReveal; // 0x160

	// Properties
	internal int PlayerTurnIndex { get; set; } // 0x00000001806A5EC0-0x00000001806A5ED0 0x00000001806A5ED0-0x00000001806A5F20
	internal int DealerTurnIndex { get; set; } // 0x000000018057C3B0-0x000000018057C3C0 0x000000018057C520-0x000000018057C530
	internal EgameState GameState { get; set; } // 0x00000001803B7C30-0x00000001803B7C40 0x00000001803B7A20-0x00000001803B7A30

	// Nested types
	internal class Player // TypeDefIndex: 10699
	{
		// Fields
		internal List<FourCrowsCard> currentHand; // 0x10
		internal List<FourCrowsCard> playedCards; // 0x18

		// Constructors
		public Player(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void NewHand(); // 0x0000000180687E20-0x0000000180687EA0
		internal void PlayCard(int inIndex); // 0x0000000180687EA0-0x0000000180687F50
	}

	internal class Dealer : Player // TypeDefIndex: 10700
	{
		// Fields
		internal int dealerPlay; // 0x20

		// Constructors
		public Dealer(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void PlayTurn(); // 0x000000018067A5B0-0x000000018067A880
	}

	internal enum EgameState // TypeDefIndex: 10701
	{
		Deal = 0,
		Collect = 1,
		Turn1_dealer = 2,
		Turn1_player = 3,
		Turn2_dealer = 4,
		Turn2_player = 5,
		Turn3_dealer = 6,
		Turn3_player = 7,
		Turn4_dealer = 8,
		Turn4_player = 9,
		Reveal = 10
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Load>d__45 : IEnumerator<object> // TypeDefIndex: 10702
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FourCrowsGame <>4__this; // 0x20
		public int[] inAdditionalParameters; // 0x28
		private float <t>5__2; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Load>d__45(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180689E50-0x000000018068A4D0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018068A4D0-0x000000018068C790
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <StartGame>d__47 : IEnumerator<object> // TypeDefIndex: 10703
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FourCrowsGame <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <StartGame>d__47(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018068DFA0-0x000000018068E0D0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018068E0D0-0x000000018068E120
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <BranchBreak>d__53 : IEnumerator<object> // TypeDefIndex: 10704
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FourCrowsGame <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <BranchBreak>d__53(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180688070-0x00000001806882F0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001806882F0-0x0000000180688340
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Reveal>d__54 : IEnumerator<object> // TypeDefIndex: 10705
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FourCrowsGame <>4__this; // 0x20
		public int inMultiplerResults; // 0x28
		private float <t>5__2; // 0x2C

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Reveal>d__54(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018068C790-0x000000018068CC20
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018068CC20-0x000000018068CC70
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 10706
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action <>9__56_0; // 0x08

		// Constructors
		static <>c(); // 0x000000018068EA30-0x000000018068EA90
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <ResetTreeAndCrowsAndCardIndicators>b__56_0(); // 0x000000018068E270-0x000000018068E280
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <DealerRevealPlayedCard>d__58 : IEnumerator<object> // TypeDefIndex: 10707
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FourCrowsGame <>4__this; // 0x20
		private float <t>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <DealerRevealPlayedCard>d__58(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180688340-0x0000000180688510
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180688510-0x0000000180688560
	}

	// Constructors
	public FourCrowsGame(); // 0x00000001806A5E30-0x00000001806A5EC0

	// Methods
	private void Awake(); // 0x00000001806A46B0-0x00000001806A46F0
	private void Start(); // 0x00000001806A58A0-0x00000001806A59D0
	private void Update(); // 0x00000001806A5B90-0x00000001806A5E30
	internal Vector3 GetBoardClickPos(); // 0x00000001806A48D0-0x00000001806A49E0
	[IteratorStateMachine] // 0x0000000180259510-0x0000000180259560
	internal override IEnumerator Load(int[] inAdditionalParameters); // 0x00000001806A49E0-0x00000001806A4A60
	internal override void Unload(); // 0x00000001806A59F0-0x00000001806A5B90
	[IteratorStateMachine] // 0x0000000180259720-0x0000000180259770
	internal override IEnumerator StartGame(); // 0x00000001806A5830-0x00000001806A58A0
	internal override void Replay(bool inDoubleUp = false /* Metadata: 0x0077BFD1 */); // 0x00000001806A4AE0-0x00000001806A4BA0
	private void StartGameLoop(); // 0x00000001806A5700-0x00000001806A5830
	private void RequestDealCards(); // 0x00000001806A4BA0-0x00000001806A4CC0
	internal override void GameResponse(ParlorGameCommand inParlorGameCommand); // 0x00000001806A4800-0x00000001806A48D0
	private void DealerResponse(ParlorGameCommand parlorGameCommand); // 0x00000001806A4760-0x00000001806A4790
	[IteratorStateMachine] // 0x0000000180259A30-0x0000000180259A80
	private IEnumerator BranchBreak(); // 0x00000001806A46F0-0x00000001806A4760
	[IteratorStateMachine] // 0x0000000180259C20-0x0000000180259C70
	internal IEnumerator Reveal(int inMultiplerResults); // 0x00000001806A4F30-0x00000001806A4FA0
	internal override void MultiplierResponse(int inMultiplerResults); // 0x00000001806A4A60-0x00000001806A4AE0
	private void ResetTreeAndCrowsAndCardIndicators(); // 0x00000001806A4CC0-0x00000001806A4F30
	internal void RoundOver(); // 0x00000001806A4FA0-0x00000001806A4FD0
	[IteratorStateMachine] // 0x0000000180259E50-0x0000000180259EA0
	internal IEnumerator DealerRevealPlayedCard(); // 0x00000001806A4790-0x00000001806A4800
	private void AfterCompare(); // 0x00000001806A4440-0x00000001806A44C0
	private void ScoreCards(); // 0x00000001806A4FD0-0x00000001806A5690
	internal void ShowPlayerPlayIndicator(bool inShow); // 0x00000001806A5690-0x00000001806A5700
	internal void AllCardsMoved(); // 0x00000001806A44C0-0x00000001806A46B0
	[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
	[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
	private IEnumerator <>n__0(int[] inAdditionalParameters); // 0x00000001806A59D0-0x00000001806A59E0
	[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
	[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
	private IEnumerator <>n__1(); // 0x00000001806A59E0-0x00000001806A59F0
}

