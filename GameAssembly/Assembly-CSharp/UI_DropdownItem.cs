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

public class UI_DropdownItem : MonoBehaviour // TypeDefIndex: 13886
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWButton _button; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _text; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _iconImage; // 0x30
	private DropdownItemInfo _info; // 0x38
	private Action<UI_DropdownItem> _onClickedAction; // 0x40

	// Properties
	public WWButton Button { get; } // 0x0000000180374AF0-0x0000000180374B00 
	public DropdownItemInfo Info { get; } // 0x00000001803743D0-0x00000001803743E0 

	// Constructors
	public UI_DropdownItem(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	public void Setup(DropdownItemInfo inInfo, Action<UI_DropdownItem> inOnClickedAction = null); // 0x00000001803748B0-0x0000000180374A60
	private void Start(); // 0x0000000180374A60-0x0000000180374AF0
	private void OnClick(); // 0x0000000180374860-0x00000001803748B0
}

