/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_CasualGameSlideshow : MonoBehaviour // TypeDefIndex: 13183
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _nextBtnText; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_TabGroup _tabGroup; // 0x28

	// Constructors
	public UI_CasualGameSlideshow(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	public void Show(int inStartIndex = 0 /* Metadata: 0x00783777 */); // 0x0000000180F1FE60-0x0000000180F1FFC0
	public void Hide(); // 0x0000000180F1FCB0-0x0000000180F1FD50
	public void BtnClicked_Next(); // 0x0000000180F1FBA0-0x0000000180F1FCB0
	private void OnPageSelected(int inCurrentPageIndex); // 0x0000000180F1FD50-0x0000000180F1FE60
}

