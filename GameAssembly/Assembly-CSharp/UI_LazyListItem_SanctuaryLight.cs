/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyListItem_SanctuaryLight : UI_LazyListItem<SanctuaryLightDefComponent> // TypeDefIndex: 13665
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_ItemImage _itemImage; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _nameText; // 0x70

	// Constructors
	public UI_LazyListItem_SanctuaryLight(); // 0x00000001803ABF40-0x00000001803ABF80

	// Methods
	public override void Setup(Action<UI_LazyListItem<SanctuaryLightDefComponent>> inOnClicked, Action<UI_LazyListItem<SanctuaryLightDefComponent>> inOnSelected, SanctuaryLightDefComponent inData, UI_LazyItemList<SanctuaryLightDefComponent> inItemList); // 0x00000001803ABE00-0x00000001803ABF40
	public override void MarkAsSelected(bool inIsSelected); // 0x00000001803774A0-0x00000001803774B0
	public override void Refresh(); // 0x00000001803ABC00-0x00000001803ABE00
}

