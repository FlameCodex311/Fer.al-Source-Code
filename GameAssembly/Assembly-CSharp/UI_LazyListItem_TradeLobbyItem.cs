/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyListItem_TradeLobbyItem : UI_LazyListItem<Item> // TypeDefIndex: 12160
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RawImage _iconImage; // 0x68
	private bool _isOffered; // 0x70

	// Constructors
	public UI_LazyListItem_TradeLobbyItem(); // 0x0000000180E7D510-0x0000000180E7D550

	// Methods
	public override void Setup(Action<UI_LazyListItem<Item>> inOnClicked, Action<UI_LazyListItem<Item>> inOnSelected, Item inData, UI_LazyItemList<Item> inItemList); // 0x0000000180E7D1B0-0x0000000180E7D3C0
	protected override void OnClicked(); // 0x0000000180E7CE30-0x0000000180E7CEC0
	private void RefreshIsOffered(); // 0x0000000180E7D0B0-0x0000000180E7D1B0
	public override void MarkAsSelected(bool inIsSelected); // 0x00000001803581E0-0x00000001803581F0
	protected override void Start(); // 0x0000000180E7D3C0-0x0000000180E7D4A0
	private void OnDestroy(); // 0x0000000180E7CEC0-0x0000000180E7CF90
	private void OnItemRemovedFromTrade(ItemRemovedFromTradeMessage inMessage); // 0x0000000180E7D020-0x0000000180E7D0B0
	private void OnItemAddedToTrade(ItemAddedToTradeMessage inMessage); // 0x0000000180E7CF90-0x0000000180E7D020
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <RefreshIsOffered>b__4_0(Item item); // 0x0000000180E7D4A0-0x0000000180E7D510
}

