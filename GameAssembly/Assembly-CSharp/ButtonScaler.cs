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

public class ButtonScaler : ManagedBehaviour, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 13466
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _targetScale; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _tweenTime; // 0x54
	[SerializeField] // 0x00000001802425C0-0x0000000180242600
	[Tooltip] // 0x00000001802425C0-0x0000000180242600
	private Transform _target; // 0x58
	[SerializeField] // 0x0000000180242930-0x0000000180242970
	[Tooltip] // 0x0000000180242930-0x0000000180242970
	private Selectable _selectable; // 0x60
	private float _defaultScale; // 0x68

	// Constructors
	public ButtonScaler(); // 0x0000000180498CF0-0x0000000180498D50

	// Methods
	public override void Awake(); // 0x00000001804989A0-0x0000000180498A90
	public override void MOnEnable(); // 0x0000000180498A90-0x0000000180498B60
	public void OnPointerDown(PointerEventData eventData); // 0x0000000180498C30-0x0000000180498CA0
	public void OnPointerUp(PointerEventData eventData); // 0x0000000180498CA0-0x0000000180498CF0
	private void OnApplicationFocus(bool inIsFocused); // 0x0000000180498B60-0x0000000180498C30
}

