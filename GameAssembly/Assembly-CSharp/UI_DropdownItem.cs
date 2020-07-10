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

public class UI_DropdownItem : MonoBehaviour // TypeDefIndex: 12302
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWButton _button; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _text; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _iconImage; // 0x30
	private DropdownItemInfo _info; // 0x38
	private Action<UI_DropdownItem> _onClickedAction; // 0x40

	// Properties
	public WWButton Button { get; } // 0x000000018036AC70-0x000000018036AC80 
	public DropdownItemInfo Info { get; } // 0x0000000180369BB0-0x0000000180369BC0 

	// Constructors
	public UI_DropdownItem(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	public void Setup(DropdownItemInfo inInfo, Action<UI_DropdownItem> inOnClickedAction = null); // 0x0000000180F33520-0x0000000180F336E0
	private void Start(); // 0x0000000180F336E0-0x0000000180F33770
	private void OnClick(); // 0x0000000180F334D0-0x0000000180F33520
}

