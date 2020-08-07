/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyListItem_TradeLobbyInventory : UI_LazyListItem<Item> // TypeDefIndex: 13707
{
	// Fields
	[Header] // 0x00000001801DACB0-0x00000001801DAD00
	[SerializeField] // 0x00000001801DACB0-0x00000001801DAD00
	private UI_ItemImage _itemImage; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _nameText; // 0x70
	[Header] // 0x00000001801DAF30-0x00000001801DAF80
	[SerializeField] // 0x00000001801DAF30-0x00000001801DAF80
	private GameObject _memberGroup; // 0x78
	[Header] // 0x00000001801DB2C0-0x00000001801DB310
	[SerializeField] // 0x00000001801DB2C0-0x00000001801DB310
	private UI_RarityBadge _rarityBadge; // 0x80
	[Header] // 0x00000001801DB5C0-0x00000001801DB610
	[SerializeField] // 0x00000001801DB5C0-0x00000001801DB610
	private GameObject _ownedCountBadge; // 0x88
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _ownedCount; // 0x90
	private bool _isOffered; // 0x98

	// Constructors
	public UI_LazyListItem_TradeLobbyInventory(); // 0x00000001803AEB50-0x00000001803AEB90

	// Methods
	public override void Setup(Action<UI_LazyListItem<Item>> inOnClicked, Action<UI_LazyListItem<Item>> inOnSelected, Item inData, UI_LazyItemList<Item> inItemList); // 0x00000001803AE610-0x00000001803AE9A0
	protected override void OnClicked(); // 0x00000001803ADFF0-0x00000001803AE110
	public override void MarkAsSelected(bool inIsSelected); // 0x00000001803774A0-0x00000001803774B0
	private void RefreshIsOffered(bool inFromSetup); // 0x00000001803AE300-0x00000001803AE4D0
	public void RefreshQuantity(); // 0x00000001803AE4D0-0x00000001803AE610
	protected override void Start(); // 0x00000001803AE9A0-0x00000001803AEA80
	private void OnDestroy(); // 0x00000001803AE110-0x00000001803AE1E0
	private void OnItemRemovedFromTrade(ItemRemovedFromTradeMessage inMessage); // 0x00000001803AE270-0x00000001803AE300
	private void OnItemAddedToTrade(ItemAddedToTradeMessage inMessage); // 0x00000001803AE1E0-0x00000001803AE270
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnClicked>b__8_0(int inQuantity); // 0x00000001803AEA80-0x00000001803AEAF0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <RefreshIsOffered>b__10_0(Item item); // 0x00000001803AEAF0-0x00000001803AEB50
}

