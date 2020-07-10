/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_CharmSlotCallout : MonoBehaviour // TypeDefIndex: 12287
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RectTransform _boundingRect; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UICalloutTail _calloutTail; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _charmSlotA; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _charmSlotB; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _target; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _moveSpeed; // 0x48
	private Camera _uiCamera; // 0x50
	private Vector2 _targetDirection; // 0x58
	private Vector2 _smoothedDirection; // 0x60

	// Properties
	public Transform Target { get; } // 0x0000000180369B30-0x0000000180369B40 

	// Constructors
	public UI_CharmSlotCallout(); // 0x0000000180F21AE0-0x0000000180F21B80

	// Methods
	public void SetTarget(Transform inTarget, Camera inTargetCamera); // 0x0000000180F20960-0x0000000180F20B80
	public void SetTargetDirection(Vector2 inTargetDirection); // 0x0000000180485C70-0x0000000180485C80
	private void Update(); // 0x0000000180F20B80-0x0000000180F21AE0
}

