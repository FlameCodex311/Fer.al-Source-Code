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

public class UI_ListFilterItem : MonoBehaviour // TypeDefIndex: 13733
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _toggleBtn; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _filterNameText; // 0x28
	private UI_ListFilterDropdown.CategorizedFilter _filter; // 0x30
	private Action<UI_ListFilterItem, bool> OnSelected; // 0x38

	// Properties
	public UI_ListFilterDropdown.CategorizedFilter Filter { get; } // 0x00000001803745C0-0x00000001803745D0 

	// Constructors
	public UI_ListFilterItem(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Awake(); // 0x00000001803C84A0-0x00000001803C8570
	public void Setup(UI_ListFilterDropdown.CategorizedFilter inFilter, Action<UI_ListFilterItem, bool> inOnSelectedCallback); // 0x00000001803C8570-0x00000001803C85B0
	private void ToggleBtnClicked_SelectFilter(bool inIsOn); // 0x00000001803C85B0-0x00000001803C8610
}

