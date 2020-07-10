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

public class UI_LazyListItem_CraftableItem_Shop : UI_LazyListItem<BaseDef> // TypeDefIndex: 12131
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _canvasGroup; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RawImage _iconImage; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _nameText; // 0x78
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _memberGroup; // 0x80
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_RarityBadge _rarityBadge; // 0x88
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_TimeRemainingBadge _timeRemainingBadge; // 0x90
	[Header] // 0x00000001800DA180-0x00000001800DA1D0
	[SerializeField] // 0x00000001800DA180-0x00000001800DA1D0
	private FeralAudioInfo _selectedAudioInfo; // 0x98
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo _deselectedAudioInfo; // 0xA0

	// Constructors
	public UI_LazyListItem_CraftableItem_Shop(); // 0x0000000180E73720-0x0000000180E73760

	// Methods
	private void OnEnable(); // 0x0000000180E73070-0x0000000180E730D0
	protected override void Start(); // 0x0000000180E73640-0x0000000180E73720
	private void OnDestroy(); // 0x0000000180E72FA0-0x0000000180E73070
	public override void Setup(Action<UI_LazyListItem<BaseDef>> inOnClicked, Action<UI_LazyListItem<BaseDef>> inOnSelected, BaseDef inData, UI_LazyItemList<BaseDef> inItemList); // 0x0000000180E73340-0x0000000180E73640
	public override void MarkAsSelected(bool inIsSelected); // 0x0000000180E72EF0-0x0000000180E72FA0
	private void RefreshCanBeCrafted(); // 0x0000000180E73210-0x0000000180E73340
	private void OnInventoryUpdated(InventoryListResponse inMessage); // 0x0000000180E73170-0x0000000180E73210
	private void OnInventoryItemsRemoved(InventoryListRemovedResponse inMessage); // 0x0000000180E730D0-0x0000000180E73170
}

