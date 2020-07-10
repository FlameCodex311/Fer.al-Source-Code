/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyItemList_TradeLobbyTheirs : UI_LazyItemList<Item> // TypeDefIndex: 12156
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItem_TradeLobbyTheirs _itemPrefabReference; // 0xE8
	private List<Item> _dataItems; // 0xF0

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass8_0 // TypeDefIndex: 12157
	{
		// Fields
		public ItemRemovedFromTradeMessage inMessage; // 0x10

		// Constructors
		public <>c__DisplayClass8_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <OnItemRemovedFromTrade>b__0(Item item); // 0x0000000180E5AAA0-0x0000000180E5AAF0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass9_0 // TypeDefIndex: 12158
	{
		// Fields
		public ItemAddedToTradeMessage inMessage; // 0x10

		// Constructors
		public <>c__DisplayClass9_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <OnItemAddedToTrade>b__0(Item item); // 0x0000000180E5AAA0-0x0000000180E5AAF0
	}

	// Constructors
	public UI_LazyItemList_TradeLobbyTheirs(); // 0x0000000180E5F530-0x0000000180E5F570

	// Methods
	protected override void Setup(); // 0x0000000180E5F3A0-0x0000000180E5F450
	protected override void Start(); // 0x0000000180E5F450-0x0000000180E5F530
	private void OnDestroy(); // 0x0000000180E5F0B0-0x0000000180E5F180
	protected override List<Item> GetDataItems(); // 0x00000001803BD320-0x00000001803BD330
	protected override UI_LazyListItemDetailPanel<Item> GetDetailPanelReference(); // 0x000000018035FCC0-0x000000018035FCD0
	protected override UI_LazyListItem<Item> GetListItemPrefab(); // 0x000000018037A250-0x000000018037A260
	private void OnItemRemovedFromTrade(ItemRemovedFromTradeMessage inMessage); // 0x0000000180E5F2A0-0x0000000180E5F3A0
	private void OnItemAddedToTrade(ItemAddedToTradeMessage inMessage); // 0x0000000180E5F180-0x0000000180E5F2A0
}

