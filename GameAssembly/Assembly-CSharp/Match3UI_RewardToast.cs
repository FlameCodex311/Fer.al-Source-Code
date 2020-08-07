/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class Match3UI_RewardToast : MonoBehaviour // TypeDefIndex: 10683
{
	// Fields
	public WWTextMeshProUGUI rewardName; // 0x20
	public WWTextMeshProUGUI rewardCount; // 0x28
	public RawImage rewardIcon; // 0x30

	// Constructors
	public Match3UI_RewardToast(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	public void ShowToast(string inRewardDefId, int inCount); // 0x00000001807E8A00-0x00000001807E8D10
	public void HideToast(); // 0x00000001807E86A0-0x00000001807E86E0
	private void OnDestroy(); // 0x00000001807E86E0-0x00000001807E86F0
	private void ClearIcon(); // 0x00000001807E85F0-0x00000001807E86A0
	private void SetIcon(string inRewardItemId); // 0x00000001807E86F0-0x00000001807E8800
	private void SetRewardCount(int inCount); // 0x00000001807E8800-0x00000001807E8920
	private void SetRewardName(string inRewardItemId); // 0x00000001807E8920-0x00000001807E8A00
}

