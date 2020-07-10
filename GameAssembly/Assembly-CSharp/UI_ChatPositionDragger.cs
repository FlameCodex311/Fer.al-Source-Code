/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_ChatPositionDragger : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler, IInitializePotentialDragHandler // TypeDefIndex: 11953
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RectTransform _bodyToDrag; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RectTransform _windowRect; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private DragFunction _dragFunction; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector2 _minSize; // 0x34
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UnityEvent _onClamp; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UnityEvent _onSizeChange; // 0x48
	public int anchorCornerIndex; // 0x50
	private Vector3 _lastPointerPosition; // 0x54
	private Vector3[] _bodyWorldCorners; // 0x60
	private Vector3[] _windowWorldCorners; // 0x68

	// Properties
	public DragFunction CurrentDragFunction { get; } // 0x000000018043DDC0-0x000000018043DDD0 

	// Nested types
	public enum DragFunction // TypeDefIndex: 11954
	{
		Position = 0,
		ResizeUp = 1,
		ResizeDown = 2,
		ResizeLeft = 3,
		ResizeRight = 4,
		ResizeDownRight = 5
	}

	// Constructors
	public UI_ChatPositionDragger(); // 0x0000000180F27A70-0x0000000180F27B10

	// Methods
	public void OnInitializePotentialDrag(PointerEventData eventData); // 0x0000000180F27950-0x0000000180F27A70
	public void OnBeginDrag(PointerEventData eventData); // 0x00000001803581E0-0x00000001803581F0
	public void OnDrag(PointerEventData eventData); // 0x0000000180F276E0-0x0000000180F27940
	public void OnEndDrag(PointerEventData eventData); // 0x0000000180F27940-0x0000000180F27950
	public void ClampPosition(bool inInstant = false /* Metadata: 0x00782D42 */); // 0x0000000180F26960-0x0000000180F270C0
	private void DoPositionDrag(Vector3 inDelta); // 0x0000000180F270C0-0x0000000180F271B0
	private void DoSizeDrag(Vector3 inDelta, DragFunction inResizeDirection); // 0x0000000180F271B0-0x0000000180F276E0
}

