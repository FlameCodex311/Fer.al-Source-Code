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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent] // 0x00000001800B36B0-0x00000001800B36C0
	public sealed class TouchRegion : TouchInteractable // TypeDefIndex: 5865
	{
		// Fields
		[CustomObfuscation] // 0x00000001800B7110-0x00000001800B7170
		[SerializeField] // 0x00000001800B7110-0x00000001800B7170
		[Tooltip] // 0x00000001800B7110-0x00000001800B7170
		private bool _hideAtRuntime; // 0x128
		private VugHNrGwwHElkQqEnXvUfCcjxrP _onPointerDown; // 0x130
		private CrxIoZnoppQKNwyWvmQiwZtYobn _onPointerUp; // 0x138
		private lXaicWqqBSGvYByyEwgDfbHqNqBG _onPointerEnter; // 0x140
		private HWOFyvATWrreAjbnVGpGUIverogH _onPointerExit; // 0x148
		private SYSBHvHssiKLGADHvbktEKUHzWMu _onBeginDrag; // 0x150
		private keGNuzKnrKSOAsgUAArSamgbDVxQ _onDrag; // 0x158
		private dmjQJcwGEPJgGEbWvxDPQrJacpI _onEndDrag; // 0x160
	
		// Properties
		public bool hideAtRuntime { get; set; } // 0x00000001805B6EE0-0x00000001805B6EF0 0x0000000181922740-0x0000000181922770
	
		// Events
		public event UnityAction<PointerEventData> PointerDownEvent {
			add; // 0x0000000181922320-0x0000000181922380
			remove; // 0x00000001819225C0-0x0000000181922620
		}
		public event UnityAction<PointerEventData> PointerUpEvent {
			add; // 0x0000000181922440-0x00000001819224A0
			remove; // 0x00000001819226E0-0x0000000181922740
		}
		public event UnityAction<PointerEventData> PointerEnterEvent {
			add; // 0x0000000181922380-0x00000001819223E0
			remove; // 0x0000000181922620-0x0000000181922680
		}
		public event UnityAction<PointerEventData> PointerExitEvent {
			add; // 0x00000001819223E0-0x0000000181922440
			remove; // 0x0000000181922680-0x00000001819226E0
		}
		public event UnityAction<PointerEventData> BeginDragEvent {
			add; // 0x0000000181922200-0x0000000181922260
			remove; // 0x00000001819224A0-0x0000000181922500
		}
		public event UnityAction<PointerEventData> DragEvent {
			add; // 0x0000000181922260-0x00000001819222C0
			remove; // 0x0000000181922500-0x0000000181922560
		}
		public event UnityAction<PointerEventData> EndDragEvent {
			add; // 0x00000001819222C0-0x0000000181922320
			remove; // 0x0000000181922560-0x00000001819225C0
		}
	
		// Nested types
		[Serializable]
		private class VugHNrGwwHElkQqEnXvUfCcjxrP : UnityEvent<PointerEventData> // TypeDefIndex: 5866
		{
			// Constructors
			public VugHNrGwwHElkQqEnXvUfCcjxrP(); // 0x0000000181922830-0x0000000181922870
		}
	
		[Serializable]
		private class CrxIoZnoppQKNwyWvmQiwZtYobn : UnityEvent<PointerEventData> // TypeDefIndex: 5867
		{
			// Constructors
			public CrxIoZnoppQKNwyWvmQiwZtYobn(); // 0x00000001819063A0-0x00000001819063E0
		}
	
		[Serializable]
		private class lXaicWqqBSGvYByyEwgDfbHqNqBG : UnityEvent<PointerEventData> // TypeDefIndex: 5868
		{
			// Constructors
			public lXaicWqqBSGvYByyEwgDfbHqNqBG(); // 0x0000000181922E40-0x0000000181922E80
		}
	
		[Serializable]
		private class HWOFyvATWrreAjbnVGpGUIverogH : UnityEvent<PointerEventData> // TypeDefIndex: 5869
		{
			// Constructors
			public HWOFyvATWrreAjbnVGpGUIverogH(); // 0x0000000181907190-0x00000001819071D0
		}
	
		[Serializable]
		private class SYSBHvHssiKLGADHvbktEKUHzWMu : UnityEvent<PointerEventData> // TypeDefIndex: 5870
		{
			// Constructors
			public SYSBHvHssiKLGADHvbktEKUHzWMu(); // 0x000000018190C3C0-0x000000018190C400
		}
	
		[Serializable]
		private class keGNuzKnrKSOAsgUAArSamgbDVxQ : UnityEvent<PointerEventData> // TypeDefIndex: 5871
		{
			// Constructors
			public keGNuzKnrKSOAsgUAArSamgbDVxQ(); // 0x0000000181922E00-0x0000000181922E40
		}
	
		[Serializable]
		private class dmjQJcwGEPJgGEbWvxDPQrJacpI : UnityEvent<PointerEventData> // TypeDefIndex: 5872
		{
			// Constructors
			public dmjQJcwGEPJgGEbWvxDPQrJacpI(); // 0x0000000181922DC0-0x0000000181922E00
		}
	
		// Constructors
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		private TouchRegion(); // 0x0000000181921FD0-0x0000000181922200
	
		// Methods
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal override void Awake(); // 0x00000001819212F0-0x0000000181921400
		public override void ClearValue(); // 0x00000001803581E0-0x00000001803581F0
		internal override void OnCustomControllerUpdate(); // 0x00000001803581E0-0x00000001803581F0
		internal override void OnPointerDown(PointerEventData eventData); // 0x0000000181921920-0x0000000181921AF0
		internal override void OnPointerUp(PointerEventData eventData); // 0x0000000181921E00-0x0000000181921FD0
		internal override void OnPointerEnter(PointerEventData eventData); // 0x0000000181921AF0-0x0000000181921C60
		internal override void OnPointerExit(PointerEventData eventData); // 0x0000000181921C60-0x0000000181921E00
		internal override void OnBeginDrag(PointerEventData eventData); // 0x0000000181921400-0x00000001819215B0
		internal override void OnDrag(PointerEventData eventData); // 0x00000001819215B0-0x0000000181921770
		internal override void OnEndDrag(PointerEventData eventData); // 0x0000000181921770-0x0000000181921920
	}
}
