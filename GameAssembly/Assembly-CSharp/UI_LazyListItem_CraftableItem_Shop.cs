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

public class UI_LazyListItem_CraftableItem_Shop : UI_LazyListItem<BaseDef> // TypeDefIndex: 13681
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _canvasGroup; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RawImage _iconImage; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _nameText; // 0x78
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _memberGroup; // 0x80
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_RarityBadge _rarityBadge; // 0x88
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_TimeRemainingBadge _timeRemainingBadge; // 0x90
	[Header] // 0x00000001801D2A20-0x00000001801D2A70
	[SerializeField] // 0x00000001801D2A20-0x00000001801D2A70
	private FeralAudioInfo _selectedAudioInfo; // 0x98
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo _deselectedAudioInfo; // 0xA0

	// Constructors
	public UI_LazyListItem_CraftableItem_Shop(); // 0x00000001803A5350-0x00000001803A5390

	// Methods
	private void OnEnable(); // 0x00000001803A4CB0-0x00000001803A4D10
	protected override void Start(); // 0x00000001803A5270-0x00000001803A5350
	private void OnDestroy(); // 0x00000001803A4BE0-0x00000001803A4CB0
	public override void Setup(Action<UI_LazyListItem<BaseDef>> inOnClicked, Action<UI_LazyListItem<BaseDef>> inOnSelected, BaseDef inData, UI_LazyItemList<BaseDef> inItemList); // 0x00000001803A4F80-0x00000001803A5270
	public override void MarkAsSelected(bool inIsSelected); // 0x00000001803A4B40-0x00000001803A4BE0
	private void RefreshCanBeCrafted(); // 0x00000001803A4E50-0x00000001803A4F80
	private void OnInventoryUpdated(InventoryListResponse inMessage); // 0x00000001803A4DB0-0x00000001803A4E50
	private void OnInventoryItemsRemoved(InventoryListRemovedResponse inMessage); // 0x00000001803A4D10-0x00000001803A4DB0
}

