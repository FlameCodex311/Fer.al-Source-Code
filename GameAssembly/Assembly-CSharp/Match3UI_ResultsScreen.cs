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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class Match3UI_ResultsScreen : MonoBehaviour // TypeDefIndex: 10681
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
	public Match3UI_ResultsScreen(); // 0x00000001807E8260-0x00000001807E82C0

	// Methods
	public void Show(int inLevel, float inLevelProgress, int inScore, IReadOnlyDictionary<Match3Reward, int> inRewards, bool isGameProgress = false /* Metadata: 0x0077BFAB */); // 0x00000001807E7F60-0x00000001807E8260
	public void Hide(); // 0x00000001807E7C00-0x00000001807E7CA0
	private int SetupRewardsAndReturnLikes(IReadOnlyDictionary<Match3Reward, int> inRewards); // 0x00000001807E7CA0-0x00000001807E7F60
	private Match3UI_RewardItem CreateRewardItem(Match3Reward inReward, int inCount); // 0x00000001807E78B0-0x00000001807E7C00
	private void ClearRewards(); // 0x00000001807E7730-0x00000001807E78B0
	public void BtnClicked_Quit(); // 0x00000001807E76B0-0x00000001807E7730
	public void BtnClicked_PlayAgain(); // 0x00000001807E75A0-0x00000001807E7620
	public void BtnClicked_PuzzleGallery(); // 0x00000001807E7620-0x00000001807E76B0
	public void BtnClicked_Continue(); // 0x00000001807E7590-0x00000001807E75A0
}

