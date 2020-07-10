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

public class UI_LazyListItemDetailPanel_SanctuaryLookSaving : UI_LazyListItemDetailPanel<SanctuaryLookItemComponent> // TypeDefIndex: 12057
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
	public UI_LazyListItemDetailPanel_SanctuaryLookSaving(); // 0x0000000180E6D010-0x0000000180E6D050

	// Methods
	private void Start(); // 0x0000000180E6CF70-0x0000000180E6D010
	private void OnDestroy(); // 0x0000000180E6C9E0-0x0000000180E6CA80
	public override void Setup(UI_LazyListItem<SanctuaryLookItemComponent> inDataSrc); // 0x0000000180E6CC80-0x0000000180E6CF70
	public override void Refresh(); // 0x0000000180E6CBC0-0x0000000180E6CC80
	public void BtnClicked_Save(); // 0x0000000180E6C8F0-0x0000000180E6C9E0
	public void OnInputFieldChanged_Name(string inValue); // 0x0000000180E602E0-0x0000000180E60320
	private void OnSubmit(string inValue); // 0x0000000180E6CA80-0x0000000180E6CBC0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__9_0(); // 0x0000000180E608B0-0x0000000180E608F0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__9_1(); // 0x0000000180E608F0-0x0000000180E60930
}

