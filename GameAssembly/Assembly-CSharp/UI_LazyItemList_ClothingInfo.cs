/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyItemList_ClothingInfo : UI_LazyItemList<ColorableItemComponent> // TypeDefIndex: 12066
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_AvatarPositioner _avatarPositioner; // 0xE8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItemDetailPanel_ClothingInfo _detailPanel; // 0xF0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItem_ClothingInfo _itemPrefab; // 0xF8
	[RootSelector] // 0x00000001800D6770-0x00000001800D67F0
	[SerializeField] // 0x00000001800D6770-0x00000001800D67F0
	private string _actorAttachNodeGroupDefId; // 0x100
	private List<ColorableItemComponent> _dataItems; // 0x108
	private Dictionary<string, int> _attachNodeDefIdMap; // 0x110
	private bool _isDesignerMode; // 0x118
	private string _equippedCategory; // 0x120

	// Properties
	private ActorInfo ActorInfo { get; } // 0x0000000180E49D90-0x0000000180E49DE0 
	private string EquippedCategory { get; } // 0x0000000180E49DE0-0x0000000180E49EB0 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass11_0 // TypeDefIndex: 12067
	{
		// Fields
		public ActorInfoClothingItem clothingItem; // 0x10

		// Constructors
		public <>c__DisplayClass11_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <Setup>b__0(BaseDef def); // 0x0000000180E3E040-0x0000000180E3E080
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass22_0 // TypeDefIndex: 12068
	{
		// Fields
		public string inAttachNodeDefId; // 0x10

		// Constructors
		public <>c__DisplayClass22_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal int <SortByAttachNode>b__0(UI_LazyItemList<ColorableItemComponent> a, UI_LazyItemList<ColorableItemComponent> b); // 0x0000000180E3E680-0x0000000180E3E810
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12069
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static UnityAction<UI_Window> <>9__30_1; // 0x08
		public static UnityAction<UI_Window> <>9__30_2; // 0x10
		public static Action<UI_Window_Shop_Clothing> <>9__30_0; // 0x18

		// Constructors
		static <>c(); // 0x0000000180E3ED40-0x0000000180E3EDA0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <BtnClicked_GoToShop>b__30_0(UI_Window_Shop_Clothing openedWindow); // 0x0000000180E3D870-0x0000000180E3DA60
		internal void <BtnClicked_GoToShop>b__30_1(UI_Window completedWindow); // 0x0000000180E3DA60-0x0000000180E3DAD0
		internal void <BtnClicked_GoToShop>b__30_2(UI_Window closedWindow); // 0x0000000180E3DAD0-0x0000000180E3DB40
	}

	// Constructors
	public UI_LazyItemList_ClothingInfo(); // 0x0000000180E49CF0-0x0000000180E49D90

	// Methods
	protected override void OnEnable(); // 0x0000000180E49020-0x0000000180E490D0
	private void OnDisable(); // 0x0000000180E48FE0-0x0000000180E49020
	protected override void Setup(); // 0x0000000180E490D0-0x0000000180E49A80
	protected override UI_LazyListItemDetailPanel<ColorableItemComponent> GetDetailPanelReference(); // 0x00000001803BD320-0x00000001803BD330
	protected override UI_LazyListItem<ColorableItemComponent> GetListItemPrefab(); // 0x00000001803BD310-0x00000001803BD320
	protected override List<ColorableItemComponent> GetDataItems(); // 0x00000001803BD3C0-0x00000001803BD3D0
	protected override bool ItemMatchesSearch(LazyListItem<ColorableItemComponent> inItem); // 0x0000000180E48EE0-0x0000000180E48FE0
	protected override bool ItemMatchesCategory(LazyListItem<ColorableItemComponent> inItem); // 0x00000001803C29F0-0x00000001803C2A00
	protected override bool ItemMatchesFilter(LazyListItem<ColorableItemComponent> inItem, string inFilterCategory); // 0x0000000180E48C90-0x0000000180E48EE0
	protected override void SortData(); // 0x0000000180E49B40-0x0000000180E49CF0
	protected virtual void SortByAttachNode(string inAttachNodeDefId); // 0x0000000180E49A80-0x0000000180E49B40
	protected override string GetDataItemName(ColorableItemComponent inData); // 0x0000000180E48B10-0x0000000180E48B90
	protected override List<string> GetDataItemFilters(ColorableItemComponent inData); // 0x0000000180E48A80-0x0000000180E48B10
	protected override List<string> GetDataItemTags(ColorableItemComponent inData); // 0x0000000180E48C00-0x0000000180E48C90
	protected override int GetDataItemRarity(ColorableItemComponent inData); // 0x0000000180E48B90-0x0000000180E48C00
	protected override bool GetDataItemFav(ColorableItemComponent inData); // 0x00000001803C28F0-0x00000001803C2900
	protected override long GetDataItemAge(ColorableItemComponent inData); // 0x0000000180E48A00-0x0000000180E48A80
	public void BtnClicked_ClearAll(); // 0x0000000180E488A0-0x0000000180E48900
	public void BtnClicked_GoToShop(); // 0x0000000180E48900-0x0000000180E48A00
}

