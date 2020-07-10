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

public class UI_LazyListItem_TradeLobbyTheirs : UI_LazyListItem<Item> // TypeDefIndex: 12162
{
	// Fields
	[Header] // 0x00000001800F5540-0x00000001800F5590
	[SerializeField] // 0x00000001800F5540-0x00000001800F5590
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
	private Waiter _iconLoadWaiter; // 0x98

	// Constructors
	public UI_LazyListItem_TradeLobbyTheirs(); // 0x0000000180E7E1D0-0x0000000180E7E210

	// Methods
	public override void Setup(Action<UI_LazyListItem<Item>> inOnClicked, Action<UI_LazyListItem<Item>> inOnSelected, Item inData, UI_LazyItemList<Item> inItemList); // 0x0000000180E7DD20-0x0000000180E7E0E0
	public override void MarkAsSelected(bool inIsSelected); // 0x00000001803581E0-0x00000001803581F0
	public void RefreshQuantity(); // 0x0000000180E7DBE0-0x0000000180E7DD20
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__7_0(); // 0x0000000180E7E0E0-0x0000000180E7E1D0
}

