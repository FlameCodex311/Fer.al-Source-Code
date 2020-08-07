/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyListItemDetailPanel_SanctuaryLookSaving : UI_LazyListItemDetailPanel<SanctuaryLookItemComponent> // TypeDefIndex: 13599
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _groupNoLookSelected; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _groupLookSelected; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _saveBtn; // 0x48
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private TMP_InputField _nameInput; // 0x50

	// Properties
	public string Name { get; set; } // 0x0000000180392580-0x00000001803925A0 0x0000000180391F00-0x0000000180391F40

	// Constructors
	public UI_LazyListItemDetailPanel_SanctuaryLookSaving(); // 0x00000001803A0730-0x00000001803A0770

	// Methods
	private void Start(); // 0x00000001803A0690-0x00000001803A0730
	private void OnDestroy(); // 0x00000001803A0110-0x00000001803A01B0
	public override void Setup(UI_LazyListItem<SanctuaryLookItemComponent> inDataSrc); // 0x00000001803A03B0-0x00000001803A0690
	public override void Refresh(); // 0x00000001803A02F0-0x00000001803A03B0
	public void BtnClicked_Save(); // 0x00000001803A0020-0x00000001803A0110
	public void OnInputFieldChanged_Name(string inValue); // 0x0000000180391F00-0x0000000180391F40
	private void OnSubmit(string inValue); // 0x00000001803A01B0-0x00000001803A02F0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__9_0(); // 0x00000001803924C0-0x0000000180392500
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__9_1(); // 0x0000000180392500-0x0000000180392540
}

