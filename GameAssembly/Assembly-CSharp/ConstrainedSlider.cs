/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class ConstrainedSlider : MonoBehaviour // TypeDefIndex: 11971
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Slider _slider; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RectTransform _blockerLeft; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RectTransform _blockerRight; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _minValue; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _maxValue; // 0x3C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _availableMin; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _availableMax; // 0x44
	private RectTransform _sliderRect; // 0x48

	// Properties
	public Slider Slider { get; } // 0x000000018036AC70-0x000000018036AC80 
	private RectTransform SliderRect { get; } // 0x0000000181473270-0x0000000181473310 

	// Constructors
	public ConstrainedSlider(); // 0x0000000181473250-0x0000000181473270

	// Methods
	public void SetAvailableValues(float inMin, float inMax, float inAvailableMin, float inAvailableMax); // 0x0000000181472D10-0x0000000181472E10
	private void UpdateVisuals(); // 0x0000000181472E10-0x0000000181473250
}

