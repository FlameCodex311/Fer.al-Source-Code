/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class QueensDuelUIManager : MonoBehaviour // TypeDefIndex: 13131
{
	// Fields
	public Canvas hudCanvas; // 0x20
	[Space] // 0x00000001800C6850-0x00000001800C6870
	public GameObject gameHUD; // 0x28
	public GameObject selectReRollScreen; // 0x30
	public GameObject attackScreen; // 0x38
	public QueensDuelUI_ColumnScore[] playerColumnScores; // 0x40
	public QueensDuelUI_ColumnScore[] opponentColumnScores; // 0x48
	public QueensDuelUI_ColumnScore[] diceKeepers; // 0x50
	public float columnScoreOffset; // 0x58
	private QueensDuelGame _game; // 0x60

	// Constructors
	public QueensDuelUIManager(); // 0x00000001815FFCE0-0x00000001815FFD60

	// Methods
	internal void Init(); // 0x00000001815FED30-0x00000001815FFA70
	internal void UpdateScores(bool inPlayer); // 0x00000001815FFAF0-0x00000001815FFCE0
	internal void ShowHUD(bool inShow); // 0x00000001815FFA90-0x00000001815FFAD0
	internal void ShowSelectReRoll(bool inShow); // 0x00000001815FFAD0-0x00000001815FFAF0
	internal void ShowCompare(bool inShow); // 0x00000001815FFA70-0x00000001815FFA90
	public void BtnClicked_SelectReRoll(); // 0x00000001815FEC70-0x00000001815FED30
	public void BtnClicked_Attack(); // 0x00000001815FEB90-0x00000001815FEC70
}

