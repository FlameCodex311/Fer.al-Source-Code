/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001800DB220-0x00000001800DB280
	[Description] // 0x00000001800DB220-0x00000001800DB280
	public class InterceptEvent : ConditionTask<Transform> // TypeDefIndex: 14167
	{
		// Fields
		public EventTriggerType eventType; // 0x68
	
		// Properties
		protected override string info { get; } // 0x0000000181257150-0x0000000181257200 
	
		// Constructors
		public InterceptEvent(); // 0x0000000181257110-0x0000000181257150
	
		// Methods
		protected override string OnInit(); // 0x0000000181257060-0x0000000181257110
		protected override bool OnCheck(); // 0x00000001803C28F0-0x00000001803C2900
		private void OnPointerEnter(PointerEventData eventData); // 0x000000018124D880-0x000000018124D890
		private void OnPointerExit(PointerEventData eventData); // 0x000000018124D880-0x000000018124D890
		private void OnPointerDown(PointerEventData eventData); // 0x000000018124D880-0x000000018124D890
		private void OnPointerUp(PointerEventData eventData); // 0x000000018124D880-0x000000018124D890
		private void OnPointerClick(PointerEventData eventData); // 0x000000018124D880-0x000000018124D890
		private void OnDrag(PointerEventData eventData); // 0x000000018124D880-0x000000018124D890
		private void OnDrop(BaseEventData eventData); // 0x000000018124D880-0x000000018124D890
		private void OnScroll(PointerEventData eventData); // 0x000000018124D880-0x000000018124D890
		private void OnUpdateSelected(BaseEventData eventData); // 0x000000018124D880-0x000000018124D890
		private void OnSelect(BaseEventData eventData); // 0x000000018124D880-0x000000018124D890
		private void OnDeselect(BaseEventData eventData); // 0x000000018124D880-0x000000018124D890
		private void OnMove(AxisEventData eventData); // 0x000000018124D880-0x000000018124D890
		private void OnSubmit(BaseEventData eventData); // 0x000000018124D880-0x000000018124D890
	}
}
