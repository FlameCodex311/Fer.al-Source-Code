/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Panel_Dropdown : UI_Panel // TypeDefIndex: 13913
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _dropdownCanvasGroup; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_DropdownItem _mainItem; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_DropdownItem _prefabItem; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Canvas _dropdownCanvas; // 0x78
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _autoSetup; // 0x80
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<UI_DropdownItem> _dropdownItems; // 0x88
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<DropdownItemInfo> _itemInfos; // 0x90
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private OnDropdownItemSelectedEvent _onDropdownItemSelected; // 0x98
	private int _selectedIndex; // 0xA0
	private GameObject m_Blocker; // 0xA8

	// Nested types
	[Serializable]
	public class OnDropdownItemSelectedEvent : UnityEvent<int> // TypeDefIndex: 13914
	{
		// Constructors
		public OnDropdownItemSelectedEvent(); // 0x00000001803C5680-0x00000001803C5AF0
	}

	// Constructors
	public UI_Panel_Dropdown(); // 0x00000001803D0DE0-0x00000001803D0EF0

	// Methods
	public override void MStart(); // 0x00000001803D0230-0x00000001803D0270
	public override void MOnDestroy(); // 0x00000001803D0150-0x00000001803D0230
	public override void OnReceiveFocus(); // 0x00000001803D0650-0x00000001803D0920
	public override void OnLoseFocus(); // 0x00000001803D0410-0x00000001803D05C0
	public void SetupItems(bool inIsInitialSetup, int inIndexToSelect = -1 /* Metadata: 0x007BA56C */); // 0x00000001803D0920-0x00000001803D0D70
	private void AssignNavigation(); // 0x00000001803CFC30-0x00000001803CFE20
	private void OnDropdownItemClicked(UI_DropdownItem inItem); // 0x00000001803D02E0-0x00000001803D0410
	private void OnMainItemClicked(UI_DropdownItem inItem); // 0x00000001803D05C0-0x00000001803D0650
	private void OnBackBtnPressed(); // 0x00000001803D0270-0x00000001803D02E0
	protected virtual GameObject CreateBlocker(Canvas rootCanvas); // 0x00000001803CFE20-0x00000001803D00F0
	protected virtual void DestroyBlocker(GameObject blocker); // 0x00000001803D00F0-0x00000001803D0150
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnLoseFocus>b__14_0(); // 0x00000001803C8400-0x00000001803C8440
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <CreateBlocker>b__20_0(); // 0x00000001803D0D70-0x00000001803D0DE0
}

