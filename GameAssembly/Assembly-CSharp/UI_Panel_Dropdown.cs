/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Panel_Dropdown : UI_Panel // TypeDefIndex: 12329
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _dropdownCanvasGroup; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_DropdownItem _mainItem; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_DropdownItem _prefabItem; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Canvas _dropdownCanvas; // 0x78
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _autoSetup; // 0x80
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<UI_DropdownItem> _dropdownItems; // 0x88
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<DropdownItemInfo> _itemInfos; // 0x90
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private OnDropdownItemSelectedEvent _onDropdownItemSelected; // 0x98
	private int _selectedIndex; // 0xA0
	private GameObject m_Blocker; // 0xA8

	// Nested types
	[Serializable]
	public class OnDropdownItemSelectedEvent : UnityEvent<int> // TypeDefIndex: 12330
	{
		// Constructors
		public OnDropdownItemSelectedEvent(); // 0x0000000180EDFA40-0x0000000180EDFA80
	}

	// Constructors
	public UI_Panel_Dropdown(); // 0x0000000180E874C0-0x0000000180E875B0

	// Methods
	public override void MStart(); // 0x0000000180E868F0-0x0000000180E86930
	public override void MOnDestroy(); // 0x0000000180E86810-0x0000000180E868F0
	public override void OnReceiveFocus(); // 0x0000000180E86D10-0x0000000180E86FF0
	public override void OnLoseFocus(); // 0x0000000180E86AD0-0x0000000180E86C80
	public void SetupItems(bool inIsInitialSetup, int inIndexToSelect = -1 /* Metadata: 0x00782E55 */); // 0x0000000180E86FF0-0x0000000180E87450
	private void AssignNavigation(); // 0x0000000180E862E0-0x0000000180E864D0
	private void OnDropdownItemClicked(UI_DropdownItem inItem); // 0x0000000180E869A0-0x0000000180E86AD0
	private void OnMainItemClicked(UI_DropdownItem inItem); // 0x0000000180E86C80-0x0000000180E86D10
	private void OnBackBtnPressed(); // 0x0000000180E86930-0x0000000180E869A0
	protected virtual GameObject CreateBlocker(Canvas rootCanvas); // 0x0000000180E864D0-0x0000000180E867B0
	protected virtual void DestroyBlocker(GameObject blocker); // 0x0000000180E867B0-0x0000000180E86810
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnLoseFocus>b__14_0(); // 0x0000000180E7F7F0-0x0000000180E7F830
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <CreateBlocker>b__20_0(); // 0x0000000180E87450-0x0000000180E874C0
}

