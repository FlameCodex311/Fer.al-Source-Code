/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_SpinWithMouse : MonoBehaviour, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler // TypeDefIndex: 13947
{
	// Fields
	public PointerEventData.InputButton inputButton; // 0x20
	public Transform target; // 0x28
	public float rotationSpeed; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _useX; // 0x34
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _useY; // 0x35
	[Range] // 0x00000001801D3630-0x00000001801D3650
	public float decelerationRate; // 0x38
	[SerializeField] // 0x0000000180247200-0x0000000180247250
	[Tooltip] // 0x0000000180247200-0x0000000180247250
	private LayerMask _deferCheckRaycastLayerMask; // 0x3C
	private Vector2 _velocity; // 0x40
	private bool _isDragging; // 0x48
	private int _lastDraggedFrame; // 0x4C

	// Constructors
	public UI_SpinWithMouse(); // 0x00000001804CBCB0-0x00000001804CBCD0

	// Methods
	public void OnInitializePotentialDrag(PointerEventData inEventData); // 0x00000001804CB680-0x00000001804CB870
	public void OnBeginDrag(PointerEventData inEventData); // 0x00000001804CB230-0x00000001804CB3E0
	public void OnDrag(PointerEventData inEventData); // 0x00000001804CB3E0-0x00000001804CB590
	public void OnEndDrag(PointerEventData inEventData); // 0x00000001804CB590-0x00000001804CB680
	public void SetRotation(Vector2 inRotation, float inDuration = 0f /* Metadata: 0x007BA5A4 */); // 0x00000001804CB870-0x00000001804CBA70
	private void Update(); // 0x00000001804CBB80-0x00000001804CBCB0
	private void UpdateRotation(); // 0x00000001804CBA70-0x00000001804CBB80
	private void ApplyDeceleration(); // 0x00000001804CB170-0x00000001804CB230
}

