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

public class UI_LazyListItem_SeasonPassChallenges : UI_LazyListItem<ISeasonPassChallenge> // TypeDefIndex: 12122
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _descriptionText; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _rewardText; // 0x70
	[Header] // 0x00000001800EE7A0-0x00000001800EE7F0
	[SerializeField] // 0x00000001800EE7A0-0x00000001800EE7F0
	private WWImage _progressImage; // 0x78
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _groupComplete; // 0x80
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _progressText; // 0x88
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _progressColorIncomplete; // 0x90
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _progressColorComplete; // 0xA0

	// Constructors
	public UI_LazyListItem_SeasonPassChallenges(); // 0x0000000180E7AE90-0x0000000180E7AF00

	// Methods
	public override void Setup(Action<UI_LazyListItem<ISeasonPassChallenge>> inOnClicked, Action<UI_LazyListItem<ISeasonPassChallenge>> inOnSelected, ISeasonPassChallenge inData, UI_LazyItemList<ISeasonPassChallenge> inItemList); // 0x0000000180E7AAE0-0x0000000180E7AE90
}

