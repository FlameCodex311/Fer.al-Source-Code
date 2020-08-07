/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyItemList_ClothingInfo : UI_LazyItemList<ColorableItemComponent> // TypeDefIndex: 13612
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_AvatarPositioner _avatarPositioner; // 0xE8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItemDetailPanel_ClothingInfo _detailPanel; // 0xF0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_ClothingInfo _itemPrefab; // 0xF8
	[RootSelector] // 0x000000018027B360-0x000000018027B3E0
	[SerializeField] // 0x000000018027B360-0x000000018027B3E0
	private string _actorAttachNodeGroupDefId; // 0x100
	private List<ColorableItemComponent> _dataItems; // 0x108
	private Dictionary<string, int> _attachNodeDefIdMap; // 0x110
	private bool _isDesignerMode; // 0x118
	private string _equippedCategory; // 0x120

	// Properties
	private ActorInfo ActorInfo { get; } // 0x0000000180381C20-0x0000000180381C70 
	private string EquippedCategory { get; } // 0x0000000180381C70-0x0000000180381D40 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass11_0 // TypeDefIndex: 13613
	{
		// Fields
		public ActorInfoClothingItem clothingItem; // 0x10

		// Constructors
		public <>c__DisplayClass11_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <Setup>b__0(BaseDef def); // 0x0000000180373200-0x0000000180373240
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass22_0 // TypeDefIndex: 13614
	{
		// Fields
		public string inAttachNodeDefId; // 0x10

		// Constructors
		public <>c__DisplayClass22_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal int <SortByAttachNode>b__0(UI_LazyItemList<ColorableItemComponent> a, UI_LazyItemList<ColorableItemComponent> b); // 0x0000000180373820-0x00000001803739A0
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13615
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static UnityAction<UI_Window> <>9__30_1; // 0x08
		public static UnityAction<UI_Window> <>9__30_2; // 0x10
		public static Action<UI_Window_Shop_Clothing> <>9__30_0; // 0x18

		// Constructors
		static <>c(); // 0x0000000180373D70-0x0000000180373DD0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <BtnClicked_GoToShop>b__30_0(UI_Window_Shop_Clothing openedWindow); // 0x0000000180372AA0-0x0000000180372C90
		internal void <BtnClicked_GoToShop>b__30_1(UI_Window completedWindow); // 0x0000000180372C90-0x0000000180372D00
		internal void <BtnClicked_GoToShop>b__30_2(UI_Window closedWindow); // 0x0000000180372D00-0x0000000180372D70
	}

	// Constructors
	public UI_LazyItemList_ClothingInfo(); // 0x0000000180381B80-0x0000000180381C20

	// Methods
	protected override void OnEnable(); // 0x0000000180380EE0-0x0000000180380F90
	private void OnDisable(); // 0x0000000180380EA0-0x0000000180380EE0
	protected override void Setup(); // 0x0000000180380F90-0x0000000180381910
	protected override UI_LazyListItemDetailPanel<ColorableItemComponent> GetDetailPanelReference(); // 0x000000018037DDB0-0x000000018037DDC0
	protected override UI_LazyListItem<ColorableItemComponent> GetListItemPrefab(); // 0x000000018037E230-0x000000018037E240
	protected override List<ColorableItemComponent> GetDataItems(); // 0x0000000180380B50-0x0000000180380B60
	protected override bool ItemMatchesSearch(LazyListItem<ColorableItemComponent> inItem); // 0x0000000180380DB0-0x0000000180380EA0
	protected override bool ItemMatchesCategory(LazyListItem<ColorableItemComponent> inItem); // 0x0000000180380B60-0x0000000180380B70
	protected override bool ItemMatchesFilter(LazyListItem<ColorableItemComponent> inItem, string inFilterCategory); // 0x0000000180380B70-0x0000000180380DB0
	protected override void SortData(); // 0x00000001803819D0-0x0000000180381B80
	protected virtual void SortByAttachNode(string inAttachNodeDefId); // 0x0000000180381910-0x00000001803819D0
	protected override string GetDataItemName(ColorableItemComponent inData); // 0x00000001803809F0-0x0000000180380A60
	protected override List<string> GetDataItemFilters(ColorableItemComponent inData); // 0x0000000180380960-0x00000001803809F0
	protected override List<string> GetDataItemTags(ColorableItemComponent inData); // 0x0000000180380AC0-0x0000000180380B50
	protected override int GetDataItemRarity(ColorableItemComponent inData); // 0x0000000180380A60-0x0000000180380AC0
	protected override bool GetDataItemFav(ColorableItemComponent inData); // 0x0000000180380950-0x0000000180380960
	protected override long GetDataItemAge(ColorableItemComponent inData); // 0x00000001803808D0-0x0000000180380950
	public void BtnClicked_ClearAll(); // 0x0000000180380770-0x00000001803807D0
	public void BtnClicked_GoToShop(); // 0x00000001803807D0-0x00000001803808D0
}

