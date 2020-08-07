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

public class RunesRewardItemUI : MonoBehaviour // TypeDefIndex: 10836
{
	// Fields
	public RawImage rewardIcon; // 0x20
	public GameObject rewardCountContainer; // 0x28
	public WWTextMeshProUGUI rewardCountText; // 0x30
	public WWTextMeshProUGUI rewardName; // 0x38

	// Constructors
	public RunesRewardItemUI(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void OnDestroy(); // 0x000000018073B160-0x000000018073B210
	public void SetIcon(string inRewardItemId); // 0x000000018073B210-0x000000018073B320
	public void SetRewardCount(int inCount); // 0x000000018073B320-0x000000018073B400
	public void SetRewardName(string inLocalizedName); // 0x000000018073B400-0x000000018073B490
}

