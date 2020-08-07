/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Control_EyeSizeSlider : UI_CustomizationControl // TypeDefIndex: 13522
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private ConstrainedSlider _slider; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private EyeScaleType _scaleType; // 0x28

	// Properties
	private ActorInfo ActorInfo { get; } // 0x0000000180549D30-0x0000000180549D80 

	// Nested types
	private enum EyeScaleType // TypeDefIndex: 13523
	{
		Shape = 0,
		Pupil = 1
	}

	// Constructors
	public UI_Control_EyeSizeSlider(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void OnEnable(); // 0x00000001805499D0-0x00000001805499E0
	private void Reset(); // 0x00000001805499E0-0x0000000180549A20
	private void SliderValueChanged_Scale(float inScale); // 0x0000000180549C40-0x0000000180549D30
	public override bool CheckIsValid(); // 0x0000000180549970-0x00000001805499D0
	public void Setup(); // 0x0000000180549A20-0x0000000180549C40
}

