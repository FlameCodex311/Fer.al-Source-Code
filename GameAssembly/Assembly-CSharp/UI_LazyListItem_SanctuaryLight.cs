/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyListItem_SanctuaryLight : UI_LazyListItem<SanctuaryLightDefComponent> // TypeDefIndex: 12119
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_ItemImage _itemImage; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _nameText; // 0x70

	// Constructors
	public UI_LazyListItem_SanctuaryLight(); // 0x0000000180E7A4B0-0x0000000180E7A4F0

	// Methods
	public override void Setup(Action<UI_LazyListItem<SanctuaryLightDefComponent>> inOnClicked, Action<UI_LazyListItem<SanctuaryLightDefComponent>> inOnSelected, SanctuaryLightDefComponent inData, UI_LazyItemList<SanctuaryLightDefComponent> inItemList); // 0x0000000180E7A360-0x0000000180E7A4B0
	public override void MarkAsSelected(bool inIsSelected); // 0x00000001803581E0-0x00000001803581F0
	public override void Refresh(); // 0x0000000180E7A160-0x0000000180E7A360
}

