/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Match3UI_RewardToast : MonoBehaviour // TypeDefIndex: 13018
{
	// Fields
	public WWTextMeshProUGUI rewardName; // 0x20
	public WWTextMeshProUGUI rewardCount; // 0x28
	public RawImage rewardIcon; // 0x30

	// Constructors
	public Match3UI_RewardToast(); // 0x0000000180407560-0x0000000180407570

	// Methods
	public void ShowToast(string inRewardDefId, int inCount); // 0x00000001810AC280-0x00000001810AC5A0
	private void OnDestroy(); // 0x00000001810ABEC0-0x00000001810ABF70
	private void SetIcon(string inRewardItemId); // 0x00000001810ABF70-0x00000001810AC080
	private void SetRewardCount(int inCount); // 0x00000001810AC080-0x00000001810AC1A0
	private void SetRewardName(string inRewardItemId); // 0x00000001810AC1A0-0x00000001810AC280
}

