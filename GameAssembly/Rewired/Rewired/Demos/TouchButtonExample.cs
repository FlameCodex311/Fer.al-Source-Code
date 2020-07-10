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
	[AddComponentMenu] // 0x0000000180103130-0x00000001801031B0
	[RequireComponent] // 0x0000000180103130-0x00000001801031B0
	public class TouchButtonExample : UnityEngine.MonoBehaviour, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 9231
	{
		// Fields
		public bool allowMouseControl; // 0x18
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <isPressed>k__BackingField; // 0x19
	
		// Properties
		public bool isPressed { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018048F440-0x000000018048F450 0x000000018048F560-0x000000018048F570
	
		// Constructors
		public TouchButtonExample(); // 0x00000001817BA9B0-0x00000001817BA9C0
	
		// Methods
		private void Awake(); // 0x0000000181BCB530-0x0000000181BCB550
		private void Restart(); // 0x0000000181BCB570-0x0000000181BCB580
		void IPointerDownHandler.OnPointerDown(PointerEventData eventData); // 0x0000000181BCB580-0x0000000181BCB5C0
		void IPointerUpHandler.OnPointerUp(PointerEventData eventData); // 0x0000000181BCB5C0-0x0000000181BCB600
		private static bool IsMousePointerId(int id); // 0x0000000181BCB550-0x0000000181BCB570
	}
}
