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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyListItem_InventoryTradeList : UI_LazyListItem<Item> // TypeDefIndex: 12082
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RawImage _iconImage; // 0x68
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
	[Header] // 0x00000001800D2DF0-0x00000001800D2E40
	[SerializeField] // 0x00000001800D2DF0-0x00000001800D2E40
	private GameObject _equippedIcon; // 0x98
	private ActorInfo _actorInfo; // 0xA0
	private Waiter _iconLoadWaiter; // 0xA8

	// Constructors
	public UI_LazyListItem_InventoryTradeList(); // 0x0000000180E76AB0-0x0000000180E76AF0

	// Methods
	public override void Setup(Action<UI_LazyListItem<Item>> inOnClicked, Action<UI_LazyListItem<Item>> inOnSelected, Item inData, UI_LazyItemList<Item> inItemList); // 0x0000000180E76590-0x0000000180E769C0
	public override void MarkAsSelected(bool inIsSelected); // 0x00000001803581E0-0x00000001803581F0
	public void BtnClicked_RemoveFromTradeList(); // 0x0000000180E76540-0x0000000180E76590
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__9_0(); // 0x0000000180E769C0-0x0000000180E76AB0
}

