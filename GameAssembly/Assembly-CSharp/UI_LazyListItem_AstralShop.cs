/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyListItem_AstralShop : UI_LazyListItem<BaseDef> // TypeDefIndex: 12130
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _costText; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_RarityBadge _rarityBadge; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_TimeRemainingBadge _timeRemainingBadge; // 0x78
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _nameText; // 0x80
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _descriptionText; // 0x88
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_ItemImage _itemImage; // 0x90
	[Header] // 0x00000001800E17E0-0x00000001800E1830
	[SerializeField] // 0x00000001800E17E0-0x00000001800E1830
	private WWImage _backgroundImage; // 0x98
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Sprite _backgroundSpriteRegular; // 0xA0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Sprite _backgroundSpriteSeasonPass; // 0xA8
	private BundlePackDefComponent _bundlePack; // 0xB0
	private PurchaseableDefComponent _purchaseable; // 0xB8

	// Constructors
	public UI_LazyListItem_AstralShop(); // 0x0000000180E6E4A0-0x0000000180E6E4E0

	// Methods
	public override void Setup(Action<UI_LazyListItem<BaseDef>> inOnClicked, Action<UI_LazyListItem<BaseDef>> inOnSelected, BaseDef inData, UI_LazyItemList<BaseDef> inItemList); // 0x0000000180E6E0B0-0x0000000180E6E4A0
	protected override void OnClicked(); // 0x0000000180E6E060-0x0000000180E6E0B0
}

