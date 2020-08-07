/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyListItem_AvatarLook : UI_LazyListItem<AvatarLookItemComponent> // TypeDefIndex: 13586
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _canvasGroup; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_AvatarLookImage _itemImage; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _nameText; // 0x78

	// Constructors
	public UI_LazyListItem_AvatarLook(); // 0x00000001803A2080-0x00000001803A20C0

	// Methods
	public override void Setup(Action<UI_LazyListItem<AvatarLookItemComponent>> inOnClicked, Action<UI_LazyListItem<AvatarLookItemComponent>> inOnSelected, AvatarLookItemComponent inData, UI_LazyItemList<AvatarLookItemComponent> inItemList); // 0x00000001803A1F10-0x00000001803A2080
	public override void MarkAsSelected(bool inIsSelected); // 0x00000001803A1E80-0x00000001803A1F10
}

