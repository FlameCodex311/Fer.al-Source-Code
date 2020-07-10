/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyItemList_TradeLobbyMine : UI_LazyItemList<Item> // TypeDefIndex: 12155
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItem_TradeLobbyMine _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _addItemBtn; // 0xF0
	private List<Item> _dataItems; // 0xF8

	// Constructors
	public UI_LazyItemList_TradeLobbyMine(); // 0x0000000180E5F070-0x0000000180E5F0B0

	// Methods
	protected override void Setup(); // 0x0000000180E5EDB0-0x0000000180E5EF50
	protected override void Start(); // 0x0000000180E5EF50-0x0000000180E5F070
	private void OnDestroy(); // 0x0000000180E5EA30-0x0000000180E5EB40
	protected override List<Item> GetDataItems(); // 0x00000001803BD310-0x00000001803BD320
	protected override UI_LazyListItemDetailPanel<Item> GetDetailPanelReference(); // 0x000000018035FCC0-0x000000018035FCD0
	protected override UI_LazyListItem<Item> GetListItemPrefab(); // 0x000000018037A250-0x000000018037A260
	private void OnItemRemovedFromTrade(ItemRemovedFromTradeMessage inMessage); // 0x0000000180E5EC40-0x0000000180E5ED30
	private void OnItemAddedToTrade(ItemAddedToTradeMessage inMessage); // 0x0000000180E5EB40-0x0000000180E5EC40
	private void OnTradeReady(UserReadyStateChangedMessage inMessage); // 0x0000000180E5ED30-0x0000000180E5EDB0
	public void BtnClicked_AddItem(); // 0x0000000180E5EA20-0x0000000180E5EA30
}

