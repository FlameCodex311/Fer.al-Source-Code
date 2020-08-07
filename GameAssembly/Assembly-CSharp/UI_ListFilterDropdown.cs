/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_ListFilterDropdown : UI_Panel // TypeDefIndex: 13729
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _dropdownCanvasGroup; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Canvas _dropdownCanvas; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _content; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _dropdownToggleBtn; // 0x78
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_ListFilterItem _filterItemPrefab; // 0x80
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_ListFilterCategory _filterCategoryPrefab; // 0x88
	[InterfaceType] // 0x00000001801E9B30-0x00000001801E9B90
	[SerializeField] // 0x00000001801E9B30-0x00000001801E9B90
	private UnityEngine.Object _autoFilterTarget; // 0x90
	private List<CategorizedFilter> _filters; // 0x98
	private IFilterable _filterTarget; // 0xA0
	private GameObject _blocker; // 0xA8

	// Nested types
	public class CategorizedFilter // TypeDefIndex: 13730
	{
		// Fields
		public string originalFilterString; // 0x10
		public string category; // 0x18
		public string filter; // 0x20

		// Constructors
		public CategorizedFilter(string originalFilterString); // 0x00000001803C55B0-0x00000001803C5680
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass11_0 // TypeDefIndex: 13731
	{
		// Fields
		public string filter; // 0x10

		// Constructors
		public <>c__DisplayClass11_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <Setup>b__1(CategorizedFilter cFilter); // 0x00000001803C64C0-0x00000001803C6500
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13732
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Comparison<CategorizedFilter> <>9__11_0; // 0x08

		// Constructors
		static <>c(); // 0x00000001803C6780-0x00000001803C67E0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal int <Setup>b__11_0(CategorizedFilter a, CategorizedFilter b); // 0x00000001803C6400-0x00000001803C6440
	}

	// Constructors
	public UI_ListFilterDropdown(); // 0x00000001803C8440-0x00000001803C84A0

	// Methods
	public override void MAwake(); // 0x00000001803C7570-0x00000001803C7650
	public void Setup(IFilterable inFilterTarget); // 0x00000001803C7B80-0x00000001803C8030
	private void ToggleBtnClicked_Dropdown(bool inIsOn); // 0x00000001803C8250-0x00000001803C8390
	public override void OnReceiveFocus(); // 0x00000001803C7900-0x00000001803C7B80
	public override void OnLoseFocus(); // 0x00000001803C7770-0x00000001803C7900
	private UI_ListFilterCategory SpawnCategoryItem(string inCategory); // 0x00000001803C8030-0x00000001803C8120
	private UI_ListFilterItem SpawnFilterItem(CategorizedFilter inFilter, UI_ListFilterCategory inCategory); // 0x00000001803C8120-0x00000001803C8250
	private void OnFilterToggled(UI_ListFilterItem inFilterItem, bool inIsSelected); // 0x00000001803C76B0-0x00000001803C7770
	private void OnBackBtnPressed(); // 0x00000001803C7650-0x00000001803C76B0
	private GameObject CreateBlocker(Canvas rootCanvas); // 0x00000001803C72A0-0x00000001803C7570
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnLoseFocus>b__14_0(); // 0x00000001803C8400-0x00000001803C8440
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <CreateBlocker>b__19_0(); // 0x00000001803C8390-0x00000001803C8400
}

