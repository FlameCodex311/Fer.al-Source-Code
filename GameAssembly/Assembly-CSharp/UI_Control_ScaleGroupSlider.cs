/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Control_ScaleGroupSlider : UI_CustomizationControl // TypeDefIndex: 13524
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private ConstrainedSlider _slider; // 0x20
	[RootSelector] // 0x0000000180259840-0x00000001802598B0
	[SerializeField] // 0x0000000180259840-0x00000001802598B0
	private string _scaleGroupId; // 0x28
	private ActorInfoScaleGroup _scaleGroup; // 0x30
	private bool _firstSetup; // 0x38

	// Properties
	private ActorInfoScaleGroup ScaleGroup { get; } // 0x000000018054B580-0x000000018054B600 
	private ActorInfo ActorInfo { get; } // 0x000000018054B4D0-0x000000018054B520 
	private bool DesignMode { get; } // 0x000000018054B520-0x000000018054B580 

	// Constructors
	public UI_Control_ScaleGroupSlider(); // 0x000000018054B480-0x000000018054B4D0

	// Methods
	private void OnEnable(); // 0x000000018054B100-0x000000018054B220
	private void OnDisable(); // 0x000000018054AFA0-0x000000018054B100
	private void Reset(); // 0x000000018054B220-0x000000018054B260
	private void SliderValueChanged_Scale(float inScale); // 0x000000018054B430-0x000000018054B480
	private void OnBodyPartSet(ActorInfoBodyPart inBodyPart); // 0x000000018054AF90-0x000000018054AFA0
	public override bool CheckIsValid(); // 0x000000018054ADE0-0x000000018054AF90
	public void Setup(); // 0x000000018054B260-0x000000018054B430
}

