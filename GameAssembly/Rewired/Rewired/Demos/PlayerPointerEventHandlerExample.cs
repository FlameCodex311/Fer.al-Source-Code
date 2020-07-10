/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired.Integration.UnityUI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 78: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9189-9271

namespace Rewired.Demos
{
	[AddComponentMenu] // 0x00000001800B75F0-0x00000001800B7620
	public sealed class PlayerPointerEventHandlerExample : UnityEngine.MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerUpHandler, IPointerDownHandler, IPointerClickHandler, IScrollHandler, IBeginDragHandler, IDragHandler, IEndDragHandler // TypeDefIndex: 9239
	{
		// Fields
		public UnityEngine.UI.Text text; // 0x18
		private const int logLength = 10; // Metadata: 0x00744DE9
		private List<string> log; // 0x20
	
		// Constructors
		public PlayerPointerEventHandlerExample(); // 0x00000001815BCAD0-0x00000001815BCB30
	
		// Methods
		private void Log(string o); // 0x00000001815B95B0-0x00000001815B9640
		private void Update(); // 0x00000001815BC8E0-0x00000001815BCAD0
		public void OnPointerEnter(PointerEventData eventData); // 0x00000001815BB3A0-0x00000001815BB8C0
		public void OnPointerExit(PointerEventData eventData); // 0x00000001815BB8C0-0x00000001815BBDE0
		public void OnPointerUp(PointerEventData eventData); // 0x00000001815BBDE0-0x00000001815BC3C0
		public void OnPointerDown(PointerEventData eventData); // 0x00000001815BADC0-0x00000001815BB3A0
		public void OnPointerClick(PointerEventData eventData); // 0x00000001815BA7E0-0x00000001815BADC0
		public void OnScroll(PointerEventData eventData); // 0x00000001815BC3C0-0x00000001815BC8E0
		public void OnBeginDrag(PointerEventData eventData); // 0x00000001815B9640-0x00000001815B9C20
		public void OnDrag(PointerEventData eventData); // 0x00000001815B9C20-0x00000001815BA200
		public void OnEndDrag(PointerEventData eventData); // 0x00000001815BA200-0x00000001815BA7E0
		private static string GetSourceName(PlayerPointerEventData playerEventData); // 0x00000001815B93E0-0x00000001815B95B0
	}
}
