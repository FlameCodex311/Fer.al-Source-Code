/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_SanctuaryDecorationPanel_LightSettings : MonoBehaviour // TypeDefIndex: 12189
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyItemList_SanctuaryLight _itemList; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private ConstrainedSlider _rotationSlider; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private ConstrainedSlider _brightnessSlider; // 0x30
	private SanctuaryLightDefComponent _currentLight; // 0x38

	// Constructors
	public UI_SanctuaryDecorationPanel_LightSettings(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Start(); // 0x0000000180EEB8A0-0x0000000180EEBA60
	private void OnDestroy(); // 0x0000000180EEB080-0x0000000180EEB1A0
	private void OnLightItemSelected(SanctuaryLightDefComponent inSelectedLight); // 0x0000000180EEB1A0-0x0000000180EEB280
	private void OnSanctuaryIndoorRoom(SanctuaryIndoorRoomMessage inMessage); // 0x0000000180EEB280-0x0000000180EEB290
	private void OnRoomChange(); // 0x0000000180EEB280-0x0000000180EEB290
	private void RefreshSliders(); // 0x0000000180EEB290-0x0000000180EEB720
	public void SliderValueChanged_LightAngle(float inValue); // 0x0000000180EEB720-0x0000000180EEB7E0
	public void SliderValueChanged_LightIntensity(float inValue); // 0x0000000180EEB7E0-0x0000000180EEB8A0
}

