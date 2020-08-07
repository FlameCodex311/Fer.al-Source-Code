/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyItemList_TradeLobbyMine : UI_LazyItemList<Item> // TypeDefIndex: 13702
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_TradeLobbyMine _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _addItemBtn; // 0xF0
	private List<Item> _dataItems; // 0xF8

	// Constructors
	public UI_LazyItemList_TradeLobbyMine(); // 0x0000000180390BF0-0x0000000180390C30

	// Methods
	protected override void Setup(); // 0x0000000180390940-0x0000000180390AD0
	protected override void Start(); // 0x0000000180390AD0-0x0000000180390BF0
	private void OnDestroy(); // 0x00000001803905C0-0x00000001803906D0
	protected override List<Item> GetDataItems(); // 0x000000018037E230-0x000000018037E240
	protected override UI_LazyListItemDetailPanel<Item> GetDetailPanelReference(); // 0x000000018037DDC0-0x000000018037DDD0
	protected override UI_LazyListItem<Item> GetListItemPrefab(); // 0x000000018037DDD0-0x000000018037DDE0
	private void OnItemRemovedFromTrade(ItemRemovedFromTradeMessage inMessage); // 0x00000001803907D0-0x00000001803908C0
	private void OnItemAddedToTrade(ItemAddedToTradeMessage inMessage); // 0x00000001803906D0-0x00000001803907D0
	private void OnTradeReady(UserReadyStateChangedMessage inMessage); // 0x00000001803908C0-0x0000000180390940
	public void BtnClicked_AddItem(); // 0x00000001803905B0-0x00000001803905C0
}

