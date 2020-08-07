/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coffee.UIExtensions;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyListItem_SanctuaryDecoration : UI_LazyListItem<Item> // TypeDefIndex: 13664
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _canvasGroup; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_ItemImage _itemImage; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _nameText; // 0x78
	[Header] // 0x0000000180290850-0x00000001802908A0
	[SerializeField] // 0x0000000180290850-0x00000001802908A0
	private GameObject _roomGroup; // 0x80
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_Tooltip _roomTooltip; // 0x88
	[Header] // 0x00000001801DAF30-0x00000001801DAF80
	[SerializeField] // 0x00000001801DAF30-0x00000001801DAF80
	private GameObject _memberGroup; // 0x90
	[Header] // 0x00000001801DB2C0-0x00000001801DB310
	[SerializeField] // 0x00000001801DB2C0-0x00000001801DB310
	private UI_RarityBadge _rarityBadge; // 0x98
	[Header] // 0x0000000180283BA0-0x0000000180283BF0
	[SerializeField] // 0x0000000180283BA0-0x0000000180283BF0
	private GameObject _unreadGroup; // 0xA0
	[Header] // 0x0000000180277BF0-0x0000000180277C40
	[SerializeField] // 0x0000000180277BF0-0x0000000180277C40
	private GameObject _equippedIcon; // 0xA8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UIEffect _uiEffect; // 0xB0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioEmitter _equipSound; // 0xB8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioEmitter _unequipSound; // 0xC0
	private bool _isEquipped; // 0xC8

	// Constructors
	public UI_LazyListItem_SanctuaryDecoration(); // 0x00000001803ABBC0-0x00000001803ABC00

	// Methods
	public override void Setup(Action<UI_LazyListItem<Item>> inOnClicked, Action<UI_LazyListItem<Item>> inOnSelected, Item inData, UI_LazyItemList<Item> inItemList); // 0x00000001803AB9A0-0x00000001803ABBC0
	public override void Refresh(); // 0x00000001803AB940-0x00000001803AB9A0
	public void RefreshUnread(); // 0x00000001803AB8C0-0x00000001803AB940
	public void RefreshInteractable(); // 0x00000001803AB670-0x00000001803AB8C0
	private void OnEnable(); // 0x00000001803AB3B0-0x00000001803AB450
	protected override void OnClicked(); // 0x00000001803AB1F0-0x00000001803AB3B0
	public override void MarkAsSelected(bool inIsSelected); // 0x00000001803774A0-0x00000001803774B0
	private void CraftableItemSetup(BaseDef inDef); // 0x00000001803AB140-0x00000001803AB1F0
	private void RefreshEquipped(); // 0x00000001803AB450-0x00000001803AB670
}

