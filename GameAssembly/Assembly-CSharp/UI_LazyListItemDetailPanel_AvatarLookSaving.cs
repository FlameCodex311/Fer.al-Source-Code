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

public class UI_LazyListItemDetailPanel_AvatarLookSaving : UI_LazyListItemDetailPanel<AvatarLookItemComponent> // TypeDefIndex: 13579
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
	public UI_LazyListItemDetailPanel_AvatarLookSaving(); // 0x0000000180392540-0x0000000180392580

	// Methods
	private void Start(); // 0x0000000180392420-0x00000001803924C0
	private void OnDestroy(); // 0x0000000180391E60-0x0000000180391F00
	public override void Setup(UI_LazyListItem<AvatarLookItemComponent> inDataSrc); // 0x0000000180392140-0x0000000180392420
	public override void Refresh(); // 0x0000000180392080-0x0000000180392140
	public void BtnClicked_Save(); // 0x0000000180391D70-0x0000000180391E60
	public void OnInputFieldChanged_Name(string inValue); // 0x0000000180391F00-0x0000000180391F40
	private void OnSubmit(string inValue); // 0x0000000180391F40-0x0000000180392080
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__9_0(); // 0x00000001803924C0-0x0000000180392500
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__9_1(); // 0x0000000180392500-0x0000000180392540
}

