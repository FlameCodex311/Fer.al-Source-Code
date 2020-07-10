/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_SpinWithMouse : MonoBehaviour, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler // TypeDefIndex: 12362
{
	// Fields
	public PointerEventData.InputButton inputButton; // 0x20
	public Transform target; // 0x28
	public float rotationSpeed; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _useX; // 0x34
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _useY; // 0x35
	[Range] // 0x00000001800C20E0-0x00000001800C2100
	public float decelerationRate; // 0x38
	[SerializeField] // 0x000000018014D960-0x000000018014D9B0
	[Tooltip] // 0x000000018014D960-0x000000018014D9B0
	private LayerMask _deferCheckRaycastLayerMask; // 0x3C
	private Vector2 _velocity; // 0x40
	private bool _isDragging; // 0x48

	// Constructors
	public UI_SpinWithMouse(); // 0x0000000180EF6BF0-0x0000000180EF6C10

	// Methods
	public void OnInitializePotentialDrag(PointerEventData inEventData); // 0x0000000180EF65C0-0x0000000180EF67B0
	public void OnBeginDrag(PointerEventData inEventData); // 0x0000000180EF61E0-0x0000000180EF6390
	public void OnDrag(PointerEventData inEventData); // 0x0000000180EF6390-0x0000000180EF6530
	public void OnEndDrag(PointerEventData inEventData); // 0x0000000180EF6530-0x0000000180EF65C0
	public void SetRotation(Vector2 inRotation, float inDuration = 0f /* Metadata: 0x00782E8D */); // 0x0000000180EF67B0-0x0000000180EF69B0
	private void Update(); // 0x0000000180EF6AC0-0x0000000180EF6BF0
	private void UpdateRotation(); // 0x0000000180EF69B0-0x0000000180EF6AC0
	private void ApplyDeceleration(); // 0x0000000180EF6120-0x0000000180EF61E0
}

