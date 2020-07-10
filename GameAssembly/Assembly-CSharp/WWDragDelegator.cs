/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class WWDragDelegator : MonoBehaviour, IInitializePotentialDragHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler // TypeDefIndex: 13625
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _horizontalDragTargetObject; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _verticalDragTargetObject; // 0x28
	private DragTarget _horizontalDragTarget; // 0x30
	private DragTarget _verticalDragTarget; // 0x38
	private DragTarget _currentDragTarget; // 0x40

	// Nested types
	private class DragTarget : IInitializePotentialDragHandler, IBeginDragHandler, IEndDragHandler, IDragHandler // TypeDefIndex: 13626
	{
		// Fields
		private IInitializePotentialDragHandler _initializePotentialDragHandler; // 0x10
		private IBeginDragHandler _beginDragHandler; // 0x18
		private IEndDragHandler _endDragHandler; // 0x20
		private IDragHandler _dragHandler; // 0x28
		private IScrollHandler _scrollHandler; // 0x30

		// Constructors
		public DragTarget(GameObject inSrc); // 0x0000000180FE5A60-0x0000000180FE5B70

		// Methods
		public void OnBeginDrag(PointerEventData eventData); // 0x0000000180FE58D0-0x0000000180FE5920
		public void OnDrag(PointerEventData eventData); // 0x0000000180FE5920-0x0000000180FE5970
		public void OnEndDrag(PointerEventData eventData); // 0x0000000180FE5970-0x0000000180FE59C0
		public void OnInitializePotentialDrag(PointerEventData eventData); // 0x0000000180FE59C0-0x0000000180FE5A10
		public void OnScroll(PointerEventData eventData); // 0x0000000180FE5A10-0x0000000180FE5A60
	}

	// Constructors
	public WWDragDelegator(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void OnEnable(); // 0x0000000180FF7A30-0x0000000180FF7B40
	public void OnInitializePotentialDrag(PointerEventData eventData); // 0x0000000180FF7BC0-0x0000000180FF7C80
	public void OnBeginDrag(PointerEventData eventData); // 0x0000000180FF7830-0x0000000180FF79D0
	public void OnDrag(PointerEventData eventData); // 0x0000000180FF79D0-0x0000000180FF7A30
	public void OnEndDrag(PointerEventData eventData); // 0x0000000180FF7B40-0x0000000180FF7BC0
	public void OnScroll(PointerEventData eventData); // 0x0000000180FF7C80-0x0000000180FF7CE0
}

