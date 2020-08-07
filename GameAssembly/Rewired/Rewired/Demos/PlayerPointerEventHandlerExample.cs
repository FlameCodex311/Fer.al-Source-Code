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

// Image 79: Rewired.dll - Assembly: Rewired, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9355-9437

namespace Rewired.Demos
{
	[AddComponentMenu] // 0x0000000180213020-0x0000000180213050
	public sealed class PlayerPointerEventHandlerExample : UnityEngine.MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerUpHandler, IPointerDownHandler, IPointerClickHandler, IScrollHandler, IBeginDragHandler, IDragHandler, IEndDragHandler // TypeDefIndex: 9405
	{
		// Fields
		public UnityEngine.UI.Text text; // 0x18
		private const int logLength = 10; // Metadata: 0x00779AD7
		private List<string> log; // 0x20
	
		// Constructors
		public PlayerPointerEventHandlerExample(); // 0x0000000180DD7020-0x0000000180DD7080
	
		// Methods
		private void Log(string o); // 0x0000000180DD3CB0-0x0000000180DD3D40
		private void Update(); // 0x0000000180DD6E30-0x0000000180DD7020
		public void OnPointerEnter(PointerEventData eventData); // 0x0000000180DD59B0-0x0000000180DD5EA0
		public void OnPointerExit(PointerEventData eventData); // 0x0000000180DD5EA0-0x0000000180DD6390
		public void OnPointerUp(PointerEventData eventData); // 0x0000000180DD6390-0x0000000180DD6940
		public void OnPointerDown(PointerEventData eventData); // 0x0000000180DD5400-0x0000000180DD59B0
		public void OnPointerClick(PointerEventData eventData); // 0x0000000180DD4E50-0x0000000180DD5400
		public void OnScroll(PointerEventData eventData); // 0x0000000180DD6940-0x0000000180DD6E30
		public void OnBeginDrag(PointerEventData eventData); // 0x0000000180DD3D40-0x0000000180DD42F0
		public void OnDrag(PointerEventData eventData); // 0x0000000180DD42F0-0x0000000180DD48A0
		public void OnEndDrag(PointerEventData eventData); // 0x0000000180DD48A0-0x0000000180DD4E50
		private static string GetSourceName(PlayerPointerEventData playerEventData); // 0x0000000180DD3AF0-0x0000000180DD3CB0
	}
}
