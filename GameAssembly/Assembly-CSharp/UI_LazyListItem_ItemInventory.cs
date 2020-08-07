/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyListItem_ItemInventory : UI_LazyListItem<Item> // TypeDefIndex: 13633
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _canvasGroup; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_ItemImage _itemImage; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _nameText; // 0x78
	[Header] // 0x00000001801DAF30-0x00000001801DAF80
	[SerializeField] // 0x00000001801DAF30-0x00000001801DAF80
	private GameObject _memberGroup; // 0x80
	[Header] // 0x00000001801DB2C0-0x00000001801DB310
	[SerializeField] // 0x00000001801DB2C0-0x00000001801DB310
	private UI_RarityBadge _rarityBadge; // 0x88
	[Header] // 0x00000001801DB5C0-0x00000001801DB610
	[SerializeField] // 0x00000001801DB5C0-0x00000001801DB610
	private GameObject _ownedCountBadge; // 0x90
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _ownedCount; // 0x98
	[Header] // 0x0000000180283BA0-0x0000000180283BF0
	[SerializeField] // 0x0000000180283BA0-0x0000000180283BF0
	private GameObject _unreadGroup; // 0xA0
	[Header] // 0x0000000180277BF0-0x0000000180277C40
	[SerializeField] // 0x0000000180277BF0-0x0000000180277C40
	private GameObject _equippedIcon; // 0xA8
	[Header] // 0x00000001801D2A20-0x00000001801D2A70
	[SerializeField] // 0x00000001801D2A20-0x00000001801D2A70
	private FeralAudioInfo _selectedAudioInfo; // 0xB0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo _deselectedAudioInfo; // 0xB8
	private ActorInfo _actorInfo; // 0xC0

	// Constructors
	public UI_LazyListItem_ItemInventory(); // 0x00000001803A9150-0x00000001803A9190

	// Methods
	protected override void Start(); // 0x00000001803A90B0-0x00000001803A9150
	private void OnDestroy(); // 0x00000001803A8AF0-0x00000001803A8B80
	public override void Setup(Action<UI_LazyListItem<Item>> inOnClicked, Action<UI_LazyListItem<Item>> inOnSelected, Item inData, UI_LazyItemList<Item> inItemList); // 0x00000001803A8E20-0x00000001803A90B0
	public override void MarkAsSelected(bool inIsSelected); // 0x00000001803A89C0-0x00000001803A8A60
	public override void Refresh(); // 0x00000001803A8DA0-0x00000001803A8DF0
	public void RefreshQuantity(); // 0x00000001803A8BE0-0x00000001803A8D20
	public void RefreshUnread(); // 0x00000001803A8D20-0x00000001803A8DA0
	private void OnEnable(); // 0x00000001803A4CB0-0x00000001803A4D10
	private void CraftableItemSetup(BaseDef inDef); // 0x00000001803A8800-0x00000001803A89C0
	private void ClothingSetup(ActorClothingDefComponent inClothingDefComponent); // 0x00000001803A8670-0x00000001803A8800
	private void OnClothingItemEquip(ActorInfoClothingItem inItem, bool inIsEquipped); // 0x00000001803A8A60-0x00000001803A8AF0
	private void SetupEquipped(bool inIsEquipped); // 0x00000001803A8DF0-0x00000001803A8E20
	private void OnItemChanged(InventoryItemChangedEvent inMessage); // 0x00000001803A8B80-0x00000001803A8BE0
}

