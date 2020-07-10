/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coffee.UIExtensions;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyListItem_SanctuaryDecoration : UI_LazyListItem<Item> // TypeDefIndex: 12118
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _canvasGroup; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_ItemImage _itemImage; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _nameText; // 0x78
	[Header] // 0x00000001800ECE70-0x00000001800ECEC0
	[SerializeField] // 0x00000001800ECE70-0x00000001800ECEC0
	private GameObject _roomGroup; // 0x80
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_Tooltip _roomTooltip; // 0x88
	[Header] // 0x00000001800D9D80-0x00000001800D9DD0
	[SerializeField] // 0x00000001800D9D80-0x00000001800D9DD0
	private GameObject _memberGroup; // 0x90
	[Header] // 0x00000001800D9B70-0x00000001800D9BC0
	[SerializeField] // 0x00000001800D9B70-0x00000001800D9BC0
	private UI_RarityBadge _rarityBadge; // 0x98
	[Header] // 0x00000001800DD8F0-0x00000001800DD940
	[SerializeField] // 0x00000001800DD8F0-0x00000001800DD940
	private GameObject _unreadGroup; // 0xA0
	[Header] // 0x00000001800D2DF0-0x00000001800D2E40
	[SerializeField] // 0x00000001800D2DF0-0x00000001800D2E40
	private GameObject _equippedIcon; // 0xA8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UIEffect _uiEffect; // 0xB0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioEmitter _equipSound; // 0xB8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioEmitter _unequipSound; // 0xC0
	private bool _isEquipped; // 0xC8

	// Constructors
	public UI_LazyListItem_SanctuaryDecoration(); // 0x0000000180E7A120-0x0000000180E7A160

	// Methods
	public override void Setup(Action<UI_LazyListItem<Item>> inOnClicked, Action<UI_LazyListItem<Item>> inOnSelected, Item inData, UI_LazyItemList<Item> inItemList); // 0x0000000180E79F00-0x0000000180E7A120
	public override void Refresh(); // 0x0000000180E79EA0-0x0000000180E79F00
	public void RefreshUnread(); // 0x0000000180E79E20-0x0000000180E79EA0
	public void RefreshInteractable(); // 0x0000000180E79BD0-0x0000000180E79E20
	private void OnEnable(); // 0x0000000180E79900-0x0000000180E799A0
	protected override void OnClicked(); // 0x0000000180E79740-0x0000000180E79900
	public override void MarkAsSelected(bool inIsSelected); // 0x00000001803581E0-0x00000001803581F0
	private void CraftableItemSetup(BaseDef inDef); // 0x0000000180E79690-0x0000000180E79740
	private void RefreshEquipped(); // 0x0000000180E799A0-0x0000000180E79BD0
}

