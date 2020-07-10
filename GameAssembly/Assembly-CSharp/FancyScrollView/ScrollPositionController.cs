/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace FancyScrollView
{
	public class ScrollPositionController : UIBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler // TypeDefIndex: 15880
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private RectTransform viewport; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ScrollDirection directionOfRecognize; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public MovementType movementType; // 0x24
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float elasticity; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float scrollSensitivity; // 0x2C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool inertia; // 0x30
		[SerializeField] // 0x00000001800B7900-0x00000001800B7940
		[Tooltip] // 0x00000001800B7900-0x00000001800B7940
		private float decelerationRate; // 0x34
		[SerializeField] // 0x00000001800B7900-0x00000001800B7940
		[Tooltip] // 0x00000001800B7900-0x00000001800B7940
		private Snap snap; // 0x38
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
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
		private enum ScrollDirection // TypeDefIndex: 15881
		{
			Vertical = 0,
			Horizontal = 1
		}
	
		public enum MovementType // TypeDefIndex: 15882
		{
			Unrestricted = 0,
			Elastic = 1,
			Clamped = 2
		}
	
		[Serializable]
		private struct Snap // TypeDefIndex: 15883
		{
			// Fields
			public bool Enable; // 0x00
			public float VelocityThreshold; // 0x04
			public float Duration; // 0x08
		}
	
		private class AutoScrollState // TypeDefIndex: 15884
		{
			// Fields
			public bool Enable; // 0x10
			public bool Elastic; // 0x11
			public float Duration; // 0x14
			public float StartTime; // 0x18
			public float EndScrollPosition; // 0x1C
	
			// Constructors
			public AutoScrollState(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			public void Reset(); // 0x000000018148C180-0x000000018148C190
		}
	
		// Constructors
		public ScrollPositionController(); // 0x00000001814AA4D0-0x00000001814AA590
	
		// Methods
		public void OnUpdatePosition(Action<float> onUpdatePosition); // 0x0000000180485C70-0x0000000180485C80
		public void OnItemSelected(Action<int> onItemSelected); // 0x00000001803A27E0-0x00000001803A27F0
		public void SetDataCount(int dataCount, bool inPaddingNeeded = false /* Metadata: 0x00784FAF */); // 0x00000001814A9790-0x00000001814A97B0
		public void ScrollTo(int index, float duration); // 0x00000001814A95B0-0x00000001814A9790
		public void JumpTo(int index); // 0x00000001814A9440-0x00000001814A9510
		void IBeginDragHandler.OnBeginDrag(PointerEventData eventData); // 0x00000001814A97B0-0x00000001814A98F0
		void IDragHandler.OnDrag(PointerEventData eventData); // 0x00000001814A98F0-0x00000001814A9C20
		void IEndDragHandler.OnEndDrag(PointerEventData eventData); // 0x00000001814A9C20-0x00000001814A9C50
		private float GetViewportSize(); // 0x00000001814A9350-0x00000001814A93F0
		private float CalculateOffset(float position); // 0x00000001814A9260-0x00000001814A92A0
		private void UpdatePosition(float position); // 0x00000001814A9C50-0x00000001814A9CB0
		private void ItemSelected(int index); // 0x00000001814A93F0-0x00000001814A9440
		private float RubberDelta(float overStretching, float viewSize); // 0x00000001814A9510-0x00000001814A95B0
		private void Update(); // 0x00000001814A9CB0-0x00000001814AA4D0
		private int CalculateDestinationIndex(int index); // 0x00000001814A91D0-0x00000001814A9260
		private int CalculateClosestIndex(int index); // 0x00000001814A9050-0x00000001814A91D0
		private float GetCircularPosition(float position, int length); // 0x00000001814A9300-0x00000001814A9350
		private float EaseInOutCubic(float start, float end, float value); // 0x00000001814A92A0-0x00000001814A9300
	}
}
