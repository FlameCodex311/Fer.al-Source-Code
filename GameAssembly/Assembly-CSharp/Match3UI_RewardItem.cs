/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Match3UI_RewardItem : MonoBehaviour // TypeDefIndex: 13017
{
	// Fields
	public RawImage rewardIcon; // 0x20
	public GameObject rewardCountContainer; // 0x28
	public WWTextMeshProUGUI rewardCountText; // 0x30
	public WWTextMeshProUGUI rewardName; // 0x38

	// Constructors
	public Match3UI_RewardItem(); // 0x0000000180407560-0x0000000180407570

	// Methods
	private void OnDestroy(); // 0x00000001810ABB90-0x00000001810ABC40
	public void SetIcon(string inRewardItemId); // 0x00000001810ABC40-0x00000001810ABD50
	public void SetRewardCount(int inCount); // 0x00000001810ABD50-0x00000001810ABE30
	public void SetRewardName(string inLocalizedName); // 0x00000001810ABE30-0x00000001810ABEC0
}

