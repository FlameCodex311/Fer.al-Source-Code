/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using WW.Waiters;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyItemList_CraftableItemShop : UI_LazyItemList<BaseDef> // TypeDefIndex: 12127
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItemDetailPanel_CraftableItem_Shop _detailPanelPrefab; // 0xE8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItem_CraftableItem_Shop _itemPrefab; // 0xF0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<BaseDef> _itemDefs; // 0xF8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _craftBtn; // 0x100
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWButton _skipAnimationBtn; // 0x108
	public Action<BaseDef, int> OnItemCraftInitiated; // 0x110
	private List<BaseDef> _shopInventoryItemDefs; // 0x118
	private List<BaseDef> _enigmaInventoryItemDefs; // 0x120
	private UI_Window_Shop_Dye _window; // 0x128
	private Waiter _animationWaiter; // 0x130
	private string _shopFilterCategory; // 0x138

	// Properties
	private string ShopFilterCategory { get; } // 0x0000000180E4B510-0x0000000180E4B5E0 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass18_0 // TypeDefIndex: 12128
	{
		// Fields
		public BaseDef def; // 0x10

		// Constructors
		public <>c__DisplayClass18_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <Setup>b__0(EnigmaItemComponent enigma); // 0x0000000180E3E2C0-0x0000000180E3E330
	}

	// Constructors
	public UI_LazyItemList_CraftableItemShop(); // 0x0000000180E4B460-0x0000000180E4B510

	// Methods
	protected override void Start(); // 0x0000000180E4B350-0x0000000180E4B430
	private void OnDestroy(); // 0x0000000180E4AC60-0x0000000180E4AD30
	public void Setup(string[] inItemDefIds); // 0x0000000180E4ADB0-0x0000000180E4AEB0
	public void BtnClicked_CraftSelectedItem(); // 0x0000000180E4A2F0-0x0000000180E4A450
	private void DoCraft(int inQuantity); // 0x0000000180E4A4A0-0x0000000180E4A560
	public void LongPress_Craft_Progress(float inProgress); // 0x00000001803581E0-0x00000001803581F0
	public void LongPress_Craft_Cancel(); // 0x00000001803581E0-0x00000001803581F0
	public void BtnClicked_SkipAnimation(); // 0x0000000180E4A450-0x0000000180E4A4A0
	protected override void Setup(); // 0x0000000180E4AEB0-0x0000000180E4B300
	protected override long GetDataItemAge(BaseDef inData); // 0x0000000180E4A560-0x0000000180E4A6C0
	protected override bool GetDataItemFav(BaseDef inData); // 0x00000001803C28F0-0x00000001803C2900
	protected override string GetDataItemName(BaseDef inData); // 0x0000000180E4A740-0x0000000180E4A7B0
	protected override List<string> GetDataItemFilters(BaseDef inData); // 0x0000000180E4A6C0-0x0000000180E4A740
	protected override List<string> GetDataItemTags(BaseDef inData); // 0x0000000180E4A810-0x0000000180E4A890
	protected override int GetDataItemRarity(BaseDef inData); // 0x0000000180E4A7B0-0x0000000180E4A810
	protected override UI_LazyListItemDetailPanel<BaseDef> GetDetailPanelReference(); // 0x000000018037A250-0x000000018037A260
	protected override List<BaseDef> GetDataItems(); // 0x00000001803BD310-0x00000001803BD320
	protected override UI_LazyListItem<BaseDef> GetListItemPrefab(); // 0x00000001803BD320-0x00000001803BD330
	protected override bool ItemMatchesCategory(LazyListItem<BaseDef> inItem); // 0x0000000180E4A890-0x0000000180E4A930
	protected override bool ItemMatchesFilter(LazyListItem<BaseDef> inItem, string inFilterCategory); // 0x0000000180E4A930-0x0000000180E4AC60
	protected override void SortData(); // 0x0000000180E4B300-0x0000000180E4B350
	private void OnInventoryItemsRemoved(InventoryListRemovedResponse inMessage); // 0x0000000180E4AD30-0x0000000180E4AD70
	private void OnInventoryUpdated(InventoryListResponse inMessage); // 0x0000000180E4AD70-0x0000000180E4ADB0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <BtnClicked_CraftSelectedItem>b__13_0(); // 0x0000000180E4B430-0x0000000180E4B460
}

