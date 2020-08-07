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

public class RunesResultsScreen : MonoBehaviour // TypeDefIndex: 10834
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
	public class RuneResultsGroup // TypeDefIndex: 10835
	{
		// Fields
		public ScrollRect scroll; // 0x10
		public RunesRewardItemUI rewardItem; // 0x18
		public GameObject noRewards; // 0x20
		[NonSerialized]
		public List<RunesRewardItemUI> itemList; // 0x28

		// Constructors
		public RuneResultsGroup(); // 0x0000000180373240-0x0000000180373250
	}

	// Constructors
	public RunesResultsScreen(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	public void SetupForGameProgress(); // 0x000000018073AE20-0x000000018073AFC0
	public void SetupForGameResults(); // 0x000000018073AFC0-0x000000018073B160
	public void SetScoreText(int inScore); // 0x000000018073AD80-0x000000018073AE20
	public void SetLikesText(int inLikes); // 0x000000018073A8D0-0x000000018073A970
	public void SetRewards(List<RunesReward> inReward); // 0x000000018073A970-0x000000018073AD80
	public void ClearResults(); // 0x000000018073A710-0x000000018073A8D0
}

