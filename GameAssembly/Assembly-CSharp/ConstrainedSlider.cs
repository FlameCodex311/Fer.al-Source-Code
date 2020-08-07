/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class ConstrainedSlider : MonoBehaviour // TypeDefIndex: 13517
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Slider _slider; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RectTransform _blockerLeft; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RectTransform _blockerRight; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _minValue; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _maxValue; // 0x3C
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _availableMin; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _availableMax; // 0x44
	private RectTransform _sliderRect; // 0x48

	// Properties
	public Slider Slider { get; } // 0x0000000180374AF0-0x0000000180374B00 
	private RectTransform SliderRect { get; } // 0x000000018077E940-0x000000018077E9E0 

	// Constructors
	public ConstrainedSlider(); // 0x000000018077E920-0x000000018077E940

	// Methods
	public void SetAvailableValues(float inMin, float inMax, float inAvailableMin, float inAvailableMax); // 0x000000018077E400-0x000000018077E500
	private void UpdateVisuals(); // 0x000000018077E500-0x000000018077E920
}

