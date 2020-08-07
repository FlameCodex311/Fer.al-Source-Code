/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[RequireComponent] // 0x0000000180245A40-0x0000000180245A90
public class UI_SliderSoundPlayer : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 13942
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioEmitter _sliderStartSound; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioEmitter _sliderEndSound; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Slider _slider; // 0x30

	// Constructors
	public UI_SliderSoundPlayer(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	public void OnPointerUp(PointerEventData eventData); // 0x00000001804CA310-0x00000001804CA390
	public void OnPointerDown(PointerEventData eventData); // 0x00000001804CA290-0x00000001804CA310
	public void OnPointerClick(PointerEventData eventData); // 0x00000001803774A0-0x00000001803774B0
	private void Reset(); // 0x00000001804CA390-0x00000001804CA3D0
}

