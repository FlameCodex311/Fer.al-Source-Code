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

public class UI_LazyListItemDetailPanel_ItemInventory : UI_LazyListItemDetailPanel_Item // TypeDefIndex: 13629
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _descriptionText; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _dyeBtn; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _tradeBtn; // 0x48
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _harvestPointGroup; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RawImage _harvestPointImage; // 0x58
	private ActorInfo _actorInfo; // 0x60
	private bool _isEquipped; // 0x68
	private TradableItemComponent _tradeableItemComponent; // 0x70
	private Item _item; // 0x78
	private bool _harvestPointIconAssigned; // 0x80

	// Constructors
	public UI_LazyListItemDetailPanel_ItemInventory(); // 0x000000018039F350-0x000000018039F390

	// Methods
	public override void Setup(UI_LazyListItem<Item> inDataSrc); // 0x000000018039EEF0-0x000000018039F240
	public override void Refresh(); // 0x000000018039EBE0-0x000000018039EC50
	protected override void OnEnable(); // 0x00000001803774A0-0x00000001803774B0
	public void BtnClicked_Equip(); // 0x000000018039E610-0x000000018039E6C0
	public void BtnClicked_Edit(); // 0x000000018039E590-0x000000018039E610
	public void ToggleBtnClicked_TradeList(bool inIsOn); // 0x000000018039F310-0x000000018039F350
	private void ClothingSetup(ActorClothingDefComponent inClothingDefComponent); // 0x000000018039E6C0-0x000000018039E810
	private void OnClothingItemEquip(ActorInfoClothingItem inInfo, bool inIsEquipped); // 0x000000018039E810-0x000000018039E8A0
	private void SetupEquipped(bool inIsEquipped); // 0x000000018039EC50-0x000000018039EC60
	private void SetupIngredient(); // 0x000000018039EC60-0x000000018039EE20
	private void SetupTradeable(); // 0x000000018039EE20-0x000000018039EEF0
	private void RefreshTradeable(); // 0x000000018039EBA0-0x000000018039EBE0
	private void Start(); // 0x000000018039F240-0x000000018039F310
	private void OnDestroy(); // 0x000000018039E8A0-0x000000018039E970
	private void OnInventoryUpdated(InventoryListResponse inMessage); // 0x000000018039E970-0x000000018039EB50
	private void OnItemAddedOrRemovedFromTradeList(ItemAddedOrRemovedFromTradeList inMessage); // 0x000000018039EB50-0x000000018039EBA0
}

