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
	[AddComponentMenu] // 0x00000001802624B0-0x0000000180262530
	[RequireComponent] // 0x00000001802624B0-0x0000000180262530
	public class TouchButtonExample : UnityEngine.MonoBehaviour, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 9397
	{
		// Fields
		public bool allowMouseControl; // 0x18
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <isPressed>k__BackingField; // 0x19
	
		// Properties
		public bool isPressed { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180690340-0x0000000180690350 0x0000000180878500-0x0000000180878510
	
		// Constructors
		public TouchButtonExample(); // 0x000000018100CA10-0x000000018100CA20
	
		// Methods
		private void Awake(); // 0x000000018106D170-0x000000018106D190
		private void Restart(); // 0x000000018106D1B0-0x000000018106D1C0
		void IPointerDownHandler.OnPointerDown(PointerEventData eventData); // 0x000000018106D1C0-0x000000018106D200
		void IPointerUpHandler.OnPointerUp(PointerEventData eventData); // 0x000000018106D200-0x000000018106D240
		private static bool IsMousePointerId(int id); // 0x000000018106D190-0x000000018106D1B0
	}
}
