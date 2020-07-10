/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyListItem_ItemInventory : UI_LazyListItem<Item> // TypeDefIndex: 12083
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _canvasGroup; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_ItemImage _itemImage; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _nameText; // 0x78
	[Header] // 0x00000001800D9D80-0x00000001800D9DD0
	[SerializeField] // 0x00000001800D9D80-0x00000001800D9DD0
	private GameObject _memberGroup; // 0x80
	[Header] // 0x00000001800D9B70-0x00000001800D9BC0
	[SerializeField] // 0x00000001800D9B70-0x00000001800D9BC0
	private UI_RarityBadge _rarityBadge; // 0x88
	[Header] // 0x00000001800DB280-0x00000001800DB2D0
	[SerializeField] // 0x00000001800DB280-0x00000001800DB2D0
	private GameObject _ownedCountBadge; // 0x90
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _ownedCount; // 0x98
	[Header] // 0x00000001800DD8F0-0x00000001800DD940
	[SerializeField] // 0x00000001800DD8F0-0x00000001800DD940
	private GameObject _unreadGroup; // 0xA0
	[Header] // 0x00000001800D2DF0-0x00000001800D2E40
	[SerializeField] // 0x00000001800D2DF0-0x00000001800D2E40
	private GameObject _equippedIcon; // 0xA8
	[Header] // 0x00000001800DA180-0x00000001800DA1D0
	[SerializeField] // 0x00000001800DA180-0x00000001800DA1D0
	private FeralAudioInfo _selectedAudioInfo; // 0xB0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo _deselectedAudioInfo; // 0xB8
	private ActorInfo _actorInfo; // 0xC0

	// Constructors
	public UI_LazyListItem_ItemInventory(); // 0x0000000180E77610-0x0000000180E77650

	// Methods
	protected override void Start(); // 0x0000000180E77570-0x0000000180E77610
	private void OnDestroy(); // 0x0000000180E76FA0-0x0000000180E77030
	public override void Setup(Action<UI_LazyListItem<Item>> inOnClicked, Action<UI_LazyListItem<Item>> inOnSelected, Item inData, UI_LazyItemList<Item> inItemList); // 0x0000000180E772D0-0x0000000180E77570
	public override void MarkAsSelected(bool inIsSelected); // 0x0000000180E76E60-0x0000000180E76F10
	public override void Refresh(); // 0x0000000180E77250-0x0000000180E772A0
	public void RefreshQuantity(); // 0x0000000180E77090-0x0000000180E771D0
	public void RefreshUnread(); // 0x0000000180E771D0-0x0000000180E77250
	private void OnEnable(); // 0x0000000180E73070-0x0000000180E730D0
	private void CraftableItemSetup(BaseDef inDef); // 0x0000000180E76C80-0x0000000180E76E60
	private void ClothingSetup(ActorClothingDefComponent inClothingDefComponent); // 0x0000000180E76AF0-0x0000000180E76C80
	private void OnClothingItemEquip(ActorInfoClothingItem inItem, bool inIsEquipped); // 0x0000000180E76F10-0x0000000180E76FA0
	private void SetupEquipped(bool inIsEquipped); // 0x0000000180E772A0-0x0000000180E772D0
	private void OnItemChanged(InventoryItemChangedEvent inMessage); // 0x0000000180E77030-0x0000000180E77090
}

