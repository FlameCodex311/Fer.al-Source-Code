/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_ListFilterDropdown : UI_Panel // TypeDefIndex: 12182
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _dropdownCanvasGroup; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Canvas _dropdownCanvas; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _content; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _dropdownToggleBtn; // 0x78
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_ListFilterItem _filterItemPrefab; // 0x80
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_ListFilterCategory _filterCategoryPrefab; // 0x88
	[InterfaceType] // 0x0000000180107F10-0x0000000180107F70
	[SerializeField] // 0x0000000180107F10-0x0000000180107F70
	private UnityEngine.Object _autoFilterTarget; // 0x90
	private List<CategorizedFilter> _filters; // 0x98
	private IFilterable _filterTarget; // 0xA0
	private GameObject _blocker; // 0xA8

	// Nested types
	public class CategorizedFilter // TypeDefIndex: 12183
	{
		// Fields
		public string originalFilterString; // 0x10
		public string category; // 0x18
		public string filter; // 0x20

		// Constructors
		public CategorizedFilter(string originalFilterString); // 0x0000000180E70740-0x0000000180E70810
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass11_0 // TypeDefIndex: 12184
	{
		// Fields
		public string filter; // 0x10

		// Constructors
		public <>c__DisplayClass11_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <Setup>b__1(CategorizedFilter cFilter); // 0x0000000180E72270-0x0000000180E722B0
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12185
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Comparison<CategorizedFilter> <>9__11_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180E724C0-0x0000000180E72520
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal int <Setup>b__11_0(CategorizedFilter a, CategorizedFilter b); // 0x0000000180E721B0-0x0000000180E721F0
	}

	// Constructors
	public UI_ListFilterDropdown(); // 0x0000000180E7F830-0x0000000180E7F890

	// Methods
	public override void MAwake(); // 0x0000000180E7E930-0x0000000180E7EA10
	public void Setup(IFilterable inFilterTarget); // 0x0000000180E7EF60-0x0000000180E7F420
	private void ToggleBtnClicked_Dropdown(bool inIsOn); // 0x0000000180E7F640-0x0000000180E7F780
	public override void OnReceiveFocus(); // 0x0000000180E7ECD0-0x0000000180E7EF60
	public override void OnLoseFocus(); // 0x0000000180E7EB40-0x0000000180E7ECD0
	private UI_ListFilterCategory SpawnCategoryItem(string inCategory); // 0x0000000180E7F420-0x0000000180E7F510
	private UI_ListFilterItem SpawnFilterItem(CategorizedFilter inFilter, UI_ListFilterCategory inCategory); // 0x0000000180E7F510-0x0000000180E7F640
	private void OnFilterToggled(UI_ListFilterItem inFilterItem, bool inIsSelected); // 0x0000000180E7EA70-0x0000000180E7EB40
	private void OnBackBtnPressed(); // 0x0000000180E7EA10-0x0000000180E7EA70
	private GameObject CreateBlocker(Canvas rootCanvas); // 0x0000000180E7E650-0x0000000180E7E930
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnLoseFocus>b__14_0(); // 0x0000000180E7F7F0-0x0000000180E7F830
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <CreateBlocker>b__19_0(); // 0x0000000180E7F780-0x0000000180E7F7F0
}

