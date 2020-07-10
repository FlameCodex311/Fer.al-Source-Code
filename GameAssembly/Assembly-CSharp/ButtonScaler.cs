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

public class ButtonScaler : ManagedBehaviour, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 11920
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _targetScale; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _tweenTime; // 0x54
	[SerializeField] // 0x000000018015A590-0x000000018015A5D0
	[Tooltip] // 0x000000018015A590-0x000000018015A5D0
	private Transform _target; // 0x58
	[SerializeField] // 0x000000018015A7F0-0x000000018015A830
	[Tooltip] // 0x000000018015A7F0-0x000000018015A830
	private Selectable _selectable; // 0x60
	private float _defaultScale; // 0x68

	// Constructors
	public ButtonScaler(); // 0x0000000181020510-0x0000000181020570

	// Methods
	public override void Awake(); // 0x00000001810201C0-0x00000001810202B0
	public override void MOnEnable(); // 0x00000001810202B0-0x0000000181020380
	public void OnPointerDown(PointerEventData eventData); // 0x0000000181020450-0x00000001810204C0
	public void OnPointerUp(PointerEventData eventData); // 0x00000001810204C0-0x0000000181020510
	private void OnApplicationFocus(bool inIsFocused); // 0x0000000181020380-0x0000000181020450
}

