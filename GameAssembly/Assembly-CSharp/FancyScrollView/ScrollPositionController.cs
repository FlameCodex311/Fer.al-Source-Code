/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace FancyScrollView
{
	public class ScrollPositionController : UIBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler // TypeDefIndex: 14327
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private RectTransform viewport; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ScrollDirection directionOfRecognize; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public MovementType movementType; // 0x24
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float elasticity; // 0x28
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float scrollSensitivity; // 0x2C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool inertia; // 0x30
		[SerializeField] // 0x00000001802146F0-0x0000000180214730
		[Tooltip] // 0x00000001802146F0-0x0000000180214730
		private float decelerationRate; // 0x34
		[SerializeField] // 0x00000001802146F0-0x0000000180214730
		[Tooltip] // 0x00000001802146F0-0x0000000180214730
		private Snap snap; // 0x38
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int dataCount; // 0x44
		private float _cellPadding; // 0x48
		private readonly AutoScrollState autoScrollState; // 0x50
		private Action<float> onUpdatePosition; // 0x58
		private Action<int> onItemSelected; // 0x60
		private Vector2 pointerStartLocalPosition; // 0x68
		private float dragStartScrollPosition; // 0x70
		private float prevScrollPosition; // 0x74
		private float currentScrollPosition; // 0x78
		private bool dragging; // 0x7C
		private float velocity; // 0x80
	
		// Nested types
		private enum ScrollDirection // TypeDefIndex: 14328
		{
			Vertical = 0,
			Horizontal = 1
		}
	
		public enum MovementType // TypeDefIndex: 14329
		{
			Unrestricted = 0,
			Elastic = 1,
			Clamped = 2
		}
	
		[Serializable]
		private struct Snap // TypeDefIndex: 14330
		{
			// Fields
			public bool Enable; // 0x00
			public float VelocityThreshold; // 0x04
			public float Duration; // 0x08
		}
	
		private class AutoScrollState // TypeDefIndex: 14331
		{
			// Fields
			public bool Enable; // 0x10
			public bool Elastic; // 0x11
			public float Duration; // 0x14
			public float StartTime; // 0x18
			public float EndScrollPosition; // 0x1C
	
			// Constructors
			public AutoScrollState(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			public void Reset(); // 0x0000000180E1FDD0-0x0000000180E1FDE0
		}
	
		// Constructors
		public ScrollPositionController(); // 0x0000000180E3A660-0x0000000180E3A720
	
		// Methods
		public void OnUpdatePosition(Action<float> onUpdatePosition); // 0x00000001803A1740-0x00000001803A1750
		public void OnItemSelected(Action<int> onItemSelected); // 0x00000001804AF510-0x00000001804AF520
		public void SetDataCount(int dataCount, bool inPaddingNeeded = false /* Metadata: 0x007BA767 */); // 0x0000000180E39930-0x0000000180E39950
		public void ScrollTo(int index, float duration); // 0x0000000180E39750-0x0000000180E39930
		public void JumpTo(int index); // 0x0000000180E395E0-0x0000000180E396B0
		void IBeginDragHandler.OnBeginDrag(PointerEventData eventData); // 0x0000000180E39950-0x0000000180E39A90
		void IDragHandler.OnDrag(PointerEventData eventData); // 0x0000000180E39A90-0x0000000180E39DC0
		void IEndDragHandler.OnEndDrag(PointerEventData eventData); // 0x0000000180E39DC0-0x0000000180E39DF0
		private float GetViewportSize(); // 0x0000000180E39500-0x0000000180E39590
		private float CalculateOffset(float position); // 0x0000000180E39410-0x0000000180E39450
		private void UpdatePosition(float position); // 0x0000000180E39DF0-0x0000000180E39E50
		private void ItemSelected(int index); // 0x0000000180E39590-0x0000000180E395E0
		private float RubberDelta(float overStretching, float viewSize); // 0x0000000180E396B0-0x0000000180E39750
		private void Update(); // 0x0000000180E39E50-0x0000000180E3A660
		private int CalculateDestinationIndex(int index); // 0x0000000180E39380-0x0000000180E39410
		private int CalculateClosestIndex(int index); // 0x0000000180E39200-0x0000000180E39380
		private float GetCircularPosition(float position, int length); // 0x0000000180E394B0-0x0000000180E39500
		private float EaseInOutCubic(float start, float end, float value); // 0x0000000180E39450-0x0000000180E394B0
	}
}
