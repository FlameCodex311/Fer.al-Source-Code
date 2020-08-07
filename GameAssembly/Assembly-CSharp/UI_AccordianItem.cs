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

public class UI_AccordianItem : MonoBehaviour // TypeDefIndex: 13711
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _nameText; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _button; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RectTransform _rectTransform; // 0x30
	private Action<UI_AccordianItem> _onClicked; // 0x38

	// Properties
	public FeralButton Button { get; } // 0x000000018051B880-0x000000018051B900 
	public RectTransform RectTransform { get; } // 0x000000018051B900-0x000000018051B980 

	// Constructors
	public UI_AccordianItem(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Start(); // 0x000000018051B790-0x000000018051B880
	public void Setup(string inName, Action<UI_AccordianItem> inOnClicked); // 0x000000018051B750-0x000000018051B790
	public void MarkAsSelected(bool inIsSelected); // 0x000000018051B6E0-0x000000018051B710
	public void ClickItem(); // 0x000000018051B690-0x000000018051B6E0
	private void OnClicked(); // 0x000000018051B690-0x000000018051B6E0
	private void Reset(); // 0x000000018051B710-0x000000018051B750
}

