/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class MoonPhasesGame : ParlorGameBase // TypeDefIndex: 13045
{
	// Fields
	public MoonPhasesTokenManager tokenManager; // 0xA8
	public MoonPhasesTileManager tileManager; // 0xB0
	public MoonPhasesUIManager uiManager; // 0xB8
	public float minMoveDistance; // 0xC0
	public float showWaitDeck; // 0xC4
	public float revealWait; // 0xC8
	internal bool canClickTile; // 0xCC
	internal bool canPlay; // 0xCD
	internal bool skipCompare; // 0xCE
	internal int _playerTurnIndex; // 0xD0
	internal int _dealerTurnIndex; // 0xD4
	internal static MoonPhasesGame instance; // 0x00
	internal Dealer dealer; // 0xD8
	internal Player player; // 0xE0
	private EgameState _gameState; // 0xE8
	private int _timesDoubledUp; // 0xEC
	private bool _doReveal; // 0xF0
	private ParlorManager.EWinState _serverWinResults; // 0xF4

	// Properties
	internal int PlayerTurnIndex { get; set; } // 0x00000001804241D0-0x00000001804241E0 0x00000001810BB880-0x00000001810BB890
	internal int DealerTurnIndex { get; set; } // 0x0000000180F44090-0x0000000180F440A0 0x0000000180F44170-0x0000000180F44180
	internal EgameState GameState { get; set; } // 0x0000000180EE4B70-0x0000000180EE4B80 0x00000001810BB870-0x00000001810BB880
	private ParlorManager.EWinState ServerWinResults { get; set; } // 0x0000000180E36620-0x0000000180E36630 0x0000000180E3A050-0x0000000180E3A060

	// Nested types
	internal class Player // TypeDefIndex: 13046
	{
		// Fields
		private EHandType _handType; // 0x10
		internal List<MoonPhasesTile> currentHand; // 0x18
		internal List<MoonPhasesTile> playedTiles; // 0x20
		internal int score; // 0x28
		internal int tokenPositionIndex; // 0x2C

		// Properties
		internal EHandType HandType { get; set; } // 0x000000018036CFF0-0x000000018036D000 0x000000018037AA40-0x000000018037AA50

		// Nested types
		internal enum EHandType // TypeDefIndex: 13047
		{
			None = 0,
			HighVal = 1,
			Crescent = 2,
			Gibbous = 3,
			PartialFull = 4,
			Full = 5
		}

		// Constructors
		public Player(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void NewHand(); // 0x00000001812EBAE0-0x00000001812EBB60
		internal void PlayTile(int inIndex); // 0x00000001812EBB60-0x00000001812EBC10
	}

	internal class Dealer : Player // TypeDefIndex: 13048
	{
		// Fields
		internal int dealerPlay; // 0x30

		// Constructors
		public Dealer(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void PlayTurn(); // 0x00000001812D7370-0x00000001812D7880
	}

	internal enum EgameState // TypeDefIndex: 13049
	{
		DealPlayedTiles = 0,
		DealHandTiles = 1,
		DrawTile = 2,
		Turn1_dealer = 3,
		Turn1_player = 4,
		Draw = 5,
		Reveal = 6,
		Collect = 7
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Load>d__36 : IEnumerator<object> // TypeDefIndex: 13050
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MoonPhasesGame <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Load>d__36(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001810BC8D0-0x00000001810BCA60
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001810BCA60-0x00000001810BCAB0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <StartGame>d__38 : IEnumerator<object> // TypeDefIndex: 13051
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MoonPhasesGame <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <StartGame>d__38(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812F1F40-0x00000001812F2010
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812F2010-0x00000001812F2060
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Reveal>d__45 : IEnumerator<object> // TypeDefIndex: 13052
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MoonPhasesGame <>4__this; // 0x20
		public string inResults; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Reveal>d__45(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812F0260-0x00000001812F03E0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812F03E0-0x00000001812F0430
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <TallyScore>d__47 : IEnumerator<object> // TypeDefIndex: 13053
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MoonPhasesGame <>4__this; // 0x20
		private float <t>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <TallyScore>d__47(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812F23A0-0x00000001812F2540
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812F2540-0x00000001812F2590
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <DealerRevealPlayedTile>d__50 : IEnumerator<object> // TypeDefIndex: 13054
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MoonPhasesGame <>4__this; // 0x20
		private float <t>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <DealerRevealPlayedTile>d__50(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001810BBA00-0x00000001810BBE60
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001810BBE60-0x00000001810BBEB0
	}

	// Constructors
	public MoonPhasesGame(); // 0x00000001810BB800-0x00000001810BB870

	// Methods
	private void Awake(); // 0x00000001810B9810-0x00000001810B9850
	private void Start(); // 0x00000001810BB560-0x00000001810BB5E0
	private void Update(); // 0x00000001810BB790-0x00000001810BB800
	[IteratorStateMachine] // 0x00000001800C8250-0x00000001800C82A0
	internal override IEnumerator Load(int[] inAdditionalParameters); // 0x00000001810B9E10-0x00000001810B9E70
	internal override void Unload(); // 0x00000001810BB6E0-0x00000001810BB790
	[IteratorStateMachine] // 0x00000001800C8690-0x00000001800C86E0
	internal override IEnumerator StartGame(); // 0x00000001810BB310-0x00000001810BB380
	internal override void Replay(bool inDoubleUp = false /* Metadata: 0x00783543 */); // 0x00000001810B9F60-0x00000001810BA050
	private void StartGameLoop(); // 0x00000001810BB2F0-0x00000001810BB310
	private void RequestDealTiles(); // 0x00000001810BA050-0x00000001810BA230
	internal void RequestScore(); // 0x00000001810BA230-0x00000001810BB240
	internal override void GameResponse(ParlorGameCommand inParlorGameCommand); // 0x00000001810B98B0-0x00000001810B9A80
	private void TieResponse(ParlorGameCommand parlorGameCommand); // 0x00000001810BB650-0x00000001810BB6C0
	[IteratorStateMachine] // 0x00000001800C89B0-0x00000001800C8A00
	internal IEnumerator Reveal(string inResults); // 0x00000001810BB240-0x00000001810BB2C0
	internal override void MultiplierResponse(int inMultiplerResults); // 0x00000001810B9E70-0x00000001810B9ED0
	[IteratorStateMachine] // 0x00000001800C8FD0-0x00000001800C9020
	private IEnumerator TallyScore(); // 0x00000001810BB5E0-0x00000001810BB650
	private void StartTieBreaker(); // 0x00000001810BB380-0x00000001810BB560
	internal void RoundOver(); // 0x00000001810BB2C0-0x00000001810BB2F0
	[IteratorStateMachine] // 0x00000001800C9280-0x00000001800C92D0
	internal IEnumerator DealerRevealPlayedTile(); // 0x00000001810B9850-0x00000001810B98B0
	private bool IsPossible(Player inPlayer, Player.EHandType inHandType); // 0x00000001810B9A80-0x00000001810B9E10
	internal void AllTilesMoved(); // 0x00000001810B9580-0x00000001810B9810
	internal override bool OverDoubleUpLimit(); // 0x00000001810B9ED0-0x00000001810B9F60
	[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
	[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
	private IEnumerator <>n__0(int[] inAdditionalParameters); // 0x00000001810BB6C0-0x00000001810BB6D0
	[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
	[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
	private IEnumerator <>n__1(); // 0x00000001810BB6D0-0x00000001810BB6E0
}

