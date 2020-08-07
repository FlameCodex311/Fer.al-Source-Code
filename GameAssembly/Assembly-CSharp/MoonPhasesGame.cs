/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class MoonPhasesGame : ParlorGameBase // TypeDefIndex: 10710
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
	private bool _doReveal; // 0xEC
	private ParlorManager.EWinState _serverWinResults; // 0xF0

	// Properties
	internal int PlayerTurnIndex { get; set; } // 0x000000018082F960-0x000000018082F970 0x0000000180C0AE00-0x0000000180C0AE10
	internal int DealerTurnIndex { get; set; } // 0x0000000180556930-0x0000000180556940 0x0000000180556A20-0x0000000180556A30
	internal EgameState GameState { get; set; } // 0x00000001803D3ED0-0x00000001803D3EE0 0x00000001807C7A90-0x00000001807C7AA0
	private ParlorManager.EWinState ServerWinResults { get; set; } // 0x00000001804DE030-0x00000001804DE040 0x0000000180C0AE10-0x0000000180C0AE20

	// Nested types
	internal class Player // TypeDefIndex: 10711
	{
		// Fields
		private EHandType _handType; // 0x10
		internal List<MoonPhasesTile> currentHand; // 0x18
		internal List<MoonPhasesTile> playedTiles; // 0x20
		internal int score; // 0x28
		internal int tokenPositionIndex; // 0x2C

		// Properties
		internal EHandType HandType { get; set; } // 0x0000000180387590-0x0000000180387930 0x00000001803FEB70-0x00000001803FEB80

		// Nested types
		internal enum EHandType // TypeDefIndex: 10712
		{
			None = 0,
			HighVal = 1,
			Crescent = 2,
			Gibbous = 3,
			PartialFull = 4,
			Full = 5
		}

		// Constructors
		public Player(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void NewHand(); // 0x0000000180C12B00-0x0000000180C12B80
		internal void PlayTile(int inIndex); // 0x0000000180C12B80-0x0000000180C12C30
	}

	internal class Dealer : Player // TypeDefIndex: 10713
	{
		// Fields
		internal int dealerPlay; // 0x30

		// Constructors
		public Dealer(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void PlayTurn(); // 0x0000000180BFD930-0x0000000180BFDE10
	}

	internal enum EgameState // TypeDefIndex: 10714
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

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Load>d__35 : IEnumerator<object> // TypeDefIndex: 10715
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MoonPhasesGame <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Load>d__35(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180C14110-0x0000000180C14420
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180C14420-0x0000000180C14470
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <StartGame>d__37 : IEnumerator<object> // TypeDefIndex: 10716
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MoonPhasesGame <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <StartGame>d__37(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180C17030-0x0000000180C17110
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180C17110-0x0000000180C17160
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Reveal>d__44 : IEnumerator<object> // TypeDefIndex: 10717
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MoonPhasesGame <>4__this; // 0x20
		public string inResults; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Reveal>d__44(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180C168B0-0x0000000180C16A70
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180C16A70-0x0000000180C16AC0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <TallyScore>d__46 : IEnumerator<object> // TypeDefIndex: 10718
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MoonPhasesGame <>4__this; // 0x20
		private float <t>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <TallyScore>d__46(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180C17160-0x0000000180C17300
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180C17300-0x0000000180C17350
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <DealerRevealPlayedTile>d__49 : IEnumerator<object> // TypeDefIndex: 10719
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MoonPhasesGame <>4__this; // 0x20
		private float <t>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <DealerRevealPlayedTile>d__49(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180C135E0-0x0000000180C13A90
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180C13A90-0x0000000180C13AE0
	}

	// Constructors
	public MoonPhasesGame(); // 0x0000000180C0AD90-0x0000000180C0AE00

	// Methods
	private void Awake(); // 0x0000000180C08C00-0x0000000180C08C40
	private void Start(); // 0x0000000180C0A970-0x0000000180C0A9F0
	private void Update(); // 0x0000000180C0AD20-0x0000000180C0AD90
	[IteratorStateMachine] // 0x000000018025EF00-0x000000018025EF50
	internal override IEnumerator Load(int[] inAdditionalParameters); // 0x0000000180C09300-0x0000000180C09360
	internal override void Unload(); // 0x0000000180C0ABF0-0x0000000180C0AD20
	[IteratorStateMachine] // 0x000000018025F250-0x000000018025F2A0
	internal override IEnumerator StartGame(); // 0x0000000180C0A740-0x0000000180C0A7A0
	internal override void Replay(bool inDoubleUp = false /* Metadata: 0x0077BFFE */); // 0x0000000180C09400-0x0000000180C09580
	private void StartGameLoop(); // 0x0000000180C0A720-0x0000000180C0A740
	private void RequestDealTiles(); // 0x0000000180C09580-0x0000000180C09750
	internal void RequestScore(); // 0x0000000180C09750-0x0000000180C0A680
	internal override void GameResponse(ParlorGameCommand inParlorGameCommand); // 0x0000000180C08CA0-0x0000000180C08F90
	private void TieResponse(ParlorGameCommand parlorGameCommand); // 0x0000000180C0AA50-0x0000000180C0ABF0
	[IteratorStateMachine] // 0x000000018025F3F0-0x000000018025F440
	internal IEnumerator Reveal(string inResults); // 0x0000000180C0A680-0x0000000180C0A6F0
	internal override void MultiplierResponse(int inMultiplerResults); // 0x0000000180C09360-0x0000000180C09400
	[IteratorStateMachine] // 0x000000018025F5E0-0x000000018025F630
	private IEnumerator TallyScore(); // 0x0000000180C0A9F0-0x0000000180C0AA50
	private void StartTieBreaker(); // 0x0000000180C0A7A0-0x0000000180C0A970
	internal void RoundOver(); // 0x0000000180C0A6F0-0x0000000180C0A720
	[IteratorStateMachine] // 0x000000018025F950-0x000000018025F9A0
	internal IEnumerator DealerRevealPlayedTile(); // 0x0000000180C08C40-0x0000000180C08CA0
	private bool IsPossible(Player inPlayer, Player.EHandType inHandType); // 0x0000000180C08F90-0x0000000180C09300
	internal void AllTilesMoved(); // 0x0000000180C08930-0x0000000180C08C00
	[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
	[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
	private IEnumerator <>n__0(int[] inAdditionalParameters); // 0x00000001806A59D0-0x00000001806A59E0
	[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
	[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
	private IEnumerator <>n__1(); // 0x00000001806A59E0-0x00000001806A59F0
}

