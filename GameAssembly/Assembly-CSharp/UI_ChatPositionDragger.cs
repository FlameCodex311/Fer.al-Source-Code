/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_ChatPositionDragger : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler, IInitializePotentialDragHandler // TypeDefIndex: 13499
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RectTransform _bodyToDrag; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RectTransform _windowRect; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private DragFunction _dragFunction; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector2 _minSize; // 0x34
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UnityEvent _onClamp; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UnityEvent _onSizeChange; // 0x48
	public int anchorCornerIndex; // 0x50
	private Vector3 _lastPointerPosition; // 0x54
	private Vector3[] _bodyWorldCorners; // 0x60
	private Vector3[] _windowWorldCorners; // 0x68

	// Properties
	public DragFunction CurrentDragFunction { get; } // 0x00000001804AA650-0x00000001804AA660 

	// Nested types
	public enum DragFunction // TypeDefIndex: 13500
	{
		Position = 0,
		ResizeUp = 1,
		ResizeDown = 2,
		ResizeLeft = 3,
		ResizeRight = 4,
		ResizeDownRight = 5
	}

	// Constructors
	public UI_ChatPositionDragger(); // 0x0000000180545490-0x0000000180545530

	// Methods
	public void OnInitializePotentialDrag(PointerEventData eventData); // 0x0000000180545370-0x0000000180545490
	public void OnBeginDrag(PointerEventData eventData); // 0x00000001803774A0-0x00000001803774B0
	public void OnDrag(PointerEventData eventData); // 0x0000000180545100-0x0000000180545360
	public void OnEndDrag(PointerEventData eventData); // 0x0000000180545360-0x0000000180545370
	public void ClampPosition(bool inInstant = false /* Metadata: 0x007BA450 */); // 0x00000001805443E0-0x0000000180544AE0
	private void DoPositionDrag(Vector3 inDelta); // 0x0000000180544AE0-0x0000000180544BD0
	private void DoSizeDrag(Vector3 inDelta, DragFunction inResizeDirection); // 0x0000000180544BD0-0x0000000180545100
}

