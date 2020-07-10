/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ParadoxNotion.Services
{
	public class MessageRouter : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IDragHandler, IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler // TypeDefIndex: 15268
	{
		// Fields
		private const BindingFlags METHOD_FLAGS = BindingFlags.Default | BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic; // Metadata: 0x00784788
		private Dictionary<string, List<object>> listeners; // 0x20
		private object _animator; // 0x28
	
		// Properties
		private Animator animator { get; } // 0x000000018116AC00-0x000000018116ACC0 
	
		// Nested types
		public class MessageData // TypeDefIndex: 15269
		{
			// Fields
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private GameObject <receiver>k__BackingField; // 0x10
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private object <sender>k__BackingField; // 0x18
	
			// Properties
			public GameObject receiver { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
			public object sender { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
	
			// Constructors
			public MessageData(GameObject receiver, object sender); // 0x00000001803DA900-0x00000001803DA940
		}
	
		public class MessageData<T> : MessageData // TypeDefIndex: 15270
		{
			// Fields
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private T <value>k__BackingField;
	
			// Properties
			public T value { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; }
	
			// Constructors
			public MessageData(T value, GameObject receiver, object sender);
		}
	
		// Constructors
		public MessageRouter(); // 0x000000018116AB10-0x000000018116AC00
	
		// Methods
		public void OnPointerEnter(PointerEventData eventData); // 0x0000000181169C50-0x0000000181169CB0
		public void OnPointerExit(PointerEventData eventData); // 0x0000000181169CB0-0x0000000181169D10
		public void OnPointerDown(PointerEventData eventData); // 0x0000000181169BF0-0x0000000181169C50
		public void OnPointerUp(PointerEventData eventData); // 0x0000000181169D10-0x0000000181169D70
		public void OnPointerClick(PointerEventData eventData); // 0x0000000181169B90-0x0000000181169BF0
		public void OnDrag(PointerEventData eventData); // 0x0000000181169690-0x00000001811696F0
		public void OnDrop(BaseEventData eventData); // 0x00000001811696F0-0x0000000181169750
		public void OnScroll(PointerEventData eventData); // 0x0000000181169D70-0x0000000181169DD0
		public void OnUpdateSelected(BaseEventData eventData); // 0x000000018116A1D0-0x000000018116A230
		public void OnSelect(BaseEventData eventData); // 0x0000000181169DD0-0x0000000181169E30
		public void OnDeselect(BaseEventData eventData); // 0x0000000181169530-0x0000000181169590
		public void OnMove(AxisEventData eventData); // 0x0000000181169AD0-0x0000000181169B30
		public void OnSubmit(BaseEventData eventData); // 0x0000000181169E30-0x0000000181169E90
		private void OnAnimatorIK(int layerIndex); // 0x0000000181169070-0x00000001811690D0
		private void OnAnimatorMove(); // 0x00000001811690D0-0x0000000181169190
		private void OnBecameInvisible(); // 0x0000000181169190-0x0000000181169210
		private void OnBecameVisible(); // 0x0000000181169210-0x0000000181169290
		private void OnCollisionEnter(Collision collisionInfo); // 0x00000001811692F0-0x0000000181169350
		private void OnCollisionExit(Collision collisionInfo); // 0x00000001811693B0-0x0000000181169410
		private void OnCollisionStay(Collision collisionInfo); // 0x0000000181169470-0x00000001811694D0
		private void OnCollisionEnter2D(Collision2D collisionInfo); // 0x0000000181169290-0x00000001811692F0
		private void OnCollisionExit2D(Collision2D collisionInfo); // 0x0000000181169350-0x00000001811693B0
		private void OnCollisionStay2D(Collision2D collisionInfo); // 0x0000000181169410-0x0000000181169470
		private void OnTriggerEnter(Collider other); // 0x0000000181169FF0-0x000000018116A050
		private void OnTriggerExit(Collider other); // 0x000000018116A0B0-0x000000018116A110
		private void OnTriggerStay(Collider other); // 0x000000018116A170-0x000000018116A1D0
		private void OnTriggerEnter2D(Collider2D other); // 0x0000000181169F90-0x0000000181169FF0
		private void OnTriggerExit2D(Collider2D other); // 0x000000018116A050-0x000000018116A0B0
		private void OnTriggerStay2D(Collider2D other); // 0x000000018116A110-0x000000018116A170
		private void OnMouseDown(); // 0x00000001811697D0-0x0000000181169850
		private void OnMouseDrag(); // 0x0000000181169850-0x00000001811698D0
		private void OnMouseEnter(); // 0x00000001811698D0-0x0000000181169950
		private void OnMouseExit(); // 0x0000000181169950-0x00000001811699D0
		private void OnMouseOver(); // 0x00000001811699D0-0x0000000181169A50
		private void OnMouseUp(); // 0x0000000181169A50-0x0000000181169AD0
		private void OnControllerColliderHit(ControllerColliderHit hit); // 0x00000001811694D0-0x0000000181169530
		private void OnParticleCollision(GameObject other); // 0x0000000181169B30-0x0000000181169B90
		private void OnEnable(); // 0x0000000181169750-0x00000001811697D0
		private void OnDisable(); // 0x0000000181169610-0x0000000181169690
		private void OnDestroy(); // 0x0000000181169590-0x0000000181169610
		private void OnTransformChildrenChanged(); // 0x0000000181169E90-0x0000000181169F10
		private void OnTransformParentChanged(); // 0x0000000181169F10-0x0000000181169F90
		public void Register(object target, params /* 0x00000001800B36B0-0x00000001800B36C0 */ string[] messages); // 0x000000018116A230-0x000000018116A4E0
		public void RegisterCallback(string message, Action callback); // 0x0000000181168F60-0x0000000181169070
		public void RegisterCallback<T>(string message, Action<T> callback);
		private void Internal_RegisterCallback(string message, Delegate callback); // 0x0000000181168F60-0x0000000181169070
		public void UnRegister(object target); // 0x000000018116A7B0-0x000000018116AB10
		public void UnRegister(object target, params /* 0x00000001800B36B0-0x00000001800B36C0 */ string[] messages); // 0x000000018116A4E0-0x000000018116A7B0
		public bool Dispatch(string message, object sender = null); // 0x0000000181168F00-0x0000000181168F60
		public bool Dispatch<T>(string message, T arg, object sender = null);
	}
}
