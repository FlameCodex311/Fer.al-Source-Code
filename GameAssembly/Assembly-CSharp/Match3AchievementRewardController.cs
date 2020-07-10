/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityAtoms;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Match3AchievementRewardController : MonoBehaviour // TypeDefIndex: 12940
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CachedUserVar _puzzleRedemptionStatusUserVar; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CachedUserVar _puzzlePieceRedemptionStatusUserVar; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private IntIntEvent _puzzlePieceRedeemedEvent; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private IntEvent _puzzleRedeemedEvent; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Match3PuzzleCollectionVariable _puzzleCollection; // 0x40
	private const int PUZZLE_PRIZE_LIST_INDEX = 1; // Metadata: 0x0078334F

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass13_0 // TypeDefIndex: 12941
	{
		// Fields
		public MinigamePrizeGiven inMessage; // 0x10

		// Constructors
		public <>c__DisplayClass13_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OnMinigamePrizeGiven>b__0(); // 0x00000001811F6380-0x00000001811F6430
	}

	// Constructors
	public Match3AchievementRewardController(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	public int GetAvailablePuzzlePieces(int inPuzzleIndex = -1 /* Metadata: 0x0078334B */); // 0x00000001811EF3E0-0x00000001811EF5C0
	public bool GetPuzzleRedemptionStatus(int inPuzzleIndex); // 0x00000001811EF5F0-0x00000001811EF620
	public bool GetPuzzlePieceRedemptionStatus(int inPuzzleIndex, int inPieceIndex); // 0x00000001811EF5C0-0x00000001811EF5F0
	public void RedeemPuzzlePiece(int inPuzzleIndex, int inPieceIndex); // 0x00000001811EF790-0x00000001811EF980
	private void Start(); // 0x00000001811EFA50-0x00000001811EFAE0
	private void OnDestroy(); // 0x00000001811EF620-0x00000001811EF6B0
	public void RedeemPuzzle(int inPuzzleIndex); // 0x00000001811EF980-0x00000001811EFA50
	private void OnMinigamePrizeGiven(MinigamePrizeGiven inMessage); // 0x00000001811EF6B0-0x00000001811EF790
}

