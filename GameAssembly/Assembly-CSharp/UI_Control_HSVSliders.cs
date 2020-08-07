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

public class UI_Control_HSVSliders : MonoBehaviour // TypeDefIndex: 13873
{
	// Fields
	[Header] // 0x0000000180223670-0x00000001802236C0
	[SerializeField] // 0x0000000180223670-0x00000001802236C0
	private Slider _sliderH; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _sliderHHandle; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private TMP_InputField _sliderHText; // 0x30
	[Header] // 0x00000001802239F0-0x0000000180223A40
	[SerializeField] // 0x00000001802239F0-0x0000000180223A40
	private Slider _sliderS; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _sliderSHandle; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private TMP_InputField _sliderSText; // 0x48
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UIGradient _sliderSGradient; // 0x50
	[Header] // 0x0000000180224040-0x0000000180224090
	[SerializeField] // 0x0000000180224040-0x0000000180224090
	private Slider _sliderV; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _sliderVHandle; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private TMP_InputField _sliderVText; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UIGradient _sliderVGradient; // 0x70
	[Header] // 0x0000000180225A00-0x0000000180225A50
	[SerializeField] // 0x0000000180225A00-0x0000000180225A50
	private TMP_InputField _hexInputField; // 0x78
	private HSVColor _hsvColor; // 0x80
	private Action<HSVColor> _onColorChanged; // 0xB8
	private bool _ignoreSliderChanges; // 0xC0
	private bool _firstSetup; // 0xC1

	// Properties
	public HSVColor HSVColor { get; set; } // 0x0000000180523CA0-0x0000000180523CE0 0x000000018054AD00-0x000000018054ADE0

	// Constructors
	public UI_Control_HSVSliders(); // 0x000000018054ACF0-0x000000018054AD00

	// Methods
	public void Setup(HSVColor inColor, Action<HSVColor> inOnColorChanged); // 0x000000018054AA20-0x000000018054ACF0
	public void OnEndEdit_H(string inValue); // 0x0000000180549D80-0x0000000180549E70
	public void OnEndEdit_S(string inValue); // 0x000000018054A010-0x000000018054A100
	public void OnEndEdit_V(string inValue); // 0x000000018054A100-0x000000018054A1F0
	public void OnEndEdit_HexString(string inValue); // 0x0000000180549E70-0x000000018054A010
	private void OnSliderChanged(float inValue); // 0x000000018054A1F0-0x000000018054A3E0
	private void RefreshSliderValues(); // 0x000000018054A970-0x000000018054AA20
	private void RefreshSliderDisplay(); // 0x000000018054A470-0x000000018054A970
	private void RefreshHexValue(); // 0x000000018054A3E0-0x000000018054A470
}

