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

public class RunesResultsScreen : MonoBehaviour // TypeDefIndex: 13169
{
	// Fields
	public WWTextMeshProUGUI gameResultsLabel; // 0x20
	public WWTextMeshProUGUI gameProgressLabel; // 0x28
	public WWTextMeshProUGUI scoreText; // 0x30
	public WWTextMeshProUGUI likesText; // 0x38
	public RuneResultsGroup allResults; // 0x40
	public GameObject navigationBackground; // 0x48
	public GameObject navigationButtonsContainer; // 0x50

	// Nested types
	[Serializable]
	public class RuneResultsGroup // TypeDefIndex: 13170
	{
		// Fields
		public ScrollRect scroll; // 0x10
		public RunesRewardItemUI rewardItem; // 0x18
		public GameObject noRewards; // 0x20
		[NonSerialized]
		public List<RunesRewardItemUI> itemList; // 0x28

		// Constructors
		public RuneResultsGroup(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	// Constructors
	public RunesResultsScreen(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	public void SetupForGameProgress(); // 0x0000000180E09290-0x0000000180E09430
	public void SetupForGameResults(); // 0x0000000180E09430-0x0000000180E095D0
	public void SetScoreText(int inScore); // 0x0000000180E091F0-0x0000000180E09290
	public void SetLikesText(int inLikes); // 0x0000000180E08D20-0x0000000180E08DC0
	public void SetRewards(List<RunesReward> inReward); // 0x0000000180E08DC0-0x0000000180E091F0
	public void ClearResults(); // 0x0000000180E08B50-0x0000000180E08D20
}

