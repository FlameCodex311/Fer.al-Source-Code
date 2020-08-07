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

public class Match3UI_RewardItem : MonoBehaviour // TypeDefIndex: 10682
{
	// Fields
	public RawImage rewardIcon; // 0x20
	public GameObject rewardCountContainer; // 0x28
	public WWTextMeshProUGUI rewardCountText; // 0x30
	public WWTextMeshProUGUI rewardName; // 0x38

	// Constructors
	public Match3UI_RewardItem(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void OnDestroy(); // 0x00000001807E82C0-0x00000001807E8370
	public void SetIcon(string inRewardItemId); // 0x00000001807E8370-0x00000001807E8480
	public void SetRewardCount(int inCount); // 0x00000001807E8480-0x00000001807E8560
	public void SetRewardName(string inLocalizedName); // 0x00000001807E8560-0x00000001807E85F0
}

