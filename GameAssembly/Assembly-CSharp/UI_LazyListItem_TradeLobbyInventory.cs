/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyListItem_TradeLobbyInventory : UI_LazyListItem<Item> // TypeDefIndex: 12159
{
	// Fields
	[Header] // 0x00000001800F5540-0x00000001800F5590
	[SerializeField] // 0x00000001800F5540-0x00000001800F5590
	private UI_ItemImage _itemImage; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _nameText; // 0x70
	[Header] // 0x00000001800D9D80-0x00000001800D9DD0
	[SerializeField] // 0x00000001800D9D80-0x00000001800D9DD0
	private GameObject _memberGroup; // 0x78
	[Header] // 0x00000001800D9B70-0x00000001800D9BC0
	[SerializeField] // 0x00000001800D9B70-0x00000001800D9BC0
	private UI_RarityBadge _rarityBadge; // 0x80
	[Header] // 0x00000001800DB280-0x00000001800DB2D0
	[SerializeField] // 0x00000001800DB280-0x00000001800DB2D0
	private GameObject _ownedCountBadge; // 0x88
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _ownedCount; // 0x90
	private bool _isOffered; // 0x98

	// Constructors
	public UI_LazyListItem_TradeLobbyInventory(); // 0x0000000180E7CDF0-0x0000000180E7CE30

	// Methods
	public override void Setup(Action<UI_LazyListItem<Item>> inOnClicked, Action<UI_LazyListItem<Item>> inOnSelected, Item inData, UI_LazyItemList<Item> inItemList); // 0x0000000180E7C890-0x0000000180E7CC30
	protected override void OnClicked(); // 0x0000000180E7C2A0-0x0000000180E7C3C0
	public override void MarkAsSelected(bool inIsSelected); // 0x00000001803581E0-0x00000001803581F0
	private void RefreshIsOffered(); // 0x0000000180E7C5B0-0x0000000180E7C750
	public void RefreshQuantity(); // 0x0000000180E7C750-0x0000000180E7C890
	protected override void Start(); // 0x0000000180E7CC30-0x0000000180E7CD10
	private void OnDestroy(); // 0x0000000180E7C3C0-0x0000000180E7C490
	private void OnItemRemovedFromTrade(ItemRemovedFromTradeMessage inMessage); // 0x0000000180E7C520-0x0000000180E7C5B0
	private void OnItemAddedToTrade(ItemAddedToTradeMessage inMessage); // 0x0000000180E7C490-0x0000000180E7C520
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnClicked>b__8_0(int inQuantity); // 0x0000000180E7CD10-0x0000000180E7CD80
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <RefreshIsOffered>b__10_0(Item item); // 0x0000000180E7CD80-0x0000000180E7CDF0
}

