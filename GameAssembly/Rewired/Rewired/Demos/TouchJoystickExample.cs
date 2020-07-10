/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 78: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9189-9271

namespace Rewired.Demos
{
	[AddComponentMenu] // 0x0000000180103920-0x00000001801039A0
	[RequireComponent] // 0x0000000180103920-0x00000001801039A0
	public class TouchJoystickExample : UnityEngine.MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler // TypeDefIndex: 9232
	{
		// Fields
		public bool allowMouseControl; // 0x18
		public int radius; // 0x1C
		private Vector2 origAnchoredPosition; // 0x20
		private Vector3 origWorldPosition; // 0x28
		private Vector2 origScreenResolution; // 0x34
		private ScreenOrientation origScreenOrientation; // 0x3C
		[NonSerialized]
		private bool hasFinger; // 0x40
		[NonSerialized]
		private int lastFingerId; // 0x44
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector2 <position>k__BackingField; // 0x48
	
		// Properties
		public Vector2 position { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000181BCCA00-0x0000000181BCCA20 0x00000001803A27F0-0x00000001803A2800
	
		// Constructors
		public TouchJoystickExample(); // 0x0000000181BCC9E0-0x0000000181BCCA00
	
		// Methods
		private void Start(); // 0x0000000181BCC3F0-0x0000000181BCC420
		private void Update(); // 0x0000000181BCC980-0x0000000181BCC9E0
		private void Restart(); // 0x0000000181BCC330-0x0000000181BCC3F0
		private void StoreOrigValues(); // 0x0000000181BCC420-0x0000000181BCC530
		private void UpdateValue(Vector3 value); // 0x0000000181BCC850-0x0000000181BCC980
		void IPointerDownHandler.OnPointerDown(PointerEventData eventData); // 0x0000000181BCC7A0-0x0000000181BCC800
		void IPointerUpHandler.OnPointerUp(PointerEventData eventData); // 0x0000000181BCC800-0x0000000181BCC850
		void IDragHandler.OnDrag(PointerEventData eventData); // 0x0000000181BCC530-0x0000000181BCC7A0
		private static bool IsMousePointerId(int id); // 0x0000000181BCB550-0x0000000181BCB570
	}
}
