/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyListItem_AvatarLook : UI_LazyListItem<AvatarLookItemComponent> // TypeDefIndex: 12032
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _canvasGroup; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_AvatarLookImage _itemImage; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _nameText; // 0x78

	// Constructors
	public UI_LazyListItem_AvatarLook(); // 0x0000000180E6E850-0x0000000180E6E890

	// Methods
	public override void Setup(Action<UI_LazyListItem<AvatarLookItemComponent>> inOnClicked, Action<UI_LazyListItem<AvatarLookItemComponent>> inOnSelected, AvatarLookItemComponent inData, UI_LazyItemList<AvatarLookItemComponent> inItemList); // 0x0000000180E6E6E0-0x0000000180E6E850
	public override void MarkAsSelected(bool inIsSelected); // 0x0000000180E6E650-0x0000000180E6E6E0
}

