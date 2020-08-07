/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class Match3UI_PuzzleGallery : MonoBehaviour // TypeDefIndex: 10674
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Match3UI_AchievementItem _achievementItemPrefab; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _achievementItemParent; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Match3UI_PuzzleImage _puzzleImage; // 0x30
	[Header] // 0x000000018024F4C0-0x000000018024F510
	[SerializeField] // 0x000000018024F4C0-0x000000018024F510
	private Transform _pieceTargetParent; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _pieceFxPrefab; // 0x40
	private List<Transform> _pieceTargets; // 0x48
	private Match3AchievementPuzzle _currentPuzzle; // 0x50
	private int _puzzleIndex; // 0x58
	private List<Match3UI_AchievementItem> _achievementItems; // 0x60

	// Properties
	private Match3AchievementRewardController RewardController { get; } // 0x00000001807E5EA0-0x00000001807E5F00 
	private List<Transform> PieceTargets { get; } // 0x00000001807E5C40-0x00000001807E5EA0 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass16_0 // TypeDefIndex: 10675
	{
		// Fields
		public Transform pieceFX; // 0x10

		// Constructors
		public <>c__DisplayClass16_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OnPuzzlePieceRedeem>b__0(); // 0x00000001807F0EB0-0x00000001807F0F30
	}

	// Constructors
	public Match3UI_PuzzleGallery(); // 0x00000001807E5BE0-0x00000001807E5C40

	// Methods
	public void Show(Match3AchievementPuzzle inPuzzle, int inPuzzleIndex); // 0x00000001807E5AF0-0x00000001807E5BE0
	public void Hide(); // 0x00000001807E51A0-0x00000001807E5240
	public void BtnClicked_Back(); // 0x00000001807E4EF0-0x00000001807E5010
	public void OnPuzzlePieceRedeem(int inPuzzleIndex, int inPieceIndex); // 0x00000001807E5240-0x00000001807E56F0
	private void Setup(Match3AchievementPuzzle inPuzzle, int inPuzzleIndex); // 0x00000001807E56F0-0x00000001807E5AF0
	private void CheckForPendingPrize(); // 0x00000001807E5010-0x00000001807E51A0
}

