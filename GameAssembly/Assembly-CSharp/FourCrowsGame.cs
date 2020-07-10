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

public class FourCrowsGame : ParlorGameBase // TypeDefIndex: 13033
{
	// Fields
	public FourCrowsDeckManager deckManager; // 0xA8
	public FourCrowsUIManager uiManager; // 0xB0
	public float minMoveDistance; // 0xB8
	public float showWaitDeck; // 0xBC
	public float showWaitTree; // 0xC0
	public float treeGrowTime; // 0xC4
	public float revealWait; // 0xC8
	[Tooltip] // 0x00000001800C1560-0x00000001800C1590
	public float crowsFlyBranchBreaksDelay; // 0xCC
	[Tooltip] // 0x00000001800C1730-0x00000001800C1760
	public float treeBreakFXDelay; // 0xD0
	[Tooltip] // 0x00000001800C1950-0x00000001800C1980
	public float snapAfterCrackleAudioDelay; // 0xD4
	[Tooltip] // 0x00000001800C1B30-0x00000001800C1B60
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
	internal int PlayerTurnIndex { get; set; } // 0x0000000181110110-0x0000000181110120 0x0000000181110120-0x0000000181110130
	internal int DealerTurnIndex { get; set; } // 0x0000000180641680-0x0000000180641690 0x0000000180F7D930-0x0000000180F7D940
	internal EgameState GameState { get; set; } // 0x0000000180EA2380-0x0000000180EA2390 0x0000000180EA2180-0x0000000180EA2190

	// Nested types
	internal class Player // TypeDefIndex: 13034
	{
		// Fields
		internal List<FourCrowsCard> currentHand; // 0x10
		internal List<FourCrowsCard> playedCards; // 0x18

		// Constructors
		public Player(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void NewHand(); // 0x00000001810602D0-0x0000000181060350
		internal void PlayCard(int inIndex); // 0x0000000181060350-0x0000000181060400
	}

	internal class Dealer : Player // TypeDefIndex: 13035
	{
		// Fields
		internal int dealerPlay; // 0x20

		// Constructors
		public Dealer(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void PlayTurn(); // 0x000000018104FC10-0x000000018104FF00
	}

	internal enum EgameState // TypeDefIndex: 13036
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

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Load>d__45 : IEnumerator<object> // TypeDefIndex: 13037
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FourCrowsGame <>4__this; // 0x20
		public int[] inAdditionalParameters; // 0x28
		private float <t>5__2; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Load>d__45(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181113360-0x0000000181113C00
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181113C00-0x0000000181113C50
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <StartGame>d__47 : IEnumerator<object> // TypeDefIndex: 13038
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FourCrowsGame <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <StartGame>d__47(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001810658C0-0x00000001810659F0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001810659F0-0x0000000181065A40
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <BranchBreak>d__53 : IEnumerator<object> // TypeDefIndex: 13039
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FourCrowsGame <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <BranchBreak>d__53(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181110BF0-0x0000000181110FA0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181110FA0-0x0000000181110FF0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Reveal>d__54 : IEnumerator<object> // TypeDefIndex: 13040
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FourCrowsGame <>4__this; // 0x20
		public int inMultiplerResults; // 0x28
		private float <t>5__2; // 0x2C

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Reveal>d__54(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181114940-0x0000000181114DA0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181114DA0-0x0000000181114DF0
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 13041
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action <>9__56_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000181115590-0x00000001811155F0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <ResetTreeAndCrowsAndCardIndicators>b__56_0(); // 0x000000018110B340-0x000000018110B3B0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <DealerRevealPlayedCard>d__58 : IEnumerator<object> // TypeDefIndex: 13042
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FourCrowsGame <>4__this; // 0x20
		private float <t>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <DealerRevealPlayedCard>d__58(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001811117A0-0x0000000181111A30
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181111A30-0x0000000181111A80
	}

	// Constructors
	public FourCrowsGame(); // 0x0000000181110080-0x0000000181110110

	// Methods
	private void Awake(); // 0x000000018110E960-0x000000018110E9A0
	private void Start(); // 0x000000018110FB90-0x000000018110FCC0
	private void Update(); // 0x000000018110FDE0-0x0000000181110080
	internal Vector3 GetBoardClickPos(); // 0x000000018110EB70-0x000000018110EC80
	[IteratorStateMachine] // 0x00000001800C1C90-0x00000001800C1CE0
	internal override IEnumerator Load(int[] inAdditionalParameters); // 0x000000018110EC80-0x000000018110ECF0
	internal override void Unload(); // 0x000000018110FCC0-0x000000018110FDE0
	[IteratorStateMachine] // 0x00000001800C1EE0-0x00000001800C1F30
	internal override IEnumerator StartGame(); // 0x000000018110FB20-0x000000018110FB90
	internal override void Replay(bool inDoubleUp = false /* Metadata: 0x00783516 */); // 0x000000018110ED70-0x000000018110EE30
	private void StartGameLoop(); // 0x000000018110F9E0-0x000000018110FB20
	private void RequestDealCards(); // 0x000000018110EE30-0x000000018110EF60
	internal override void GameResponse(ParlorGameCommand inParlorGameCommand); // 0x000000018110EAA0-0x000000018110EB70
	private void DealerResponse(ParlorGameCommand parlorGameCommand); // 0x000000018110EA00-0x000000018110EA40
	[IteratorStateMachine] // 0x00000001800C2090-0x00000001800C20E0
	private IEnumerator BranchBreak(); // 0x000000018110E9A0-0x000000018110EA00
	[IteratorStateMachine] // 0x00000001800C2200-0x00000001800C2250
	internal IEnumerator Reveal(int inMultiplerResults); // 0x000000018110F1E0-0x000000018110F250
	internal override void MultiplierResponse(int inMultiplerResults); // 0x000000018110ECF0-0x000000018110ED70
	private void ResetTreeAndCrowsAndCardIndicators(); // 0x000000018110EF60-0x000000018110F1E0
	internal void RoundOver(); // 0x000000018110F250-0x000000018110F280
	[IteratorStateMachine] // 0x00000001800C2370-0x00000001800C23C0
	internal IEnumerator DealerRevealPlayedCard(); // 0x000000018110EA40-0x000000018110EAA0
	private void AfterCompare(); // 0x000000018110E760-0x000000018110E7E0
	private void ScoreCards(); // 0x000000018110F280-0x000000018110F960
	internal void ShowPlayerPlayIndicator(bool inShow); // 0x000000018110F960-0x000000018110F9E0
	internal void AllCardsMoved(); // 0x000000018110E7E0-0x000000018110E960
	[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
	[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
	private IEnumerator <>n__0(int[] inAdditionalParameters); // 0x00000001810BB6C0-0x00000001810BB6D0
	[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
	[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
	private IEnumerator <>n__1(); // 0x00000001810BB6D0-0x00000001810BB6E0
}

