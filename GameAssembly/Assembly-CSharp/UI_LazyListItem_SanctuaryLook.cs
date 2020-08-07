/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyListItem_SanctuaryLook : UI_LazyListItem<SanctuaryLookItemComponent> // TypeDefIndex: 13602
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _canvasGroup; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_SanctuaryLookImage _itemImage; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _nameText; // 0x78

	// Constructors
	public UI_LazyListItem_SanctuaryLook(); // 0x00000001803AC520-0x00000001803AC560

	// Methods
	public override void Setup(Action<UI_LazyListItem<SanctuaryLookItemComponent>> inOnClicked, Action<UI_LazyListItem<SanctuaryLookItemComponent>> inOnSelected, SanctuaryLookItemComponent inData, UI_LazyItemList<SanctuaryLookItemComponent> inItemList); // 0x00000001803AC3A0-0x00000001803AC480
	public override void MarkAsSelected(bool inIsSelected); // 0x00000001803AC0E0-0x00000001803AC170
	protected override void Start(); // 0x00000001803AC480-0x00000001803AC520
	private void OnDestroy(); // 0x00000001803AC170-0x00000001803AC200
	public override void Refresh(); // 0x00000001803AC2B0-0x00000001803AC3A0
	private void OnSanctuaryLookSave(SanctuaryXtHandler.SanctuaryLookSaveResponse inMessage); // 0x00000001803AC200-0x00000001803AC2B0
}

