/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FMODUnity
{
	public abstract class EventHandler : UnityEngine.MonoBehaviour // TypeDefIndex: 10278
	{
		// Fields
		public string CollisionTag; // 0x18
	
		// Constructors
		protected EventHandler(); // 0x0000000180D21920-0x0000000180D21960
	
		// Methods
		private void OnEnable(); // 0x0000000180D21700-0x0000000180D21720
		private void OnDisable(); // 0x0000000180D216E0-0x0000000180D21700
		private void OnTriggerEnter(Collider other); // 0x0000000180D21800-0x0000000180D21860
		private void OnTriggerExit(Collider other); // 0x0000000180D218C0-0x0000000180D21920
		private void OnTriggerEnter2D(Collider2D other); // 0x0000000180D217A0-0x0000000180D21800
		private void OnTriggerExit2D(Collider2D other); // 0x0000000180D21860-0x0000000180D218C0
		private void OnCollisionEnter(); // 0x0000000180D21680-0x0000000180D216A0
		private void OnCollisionExit(); // 0x0000000180D216C0-0x0000000180D216E0
		private void OnCollisionEnter2D(); // 0x0000000180D21660-0x0000000180D21680
		private void OnCollisionExit2D(); // 0x0000000180D216A0-0x0000000180D216C0
		private void OnMouseEnter(); // 0x0000000180D21740-0x0000000180D21760
		private void OnMouseExit(); // 0x0000000180D21760-0x0000000180D21780
		private void OnMouseDown(); // 0x0000000180D21720-0x0000000180D21740
		private void OnMouseUp(); // 0x0000000180D21780-0x0000000180D217A0
		protected abstract void HandleGameEvent(EmitterGameEvent gameEvent);
	}
}
