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

public class UI_AccordianItem : MonoBehaviour // TypeDefIndex: 12164
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _nameText; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _button; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RectTransform _rectTransform; // 0x30
	private Action<UI_AccordianItem> _onClicked; // 0x38

	// Properties
	public FeralButton Button { get; } // 0x0000000180FB69C0-0x0000000180FB6A40 
	public RectTransform RectTransform { get; } // 0x0000000180FB6A40-0x0000000180FB6AC0 

	// Constructors
	public UI_AccordianItem(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Start(); // 0x0000000180FB68C0-0x0000000180FB69C0
	public void Setup(string inName, Action<UI_AccordianItem> inOnClicked); // 0x0000000180FB6880-0x0000000180FB68C0
	public void MarkAsSelected(bool inIsSelected); // 0x0000000180FB6810-0x0000000180FB6840
	public void ClickItem(); // 0x0000000180FB67C0-0x0000000180FB6810
	private void OnClicked(); // 0x0000000180FB67C0-0x0000000180FB6810
	private void Reset(); // 0x0000000180FB6840-0x0000000180FB6880
}

