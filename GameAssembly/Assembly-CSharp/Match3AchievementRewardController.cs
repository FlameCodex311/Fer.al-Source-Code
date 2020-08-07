/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityAtoms;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class Match3AchievementRewardController : MonoBehaviour // TypeDefIndex: 10605
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CachedUserVar _puzzleRedemptionStatusUserVar; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CachedUserVar _puzzlePieceRedemptionStatusUserVar; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private IntIntEvent _puzzlePieceRedeemedEvent; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private IntEvent _puzzleRedeemedEvent; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Match3PuzzleCollectionVariable _puzzleCollection; // 0x40
	private const int PUZZLE_PRIZE_LIST_INDEX = 1; // Metadata: 0x0077BE0A

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass13_0 // TypeDefIndex: 10606
	{
		// Fields
		public MinigamePrizeGiven inMessage; // 0x10

		// Constructors
		public <>c__DisplayClass13_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OnMinigamePrizeGiven>b__0(); // 0x0000000180509370-0x00000001805094C0
	}

	// Constructors
	public Match3AchievementRewardController(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	public int GetAvailablePuzzlePieces(int inPuzzleIndex = -1 /* Metadata: 0x0077BE06 */); // 0x00000001804F5EA0-0x00000001804F6070
	public bool GetPuzzleRedemptionStatus(int inPuzzleIndex); // 0x00000001804F60A0-0x00000001804F60D0
	public bool GetPuzzlePieceRedemptionStatus(int inPuzzleIndex, int inPieceIndex); // 0x00000001804F6070-0x00000001804F60A0
	public void RedeemPuzzlePiece(int inPuzzleIndex, int inPieceIndex); // 0x00000001804F6240-0x00000001804F6430
	private void Start(); // 0x00000001804F6500-0x00000001804F6590
	private void OnDestroy(); // 0x00000001804F60D0-0x00000001804F6160
	public void RedeemPuzzle(int inPuzzleIndex); // 0x00000001804F6430-0x00000001804F6500
	private void OnMinigamePrizeGiven(MinigamePrizeGiven inMessage); // 0x00000001804F6160-0x00000001804F6240
}

