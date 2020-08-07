/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyItemList_TradeLobbyTheirs : UI_LazyItemList<Item> // TypeDefIndex: 13703
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_TradeLobbyTheirs _itemPrefabReference; // 0xE8
	private List<Item> _dataItems; // 0xF0

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass8_0 // TypeDefIndex: 13704
	{
		// Fields
		public ItemRemovedFromTradeMessage inMessage; // 0x10

		// Constructors
		public <>c__DisplayClass8_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <OnItemRemovedFromTrade>b__0(Item item); // 0x0000000180387FB0-0x0000000180388000
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass9_0 // TypeDefIndex: 13705
	{
		// Fields
		public ItemAddedToTradeMessage inMessage; // 0x10

		// Constructors
		public <>c__DisplayClass9_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <OnItemAddedToTrade>b__0(Item item); // 0x0000000180387FB0-0x0000000180388000
	}

	// Constructors
	public UI_LazyItemList_TradeLobbyTheirs(); // 0x00000001803910B0-0x00000001803910F0

	// Methods
	protected override void Setup(); // 0x0000000180390F20-0x0000000180390FD0
	protected override void Start(); // 0x0000000180390FD0-0x00000001803910B0
	private void OnDestroy(); // 0x0000000180390C30-0x0000000180390D00
	protected override List<Item> GetDataItems(); // 0x000000018037DDB0-0x000000018037DDC0
	protected override UI_LazyListItemDetailPanel<Item> GetDetailPanelReference(); // 0x000000018037DDC0-0x000000018037DDD0
	protected override UI_LazyListItem<Item> GetListItemPrefab(); // 0x000000018037DDD0-0x000000018037DDE0
	private void OnItemRemovedFromTrade(ItemRemovedFromTradeMessage inMessage); // 0x0000000180390E20-0x0000000180390F20
	private void OnItemAddedToTrade(ItemAddedToTradeMessage inMessage); // 0x0000000180390D00-0x0000000180390E20
}

