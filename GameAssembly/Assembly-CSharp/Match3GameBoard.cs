/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using UnityAtoms;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class Match3GameBoard : MonoBehaviour // TypeDefIndex: 10622
{
	// Fields
	public Match3Grid grid; // 0x20
	public Match3GridCamera gridCamera; // 0x28
	public Match3GridMask gridMask; // 0x30
	public Match3Tile tilePrefab; // 0x38
	public float tileSwapSpeed; // 0x40
	public float tileDropSpeed; // 0x44
	public float dropDelayBetweenTiles; // 0x48
	[Header] // 0x0000000180234B50-0x0000000180234B80
	public List<Match3TileType> tileTypes; // 0x50
	public List<Match3TileType> spawnTiles; // 0x58
	public Match3TileType colorBombTileType; // 0x60
	public List<Match3TileType> specialOrderTiles; // 0x68
	private List<GameBoardMove> _availableMoves; // 0x70
	private List<GameBoardMatch> _matches; // 0x78
	[Header] // 0x0000000180234D40-0x0000000180234D70
	public List<BoosterShapeData> boosteShapeList; // 0x80
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameBoardState <BoardState>k__BackingField; // 0x88
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameBoardMove? <CurrentMove>k__BackingField; // 0x90
	[Header] // 0x0000000180235050-0x0000000180235080
	public VoidEvent gameMoveCompleteEvent; // 0xC0
	public VoidEvent specialOrderTileRemoved; // 0xC8
	public VoidEvent boosterCombo_DoublePeacockEvent; // 0xD0
	public VoidEvent boosterCombo_PeacockTwinTroubleEvent; // 0xD8
	public VoidEvent boosterCombo_PeacockFlyerEvent; // 0xE0
	public VoidEvent boosterCombo_DoubleTwinTroubleEvent; // 0xE8
	public VoidEvent boosterCombo_TwinTroubleFlyerEvent; // 0xF0
	public VoidEvent boosterCombo_DoubleFlyerEvent; // 0xF8
	[Header] // 0x0000000180235320-0x0000000180235350
	public int baseMatch3Score; // 0x100
	public int baseBoosterTileRemoveScore; // 0x104
	public float baseBoosterMultiplier; // 0x108
	[Header] // 0x0000000180235530-0x0000000180235560
	public bool showHints; // 0x10C
	public bool autoPlay; // 0x10D
	[DeDisabled] // 0x00000001802357A0-0x00000001802357D0
	public int moveCount; // 0x110
	[DeDisabled] // 0x00000001802357A0-0x00000001802357D0
	public int turnMatchCount; // 0x114
	[DeDisabled] // 0x00000001802357A0-0x00000001802357D0
	public int boosterChains; // 0x118
	[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
	public bool disabledMoveCountFlag; // 0x11C
	[DeButton] // 0x0000000180235F90-0x0000000180236040
	public Match3DebugUtils match3DebugUtils; // 0x120
	public ObscuredIntReference score; // 0x128
	private Queue<ValueTuple<Vector2Int, Match3Tile>> _activatedBoosters; // 0x130
	private List<Match3Cell> _boostersCreatedForMove; // 0x138
	private UnityEngine.Random.State _gameBoardRandomState; // 0x140
	private Guid _gameGUID; // 0x150
	private List<Match3Tile> _createdTiles; // 0x160
	private List<Match3Cell> _specialOrderCellsToRemove; // 0x168
	private int _droppedTileCount; // 0x170
	private List<int> _cachedRandomSpawnOrderList; // 0x178

	// Properties
	public GameBoardState BoardState { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803CCE20-0x00000001803CCE30 0x00000001803CCEB0-0x00000001803CCEC0
	public GameBoardMove? CurrentMove { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180503CD0-0x0000000180503D00 0x0000000180503D00-0x0000000180503D30

	// Nested types
	public enum GameBoardState // TypeDefIndex: 10623
	{
		Init = 0,
		Ready = 1,
		Swapping = 2,
		Matching = 3,
		Dropping = 4,
		Waiting = 5,
		Done = 6,
		OutOfMoves = 7
	}

	public struct GameBoardMove : IEquatable<GameBoardMove> // TypeDefIndex: 10624
	{
		// Fields
		public Match3Cell cell1; // 0x00
		public Match3Cell cell2; // 0x08
		private Match3TileType _cachedTileType1; // 0x10
		private Match3TileType _cachedTileType2; // 0x18
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <MoveCombinesBoosters>k__BackingField; // 0x20

		// Properties
		public bool MoveCombinesBoosters { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x000000018001B920-0x000000018001B930 0x000000018001B930-0x000000018001B960

		// Constructors
		public GameBoardMove(Match3Cell inCell1, Match3Cell inCell2); // 0x000000018001B8C0-0x000000018001B920

		// Methods
		public bool CellPartOfMove(Match3Cell inCell); // 0x000000018001B670-0x000000018001B680
		public Match3TileType GetOtherTileTypeFromMove(Match3Cell inCell); // 0x000000018001B7D0-0x000000018001B8B0
		public Match3TileType GetTileTypeFromMove(Match3Cell inCell); // 0x000000018001B8B0-0x000000018001B8C0
		public override bool Equals(object obj); // 0x000000018001B6C0-0x000000018001B770
		public bool Equals(GameBoardMove move); // 0x000000018001B680-0x000000018001B6C0
		public override int GetHashCode(); // 0x000000018001B770-0x000000018001B7D0
		public static bool operator ==(GameBoardMove lhs, GameBoardMove rhs); // 0x00000001807DBA50-0x00000001807DBA90
		public static bool operator !=(GameBoardMove lhs, GameBoardMove rhs); // 0x00000001807DBA90-0x00000001807DBAD0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass70_0 // TypeDefIndex: 10625
	{
		// Fields
		public Match3Tile tile1; // 0x10
		public GameBoardMove inWrongMove; // 0x18
		public Match3GameBoard <>4__this; // 0x40
		public Match3Tile tile2; // 0x48

		// Constructors
		public <>c__DisplayClass70_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <DoWrongMove>b__0(Match3Cell cell, bool finished); // 0x00000001807F1180-0x00000001807F11D0
		internal void <DoWrongMove>b__1(Match3Cell cell, bool finished); // 0x00000001807F11D0-0x00000001807F1220
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass72_0 // TypeDefIndex: 10626
	{
		// Fields
		public GameBoardMove inMove; // 0x10

		// Constructors
		public <>c__DisplayClass72_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <WaitForMove>b__0(); // 0x00000001807F1280-0x00000001807F12E0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <WaitForMove>d__72 : IEnumerator<object> // TypeDefIndex: 10627
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public GameBoardMove inMove; // 0x20
		public Match3GameBoard <>4__this; // 0x48

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <WaitForMove>d__72(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807F1DE0-0x00000001807F1F20
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807F1F20-0x00000001807F1F70
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass73_0 // TypeDefIndex: 10628
	{
		// Fields
		public GameBoardMove inMove; // 0x10

		// Constructors
		public <>c__DisplayClass73_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <WaitCombineBoostersMove>b__0(); // 0x00000001807F12E0-0x00000001807F1310
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <WaitCombineBoostersMove>d__73 : IEnumerator<object> // TypeDefIndex: 10629
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public GameBoardMove inMove; // 0x20
		public Match3GameBoard <>4__this; // 0x48
		private <>c__DisplayClass73_0 <>8__1; // 0x50
		public BoosterType comboType; // 0x58

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <WaitCombineBoostersMove>d__73(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807F1890-0x00000001807F1C50
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807F1C50-0x00000001807F1CA0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <WaitForWrongMove>d__74 : IEnumerator<object> // TypeDefIndex: 10630
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Match3GameBoard <>4__this; // 0x20
		public float inWaitTime; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <WaitForWrongMove>d__74(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807F1F70-0x00000001807F2040
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807F2040-0x00000001807F2090
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RemoveCellsInMatch>d__79 : IAsyncStateMachine // TypeDefIndex: 10631
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
		public GameBoardMatch inMatch; // 0x18
		public Match3GameBoard <>4__this; // 0x20
		public bool inMatchShouldAttackNeighbors; // 0x28
		private string <logMatch>5__2; // 0x30
		private HashSet<Match3Cell> <>7__wrap2; // 0x38
		private Match3Cell <cell>5__4; // 0x50
		private UniTask<int> <>u__1; // 0x58

		// Methods
		private void MoveNext(); // 0x000000018001BB40-0x000000018001BB50
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002020-0x0000000180002030
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RemoveGameBoardMatches>d__80 : IAsyncStateMachine // TypeDefIndex: 10632
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
		public Match3GameBoard <>4__this; // 0x18
		private List<ValueTuple<Match3Cell, Match3Tile>> <newBoosters>5__2; // 0x20
		private bool <boostersActivated>5__3; // 0x28
		private float <timeWaited>5__4; // 0x2C
		private UniTask.Awaiter <>u__1; // 0x30
		private List<UniTask<ValueTuple<Match3Tile, Vector2Int>>> <boosterTasks>5__5; // 0x38
		private UniTask<int> <>u__2; // 0x40
		private UniTask<ValueTuple<Match3Tile, Vector2Int>[]> <>u__3; // 0x50

		// Methods
		private void MoveNext(); // 0x000000018001BB50-0x000000018001BB60
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002020-0x0000000180002030
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <OnFlyerColorBombCreated>d__83 : IEnumerator<object> // TypeDefIndex: 10633
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Match3GameBoard <>4__this; // 0x20
		public Match3TileType inTileType; // 0x28
		private int <flyerCreatedCount>5__2; // 0x30
		private List<Match3Cell> <>7__wrap2; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <OnFlyerColorBombCreated>d__83(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001807EE9B0-0x00000001807EEA50
		private bool MoveNext(); // 0x00000001807EE540-0x00000001807EE960
		private void <>m__Finally1(); // 0x00000001807EEA50-0x00000001807EEA90
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807EE960-0x00000001807EE9B0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <OnTwinTroubleColorBombCreated>d__84 : IEnumerator<object> // TypeDefIndex: 10634
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Match3GameBoard <>4__this; // 0x20
		public Match3TileType inTileType; // 0x28
		private List<Match3Cell> <>7__wrap1; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <OnTwinTroubleColorBombCreated>d__84(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001807EEE30-0x00000001807EEED0
		private bool MoveNext(); // 0x00000001807EEA90-0x00000001807EEDE0
		private void <>m__Finally1(); // 0x00000001807EEED0-0x00000001807EEF10
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807EEDE0-0x00000001807EEE30
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <HandleDoubleColorBomb>d__86 : IAsyncStateMachine // TypeDefIndex: 10635
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder<int> <>t__builder; // 0x08
		public Match3GameBoard <>4__this; // 0x20
		private int <tilesRemoved>5__2; // 0x28
		private int <y>5__3; // 0x2C
		private int <x>5__4; // 0x30
		private Match3Cell <cell>5__5; // 0x38
		private UniTask<int> <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x000000018001BA20-0x000000018001BA30
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018001BA30-0x000000018001BA80
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <HandleColorBomb>d__87 : IAsyncStateMachine // TypeDefIndex: 10636
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder<int> <>t__builder; // 0x08
		public Match3Tile inBoosterTile; // 0x20
		public Match3GameBoard <>4__this; // 0x28
		public Vector2Int inCellPos; // 0x30
		private int <tilesRemoved>5__2; // 0x38
		private Match3TileType <explosionType>5__3; // 0x40
		private int <y>5__4; // 0x48
		private int <x>5__5; // 0x4C
		private Match3Cell <cell>5__6; // 0x50
		private UniTask<int> <>u__1; // 0x58

		// Methods
		private void MoveNext(); // 0x000000018001B9C0-0x000000018001B9D0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018001B9D0-0x000000018001BA20
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <HandleTwinTrouble>d__89 : IAsyncStateMachine // TypeDefIndex: 10637
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder<int> <>t__builder; // 0x08
		public Match3GameBoard <>4__this; // 0x20
		public Vector2Int inCellPos; // 0x28
		public Match3Tile inBoosterTile; // 0x30
		public bool doLargeExplosion; // 0x38
		private int <tilesRemoved>5__2; // 0x3C
		private Match3Cell <twinCell>5__3; // 0x40
		private UniTask<int> <>u__1; // 0x48

		// Methods
		private void MoveNext(); // 0x000000018001BAE0-0x000000018001BAF0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018001BAF0-0x000000018001BB40
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <HandleFlyer>d__90 : IAsyncStateMachine // TypeDefIndex: 10638
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder<int> <>t__builder; // 0x08
		public Match3Tile inBoosterTile; // 0x20
		public Match3GameBoard <>4__this; // 0x28
		public Vector2Int inCellPos; // 0x30
		public BoosterType inBoosterType; // 0x38
		private int <tilesRemoved>5__2; // 0x3C
		private List<Match3Cell> <>7__wrap2; // 0x40
		private Match3Cell <cell>5__4; // 0x58
		private UniTask<int> <>u__1; // 0x60

		// Methods
		private void MoveNext(); // 0x000000018001BA80-0x000000018001BA90
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018001BA90-0x000000018001BAE0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <ActivateBoosterEffect>d__91 : IAsyncStateMachine // TypeDefIndex: 10639
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder<ValueTuple<Match3Tile, Vector2Int>> <>t__builder; // 0x08
		public Match3Tile inBoosterTile; // 0x28
		public Match3GameBoard <>4__this; // 0x30
		public Vector2Int inCellPos; // 0x38
		private Match3TileType <inBoosterTileType>5__2; // 0x40
		private Match3Tile <newBooster>5__3; // 0x48
		private int <tilesRemoved>5__4; // 0x50
		private int <>7__wrap4; // 0x54
		private UniTask<int> <>u__1; // 0x58
		private UniTask<int> <task1>5__6; // 0x68
		private UniTask<int> <task2>5__7; // 0x78
		[TupleElementNames] // 0x000000018023F310-0x000000018023F390
		private UniTask<ValueTuple<int, int>> <>u__2; // 0x88
		private UniTask<int> <task3>5__8; // 0x98
		private UniTask<int> <task4>5__9; // 0xA8
		private UniTask<int> <task5>5__10; // 0xB8
		private UniTask<int> <task6>5__11; // 0xC8
		[TupleElementNames] // 0x000000018023F680-0x000000018023F740
		private UniTask<ValueTuple<int, int, int, int, int, int>> <>u__3; // 0xD8

		// Methods
		private void MoveNext(); // 0x000000018001B960-0x000000018001B970
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018001B970-0x000000018001B9C0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <WaitForDroppedTiles>d__99 : IEnumerator<object> // TypeDefIndex: 10640
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Match3GameBoard <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <WaitForDroppedTiles>d__99(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807F1CA0-0x00000001807F1D90
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807F1D90-0x00000001807F1DE0
	}

	// Constructors
	public Match3GameBoard(); // 0x0000000180503BC0-0x0000000180503CD0

	// Methods
	private void Awake(); // 0x00000001804FBF20-0x00000001804FBFA0
	public void RestartGameBoard(); // 0x00000001805027F0-0x0000000180502830
	public void ReadyForNextMove(); // 0x00000001805020B0-0x0000000180502190
	public void OutOfMoves(); // 0x0000000180501F90-0x0000000180501FE0
	public void SaveBoardState(); // 0x0000000180502830-0x00000001805028D0
	public void UndoLastMove(); // 0x0000000180503770-0x00000001805037F0
	private void SetBoardState(GameBoardState inState); // 0x0000000180502FD0-0x00000001805031D0
	private void InitializeGameBoard(); // 0x00000001805015E0-0x0000000180501B60
	private void GetPossibleMoves(); // 0x0000000180500720-0x0000000180500BE0
	private bool EitherCellBoosted(Match3Cell inCell1, Match3Cell inCell2); // 0x00000001804FFBC0-0x00000001804FFC20
	private bool WillSwapMakeMatch(Match3Cell inCell1, Match3Cell inCell2); // 0x0000000180503AF0-0x0000000180503BC0
	private bool WillSwapMakeMatchIfType(Match3Cell inCell1, Match3TileType inCell1MatchType, Match3Cell inCell2); // 0x0000000180503A10-0x0000000180503AF0
	private void SwapCellTiles(Match3Cell cell1, Match3Cell cell2); // 0x0000000180503690-0x00000001805036C0
	public Match3Tile CreateTile(Match3TileType inType); // 0x00000001804FE110-0x00000001804FE1D0
	public void ResetBoard(); // 0x0000000180502690-0x00000001805027F0
	public void SetBoardFromTiles(List<Match3Tile> inTiles, int inMoveCount, UnityEngine.Random.State inRandomState); // 0x0000000180502D50-0x0000000180502FD0
	public void MoveCellTile(Match3Cell inCell, Vector2Int inDirection); // 0x0000000180501D00-0x0000000180501E80
	public bool CanActivateInPlace(Match3Cell inCell); // 0x00000001804FC050-0x00000001804FC180
	public void ActivateCellInPlace(Match3Cell inCell); // 0x00000001804FBD80-0x00000001804FBF20
	private BoosterType GetBoosterCombination(BoosterType inBoosterA, BoosterType inBoosterB); // 0x00000001805004C0-0x0000000180500560
	private void DoMoveInPlace(GameBoardMove inMove); // 0x00000001804FE1D0-0x00000001804FE620
	private void DoMove(GameBoardMove inMove); // 0x00000001804FE620-0x00000001804FECE0
	private void DoWrongMove(GameBoardMove inWrongMove); // 0x00000001804FECE0-0x00000001804FF280
	private bool CheckBoardForMatches(); // 0x00000001804FC740-0x00000001804FD6E0
	[IteratorStateMachine] // 0x0000000180236CF0-0x0000000180236D40
	private IEnumerator WaitForMove(GameBoardMove inMove); // 0x0000000180503900-0x0000000180503990
	[IteratorStateMachine] // 0x0000000180236FF0-0x0000000180237040
	private IEnumerator WaitCombineBoostersMove(GameBoardMove inMove, BoosterType comboType); // 0x00000001805037F0-0x0000000180503890
	[IteratorStateMachine] // 0x00000001802373A0-0x00000001802373F0
	private IEnumerator WaitForWrongMove(float inWaitTime); // 0x0000000180503990-0x0000000180503A10
	private bool FindMatch(Match3Cell inCell, Match3TileType inMatchType, List<Match3Cell> outMatchedCells, bool ignoreCellTileDistance = false /* Metadata: 0x0077BF64 */); // 0x00000001804FFC20-0x00000001804FFFC0
	private bool HasMatchIfType(Match3Cell inCell, Match3TileType inMatchType); // 0x00000001805014A0-0x00000001805015E0
	private bool CanMoveIfType(Match3Cell inCell, Match3TileType inMoveType); // 0x00000001804FC180-0x00000001804FC740
	private void GetFirstMatchingFromConnection(Match3Cell inCell, Match3TileType inMatchingType, Match3CellConnection inConnection, List<Match3Cell> outMatchedCells, bool ignoreCellTileDistance = false /* Metadata: 0x0077BF65 */); // 0x0000000180500560-0x0000000180500720
	[AsyncStateMachine] // 0x00000001802377B0-0x0000000180237800
	private UniTask RemoveCellsInMatch(GameBoardMatch inMatch, bool inMatchShouldAttackNeighbors); // 0x0000000180502190-0x0000000180502270
	[AsyncStateMachine] // 0x0000000180237B60-0x0000000180237BB0
	private UniTask RemoveGameBoardMatches(); // 0x0000000180502270-0x0000000180502320
	private Match3Cell FindNextBoosterPosition(Match3Cell inCell); // 0x00000001804FFFC0-0x0000000180500470
	private void QueueBoosterEffect(Vector2Int inCellPos, Match3Tile inBoosterTile); // 0x0000000180501FE0-0x00000001805020B0
	[IteratorStateMachine] // 0x0000000180237FA0-0x0000000180237FF0
	private IEnumerator OnFlyerColorBombCreated(Match3TileType inTileType); // 0x0000000180501E80-0x0000000180501F00
	[IteratorStateMachine] // 0x0000000180238260-0x00000001802382B0
	private IEnumerator OnTwinTroubleColorBombCreated(Match3TileType inTileType); // 0x0000000180501F10-0x0000000180501F90
	private bool BoosterCanRemoveTile(Match3Tile inTile); // 0x00000001804FBFA0-0x00000001804FC050
	[AsyncStateMachine] // 0x0000000180238650-0x00000001802386A0
	private UniTask<int> HandleDoubleColorBomb(Vector2Int inCellPos); // 0x0000000180501190-0x0000000180501280
	[AsyncStateMachine] // 0x0000000180238900-0x0000000180238950
	private UniTask<int> HandleColorBomb(Vector2Int inCellPos, Match3Tile inBoosterTile); // 0x0000000180501090-0x0000000180501190
	private Match3TileType GetTileTypeWithMostTilesOnBoard(); // 0x0000000180500D70-0x0000000180501090
	[AsyncStateMachine] // 0x0000000180238CF0-0x0000000180238D40
	private UniTask<int> HandleTwinTrouble(Vector2Int inCellPos, Match3Tile inBoosterTile, bool doLargeExplosion); // 0x0000000180501390-0x00000001805014A0
	[AsyncStateMachine] // 0x0000000180239070-0x00000001802390C0
	private UniTask<int> HandleFlyer(Vector2Int inCellPos, BoosterType inBoosterType, Match3Tile inBoosterTile); // 0x0000000180501280-0x0000000180501390
	[AsyncStateMachine] // 0x0000000180239400-0x0000000180239450
	private UniTask<ValueTuple<Match3Tile, Vector2Int>> ActivateBoosterEffect(Vector2Int inCellPos, Match3Tile inBoosterTile); // 0x00000001804FBC70-0x00000001804FBD80
	private void DropAndSpawnTiles(); // 0x00000001804FF280-0x00000001804FFBC0
	private void OnTileFinishedDrop(Match3Cell inCell, bool completed); // 0x0000000180501F00-0x0000000180501F10
	private void CheckForSpecialOrderTile(Match3Cell inCell); // 0x00000001804FD6E0-0x00000001804FD7C0
	private bool IsSpecialOrderTile(Match3TileType inTileType); // 0x0000000180501B60-0x0000000180501D00
	private bool RemoveSpecialOrderTiles(); // 0x0000000180502320-0x0000000180502690
	[IteratorStateMachine] // 0x00000001802396C0-0x0000000180239710
	private IEnumerator WaitForDroppedTiles(); // 0x0000000180503890-0x0000000180503900
	public int GetAvailableMoveCount(); // 0x0000000180500470-0x00000001805004C0
	private List<int> GetRandomSpawnOrder(); // 0x0000000180500BE0-0x0000000180500D70
	public void CreateEggTiles(int inEggCount); // 0x00000001804FDB20-0x00000001804FDE10
	public void CreateSpecialOrderTiles(int inCount); // 0x00000001804FDE10-0x00000001804FE110
	public void ScrambleTiles(); // 0x00000001805028D0-0x0000000180502D50
	private void ClearUntrackedTiles(); // 0x00000001804FD7C0-0x00000001804FDB20
	[DeMethodButton] // 0x00000001802399E0-0x0000000180239A60
	public void ShowHint(); // 0x00000001805031D0-0x0000000180503690
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <SetBoardState>b__54_0(); // 0x00000001805036C0-0x0000000180503760
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <WaitForDroppedTiles>b__99_0(); // 0x0000000180503760-0x0000000180503770
}

