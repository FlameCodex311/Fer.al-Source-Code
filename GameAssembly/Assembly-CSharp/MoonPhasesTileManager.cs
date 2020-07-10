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

public class MoonPhasesTileManager : MonoBehaviour // TypeDefIndex: 13060
{
	// Fields
	public float dealMoveTime; // 0x20
	[Tooltip] // 0x00000001800CFE10-0x00000001800CFE40
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
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <MoveTile>d__31 : IEnumerator<object> // TypeDefIndex: 13061
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <MoveTile>d__31(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812EE170-0x00000001812EE4A0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812EE4A0-0x00000001812EE4F0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <RotateTile>d__32 : IEnumerator<object> // TypeDefIndex: 13062
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <RotateTile>d__32(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812F0930-0x00000001812F0B60
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812F0B60-0x00000001812F0BB0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <CollectAllTiles>d__39 : IEnumerator<object> // TypeDefIndex: 13063
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MoonPhasesTileManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <CollectAllTiles>d__39(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812EC2C0-0x00000001812EC500
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812EC500-0x00000001812EC550
	}

	// Constructors
	public MoonPhasesTileManager(); // 0x00000001812DCC70-0x00000001812DCCC0

	// Methods
	internal void Init(); // 0x00000001812D9BD0-0x00000001812D9D70
	internal string[] NotServerReadyRequestDeal(); // 0x00000001812DB360-0x00000001812DB870
	internal void RequestDrawCard(bool inDraw); // 0x00000001812DBC00-0x00000001812DBE10
	internal void DrawCardResponse(int inPlayerHit, int inDealerHit); // 0x00000001812D8A90-0x00000001812D8D00
	internal string[] NotServerReadyGetTieTiles(); // 0x00000001812D9E10-0x00000001812DB360
	internal void DealTilesResponse(ParlorGameCommand inParlorGameCommand); // 0x00000001812D84B0-0x00000001812D8760
	private string GetDealerFirstPlay(int[] inTileIndexes); // 0x00000001812D91B0-0x00000001812D98F0
	internal void DealHandCards(); // 0x00000001812D7D70-0x00000001812D7F70
	private bool DealerShouldHit(); // 0x00000001812D8760-0x00000001812D8A90
	private void UpdateHandType(MoonPhasesGame.Player inPlayer); // 0x00000001812DC440-0x00000001812DCC70
	internal void DealTie(int playerValue, int opponentValue); // 0x00000001812D7F70-0x00000001812D80D0
	[IteratorStateMachine] // 0x00000001800D0370-0x00000001800D03C0
	private IEnumerator MoveTile(Transform inTrans, Vector3 inEndPosition, bool inUseLocal); // 0x00000001812D9D70-0x00000001812D9E10
	[IteratorStateMachine] // 0x00000001800D0610-0x00000001800D0660
	private IEnumerator RotateTile(Transform inTrans, Vector3 inEndRotation); // 0x00000001812DBEF0-0x00000001812DBF80
	internal void DropTile(MoonPhasesTile inTile); // 0x00000001812D8D00-0x00000001812D91B0
	internal void PlayerPlayed(int inIndex); // 0x00000001812DB870-0x00000001812DBC00
	private void SetPlayerHandType(); // 0x00000001812DBF80-0x00000001812DC250
	internal void TileMoved(); // 0x00000001812DC410-0x00000001812DC440
	private MoonPhasesTile DealTile(bool inPlayerTile, int inDeckIndex, int inHandIndex, float inDelay); // 0x00000001812D80D0-0x00000001812D84B0
	internal void ReturnTile(MoonPhasesTile inTile); // 0x00000001812DBE10-0x00000001812DBEF0
	[IteratorStateMachine] // 0x00000001800D09F0-0x00000001800D0A40
	internal IEnumerator CollectAllTiles(); // 0x00000001812D7D10-0x00000001812D7D70
	private void TieUpdateHandChq(MoonPhasesGame.Player inPlayer, int inTileValue); // 0x00000001812DC250-0x00000001812DC410
	private List<MoonPhasesTile> InitSuit(MoonPhasesTile.ETileType inTileType); // 0x00000001812D98F0-0x00000001812D9BD0
	internal void Cleanup(); // 0x00000001812D7880-0x00000001812D7D10
}

