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

public class CodeBreakerRewardUI : MonoBehaviour // TypeDefIndex: 12899
{
	// Fields
	public GameObject noRewardContainer; // 0x20
	public List<CodeBreakerReward> rewards; // 0x28
	private int _rewardCount; // 0x30

	// Nested types
	[Serializable]
	public class CodeBreakerReward // TypeDefIndex: 12900
	{
		// Fields
		public GameObject container; // 0x10
		public RawImage icon; // 0x18
		public GameObject countContainer; // 0x20
		public WWTextMeshProUGUI countText; // 0x28
		public WWTextMeshProUGUI itemName; // 0x30

		// Constructors
		public CodeBreakerReward(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	// Constructors
	public CodeBreakerRewardUI(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Start(); // 0x00000001812735B0-0x0000000181273640
	private void OnDestroy(); // 0x0000000181273230-0x00000001812732C0
	private void OnMinigamePrizeGiven(MinigamePrizeGiven inMessage); // 0x00000001812732C0-0x0000000181273330
	private void SetReward(int inIndex, string inRewardDefId, int inCount); // 0x0000000181273330-0x00000001812735B0
	public void ClearRewards(); // 0x0000000181273030-0x0000000181273230
}

