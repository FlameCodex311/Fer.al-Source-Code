/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Match3UI_PuzzleItem : MonoBehaviour // TypeDefIndex: 13013
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _unreadCountGroup; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _unreadCountText; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _completeGroup; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Match3UI_PuzzleImage _puzzleImage; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _nameText; // 0x40
	private Match3AchievementPuzzle _puzzle; // 0x48
	private int _puzzleIndex; // 0x50

	// Properties
	private Match3AchievementRewardController RewardController { get; } // 0x00000001810AA4A0-0x00000001810AA500 

	// Constructors
	public Match3UI_PuzzleItem(); // 0x0000000180407560-0x0000000180407570

	// Methods
	public void Setup(Match3AchievementPuzzle inPuzzle, int inPuzzleIndex); // 0x00000001810AA170-0x00000001810AA4A0
	public void BtnClicked_OpenPuzzle(); // 0x00000001810A9F10-0x00000001810AA170
}

