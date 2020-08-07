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

public class CodeBreakerRewardUI : MonoBehaviour // TypeDefIndex: 10564
{
	// Fields
	public GameObject noRewardContainer; // 0x20
	public List<CodeBreakerReward> rewards; // 0x28
	private int _rewardCount; // 0x30

	// Nested types
	[Serializable]
	public class CodeBreakerReward // TypeDefIndex: 10565
	{
		// Fields
		public GameObject container; // 0x10
		public RawImage icon; // 0x18
		public GameObject countContainer; // 0x20
		public WWTextMeshProUGUI countText; // 0x28
		public WWTextMeshProUGUI itemName; // 0x30

		// Constructors
		public CodeBreakerReward(); // 0x0000000180373240-0x0000000180373250
	}

	// Constructors
	public CodeBreakerRewardUI(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	public void OnMinigamePrizeGiven(MinigamePrizeGiven inMessage); // 0x000000018052BB20-0x000000018052BB90
	private void SetReward(int inIndex, string inRewardDefId, int inCount); // 0x000000018052BB90-0x000000018052BE10
	public void ClearRewards(); // 0x000000018052B920-0x000000018052BB20
}

