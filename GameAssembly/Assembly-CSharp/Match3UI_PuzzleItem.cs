/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class Match3UI_PuzzleItem : MonoBehaviour // TypeDefIndex: 10678
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _unreadCountGroup; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _unreadCountText; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _completeGroup; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Match3UI_PuzzleImage _puzzleImage; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _nameText; // 0x40
	private Match3AchievementPuzzle _puzzle; // 0x48
	private int _puzzleIndex; // 0x50

	// Properties
	private Match3AchievementRewardController RewardController { get; } // 0x00000001807E6C40-0x00000001807E6CA0 

	// Constructors
	public Match3UI_PuzzleItem(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	public void Setup(Match3AchievementPuzzle inPuzzle, int inPuzzleIndex); // 0x00000001807E6920-0x00000001807E6C40
	public void BtnClicked_OpenPuzzle(); // 0x00000001807E66D0-0x00000001807E6920
}

