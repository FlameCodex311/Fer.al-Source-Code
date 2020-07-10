/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyListItem_SeasonPassTier : UI_LazyListItem<ISeasonPassTier> // TypeDefIndex: 12123
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _tierNumberText; // 0x68
	[Header] // 0x00000001800ECA20-0x00000001800ECA70
	[SerializeField] // 0x00000001800ECA20-0x00000001800ECA70
	private UI_ItemImage _rewardItemImage; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _rewardCountGroup; // 0x78
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _rewardCountText; // 0x80
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _rewardName; // 0x88
	[Header] // 0x00000001800ED250-0x00000001800ED2A0
	[SerializeField] // 0x00000001800ED250-0x00000001800ED2A0
	private GameObject _statusActiveGroup; // 0x90
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _statusCompleteGroup; // 0x98
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _statusCompleteUnearnedGroup; // 0xA0
	[Header] // 0x00000001800ED4E0-0x00000001800ED530
	[SerializeField] // 0x00000001800ED4E0-0x00000001800ED530
	private GameObject _freeGroup; // 0xA8
	[Header] // 0x00000001800EE7A0-0x00000001800EE7F0
	[SerializeField] // 0x00000001800EE7A0-0x00000001800EE7F0
	private WWTextMeshProUGUI _progressText; // 0xB0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _progressColorIncomplete; // 0xB8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _progressColorComplete; // 0xC8
	[Header] // 0x00000001800EFF80-0x00000001800EFFD0
	[SerializeField] // 0x00000001800EFF80-0x00000001800EFFD0
	private Transform _offsetTarget; // 0xD8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _maxYPos; // 0xE0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _minYPos; // 0xE4
	private LazyLayoutElement _layoutElement; // 0xE8
	private bool _visible; // 0xF0

	// Constructors
	public UI_LazyListItem_SeasonPassTier(); // 0x0000000180E7C230-0x0000000180E7C2A0

	// Methods
	public override void Setup(Action<UI_LazyListItem<ISeasonPassTier>> inOnClicked, Action<UI_LazyListItem<ISeasonPassTier>> inOnSelected, ISeasonPassTier inData, UI_LazyItemList<ISeasonPassTier> inItemList); // 0x0000000180E7B3C0-0x0000000180E7BB80
	public override void Refresh(); // 0x0000000180E7B110-0x0000000180E7B3C0
	protected override void Start(); // 0x0000000180E7BB80-0x0000000180E7BC60
	private void OnDestroy(); // 0x0000000180E7AF50-0x0000000180E7B020
	private void OnTierCompleted(SeasonPassTierCompletedMessage inMessage); // 0x0000000180E7B0B0-0x0000000180E7B110
	private void OnInventoryChanged(InventoryItemChangedEvent inMessage); // 0x0000000180E7B020-0x0000000180E7B0B0
	public override void MarkAsSelected(bool inIsSelected); // 0x00000001803581E0-0x00000001803581F0
	protected override void OnClicked(); // 0x0000000180E7AF00-0x0000000180E7AF50
	private void Update(); // 0x0000000180E7BC60-0x0000000180E7C230
}

