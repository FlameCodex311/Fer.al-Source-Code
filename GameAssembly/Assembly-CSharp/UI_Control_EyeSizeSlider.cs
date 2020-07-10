/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Control_EyeSizeSlider : UI_CustomizationControl // TypeDefIndex: 11976
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private ConstrainedSlider _slider; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private EyeScaleType _scaleType; // 0x28

	// Properties
	private ActorInfo ActorInfo { get; } // 0x0000000180F2C4A0-0x0000000180F2C4F0 

	// Nested types
	private enum EyeScaleType // TypeDefIndex: 11977
	{
		Shape = 0,
		Pupil = 1
	}

	// Constructors
	public UI_Control_EyeSizeSlider(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void OnEnable(); // 0x0000000180F2C130-0x0000000180F2C140
	private void Reset(); // 0x0000000180F2C140-0x0000000180F2C180
	private void SliderValueChanged_Scale(float inScale); // 0x0000000180F2C3B0-0x0000000180F2C4A0
	public override bool CheckIsValid(); // 0x0000000180F2C0D0-0x0000000180F2C130
	public void Setup(); // 0x0000000180F2C180-0x0000000180F2C3B0
}

