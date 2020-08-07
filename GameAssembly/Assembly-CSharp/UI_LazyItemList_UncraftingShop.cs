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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyItemList_UncraftingShop : UI_LazyItemList<Item> // TypeDefIndex: 13676
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private ItemType _itemType; // 0xE8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_ItemInventory _itemPrefabReference; // 0xF0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItemDetailPanel_UncraftingShop _detailPanelReference; // 0xF8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _craftBtn; // 0x100
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWButton _skipAnimationBtn; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _craftAnimationTime; // 0x110
	private List<Item> _dataItems; // 0x118
	public Action<Item, int> OnItemUncraftInitiated; // 0x120
	private UI_Window_Shop_Uncrafting _window; // 0x128
	private Waiter _animationWaiter; // 0x130

	// Properties
	private UI_Window_Shop_Uncrafting Window { get; } // 0x0000000180391C30-0x0000000180391CE0 

	// Constructors
	public UI_LazyItemList_UncraftingShop(); // 0x0000000180391BE0-0x0000000180391C30

	// Methods
	protected override void Setup(); // 0x00000001803918B0-0x0000000180391A80
	private void OnDisable(); // 0x00000001803917F0-0x0000000180391830
	protected override void Start(); // 0x0000000180391B10-0x0000000180391BB0
	private void OnDestroy(); // 0x0000000180391760-0x00000001803917F0
	protected override List<Item> GetDataItems(); // 0x00000001803916B0-0x00000001803916C0
	protected override UI_LazyListItemDetailPanel<Item> GetDetailPanelReference(); // 0x000000018037E230-0x000000018037E240
	protected override UI_LazyListItem<Item> GetListItemPrefab(); // 0x000000018037DDB0-0x000000018037DDC0
	protected override long GetDataItemAge(Item inData); // 0x00000001803913C0-0x00000001803914E0
	protected override bool GetDataItemFav(Item inData); // 0x0000000180380950-0x0000000180380960
	protected override string GetDataItemName(Item inData); // 0x0000000180391560-0x00000001803915D0
	protected override List<string> GetDataItemFilters(Item inData); // 0x00000001803914E0-0x0000000180391560
	protected override List<string> GetDataItemTags(Item inData); // 0x0000000180391630-0x00000001803916B0
	protected override int GetDataItemRarity(Item inData); // 0x00000001803915D0-0x0000000180391630
	protected override void SortData(); // 0x0000000180391A80-0x0000000180391B10
	protected override bool ItemMatchesCategory(LazyListItem<Item> inItem); // 0x00000001803916C0-0x0000000180391760
	public void BtnClicked_CraftSelectedItem(); // 0x00000001803910F0-0x0000000180391290
	private void DoCraft(int inQuantity); // 0x0000000180391300-0x00000001803913C0
	private void OnInventoryItemRemoved(InventoryItemRemovedEvent inMessage); // 0x0000000180391830-0x00000001803918B0
	public void BtnClicked_SkipAnimation(); // 0x0000000180391290-0x0000000180391300
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <BtnClicked_CraftSelectedItem>b__27_0(); // 0x0000000180391BB0-0x0000000180391BE0
}

