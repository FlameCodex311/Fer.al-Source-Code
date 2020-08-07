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

public class UI_LazyListItem_ReadonlyItemList : UI_LazyListItem<Item> // TypeDefIndex: 13726
{
	// Fields
	[Header] // 0x00000001801DACB0-0x00000001801DAD00
	[SerializeField] // 0x00000001801DACB0-0x00000001801DAD00
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
	private Waiter _iconLoadWaiter; // 0x98

	// Constructors
	public UI_LazyListItem_ReadonlyItemList(); // 0x00000001803AB100-0x00000001803AB140

	// Methods
	public override void Setup(Action<UI_LazyListItem<Item>> inOnClicked, Action<UI_LazyListItem<Item>> inOnSelected, Item inData, UI_LazyItemList<Item> inItemList); // 0x00000001803AAC30-0x00000001803AB010
	public void RefreshQuantity(); // 0x00000001803AAAC0-0x00000001803AAC30
	public override void MarkAsSelected(bool inIsSelected); // 0x00000001803774A0-0x00000001803774B0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__7_0(); // 0x00000001803AB010-0x00000001803AB100
}

