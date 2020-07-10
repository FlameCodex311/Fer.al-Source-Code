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

public class RunesRewardItemUI : MonoBehaviour // TypeDefIndex: 13171
{
	// Fields
	public RawImage rewardIcon; // 0x20
	public GameObject rewardCountContainer; // 0x28
	public WWTextMeshProUGUI rewardCountText; // 0x30
	public WWTextMeshProUGUI rewardName; // 0x38

	// Constructors
	public RunesRewardItemUI(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void OnDestroy(); // 0x0000000180E095E0-0x0000000180E09690
	public void SetIcon(string inRewardItemId); // 0x0000000180E09690-0x0000000180E097A0
	public void SetRewardCount(int inCount); // 0x0000000180E097A0-0x0000000180E09880
	public void SetRewardName(string inLocalizedName); // 0x0000000180E09880-0x0000000180E09910
}

