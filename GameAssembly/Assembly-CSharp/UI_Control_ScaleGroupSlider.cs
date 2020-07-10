/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Control_ScaleGroupSlider : UI_CustomizationControl // TypeDefIndex: 11978
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private ConstrainedSlider _slider; // 0x20
	[RootSelector] // 0x00000001800B6300-0x00000001800B6370
	[SerializeField] // 0x00000001800B6300-0x00000001800B6370
	private string _scaleGroupId; // 0x28
	private ActorInfoScaleGroup _scaleGroup; // 0x30
	private bool _firstSetup; // 0x38

	// Properties
	private ActorInfoScaleGroup ScaleGroup { get; } // 0x0000000180F2DD90-0x0000000180F2DE10 
	private ActorInfo ActorInfo { get; } // 0x0000000180F2DCE0-0x0000000180F2DD30 
	private bool DesignMode { get; } // 0x0000000180F2DD30-0x0000000180F2DD90 

	// Constructors
	public UI_Control_ScaleGroupSlider(); // 0x0000000180F2DC90-0x0000000180F2DCE0

	// Methods
	private void OnEnable(); // 0x0000000180F2D900-0x0000000180F2DA20
	private void OnDisable(); // 0x0000000180F2D7A0-0x0000000180F2D900
	private void Reset(); // 0x0000000180F2DA20-0x0000000180F2DA60
	private void SliderValueChanged_Scale(float inScale); // 0x0000000180F2DC40-0x0000000180F2DC90
	private void OnBodyPartSet(ActorInfoBodyPart inBodyPart); // 0x0000000180F2D790-0x0000000180F2D7A0
	public override bool CheckIsValid(); // 0x0000000180F2D5D0-0x0000000180F2D790
	public void Setup(); // 0x0000000180F2DA60-0x0000000180F2DC40
}

