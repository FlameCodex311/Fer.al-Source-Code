/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent] // 0x00000001801CDAD0-0x00000001801CDAE0
	public sealed class TouchRegion : TouchInteractable // TypeDefIndex: 6024
	{
		// Fields
		[CustomObfuscation] // 0x0000000180217CA0-0x0000000180217D00
		[SerializeField] // 0x0000000180217CA0-0x0000000180217D00
		[Tooltip] // 0x0000000180217CA0-0x0000000180217D00
		private bool _hideAtRuntime; // 0x128
		private VugHNrGwwHElkQqEnXvUfCcjxrP _onPointerDown; // 0x130
		private CrxIoZnoppQKNwyWvmQiwZtYobn _onPointerUp; // 0x138
		private lXaicWqqBSGvYByyEwgDfbHqNqBG _onPointerEnter; // 0x140
		private HWOFyvATWrreAjbnVGpGUIverogH _onPointerExit; // 0x148
		private SYSBHvHssiKLGADHvbktEKUHzWMu _onBeginDrag; // 0x150
		private keGNuzKnrKSOAsgUAArSamgbDVxQ _onDrag; // 0x158
		private dmjQJcwGEPJgGEbWvxDPQrJacpI _onEndDrag; // 0x160
	
		// Properties
		public bool hideAtRuntime { get; set; } // 0x00000001803E93D0-0x00000001803E93E0 0x00000001810C8370-0x00000001810C83A0
	
		// Events
		public event UnityAction<PointerEventData> PointerDownEvent {
			add; // 0x00000001810C7F50-0x00000001810C7FB0
			remove; // 0x00000001810C81F0-0x00000001810C8250
		}
		public event UnityAction<PointerEventData> PointerUpEvent {
			add; // 0x00000001810C8070-0x00000001810C80D0
			remove; // 0x00000001810C8310-0x00000001810C8370
		}
		public event UnityAction<PointerEventData> PointerEnterEvent {
			add; // 0x00000001810C7FB0-0x00000001810C8010
			remove; // 0x00000001810C8250-0x00000001810C82B0
		}
		public event UnityAction<PointerEventData> PointerExitEvent {
			add; // 0x00000001810C8010-0x00000001810C8070
			remove; // 0x00000001810C82B0-0x00000001810C8310
		}
		public event UnityAction<PointerEventData> BeginDragEvent {
			add; // 0x00000001810C7E30-0x00000001810C7E90
			remove; // 0x00000001810C80D0-0x00000001810C8130
		}
		public event UnityAction<PointerEventData> DragEvent {
			add; // 0x00000001810C7E90-0x00000001810C7EF0
			remove; // 0x00000001810C8130-0x00000001810C8190
		}
		public event UnityAction<PointerEventData> EndDragEvent {
			add; // 0x00000001810C7EF0-0x00000001810C7F50
			remove; // 0x00000001810C8190-0x00000001810C81F0
		}
	
		// Nested types
		[Serializable]
		private class VugHNrGwwHElkQqEnXvUfCcjxrP : UnityEvent<PointerEventData> // TypeDefIndex: 6025
		{
			// Constructors
			public VugHNrGwwHElkQqEnXvUfCcjxrP(); // 0x00000001810C8460-0x00000001810C84A0
		}
	
		[Serializable]
		private class CrxIoZnoppQKNwyWvmQiwZtYobn : UnityEvent<PointerEventData> // TypeDefIndex: 6026
		{
			// Constructors
			public CrxIoZnoppQKNwyWvmQiwZtYobn(); // 0x00000001810AC360-0x00000001810AC3A0
		}
	
		[Serializable]
		private class lXaicWqqBSGvYByyEwgDfbHqNqBG : UnityEvent<PointerEventData> // TypeDefIndex: 6027
		{
			// Constructors
			public lXaicWqqBSGvYByyEwgDfbHqNqBG(); // 0x00000001810C8A60-0x00000001810C8AA0
		}
	
		[Serializable]
		private class HWOFyvATWrreAjbnVGpGUIverogH : UnityEvent<PointerEventData> // TypeDefIndex: 6028
		{
			// Constructors
			public HWOFyvATWrreAjbnVGpGUIverogH(); // 0x00000001810AD100-0x00000001810AD140
		}
	
		[Serializable]
		private class SYSBHvHssiKLGADHvbktEKUHzWMu : UnityEvent<PointerEventData> // TypeDefIndex: 6029
		{
			// Constructors
			public SYSBHvHssiKLGADHvbktEKUHzWMu(); // 0x00000001810B2220-0x00000001810B2260
		}
	
		[Serializable]
		private class keGNuzKnrKSOAsgUAArSamgbDVxQ : UnityEvent<PointerEventData> // TypeDefIndex: 6030
		{
			// Constructors
			public keGNuzKnrKSOAsgUAArSamgbDVxQ(); // 0x00000001810C8A20-0x00000001810C8A60
		}
	
		[Serializable]
		private class dmjQJcwGEPJgGEbWvxDPQrJacpI : UnityEvent<PointerEventData> // TypeDefIndex: 6031
		{
			// Constructors
			public dmjQJcwGEPJgGEbWvxDPQrJacpI(); // 0x00000001810C89E0-0x00000001810C8A20
		}
	
		// Constructors
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private TouchRegion(); // 0x00000001810C7C00-0x00000001810C7E30
	
		// Methods
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal override void Awake(); // 0x00000001810C6F60-0x00000001810C7070
		public override void ClearValue(); // 0x00000001803774A0-0x00000001803774B0
		internal override void OnCustomControllerUpdate(); // 0x00000001803774A0-0x00000001803774B0
		internal override void OnPointerDown(PointerEventData eventData); // 0x00000001810C7570-0x00000001810C7730
		internal override void OnPointerUp(PointerEventData eventData); // 0x00000001810C7A40-0x00000001810C7C00
		internal override void OnPointerEnter(PointerEventData eventData); // 0x00000001810C7730-0x00000001810C78A0
		internal override void OnPointerExit(PointerEventData eventData); // 0x00000001810C78A0-0x00000001810C7A40
		internal override void OnBeginDrag(PointerEventData eventData); // 0x00000001810C7070-0x00000001810C7210
		internal override void OnDrag(PointerEventData eventData); // 0x00000001810C7210-0x00000001810C73D0
		internal override void OnEndDrag(PointerEventData eventData); // 0x00000001810C73D0-0x00000001810C7570
	}
}
