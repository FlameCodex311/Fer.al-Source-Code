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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Match3GameBoard : MonoBehaviour // TypeDefIndex: 12957
{
	// Fields
	public Match3Grid grid; // 0x20
	public Match3GridCamera gridCamera; // 0x28
	public Match3GridMask gridMask; // 0x30
	public Match3Tile tilePrefab; // 0x38
	public float tileSwapSpeed; // 0x40
	public float tileDropSpeed; // 0x44
	public float dropDelayBetweenTiles; // 0x48
	[Header] // 0x00000001801578A0-0x00000001801578D0
	public List<Match3TileType> tileTypes; // 0x50
	public List<Match3TileType> spawnTiles; // 0x58
	public Match3TileType colorBombTileType; // 0x60
	public List<Match3TileType> specialOrderTiles; // 0x68
	private List<GameBoardMove> _availableMoves; // 0x70
	private List<GameBoardMatch> _matches; // 0x78
	[Header] // 0x0000000180157A90-0x0000000180157AC0
	public List<BoosterShapeData> boosteShapeList; // 0x80
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private GameBoardState <BoardState>k__BackingField; // 0x88
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private GameBoardMove? <CurrentMove>k__BackingField; // 0x90
	[Header] // 0x0000000180158150-0x0000000180158180
	public VoidEvent gameMoveCompleteEvent; // 0xC0
	public VoidEvent specialOrderTileRemoved; // 0xC8
	public VoidEvent boosterCombo_DoublePeacockEvent; // 0xD0
	public VoidEvent boosterCombo_PeacockTwinTroubleEvent; // 0xD8
	public VoidEvent boosterCombo_PeacockFlyerEvent; // 0xE0
	public VoidEvent boosterCombo_DoubleTwinTroubleEvent; // 0xE8
	public VoidEvent boosterCombo_TwinTroubleFlyerEvent; // 0xF0
	public VoidEvent boosterCombo_DoubleFlyerEvent; // 0xF8
	[Header] // 0x00000001801583D0-0x0000000180158400
	public int baseMatch3Score; // 0x100
	public int baseBoosterTileRemoveScore; // 0x104
	public float baseBoosterMultiplier; // 0x108
	[Header] // 0x0000000180158530-0x0000000180158560
	public bool showHints; // 0x10C
	public bool autoPlay; // 0x10D
	[DeDisabled] // 0x00000001801586D0-0x0000000180158700
	public int moveCount; // 0x110
	[DeDisabled] // 0x00000001801586D0-0x0000000180158700
	public int turnMatchCount; // 0x114
	[DeDisabled] // 0x00000001801586D0-0x0000000180158700
	public int boosterChains; // 0x118
	[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
	public bool disabledMoveCountFlag; // 0x11C
	[DeButton] // 0x0000000180158CF0-0x0000000180158DA0
	public Match3DebugUtils match3DebugUtils; // 0x120
	public ObscuredIntReference score; // 0x128
	private Queue<ValueTuple<Vector2Int, Match3Tile>> _activatedBoosters; // 0x130
	private List<Match3Cell> _boostersCreatedForMove; // 0x138
	private UnityEngine.Random.State _gameBoardRandomState; // 0x140
	private Guid _gameGUID; // 0x150
	private List<Match3Cell> _specialOrderCellsToRemove; // 0x160
	private int _droppedTileCount; // 0x168
	private List<int> _cachedRandomSpawnOrderList; // 0x170

	// Properties
	public GameBoardState BoardState { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018049D3B0-0x000000018049D3C0 0x000000018049D3C0-0x000000018049D3D0
	public GameBoardMove? CurrentMove { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001816CB0C0-0x00000001816CB0F0 0x00000001816CB0F0-0x00000001816CB120

	// Nested types
	public enum GameBoardState // TypeDefIndex: 12958
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

	public struct GameBoardMove : IEquatable<GameBoardMove> // TypeDefIndex: 12959
	{
		// Fields
		public Match3Cell cell1; // 0x00
		public Match3Cell cell2; // 0x08
		private Match3TileType _cachedTileType1; // 0x10
		private Match3TileType _cachedTileType2; // 0x18
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <MoveCombinesBoosters>k__BackingField; // 0x20

		// Properties
		public bool MoveCombinesBoosters { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180274F20-0x0000000180274F30 0x0000000180274F30-0x0000000180274F60

		// Constructors
		public GameBoardMove(Match3Cell inCell1, Match3Cell inCell2); // 0x0000000180274EE0-0x0000000180274F20

		// Methods
		public bool CellPartOfMove(Match3Cell inCell); // 0x0000000180274CF0-0x0000000180274D00
		public Match3TileType GetOtherTileTypeFromMove(Match3Cell inCell); // 0x0000000180274DF0-0x0000000180274ED0
		public Match3TileType GetTileTypeFromMove(Match3Cell inCell); // 0x0000000180274ED0-0x0000000180274EE0
		public override bool Equals(object obj); // 0x0000000180274D40-0x0000000180274DF0
		public bool Equals(GameBoardMove move); // 0x0000000180274D00-0x0000000180274D40
		public override int GetHashCode(); // 0x0000000180007D30-0x0000000180007DB0
		public static bool operator ==(GameBoardMove lhs, GameBoardMove rhs); // 0x00000001816BD500-0x00000001816BD540
		public static bool operator !=(GameBoardMove lhs, GameBoardMove rhs); // 0x00000001816BD540-0x00000001816BD580
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass69_0 // TypeDefIndex: 12960
	{
		// Fields
		public Match3Tile tile1; // 0x10
		public GameBoardMove inWrongMove; // 0x18
		public Match3GameBoard <>4__this; // 0x40
		public Match3Tile tile2; // 0x48

		// Constructors
		public <>c__DisplayClass69_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <DoWrongMove>b__0(Match3Cell cell, bool finished); // 0x00000001816D59D0-0x00000001816D5A20
		internal void <DoWrongMove>b__1(Match3Cell cell, bool finished); // 0x00000001816D5A20-0x00000001816D5A70
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass71_0 // TypeDefIndex: 12961
	{
		// Fields
		public GameBoardMove inMove; // 0x10

		// Constructors
		public <>c__DisplayClass71_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <WaitForMove>b__0(); // 0x00000001816D5A70-0x00000001816D5AD0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <WaitForMove>d__71 : IEnumerator<object> // TypeDefIndex: 12962
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public GameBoardMove inMove; // 0x20
		public Match3GameBoard <>4__this; // 0x48

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <WaitForMove>d__71(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001816D64A0-0x00000001816D6710
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001816D6710-0x00000001816D6760
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass72_0 // TypeDefIndex: 12963
	{
		// Fields
		public GameBoardMove inMove; // 0x10

		// Constructors
		public <>c__DisplayClass72_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <WaitCombineBoostersMove>b__0(); // 0x00000001816D5AD0-0x00000001816D5B00
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <WaitCombineBoostersMove>d__72 : IEnumerator<object> // TypeDefIndex: 12964
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public GameBoardMove inMove; // 0x20
		public Match3GameBoard <>4__this; // 0x48
		private <>c__DisplayClass72_0 <>8__1; // 0x50
		public BoosterType comboType; // 0x58

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <WaitCombineBoostersMove>d__72(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001816D5BF0-0x00000001816D61D0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001816D61D0-0x00000001816D6220
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <WaitForWrongMove>d__73 : IEnumerator<object> // TypeDefIndex: 12965
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Match3GameBoard <>4__this; // 0x20
		public float inWaitTime; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <WaitForWrongMove>d__73(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001816D6760-0x00000001816D6920
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001816D6920-0x00000001816D6970
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RemoveCellsInMatch>d__78 : IAsyncStateMachine // TypeDefIndex: 12966
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
		private void MoveNext(); // 0x0000000180275140-0x0000000180275150
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0500-0x00000001801F0510
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RemoveGameBoardMatches>d__79 : IAsyncStateMachine // TypeDefIndex: 12967
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
		private void MoveNext(); // 0x0000000180275150-0x000000018027F3E0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0500-0x00000001801F0510
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <OnFlyerColorBombCreated>d__82 : IEnumerator<object> // TypeDefIndex: 12968
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Match3GameBoard <>4__this; // 0x20
		public Match3TileType inTileType; // 0x28
		private int <flyerCreatedCount>5__2; // 0x30
		private List<Match3Cell> <>7__wrap2; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <OnFlyerColorBombCreated>d__82(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001816D3590-0x00000001816D3640
		private bool MoveNext(); // 0x00000001816D3100-0x00000001816D3540
		private void <>m__Finally1(); // 0x00000001816D3640-0x00000001816D3680
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001816D3540-0x00000001816D3590
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <OnTwinTroubleColorBombCreated>d__83 : IEnumerator<object> // TypeDefIndex: 12969
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Match3GameBoard <>4__this; // 0x20
		public Match3TileType inTileType; // 0x28
		private List<Match3Cell> <>7__wrap1; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <OnTwinTroubleColorBombCreated>d__83(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001816D3A30-0x00000001816D3AE0
		private bool MoveNext(); // 0x00000001816D3680-0x00000001816D39E0
		private void <>m__Finally1(); // 0x00000001816D3AE0-0x00000001816D56F0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001816D39E0-0x00000001816D3A30
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <HandleDoubleColorBomb>d__85 : IAsyncStateMachine // TypeDefIndex: 12970
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
		private void MoveNext(); // 0x0000000180275020-0x0000000180275030
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180275030-0x0000000180275080
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <HandleColorBomb>d__86 : IAsyncStateMachine // TypeDefIndex: 12971
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
		private void MoveNext(); // 0x0000000180274FC0-0x0000000180274FD0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180274FD0-0x0000000180275020
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <HandleTwinTrouble>d__88 : IAsyncStateMachine // TypeDefIndex: 12972
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
		private void MoveNext(); // 0x00000001802750E0-0x00000001802750F0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001802750F0-0x0000000180275140
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <HandleFlyer>d__89 : IAsyncStateMachine // TypeDefIndex: 12973
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
		private void MoveNext(); // 0x0000000180275080-0x0000000180275090
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180275090-0x00000001802750E0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <ActivateBoosterEffect>d__90 : IAsyncStateMachine // TypeDefIndex: 12974
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
		[TupleElementNames] // 0x0000000180162480-0x0000000180162500
		private UniTask<ValueTuple<int, int>> <>u__2; // 0x88
		private UniTask<int> <task3>5__8; // 0x98
		private UniTask<int> <task4>5__9; // 0xA8
		private UniTask<int> <task5>5__10; // 0xB8
		private UniTask<int> <task6>5__11; // 0xC8
		[TupleElementNames] // 0x00000001801629E0-0x0000000180162AA0
		private UniTask<ValueTuple<int, int, int, int, int, int>> <>u__3; // 0xD8

		// Methods
		private void MoveNext(); // 0x0000000180274F60-0x0000000180274F70
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180274F70-0x0000000180274FC0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <WaitForDroppedTiles>d__98 : IEnumerator<object> // TypeDefIndex: 12975
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Match3GameBoard <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <WaitForDroppedTiles>d__98(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001816D6220-0x00000001816D6450
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001816D6450-0x00000001816D64A0
	}

	// Constructors
	public Match3GameBoard(); // 0x00000001816CAFE0-0x00000001816CB0C0

	// Methods
	private void Awake(); // 0x00000001816C3000-0x00000001816C3080
	public void RestartGameBoard(); // 0x00000001816C9B20-0x00000001816C9B60
	public void ReadyForNextMove(); // 0x00000001816C90A0-0x00000001816C9170
	public void OutOfMoves(); // 0x00000001816C8F80-0x00000001816C8FD0
	public void SaveBoardState(); // 0x00000001816C9B60-0x00000001816C9CC0
	public void UndoLastMove(); // 0x00000001816CABC0-0x00000001816CAC40
	private void SetBoardState(GameBoardState inState); // 0x00000001816CA400-0x00000001816CA600
	private void InitializeGameBoard(); // 0x00000001816C8580-0x00000001816C8B10
	private void GetPossibleMoves(); // 0x00000001816C7610-0x00000001816C7B70
	private bool EitherCellBoosted(Match3Cell inCell1, Match3Cell inCell2); // 0x00000001816C6A90-0x00000001816C6AF0
	private bool WillSwapMakeMatch(Match3Cell inCell1, Match3Cell inCell2); // 0x00000001816CAF00-0x00000001816CAFE0
	private bool WillSwapMakeMatchIfType(Match3Cell inCell1, Match3TileType inCell1MatchType, Match3Cell inCell2); // 0x00000001816CAE20-0x00000001816CAF00
	private void SwapCellTiles(Match3Cell cell1, Match3Cell cell2); // 0x00000001816CAAD0-0x00000001816CAB10
	public Match3Tile CreateTile(Match3TileType inType); // 0x00000001816C4FB0-0x00000001816C5040
	public void ResetBoard(); // 0x00000001816C96D0-0x00000001816C9B20
	public void SetBoardFromTiles(List<Match3Tile> inTiles, int inMoveCount, UnityEngine.Random.State inRandomState); // 0x00000001816CA180-0x00000001816CA400
	public void MoveCellTile(Match3Cell inCell, Vector2Int inDirection); // 0x00000001816C8CC0-0x00000001816C8E90
	public bool CanActivateInPlace(Match3Cell inCell); // 0x00000001816C3130-0x00000001816C3270
	public void ActivateCellInPlace(Match3Cell inCell); // 0x00000001816C2E40-0x00000001816C3000
	private BoosterType GetBoosterCombination(BoosterType inBoosterA, BoosterType inBoosterB); // 0x00000001816C73B0-0x00000001816C7450
	private void DoMoveInPlace(GameBoardMove inMove); // 0x00000001816C5040-0x00000001816C5490
	private void DoMove(GameBoardMove inMove); // 0x00000001816C5490-0x00000001816C5B50
	private void DoWrongMove(GameBoardMove inWrongMove); // 0x00000001816C5B50-0x00000001816C6100
	private bool CheckBoardForMatches(); // 0x00000001816C3830-0x00000001816C4810
	[IteratorStateMachine] // 0x0000000180159800-0x0000000180159850
	private IEnumerator WaitForMove(GameBoardMove inMove); // 0x00000001816CAD30-0x00000001816CADB0
	[IteratorStateMachine] // 0x00000001801599B0-0x0000000180159A00
	private IEnumerator WaitCombineBoostersMove(GameBoardMove inMove, BoosterType comboType); // 0x00000001816CAC40-0x00000001816CACD0
	[IteratorStateMachine] // 0x0000000180159AD0-0x0000000180159B20
	private IEnumerator WaitForWrongMove(float inWaitTime); // 0x00000001816CADB0-0x00000001816CAE20
	private bool FindMatch(Match3Cell inCell, Match3TileType inMatchType, List<Match3Cell> outMatchedCells, bool ignoreCellTileDistance = false /* Metadata: 0x007834A9 */); // 0x00000001816C6AF0-0x00000001816C6EA0
	private bool HasMatchIfType(Match3Cell inCell, Match3TileType inMatchType); // 0x00000001816C8430-0x00000001816C8580
	private bool CanMoveIfType(Match3Cell inCell, Match3TileType inMoveType); // 0x00000001816C3270-0x00000001816C3830
	private void GetFirstMatchingFromConnection(Match3Cell inCell, Match3TileType inMatchingType, Match3CellConnection inConnection, List<Match3Cell> outMatchedCells, bool ignoreCellTileDistance = false /* Metadata: 0x007834AA */); // 0x00000001816C7450-0x00000001816C7610
	[AsyncStateMachine] // 0x0000000180159CB0-0x0000000180159D00
	private UniTask RemoveCellsInMatch(GameBoardMatch inMatch, bool inMatchShouldAttackNeighbors); // 0x00000001816C9170-0x00000001816C9250
	[AsyncStateMachine] // 0x0000000180159E70-0x0000000180159EC0
	private UniTask RemoveGameBoardMatches(); // 0x00000001816C9250-0x00000001816C9300
	private Match3Cell FindNextBoosterPosition(Match3Cell inCell); // 0x00000001816C6EA0-0x00000001816C7360
	private void QueueBoosterEffect(Vector2Int inCellPos, Match3Tile inBoosterTile); // 0x00000001816C8FD0-0x00000001816C90A0
	[IteratorStateMachine] // 0x000000018015A0A0-0x000000018015A0F0
	private IEnumerator OnFlyerColorBombCreated(Match3TileType inTileType); // 0x00000001816C8E90-0x00000001816C8F00
	[IteratorStateMachine] // 0x000000018015A450-0x000000018015A4A0
	private IEnumerator OnTwinTroubleColorBombCreated(Match3TileType inTileType); // 0x00000001816C8F10-0x00000001816C8F80
	private bool BoosterCanRemoveTile(Match3Tile inTile); // 0x00000001816C3080-0x00000001816C3130
	[AsyncStateMachine] // 0x000000018015A710-0x000000018015A760
	private UniTask<int> HandleDoubleColorBomb(Vector2Int inCellPos); // 0x00000001816C8120-0x00000001816C8210
	[AsyncStateMachine] // 0x000000018015A970-0x000000018015A9C0
	private UniTask<int> HandleColorBomb(Vector2Int inCellPos, Match3Tile inBoosterTile); // 0x00000001816C8020-0x00000001816C8120
	private Match3TileType GetTileTypeWithMostTilesOnBoard(); // 0x00000001816C7D00-0x00000001816C8020
	[AsyncStateMachine] // 0x000000018015ABA0-0x000000018015ABF0
	private UniTask<int> HandleTwinTrouble(Vector2Int inCellPos, Match3Tile inBoosterTile, bool doLargeExplosion); // 0x00000001816C8320-0x00000001816C8430
	[AsyncStateMachine] // 0x000000018015AD90-0x000000018015ADE0
	private UniTask<int> HandleFlyer(Vector2Int inCellPos, BoosterType inBoosterType, Match3Tile inBoosterTile); // 0x00000001816C8210-0x00000001816C8320
	[AsyncStateMachine] // 0x000000018015B060-0x000000018015B0B0
	private UniTask<ValueTuple<Match3Tile, Vector2Int>> ActivateBoosterEffect(Vector2Int inCellPos, Match3Tile inBoosterTile); // 0x00000001816C2D30-0x00000001816C2E40
	private void DropAndSpawnTiles(); // 0x00000001816C6100-0x00000001816C6A90
	private void OnTileFinishedDrop(Match3Cell inCell, bool completed); // 0x00000001816C8F00-0x00000001816C8F10
	private void CheckForSpecialOrderTile(Match3Cell inCell); // 0x00000001816C4810-0x00000001816C48F0
	private bool IsSpecialOrderTile(Match3TileType inTileType); // 0x00000001816C8B10-0x00000001816C8CC0
	private bool RemoveSpecialOrderTiles(); // 0x00000001816C9300-0x00000001816C96D0
	[IteratorStateMachine] // 0x000000018015B2F0-0x000000018015B340
	private IEnumerator WaitForDroppedTiles(); // 0x00000001816CACD0-0x00000001816CAD30
	public int GetAvailableMoveCount(); // 0x00000001816C7360-0x00000001816C73B0
	private List<int> GetRandomSpawnOrder(); // 0x00000001816C7B70-0x00000001816C7D00
	public void CreateEggTiles(int inEggCount); // 0x00000001816C48F0-0x00000001816C4C40
	public void CreateSpecialOrderTiles(int inCount); // 0x00000001816C4C40-0x00000001816C4FB0
	public void ScrambleTiles(); // 0x00000001816C9CC0-0x00000001816CA180
	[DeMethodButton] // 0x000000018015B760-0x000000018015B7E0
	public void ShowHint(); // 0x00000001816CA600-0x00000001816CAAD0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <SetBoardState>b__53_0(); // 0x00000001816CAB10-0x00000001816CABB0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <WaitForDroppedTiles>b__98_0(); // 0x00000001816CABB0-0x00000001816CABC0
}

