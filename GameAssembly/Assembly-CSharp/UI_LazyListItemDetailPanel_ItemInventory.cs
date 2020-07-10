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

public class UI_LazyListItemDetailPanel_ItemInventory : UI_LazyListItemDetailPanel_Item // TypeDefIndex: 12087
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _descriptionText; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _dyeBtn; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _tradeBtn; // 0x48
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _harvestPointGroup; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RawImage _harvestPointImage; // 0x58
	private ActorInfo _actorInfo; // 0x60
	private bool _isEquipped; // 0x68
	private TradableItemComponent _tradeableItemComponent; // 0x70
	private Item _item; // 0x78
	private bool _harvestPointIconAssigned; // 0x80

	// Constructors
	public UI_LazyListItemDetailPanel_ItemInventory(); // 0x0000000180E6BC00-0x0000000180E6BC40

	// Methods
	public override void Setup(UI_LazyListItem<Item> inDataSrc); // 0x0000000180E6B790-0x0000000180E6BAF0
	public override void Refresh(); // 0x0000000180E6B480-0x0000000180E6B4F0
	protected override void OnEnable(); // 0x00000001803581E0-0x00000001803581F0
	public void BtnClicked_Equip(); // 0x0000000180E6AE80-0x0000000180E6AF40
	public void BtnClicked_Edit(); // 0x0000000180E6AE00-0x0000000180E6AE80
	public void ToggleBtnClicked_TradeList(bool inIsOn); // 0x0000000180E6BBC0-0x0000000180E6BC00
	private void ClothingSetup(ActorClothingDefComponent inClothingDefComponent); // 0x0000000180E6AF40-0x0000000180E6B0A0
	private void OnClothingItemEquip(ActorInfoClothingItem inInfo, bool inIsEquipped); // 0x0000000180E6B0A0-0x0000000180E6B130
	private void SetupEquipped(bool inIsEquipped); // 0x00000001804638B0-0x00000001804638C0
	private void SetupIngredient(); // 0x0000000180E6B4F0-0x0000000180E6B6C0
	private void SetupTradeable(); // 0x0000000180E6B6C0-0x0000000180E6B790
	private void RefreshTradeable(); // 0x0000000180E6B440-0x0000000180E6B480
	private void Start(); // 0x0000000180E6BAF0-0x0000000180E6BBC0
	private void OnDestroy(); // 0x0000000180E6B130-0x0000000180E6B200
	private void OnInventoryUpdated(InventoryListResponse inMessage); // 0x0000000180E6B200-0x0000000180E6B3F0
	private void OnItemAddedOrRemovedFromTradeList(ItemAddedOrRemovedFromTradeList inMessage); // 0x0000000180E6B3F0-0x0000000180E6B440
}

