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

public class UI_LazyItemList_CraftableItemShop : UI_LazyItemList<BaseDef> // TypeDefIndex: 13674
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItemDetailPanel_CraftableItem_Shop _detailPanelPrefab; // 0xE8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_CraftableItem_Shop _itemPrefab; // 0xF0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<BaseDef> _itemDefs; // 0xF8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _craftBtn; // 0x100
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWButton _skipAnimationBtn; // 0x108
	public Action<BaseDef, int> OnItemCraftInitiated; // 0x110
	private List<BaseDef> _shopInventoryItemDefs; // 0x118
	private List<BaseDef> _enigmaInventoryItemDefs; // 0x120
	private UI_Window_Shop_Dye _window; // 0x128
	private Waiter _animationWaiter; // 0x130
	private string _shopFilterCategory; // 0x138

	// Properties
	private string ShopFilterCategory { get; } // 0x0000000180383970-0x0000000180383A40 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass18_0 // TypeDefIndex: 13675
	{
		// Fields
		public BaseDef def; // 0x10

		// Constructors
		public <>c__DisplayClass18_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <Setup>b__0(EnigmaItemComponent enigma); // 0x0000000180373480-0x00000001803734E0
	}

	// Constructors
	public UI_LazyItemList_CraftableItemShop(); // 0x00000001803838C0-0x0000000180383970

	// Methods
	protected override void Start(); // 0x00000001803837B0-0x0000000180383890
	private void OnDestroy(); // 0x00000001803830E0-0x00000001803831B0
	public void Setup(string[] inItemDefIds); // 0x0000000180383230-0x0000000180383320
	public void BtnClicked_CraftSelectedItem(); // 0x0000000180382790-0x00000001803828F0
	private void DoCraft(int inQuantity); // 0x0000000180382940-0x0000000180382A00
	public void LongPress_Craft_Progress(float inProgress); // 0x00000001803774A0-0x00000001803774B0
	public void LongPress_Craft_Cancel(); // 0x00000001803774A0-0x00000001803774B0
	public void BtnClicked_SkipAnimation(); // 0x00000001803828F0-0x0000000180382940
	protected override void Setup(); // 0x0000000180383320-0x0000000180383760
	protected override long GetDataItemAge(BaseDef inData); // 0x0000000180382A00-0x0000000180382B50
	protected override bool GetDataItemFav(BaseDef inData); // 0x0000000180380950-0x0000000180380960
	protected override string GetDataItemName(BaseDef inData); // 0x0000000180382BD0-0x0000000180382C40
	protected override List<string> GetDataItemFilters(BaseDef inData); // 0x0000000180382B50-0x0000000180382BD0
	protected override List<string> GetDataItemTags(BaseDef inData); // 0x0000000180382CA0-0x0000000180382D20
	protected override int GetDataItemRarity(BaseDef inData); // 0x0000000180382C40-0x0000000180382CA0
	protected override UI_LazyListItemDetailPanel<BaseDef> GetDetailPanelReference(); // 0x000000018037DDD0-0x000000018037DDE0
	protected override List<BaseDef> GetDataItems(); // 0x000000018037E230-0x000000018037E240
	protected override UI_LazyListItem<BaseDef> GetListItemPrefab(); // 0x000000018037DDB0-0x000000018037DDC0
	protected override bool ItemMatchesCategory(LazyListItem<BaseDef> inItem); // 0x0000000180382D20-0x0000000180382DC0
	protected override bool ItemMatchesFilter(LazyListItem<BaseDef> inItem, string inFilterCategory); // 0x0000000180382DC0-0x00000001803830E0
	protected override void SortData(); // 0x0000000180383760-0x00000001803837B0
	private void OnInventoryItemsRemoved(InventoryListRemovedResponse inMessage); // 0x00000001803831B0-0x00000001803831F0
	private void OnInventoryUpdated(InventoryListResponse inMessage); // 0x00000001803831F0-0x0000000180383230
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <BtnClicked_CraftSelectedItem>b__13_0(); // 0x0000000180383890-0x00000001803838C0
}

