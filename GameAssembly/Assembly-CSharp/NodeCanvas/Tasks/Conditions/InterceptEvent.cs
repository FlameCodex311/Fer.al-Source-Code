/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x000000018023F500-0x000000018023F560
	[Description] // 0x000000018023F500-0x000000018023F560
	public class InterceptEvent : ConditionTask<Transform> // TypeDefIndex: 15269
	{
		// Fields
		public EventTriggerType eventType; // 0x68
	
		// Properties
		protected override string info { get; } // 0x00000001807FEE30-0x00000001807FEEE0 
	
		// Constructors
		public InterceptEvent(); // 0x00000001807FEDF0-0x00000001807FEE30
	
		// Methods
		protected override void OnEnable(); // 0x00000001807FE870-0x00000001807FEDF0
		protected override void OnDisable(); // 0x00000001807FE2F0-0x00000001807FE870
		protected override bool OnCheck(); // 0x0000000180380950-0x0000000180380960
		private void OnPointerEnter(EventData<PointerEventData> data); // 0x0000000180792470-0x0000000180792480
		private void OnPointerExit(EventData<PointerEventData> data); // 0x0000000180792470-0x0000000180792480
		private void OnPointerDown(EventData<PointerEventData> data); // 0x0000000180792470-0x0000000180792480
		private void OnPointerUp(EventData<PointerEventData> data); // 0x0000000180792470-0x0000000180792480
		private void OnPointerClick(EventData<PointerEventData> data); // 0x0000000180792470-0x0000000180792480
		private void OnDrag(EventData<PointerEventData> data); // 0x0000000180792470-0x0000000180792480
		private void OnDrop(EventData<PointerEventData> eventData); // 0x0000000180792470-0x0000000180792480
		private void OnScroll(EventData<PointerEventData> data); // 0x0000000180792470-0x0000000180792480
		private void OnUpdateSelected(EventData<BaseEventData> eventData); // 0x0000000180792470-0x0000000180792480
		private void OnSelect(EventData<BaseEventData> eventData); // 0x0000000180792470-0x0000000180792480
		private void OnDeselect(EventData<BaseEventData> eventData); // 0x0000000180792470-0x0000000180792480
		private void OnMove(EventData<AxisEventData> eventData); // 0x0000000180792470-0x0000000180792480
		private void OnSubmit(EventData<BaseEventData> eventData); // 0x0000000180792470-0x0000000180792480
	}
}
