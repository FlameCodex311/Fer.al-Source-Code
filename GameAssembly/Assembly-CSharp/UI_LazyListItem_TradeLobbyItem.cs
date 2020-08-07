/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyListItem_TradeLobbyItem : UI_LazyListItem<Item> // TypeDefIndex: 13708
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RawImage _iconImage; // 0x68
	private bool _isOffered; // 0x70

	// Constructors
	public UI_LazyListItem_TradeLobbyItem(); // 0x00000001803AF260-0x00000001803AF2A0

	// Methods
	public override void Setup(Action<UI_LazyListItem<Item>> inOnClicked, Action<UI_LazyListItem<Item>> inOnSelected, Item inData, UI_LazyItemList<Item> inItemList); // 0x00000001803AEF10-0x00000001803AF120
	protected override void OnClicked(); // 0x00000001803AEB90-0x00000001803AEC20
	private void RefreshIsOffered(); // 0x00000001803AEE10-0x00000001803AEF10
	public override void MarkAsSelected(bool inIsSelected); // 0x00000001803774A0-0x00000001803774B0
	protected override void Start(); // 0x00000001803AF120-0x00000001803AF200
	private void OnDestroy(); // 0x00000001803AEC20-0x00000001803AECF0
	private void OnItemRemovedFromTrade(ItemRemovedFromTradeMessage inMessage); // 0x00000001803AED80-0x00000001803AEE10
	private void OnItemAddedToTrade(ItemAddedToTradeMessage inMessage); // 0x00000001803AECF0-0x00000001803AED80
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <RefreshIsOffered>b__4_0(Item item); // 0x00000001803AF200-0x00000001803AF260
}

