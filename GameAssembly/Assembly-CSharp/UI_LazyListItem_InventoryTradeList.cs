/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using WW.Waiters;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyListItem_InventoryTradeList : UI_LazyListItem<Item> // TypeDefIndex: 13632
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RawImage _iconImage; // 0x68
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
	[Header] // 0x0000000180277BF0-0x0000000180277C40
	[SerializeField] // 0x0000000180277BF0-0x0000000180277C40
	private GameObject _equippedIcon; // 0x98
	private ActorInfo _actorInfo; // 0xA0
	private Waiter _iconLoadWaiter; // 0xA8

	// Constructors
	public UI_LazyListItem_InventoryTradeList(); // 0x00000001803A8630-0x00000001803A8670

	// Methods
	public override void Setup(Action<UI_LazyListItem<Item>> inOnClicked, Action<UI_LazyListItem<Item>> inOnSelected, Item inData, UI_LazyItemList<Item> inItemList); // 0x00000001803A8130-0x00000001803A8540
	public override void MarkAsSelected(bool inIsSelected); // 0x00000001803774A0-0x00000001803774B0
	public void BtnClicked_RemoveFromTradeList(); // 0x00000001803A80E0-0x00000001803A8130
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__9_0(); // 0x00000001803A8540-0x00000001803A8630
}

