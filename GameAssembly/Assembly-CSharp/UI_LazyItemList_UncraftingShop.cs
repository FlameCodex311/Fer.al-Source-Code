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

public class UI_LazyItemList_UncraftingShop : UI_LazyItemList<Item> // TypeDefIndex: 12129
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItem_ItemInventory _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItemDetailPanel_UncraftingShop _detailPanelReference; // 0xF0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _craftBtn; // 0xF8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWButton _skipAnimationBtn; // 0x100
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _craftAnimationTime; // 0x108
	private List<Item> _dataItems; // 0x110
	public Action<Item, int> OnItemUncraftInitiated; // 0x118
	private UI_Window_Shop_Uncrafting _window; // 0x120
	private Waiter _animationWaiter; // 0x128

	// Properties
	private UI_Window_Shop_Uncrafting Window { get; } // 0x0000000180E60010-0x0000000180E600C0 

	// Constructors
	public UI_LazyItemList_UncraftingShop(); // 0x0000000180E5FFC0-0x0000000180E60010

	// Methods
	protected override void Setup(); // 0x0000000180E5FCB0-0x0000000180E5FE60
	protected override void Start(); // 0x0000000180E5FEF0-0x0000000180E5FF90
	private void OnDestroy(); // 0x0000000180E5FB90-0x0000000180E5FC20
	protected override List<Item> GetDataItems(); // 0x00000001803BD380-0x00000001803BD390
	protected override UI_LazyListItemDetailPanel<Item> GetDetailPanelReference(); // 0x00000001803BD320-0x00000001803BD330
	protected override UI_LazyListItem<Item> GetListItemPrefab(); // 0x000000018037A250-0x000000018037A260
	protected override long GetDataItemAge(Item inData); // 0x0000000180E5F7F0-0x0000000180E5F910
	protected override bool GetDataItemFav(Item inData); // 0x00000001803C28F0-0x00000001803C2900
	protected override string GetDataItemName(Item inData); // 0x0000000180E5F990-0x0000000180E5FA00
	protected override List<string> GetDataItemFilters(Item inData); // 0x0000000180E5F910-0x0000000180E5F990
	protected override List<string> GetDataItemTags(Item inData); // 0x0000000180E5FA60-0x0000000180E5FAE0
	protected override int GetDataItemRarity(Item inData); // 0x0000000180E5FA00-0x0000000180E5FA60
	protected override void SortData(); // 0x0000000180E5FE60-0x0000000180E5FEF0
	protected override bool ItemMatchesCategory(LazyListItem<Item> inItem); // 0x0000000180E5FAE0-0x0000000180E5FB90
	public void BtnClicked_CraftSelectedItem(); // 0x0000000180E5F570-0x0000000180E5F6E0
	private void DoCraft(int inQuantity); // 0x0000000180E5F730-0x0000000180E5F7F0
	private void OnInventoryItemRemoved(InventoryItemRemovedEvent inMessage); // 0x0000000180E5FC20-0x0000000180E5FCB0
	public void BtnClicked_SkipAnimation(); // 0x0000000180E5F6E0-0x0000000180E5F730
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <BtnClicked_CraftSelectedItem>b__25_0(); // 0x0000000180E5FF90-0x0000000180E5FFC0
}

