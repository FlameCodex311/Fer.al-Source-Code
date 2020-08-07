/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class WWDragDelegator : MonoBehaviour, IInitializePotentialDragHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler // TypeDefIndex: 11292
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _horizontalDragTargetObject; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _verticalDragTargetObject; // 0x28
	private DragTarget _horizontalDragTarget; // 0x30
	private DragTarget _verticalDragTarget; // 0x38
	private DragTarget _currentDragTarget; // 0x40

	// Nested types
	private class DragTarget : IInitializePotentialDragHandler, IBeginDragHandler, IEndDragHandler, IDragHandler // TypeDefIndex: 11293
	{
		// Fields
		private IInitializePotentialDragHandler _initializePotentialDragHandler; // 0x10
		private IBeginDragHandler _beginDragHandler; // 0x18
		private IEndDragHandler _endDragHandler; // 0x20
		private IDragHandler _dragHandler; // 0x28
		private IScrollHandler _scrollHandler; // 0x30

		// Constructors
		public DragTarget(GameObject inSrc); // 0x00000001805CF320-0x00000001805CF430

		// Methods
		public void OnBeginDrag(PointerEventData eventData); // 0x00000001805CF190-0x00000001805CF1E0
		public void OnDrag(PointerEventData eventData); // 0x00000001805CF1E0-0x00000001805CF230
		public void OnEndDrag(PointerEventData eventData); // 0x00000001805CF230-0x00000001805CF280
		public void OnInitializePotentialDrag(PointerEventData eventData); // 0x00000001805CF280-0x00000001805CF2D0
		public void OnScroll(PointerEventData eventData); // 0x00000001805CF2D0-0x00000001805CF320
	}

	// Constructors
	public WWDragDelegator(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void OnEnable(); // 0x00000001805DEE20-0x00000001805DEF30
	public void OnInitializePotentialDrag(PointerEventData eventData); // 0x00000001805DEFB0-0x00000001805DF070
	public void OnBeginDrag(PointerEventData eventData); // 0x00000001805DEC20-0x00000001805DEDC0
	public void OnDrag(PointerEventData eventData); // 0x00000001805DEDC0-0x00000001805DEE20
	public void OnEndDrag(PointerEventData eventData); // 0x00000001805DEF30-0x00000001805DEFB0
	public void OnScroll(PointerEventData eventData); // 0x00000001805DF070-0x00000001805DF0D0
}

