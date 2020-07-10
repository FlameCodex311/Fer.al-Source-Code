/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[RequireComponent] // 0x000000018014C6F0-0x000000018014C740
public class UI_SliderSoundPlayer : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 12357
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioEmitter _sliderStartSound; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioEmitter _sliderEndSound; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Slider _slider; // 0x30

	// Constructors
	public UI_SliderSoundPlayer(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	public void OnPointerUp(PointerEventData eventData); // 0x0000000180EF51D0-0x0000000180EF5250
	public void OnPointerDown(PointerEventData eventData); // 0x0000000180EF5150-0x0000000180EF51D0
	public void OnPointerClick(PointerEventData eventData); // 0x00000001803581E0-0x00000001803581F0
	private void Reset(); // 0x0000000180EF5250-0x0000000180EF5290
}

