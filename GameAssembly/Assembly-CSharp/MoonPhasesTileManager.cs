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

public class MoonPhasesTileManager : MonoBehaviour // TypeDefIndex: 10725
{
	// Fields
	public float dealMoveTime; // 0x20
	[Tooltip] // 0x0000000180267830-0x0000000180267860
	public float dealDelay; // 0x24
	public float dealerPlayTime; // 0x28
	public float dealerFlipTime; // 0x2C
	public float tileCompareTime; // 0x30
	public MoonPhasesTile tilePrefab; // 0x38
	public Transform dealPosition; // 0x40
	public Transform[] playerTilePositions; // 0x48
	public Transform[] dealerTilePositions; // 0x50
	public Transform[] playerPlayPositions; // 0x58
	public Transform[] dealerPlayPositions; // 0x60
	public float validSpotDistance; // 0x68
	public float tileDropTime; // 0x6C
	public float rotateTime; // 0x70
	public float dealerFlipRiseHeight; // 0x74
	internal MoonPhasesTile[] allTiles; // 0x78
	private int _numTilesInMotion; // 0x80
	private int[] _initialDealIndexes; // 0x88
	private List<int> _tileIndexes; // 0x90
	private MoonPhasesGame _game; // 0x98

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <MoveTile>d__31 : IEnumerator<object> // TypeDefIndex: 10726
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public bool inUseLocal; // 0x20
		public Transform inTrans; // 0x28
		public MoonPhasesTileManager <>4__this; // 0x30
		public Vector3 inEndPosition; // 0x38
		private Vector3 <startPos>5__2; // 0x44
		private float <t>5__3; // 0x50

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <MoveTile>d__31(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180C15230-0x0000000180C15540
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180C15540-0x0000000180C15590
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <RotateTile>d__32 : IEnumerator<object> // TypeDefIndex: 10727
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Transform inTrans; // 0x20
		public Vector3 inEndRotation; // 0x28
		public MoonPhasesTileManager <>4__this; // 0x38
		private Quaternion <startQ>5__2; // 0x40
		private Quaternion <endQ>5__3; // 0x50
		private float <t>5__4; // 0x60

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <RotateTile>d__32(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180C16DB0-0x0000000180C16FE0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180C16FE0-0x0000000180C17030
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <CollectAllTiles>d__39 : IEnumerator<object> // TypeDefIndex: 10728
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MoonPhasesTileManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <CollectAllTiles>d__39(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180C12D40-0x0000000180C13000
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180C13000-0x0000000180C13050
	}

	// Constructors
	public MoonPhasesTileManager(); // 0x0000000180C0FEE0-0x0000000180C0FF30

	// Methods
	internal void Init(); // 0x0000000180C0D060-0x0000000180C0D1F0
	internal string[] NotServerReadyRequestDeal(); // 0x0000000180C0E6B0-0x0000000180C0EB80
	internal void RequestDrawCard(bool inDraw); // 0x0000000180C0EF20-0x0000000180C0F110
	internal void DrawCardResponse(int inPlayerHit, int inDealerHit); // 0x0000000180C0BF60-0x0000000180C0C1C0
	internal string[] NotServerReadyGetTieTiles(); // 0x0000000180C0D290-0x0000000180C0E6B0
	internal void DealTilesResponse(ParlorGameCommand inParlorGameCommand); // 0x0000000180C0B9C0-0x0000000180C0BC50
	private string GetDealerFirstPlay(int[] inTileIndexes); // 0x0000000180C0C6E0-0x0000000180C0CDA0
	internal void DealHandCards(); // 0x0000000180C0B2E0-0x0000000180C0B4D0
	private bool DealerShouldHit(); // 0x0000000180C0BC50-0x0000000180C0BF60
	private void UpdateHandType(MoonPhasesGame.Player inPlayer); // 0x0000000180C0F710-0x0000000180C0FEE0
	internal void DealTie(int playerValue, int opponentValue); // 0x0000000180C0B4D0-0x0000000180C0B620
	[IteratorStateMachine] // 0x00000001802679A0-0x00000001802679F0
	private IEnumerator MoveTile(Transform inTrans, Vector3 inEndPosition, bool inUseLocal); // 0x0000000180C0D1F0-0x0000000180C0D290
	[IteratorStateMachine] // 0x0000000180267C40-0x0000000180267C90
	private IEnumerator RotateTile(Transform inTrans, Vector3 inEndRotation); // 0x0000000180C0F1F0-0x0000000180C0F280
	internal void DropTile(MoonPhasesTile inTile); // 0x0000000180C0C1C0-0x0000000180C0C6E0
	internal void PlayerPlayed(int inIndex); // 0x0000000180C0EB80-0x0000000180C0EF20
	private void SetPlayerHandType(); // 0x0000000180C0F280-0x0000000180C0F520
	internal void TileMoved(); // 0x0000000180C0F6E0-0x0000000180C0F710
	private MoonPhasesTile DealTile(bool inPlayerTile, int inDeckIndex, int inHandIndex, float inDelay); // 0x0000000180C0B620-0x0000000180C0B9C0
	internal void ReturnTile(MoonPhasesTile inTile); // 0x0000000180C0F110-0x0000000180C0F1F0
	[IteratorStateMachine] // 0x0000000180267D30-0x0000000180267D80
	internal IEnumerator CollectAllTiles(); // 0x0000000180C0B280-0x0000000180C0B2E0
	private void TieUpdateHandChq(MoonPhasesGame.Player inPlayer, int inTileValue); // 0x0000000180C0F520-0x0000000180C0F6E0
	private List<MoonPhasesTile> InitSuit(MoonPhasesTile.ETileType inTileType); // 0x0000000180C0CDA0-0x0000000180C0D060
	internal void Cleanup(); // 0x0000000180C0AE20-0x0000000180C0B280
}

