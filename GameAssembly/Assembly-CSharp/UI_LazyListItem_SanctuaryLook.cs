/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyListItem_SanctuaryLook : UI_LazyListItem<SanctuaryLookItemComponent> // TypeDefIndex: 12053
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _canvasGroup; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_SanctuaryLookImage _itemImage; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _nameText; // 0x78

	// Constructors
	public UI_LazyListItem_SanctuaryLook(); // 0x0000000180E7AAA0-0x0000000180E7AAE0

	// Methods
	public override void Setup(Action<UI_LazyListItem<SanctuaryLookItemComponent>> inOnClicked, Action<UI_LazyListItem<SanctuaryLookItemComponent>> inOnSelected, SanctuaryLookItemComponent inData, UI_LazyItemList<SanctuaryLookItemComponent> inItemList); // 0x0000000180E7A920-0x0000000180E7AA00
	public override void MarkAsSelected(bool inIsSelected); // 0x0000000180E7A660-0x0000000180E7A6F0
	protected override void Start(); // 0x0000000180E7AA00-0x0000000180E7AAA0
	private void OnDestroy(); // 0x0000000180E7A6F0-0x0000000180E7A780
	public override void Refresh(); // 0x0000000180E7A830-0x0000000180E7A920
	private void OnSanctuaryLookSave(SanctuaryXtHandler.SanctuaryLookSaveResponse inMessage); // 0x0000000180E7A780-0x0000000180E7A830
}

