/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion.Services
{
	public class EventRouter : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IDragHandler, IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, IDropHandler // TypeDefIndex: 15849
	{
		// Fields
		private Animator _animator; // 0x20
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate<PointerEventData> onPointerEnter; // 0x28
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate<PointerEventData> onPointerExit; // 0x30
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate<PointerEventData> onPointerDown; // 0x38
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate<PointerEventData> onPointerUp; // 0x40
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate<PointerEventData> onPointerClick; // 0x48
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate<PointerEventData> onDrag; // 0x50
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate<PointerEventData> onDrop; // 0x58
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate<PointerEventData> onScroll; // 0x60
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate<BaseEventData> onUpdateSelected; // 0x68
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate<BaseEventData> onSelect; // 0x70
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate<BaseEventData> onDeselect; // 0x78
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate<AxisEventData> onMove; // 0x80
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate<BaseEventData> onSubmit; // 0x88
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate onMouseDown; // 0x90
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate onMouseDrag; // 0x98
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate onMouseEnter; // 0xA0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate onMouseExit; // 0xA8
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate onMouseOver; // 0xB0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate onMouseUp; // 0xB8
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate onEnable; // 0xC0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate onDisable; // 0xC8
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate onDestroy; // 0xD0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate onTransformChildrenChanged; // 0xD8
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate onTransformParentChanged; // 0xE0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate<int> onAnimatorIK; // 0xE8
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate onAnimatorMove; // 0xF0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate onBecameInvisible; // 0xF8
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate onBecameVisible; // 0x100
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate<ControllerColliderHit> onControllerColliderHit; // 0x108
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate<GameObject> onParticleCollision; // 0x110
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate<Collision> onCollisionEnter; // 0x118
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate<Collision> onCollisionExit; // 0x120
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate<Collision> onCollisionStay; // 0x128
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate<Collision2D> onCollisionEnter2D; // 0x130
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate<Collision2D> onCollisionExit2D; // 0x138
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate<Collision2D> onCollisionStay2D; // 0x140
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate<Collider> onTriggerEnter; // 0x148
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate<Collider> onTriggerExit; // 0x150
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate<Collider> onTriggerStay; // 0x158
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate<Collider2D> onTriggerEnter2D; // 0x160
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate<Collider2D> onTriggerExit2D; // 0x168
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EventDelegate<Collider2D> onTriggerStay2D; // 0x170
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private CustomEventDelegate onCustomEvent; // 0x178
	
		// Properties
		private Animator animator { get; } // 0x00000001811A6080-0x00000001811A6110 
	
		// Events
		public event EventDelegate<PointerEventData> onPointerEnter {
			add; // 0x00000001811A5720-0x00000001811A57C0
			remove; // 0x00000001811A7290-0x00000001811A7330
		}
		public event EventDelegate<PointerEventData> onPointerExit {
			add; // 0x00000001811A57C0-0x00000001811A5860
			remove; // 0x00000001811A7330-0x00000001811A73D0
		}
		public event EventDelegate<PointerEventData> onPointerDown {
			add; // 0x00000001811A5680-0x00000001811A5720
			remove; // 0x00000001811A71F0-0x00000001811A7290
		}
		public event EventDelegate<PointerEventData> onPointerUp {
			add; // 0x00000001811A5860-0x00000001811A5900
			remove; // 0x00000001811A73D0-0x00000001811A7470
		}
		public event EventDelegate<PointerEventData> onPointerClick {
			add; // 0x00000001811A55E0-0x00000001811A5680
			remove; // 0x00000001811A7150-0x00000001811A71F0
		}
		public event EventDelegate<PointerEventData> onDrag {
			add; // 0x00000001811A4F00-0x00000001811A4FA0
			remove; // 0x00000001811A6A70-0x00000001811A6B10
		}
		public event EventDelegate<PointerEventData> onDrop {
			add; // 0x00000001811A4FA0-0x00000001811A5040
			remove; // 0x00000001811A6B10-0x00000001811A6BB0
		}
		public event EventDelegate<PointerEventData> onScroll {
			add; // 0x00000001811A5900-0x00000001811A59A0
			remove; // 0x00000001811A7470-0x00000001811A7510
		}
		public event EventDelegate<BaseEventData> onUpdateSelected {
			add; // 0x00000001811A5FE0-0x00000001811A6080
			remove; // 0x00000001811A7B50-0x00000001811A7BF0
		}
		public event EventDelegate<BaseEventData> onSelect {
			add; // 0x00000001811A59A0-0x00000001811A5A40
			remove; // 0x00000001811A7510-0x00000001811A75B0
		}
		public event EventDelegate<BaseEventData> onDeselect {
			add; // 0x00000001811A4D20-0x00000001811A4DC0
			remove; // 0x00000001811A6890-0x00000001811A6930
		}
		public event EventDelegate<AxisEventData> onMove {
			add; // 0x00000001811A54A0-0x00000001811A5540
			remove; // 0x00000001811A7010-0x00000001811A70B0
		}
		public event EventDelegate<BaseEventData> onSubmit {
			add; // 0x00000001811A5A40-0x00000001811A5AE0
			remove; // 0x00000001811A75B0-0x00000001811A7650
		}
		public event EventDelegate onMouseDown {
			add; // 0x00000001811A50E0-0x00000001811A5180
			remove; // 0x00000001811A6C50-0x00000001811A6CF0
		}
		public event EventDelegate onMouseDrag {
			add; // 0x00000001811A5180-0x00000001811A5220
			remove; // 0x00000001811A6CF0-0x00000001811A6D90
		}
		public event EventDelegate onMouseEnter {
			add; // 0x00000001811A5220-0x00000001811A52C0
			remove; // 0x00000001811A6D90-0x00000001811A6E30
		}
		public event EventDelegate onMouseExit {
			add; // 0x00000001811A52C0-0x00000001811A5360
			remove; // 0x00000001811A6E30-0x00000001811A6ED0
		}
		public event EventDelegate onMouseOver {
			add; // 0x00000001811A5360-0x00000001811A5400
			remove; // 0x00000001811A6ED0-0x00000001811A6F70
		}
		public event EventDelegate onMouseUp {
			add; // 0x00000001811A5400-0x00000001811A54A0
			remove; // 0x00000001811A6F70-0x00000001811A7010
		}
		public event EventDelegate onEnable {
			add; // 0x00000001811A5040-0x00000001811A50E0
			remove; // 0x00000001811A6BB0-0x00000001811A6C50
		}
		public event EventDelegate onDisable {
			add; // 0x00000001811A4E60-0x00000001811A4F00
			remove; // 0x00000001811A69D0-0x00000001811A6A70
		}
		public event EventDelegate onDestroy {
			add; // 0x00000001811A4DC0-0x00000001811A4E60
			remove; // 0x00000001811A6930-0x00000001811A69D0
		}
		public event EventDelegate onTransformChildrenChanged {
			add; // 0x00000001811A5AE0-0x00000001811A5B80
			remove; // 0x00000001811A7650-0x00000001811A76F0
		}
		public event EventDelegate onTransformParentChanged {
			add; // 0x00000001811A5B80-0x00000001811A5C20
			remove; // 0x00000001811A76F0-0x00000001811A7790
		}
		public event EventDelegate<int> onAnimatorIK {
			add; // 0x00000001811A45A0-0x00000001811A4640
			remove; // 0x00000001811A6110-0x00000001811A61B0
		}
		public event EventDelegate onAnimatorMove {
			add; // 0x00000001811A4640-0x00000001811A46E0
			remove; // 0x00000001811A61B0-0x00000001811A6250
		}
		public event EventDelegate onBecameInvisible {
			add; // 0x00000001811A46E0-0x00000001811A4780
			remove; // 0x00000001811A6250-0x00000001811A62F0
		}
		public event EventDelegate onBecameVisible {
			add; // 0x00000001811A4780-0x00000001811A4820
			remove; // 0x00000001811A62F0-0x00000001811A6390
		}
		public event EventDelegate<ControllerColliderHit> onControllerColliderHit {
			add; // 0x00000001811A4BE0-0x00000001811A4C80
			remove; // 0x00000001811A6750-0x00000001811A67F0
		}
		public event EventDelegate<GameObject> onParticleCollision {
			add; // 0x00000001811A5540-0x00000001811A55E0
			remove; // 0x00000001811A70B0-0x00000001811A7150
		}
		public event EventDelegate<Collision> onCollisionEnter {
			add; // 0x00000001811A48C0-0x00000001811A4960
			remove; // 0x00000001811A6430-0x00000001811A64D0
		}
		public event EventDelegate<Collision> onCollisionExit {
			add; // 0x00000001811A4A00-0x00000001811A4AA0
			remove; // 0x00000001811A6570-0x00000001811A6610
		}
		public event EventDelegate<Collision> onCollisionStay {
			add; // 0x00000001811A4B40-0x00000001811A4BE0
			remove; // 0x00000001811A66B0-0x00000001811A6750
		}
		public event EventDelegate<Collision2D> onCollisionEnter2D {
			add; // 0x00000001811A4820-0x00000001811A48C0
			remove; // 0x00000001811A6390-0x00000001811A6430
		}
		public event EventDelegate<Collision2D> onCollisionExit2D {
			add; // 0x00000001811A4960-0x00000001811A4A00
			remove; // 0x00000001811A64D0-0x00000001811A6570
		}
		public event EventDelegate<Collision2D> onCollisionStay2D {
			add; // 0x00000001811A4AA0-0x00000001811A4B40
			remove; // 0x00000001811A6610-0x00000001811A66B0
		}
		public event EventDelegate<Collider> onTriggerEnter {
			add; // 0x00000001811A5CC0-0x00000001811A5D60
			remove; // 0x00000001811A7830-0x00000001811A78D0
		}
		public event EventDelegate<Collider> onTriggerExit {
			add; // 0x00000001811A5E00-0x00000001811A5EA0
			remove; // 0x00000001811A7970-0x00000001811A7A10
		}
		public event EventDelegate<Collider> onTriggerStay {
			add; // 0x00000001811A5F40-0x00000001811A5FE0
			remove; // 0x00000001811A7AB0-0x00000001811A7B50
		}
		public event EventDelegate<Collider2D> onTriggerEnter2D {
			add; // 0x00000001811A5C20-0x00000001811A5CC0
			remove; // 0x00000001811A7790-0x00000001811A7830
		}
		public event EventDelegate<Collider2D> onTriggerExit2D {
			add; // 0x00000001811A5D60-0x00000001811A5E00
			remove; // 0x00000001811A78D0-0x00000001811A7970
		}
		public event EventDelegate<Collider2D> onTriggerStay2D {
			add; // 0x00000001811A5EA0-0x00000001811A5F40
			remove; // 0x00000001811A7A10-0x00000001811A7AB0
		}
		public event CustomEventDelegate onCustomEvent {
			add; // 0x00000001811A4C80-0x00000001811A4D20
			remove; // 0x00000001811A67F0-0x00000001811A6890
		}
	
		// Nested types
		public delegate void EventDelegate(EventData msg); // TypeDefIndex: 15850; 0x00000001804D6330-0x00000001804D6700
	
		public delegate void EventDelegate<T>(EventData<T> msg); // TypeDefIndex: 15851; 0x00000000-0x00000000
	
		public delegate void CustomEventDelegate(string name, IEventData data); // TypeDefIndex: 15852; 0x00000001804D5DB0-0x00000001804D62B0
	
		// Constructors
		public EventRouter(); // 0x00000001803743C0-0x00000001803743D0
	
		// Methods
		void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData); // 0x00000001811A4060-0x00000001811A4120
		void IPointerExitHandler.OnPointerExit(PointerEventData eventData); // 0x00000001811A4120-0x00000001811A41E0
		void IPointerDownHandler.OnPointerDown(PointerEventData eventData); // 0x00000001811A3FA0-0x00000001811A4060
		void IPointerUpHandler.OnPointerUp(PointerEventData eventData); // 0x00000001811A41E0-0x00000001811A42A0
		void IPointerClickHandler.OnPointerClick(PointerEventData eventData); // 0x00000001811A3EE0-0x00000001811A3FA0
		void IDragHandler.OnDrag(PointerEventData eventData); // 0x00000001811A3CA0-0x00000001811A3D60
		void IDropHandler.OnDrop(PointerEventData eventData); // 0x00000001811A3D60-0x00000001811A3E20
		void IScrollHandler.OnScroll(PointerEventData eventData); // 0x00000001811A42A0-0x00000001811A4360
		void IUpdateSelectedHandler.OnUpdateSelected(BaseEventData eventData); // 0x00000001811A44E0-0x00000001811A45A0
		void ISelectHandler.OnSelect(BaseEventData eventData); // 0x00000001811A4360-0x00000001811A4420
		void IDeselectHandler.OnDeselect(BaseEventData eventData); // 0x00000001811A3BE0-0x00000001811A3CA0
		void IMoveHandler.OnMove(AxisEventData eventData); // 0x00000001811A3E20-0x00000001811A3EE0
		void ISubmitHandler.OnSubmit(BaseEventData eventData); // 0x00000001811A4420-0x00000001811A44E0
		private void OnMouseDown(); // 0x00000001811A32A0-0x00000001811A3320
		private void OnMouseDrag(); // 0x00000001811A3320-0x00000001811A33A0
		private void OnMouseEnter(); // 0x00000001811A33A0-0x00000001811A3420
		private void OnMouseExit(); // 0x00000001811A3420-0x00000001811A34A0
		private void OnMouseOver(); // 0x00000001811A34A0-0x00000001811A3520
		private void OnMouseUp(); // 0x00000001811A3520-0x00000001811A35A0
		private void OnEnable(); // 0x00000001811A3220-0x00000001811A32A0
		private void OnDisable(); // 0x00000001811A31A0-0x00000001811A3220
		private void OnDestroy(); // 0x00000001811A3120-0x00000001811A31A0
		private void OnTransformChildrenChanged(); // 0x00000001811A3660-0x00000001811A36E0
		private void OnTransformParentChanged(); // 0x00000001811A36E0-0x00000001811A3760
		private void OnAnimatorIK(int layerIndex); // 0x00000001811A2950-0x00000001811A2A10
		private void OnAnimatorMove(); // 0x00000001811A2A10-0x00000001811A2AE0
		private void OnBecameInvisible(); // 0x00000001811A2AE0-0x00000001811A2B60
		private void OnBecameVisible(); // 0x00000001811A2B60-0x00000001811A2BE0
		private void OnControllerColliderHit(ControllerColliderHit hit); // 0x00000001811A3060-0x00000001811A3120
		private void OnParticleCollision(GameObject other); // 0x00000001811A35A0-0x00000001811A3660
		private void OnCollisionEnter(Collision collisionInfo); // 0x00000001811A2CA0-0x00000001811A2D60
		private void OnCollisionExit(Collision collisionInfo); // 0x00000001811A2E20-0x00000001811A2EE0
		private void OnCollisionStay(Collision collisionInfo); // 0x00000001811A2FA0-0x00000001811A3060
		private void OnCollisionEnter2D(Collision2D collisionInfo); // 0x00000001811A2BE0-0x00000001811A2CA0
		private void OnCollisionExit2D(Collision2D collisionInfo); // 0x00000001811A2D60-0x00000001811A2E20
		private void OnCollisionStay2D(Collision2D collisionInfo); // 0x00000001811A2EE0-0x00000001811A2FA0
		private void OnTriggerEnter(Collider other); // 0x00000001811A3820-0x00000001811A38E0
		private void OnTriggerExit(Collider other); // 0x00000001811A39A0-0x00000001811A3A60
		private void OnTriggerStay(Collider other); // 0x00000001811A3B20-0x00000001811A3BE0
		private void OnTriggerEnter2D(Collider2D other); // 0x00000001811A3760-0x00000001811A3820
		private void OnTriggerExit2D(Collider2D other); // 0x00000001811A38E0-0x00000001811A39A0
		private void OnTriggerStay2D(Collider2D other); // 0x00000001811A3A60-0x00000001811A3B20
		public void InvokeCustomEvent(string name, object value, object sender); // 0x00000001811A2870-0x00000001811A2950
		public void InvokeCustomEvent<T>(string name, T value, object sender);
	}
}
