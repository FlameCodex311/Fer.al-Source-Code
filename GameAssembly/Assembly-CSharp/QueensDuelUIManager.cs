/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class QueensDuelUIManager : MonoBehaviour // TypeDefIndex: 10795
{
	// Fields
	public Canvas hudCanvas; // 0x20
	[Space] // 0x00000001801D3D10-0x00000001801D3D30
	public GameObject gameHUD; // 0x28
	public GameObject selectReRollScreen; // 0x30
	public GameObject attackScreen; // 0x38
	public QueensDuelUI_ColumnScore[] playerColumnScores; // 0x40
	public QueensDuelUI_ColumnScore[] opponentColumnScores; // 0x48
	public QueensDuelUI_ColumnScore[] diceKeepers; // 0x50
	public float columnScoreOffset; // 0x58
	private QueensDuelGame _game; // 0x60

	// Constructors
	public QueensDuelUIManager(); // 0x0000000180648A60-0x0000000180648AE0

	// Methods
	internal void Init(); // 0x0000000180647B70-0x0000000180648790
	internal void UpdateScores(bool inPlayer); // 0x0000000180648810-0x0000000180648A60
	internal void ShowHUD(bool inShow); // 0x00000001806487B0-0x00000001806487F0
	internal void ShowSelectReRoll(bool inShow); // 0x00000001806487F0-0x0000000180648810
	internal void ShowCompare(bool inShow); // 0x0000000180648790-0x00000001806487B0
	public void BtnClicked_SelectReRoll(); // 0x0000000180647B30-0x0000000180647B70
	public void BtnClicked_Attack(); // 0x0000000180647AB0-0x0000000180647B30
}

