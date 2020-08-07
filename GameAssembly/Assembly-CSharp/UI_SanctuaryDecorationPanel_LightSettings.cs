/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_SanctuaryDecorationPanel_LightSettings : MonoBehaviour // TypeDefIndex: 13736
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyItemList_SanctuaryLight _itemList; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private ConstrainedSlider _rotationSlider; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private ConstrainedSlider _brightnessSlider; // 0x30
	private SanctuaryLightDefComponent _currentLight; // 0x38

	// Constructors
	public UI_SanctuaryDecorationPanel_LightSettings(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Start(); // 0x00000001803DAB10-0x00000001803DACD0
	private void OnDestroy(); // 0x00000001803DA310-0x00000001803DA430
	private void OnLightItemSelected(SanctuaryLightDefComponent inSelectedLight); // 0x00000001803DA430-0x00000001803DA510
	private void OnSanctuaryIndoorRoom(SanctuaryIndoorRoomMessage inMessage); // 0x00000001803DA510-0x00000001803DA520
	private void OnRoomChange(); // 0x00000001803DA510-0x00000001803DA520
	private void RefreshSliders(); // 0x00000001803DA520-0x00000001803DA990
	public void SliderValueChanged_LightAngle(float inValue); // 0x00000001803DA990-0x00000001803DAA50
	public void SliderValueChanged_LightIntensity(float inValue); // 0x00000001803DAA50-0x00000001803DAB10
}

