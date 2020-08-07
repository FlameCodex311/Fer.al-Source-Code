/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyListItem_ClothingPicker : UI_LazyListItem<ActorClothingDefComponent> // TypeDefIndex: 13460
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_ItemImage _itemImage; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _canvasGroup; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _nameText; // 0x78
	[Header] // 0x00000001801DB2C0-0x00000001801DB310
	[SerializeField] // 0x00000001801DB2C0-0x00000001801DB310
	private UI_RarityBadge _rarityBadge; // 0x80
	[Header] // 0x00000001801DAF30-0x00000001801DAF80
	[SerializeField] // 0x00000001801DAF30-0x00000001801DAF80
	private GameObject _memberGroup; // 0x88

	// Constructors
	public UI_LazyListItem_ClothingPicker(); // 0x00000001803A41C0-0x00000001803A4200

	// Methods
	public override void Setup(Action<UI_LazyListItem<ActorClothingDefComponent>> inOnClicked, Action<UI_LazyListItem<ActorClothingDefComponent>> inOnSelected, ActorClothingDefComponent inData, UI_LazyItemList<ActorClothingDefComponent> inItemList); // 0x00000001803A3F00-0x00000001803A41C0
	private void OnEnable(); // 0x00000001803A38F0-0x00000001803A3940
	public override void MarkAsSelected(bool inIsSelected); // 0x00000001803774A0-0x00000001803774B0
}

