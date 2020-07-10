/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Match3UI_AchievementItem : MonoBehaviour // TypeDefIndex: 13006
{
	// Fields
	[Header] // 0x0000000180175660-0x00000001801756B0
	[SerializeField] // 0x0000000180175660-0x00000001801756B0
	private Graphic _checkMarkBg; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _bgColorIncomplete; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _bgColorComplete; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _checkMark; // 0x48
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _puzzlePiece; // 0x50
	[Header] // 0x00000001800B3FA0-0x00000001800B3FF0
	[SerializeField] // 0x00000001800B3FA0-0x00000001800B3FF0
	private WWTextMeshProUGUI _achievementText; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _textColorIncomplete; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _textColorComplete; // 0x70
	private int _puzzleIndex; // 0x80
	private int _puzzlePieceIndex; // 0x84

	// Properties
	public Transform PuzzlePiece { get; } // 0x00000001810A6D80-0x00000001810A6DA0 
	private Match3AchievementRewardController RewardController { get; } // 0x00000001810A6DA0-0x00000001810A6E00 

	// Constructors
	public Match3UI_AchievementItem(); // 0x00000001810A6D10-0x00000001810A6D80

	// Methods
	public void Setup(Match3Achievement inAchievement, int inPuzzleIndex, int inPuzzlePieceIndex); // 0x00000001810A6B00-0x00000001810A6D10
	public void BtnClicked_RedeemPuzzlePiece(); // 0x00000001810A6A10-0x00000001810A6B00
}

