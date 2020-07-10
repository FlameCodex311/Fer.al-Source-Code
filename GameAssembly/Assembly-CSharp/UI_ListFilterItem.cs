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

public class UI_ListFilterItem : MonoBehaviour // TypeDefIndex: 12186
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _toggleBtn; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _filterNameText; // 0x28
	private UI_ListFilterDropdown.CategorizedFilter _filter; // 0x30
	private Action<UI_ListFilterItem, bool> OnSelected; // 0x38

	// Properties
	public UI_ListFilterDropdown.CategorizedFilter Filter { get; } // 0x0000000180397720-0x0000000180397730 

	// Constructors
	public UI_ListFilterItem(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Awake(); // 0x0000000180E7F890-0x0000000180E7F960
	public void Setup(UI_ListFilterDropdown.CategorizedFilter inFilter, Action<UI_ListFilterItem, bool> inOnSelectedCallback); // 0x0000000180E7F960-0x0000000180E7F9A0
	private void ToggleBtnClicked_SelectFilter(bool inIsOn); // 0x0000000180E7F9A0-0x0000000180E7FA00
}

