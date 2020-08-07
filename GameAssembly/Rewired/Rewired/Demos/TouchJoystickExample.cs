/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 79: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9355-9437

namespace Rewired.Demos
{
	[AddComponentMenu] // 0x0000000180262F50-0x0000000180262FD0
	[RequireComponent] // 0x0000000180262F50-0x0000000180262FD0
	public class TouchJoystickExample : UnityEngine.MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler // TypeDefIndex: 9398
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
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector2 <position>k__BackingField; // 0x48
	
		// Properties
		public Vector2 position { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018106E630-0x000000018106E650 0x00000001804ADAE0-0x00000001804ADAF0
	
		// Constructors
		public TouchJoystickExample(); // 0x000000018106E610-0x000000018106E630
	
		// Methods
		private void Start(); // 0x000000018106E020-0x000000018106E050
		private void Update(); // 0x000000018106E5B0-0x000000018106E610
		private void Restart(); // 0x000000018106DF60-0x000000018106E020
		private void StoreOrigValues(); // 0x000000018106E050-0x000000018106E160
		private void UpdateValue(Vector3 value); // 0x000000018106E480-0x000000018106E5B0
		void IPointerDownHandler.OnPointerDown(PointerEventData eventData); // 0x000000018106E3D0-0x000000018106E430
		void IPointerUpHandler.OnPointerUp(PointerEventData eventData); // 0x000000018106E430-0x000000018106E480
		void IDragHandler.OnDrag(PointerEventData eventData); // 0x000000018106E160-0x000000018106E3D0
		private static bool IsMousePointerId(int id); // 0x000000018106D190-0x000000018106D1B0
	}
}
