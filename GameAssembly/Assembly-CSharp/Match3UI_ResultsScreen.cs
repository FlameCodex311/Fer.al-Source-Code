/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Match3UI_ResultsScreen : MonoBehaviour // TypeDefIndex: 13016
{
	// Fields
	public Match3UI_RewardItem rewardItem; // 0x20
	public WWTextMeshProUGUI scoreText; // 0x28
	public WWTextMeshProUGUI likesText; // 0x30
	public WWTextMeshProUGUI levelText; // 0x38
	public WWImage levelProgressFillbar; // 0x40
	public WWTextMeshProUGUI gameResultsText; // 0x48
	public WWTextMeshProUGUI gameProgressText; // 0x50
	public GameObject gameResultsButtons; // 0x58
	public GameObject gameProgressButtons; // 0x60
	private List<Match3UI_RewardItem> rewards; // 0x68

	// Constructors
	public Match3UI_ResultsScreen(); // 0x00000001810ABB30-0x00000001810ABB90

	// Methods
	public void Show(int inLevel, float inLevelProgress, int inScore, IReadOnlyDictionary<Match3Reward, int> inRewards, bool isGameProgress = false /* Metadata: 0x007834F0 */); // 0x00000001810AB820-0x00000001810ABB30
	public void Hide(); // 0x00000001810AB4A0-0x00000001810AB550
	private int SetupRewardsAndReturnLikes(IReadOnlyDictionary<Match3Reward, int> inRewards); // 0x00000001810AB550-0x00000001810AB820
	private Match3UI_RewardItem CreateRewardItem(Match3Reward inReward, int inCount); // 0x00000001810AB140-0x00000001810AB4A0
	private void ClearRewards(); // 0x00000001810AAFB0-0x00000001810AB140
	public void BtnClicked_Quit(); // 0x00000001810AAF30-0x00000001810AAFB0
	public void BtnClicked_PlayAgain(); // 0x00000001810AAE20-0x00000001810AAEA0
	public void BtnClicked_PuzzleGallery(); // 0x00000001810AAEA0-0x00000001810AAF30
	public void BtnClicked_Continue(); // 0x00000001810AAE10-0x00000001810AAE20
}

