/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Match3UI_PuzzleGallery : MonoBehaviour // TypeDefIndex: 13009
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Match3UI_AchievementItem _achievementItemPrefab; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _achievementItemParent; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Match3UI_PuzzleImage _puzzleImage; // 0x30
	[Header] // 0x00000001800B62B0-0x00000001800B6300
	[SerializeField] // 0x00000001800B62B0-0x00000001800B6300
	private Transform _pieceTargetParent; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _pieceFxPrefab; // 0x40
	private List<Transform> _pieceTargets; // 0x48
	private Match3AchievementPuzzle _currentPuzzle; // 0x50
	private int _puzzleIndex; // 0x58
	private List<Match3UI_AchievementItem> _achievementItems; // 0x60

	// Properties
	private Match3AchievementRewardController RewardController { get; } // 0x00000001810A96C0-0x00000001810A9720 
	private List<Transform> PieceTargets { get; } // 0x00000001810A9460-0x00000001810A96C0 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass16_0 // TypeDefIndex: 13010
	{
		// Fields
		public Transform pieceFX; // 0x10

		// Constructors
		public <>c__DisplayClass16_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OnPuzzlePieceRedeem>b__0(); // 0x00000001810BD550-0x00000001810BD5D0
	}

	// Constructors
	public Match3UI_PuzzleGallery(); // 0x00000001810A9400-0x00000001810A9460

	// Methods
	public void Show(Match3AchievementPuzzle inPuzzle, int inPuzzleIndex); // 0x00000001810A9300-0x00000001810A9400
	public void Hide(); // 0x00000001810A8970-0x00000001810A8A10
	public void BtnClicked_Back(); // 0x00000001810A86B0-0x00000001810A87D0
	public void OnPuzzlePieceRedeem(int inPuzzleIndex, int inPieceIndex); // 0x00000001810A8A10-0x00000001810A8EE0
	private void Setup(Match3AchievementPuzzle inPuzzle, int inPuzzleIndex); // 0x00000001810A8EE0-0x00000001810A9300
	private void CheckForPendingPrize(); // 0x00000001810A87D0-0x00000001810A8970
}

