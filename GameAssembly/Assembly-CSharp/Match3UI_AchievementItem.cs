/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class Match3UI_AchievementItem : MonoBehaviour // TypeDefIndex: 10671
{
	// Fields
	[Header] // 0x000000018024D4E0-0x000000018024D530
	[SerializeField] // 0x000000018024D4E0-0x000000018024D530
	private Graphic _checkMarkBg; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _bgColorIncomplete; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _bgColorComplete; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _checkMark; // 0x48
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _puzzlePiece; // 0x50
	[Header] // 0x000000018024E0E0-0x000000018024E130
	[SerializeField] // 0x000000018024E0E0-0x000000018024E130
	private WWTextMeshProUGUI _achievementText; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _textColorIncomplete; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _textColorComplete; // 0x70
	private int _puzzleIndex; // 0x80
	private int _puzzlePieceIndex; // 0x84

	// Properties
	public Transform PuzzlePiece { get; } // 0x00000001807E3630-0x00000001807E3650 
	private Match3AchievementRewardController RewardController { get; } // 0x00000001807E3650-0x00000001807E36B0 

	// Constructors
	public Match3UI_AchievementItem(); // 0x00000001807E35C0-0x00000001807E3630

	// Methods
	public void Setup(Match3Achievement inAchievement, int inPuzzleIndex, int inPuzzlePieceIndex); // 0x00000001807E33B0-0x00000001807E35C0
	public void BtnClicked_RedeemPuzzlePiece(); // 0x00000001807E32D0-0x00000001807E33B0
}

