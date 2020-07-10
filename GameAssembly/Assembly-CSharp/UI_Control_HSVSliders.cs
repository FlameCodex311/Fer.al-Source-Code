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

public class UI_Control_HSVSliders : MonoBehaviour // TypeDefIndex: 12289
{
	// Fields
	[Header] // 0x000000018012C160-0x000000018012C1B0
	[SerializeField] // 0x000000018012C160-0x000000018012C1B0
	private Slider _sliderH; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _sliderHHandle; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private TMP_InputField _sliderHText; // 0x30
	[Header] // 0x000000018012C8A0-0x000000018012C8F0
	[SerializeField] // 0x000000018012C8A0-0x000000018012C8F0
	private Slider _sliderS; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _sliderSHandle; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private TMP_InputField _sliderSText; // 0x48
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UIGradient _sliderSGradient; // 0x50
	[Header] // 0x000000018012CF30-0x000000018012CF80
	[SerializeField] // 0x000000018012CF30-0x000000018012CF80
	private Slider _sliderV; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _sliderVHandle; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private TMP_InputField _sliderVText; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UIGradient _sliderVGradient; // 0x70
	[Header] // 0x000000018012D500-0x000000018012D550
	[SerializeField] // 0x000000018012D500-0x000000018012D550
	private TMP_InputField _hexInputField; // 0x78
	private HSVColor _hsvColor; // 0x80
	private Action<HSVColor> _onColorChanged; // 0xB8
	private bool _ignoreSliderChanges; // 0xC0
	private bool _firstSetup; // 0xC1

	// Properties
	public HSVColor HSVColor { get; set; } // 0x0000000180F2D4B0-0x0000000180F2D4F0 0x0000000180F2D4F0-0x0000000180F2D5D0

	// Constructors
	public UI_Control_HSVSliders(); // 0x0000000180F2D4A0-0x0000000180F2D4B0

	// Methods
	public void Setup(HSVColor inColor, Action<HSVColor> inOnColorChanged); // 0x0000000180F2D1C0-0x0000000180F2D4A0
	public void OnEndEdit_H(string inValue); // 0x0000000180F2C4F0-0x0000000180F2C5E0
	public void OnEndEdit_S(string inValue); // 0x0000000180F2C780-0x0000000180F2C870
	public void OnEndEdit_V(string inValue); // 0x0000000180F2C870-0x0000000180F2C960
	public void OnEndEdit_HexString(string inValue); // 0x0000000180F2C5E0-0x0000000180F2C780
	private void OnSliderChanged(float inValue); // 0x0000000180F2C960-0x0000000180F2CB50
	private void RefreshSliderValues(); // 0x0000000180F2D100-0x0000000180F2D1C0
	private void RefreshSliderDisplay(); // 0x0000000180F2CBE0-0x0000000180F2D100
	private void RefreshHexValue(); // 0x0000000180F2CB50-0x0000000180F2CBE0
}

