/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyListItemDetailPanel_AvatarLookSaving : UI_LazyListItemDetailPanel<AvatarLookItemComponent> // TypeDefIndex: 12040
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _groupNoLookSelected; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _groupLookSelected; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _saveBtn; // 0x48
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private TMP_InputField _nameInput; // 0x50

	// Properties
	public string Name { get; set; } // 0x0000000180E60970-0x0000000180E609A0 0x0000000180E602E0-0x0000000180E60320

	// Constructors
	public UI_LazyListItemDetailPanel_AvatarLookSaving(); // 0x0000000180E60930-0x0000000180E60970

	// Methods
	private void Start(); // 0x0000000180E60810-0x0000000180E608B0
	private void OnDestroy(); // 0x0000000180E60240-0x0000000180E602E0
	public override void Setup(UI_LazyListItem<AvatarLookItemComponent> inDataSrc); // 0x0000000180E60520-0x0000000180E60810
	public override void Refresh(); // 0x0000000180E60460-0x0000000180E60520
	public void BtnClicked_Save(); // 0x0000000180E60150-0x0000000180E60240
	public void OnInputFieldChanged_Name(string inValue); // 0x0000000180E602E0-0x0000000180E60320
	private void OnSubmit(string inValue); // 0x0000000180E60320-0x0000000180E60460
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__9_0(); // 0x0000000180E608B0-0x0000000180E608F0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__9_1(); // 0x0000000180E608F0-0x0000000180E60930
}

