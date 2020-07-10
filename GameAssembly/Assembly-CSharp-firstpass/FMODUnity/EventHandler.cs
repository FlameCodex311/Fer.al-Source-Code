/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FMODUnity
{
	public abstract class EventHandler : UnityEngine.MonoBehaviour // TypeDefIndex: 9824
	{
		// Fields
		public string CollisionTag; // 0x18
	
		// Constructors
		protected EventHandler(); // 0x0000000181B22820-0x0000000181B22860
	
		// Methods
		private void OnEnable(); // 0x0000000181B225C0-0x0000000181B225E0
		private void OnDisable(); // 0x0000000181B225A0-0x0000000181B225C0
		private void OnTriggerEnter(Collider other); // 0x0000000181B226D0-0x0000000181B22740
		private void OnTriggerExit(Collider other); // 0x0000000181B227B0-0x0000000181B22820
		private void OnTriggerEnter2D(Collider2D other); // 0x0000000181B22660-0x0000000181B226D0
		private void OnTriggerExit2D(Collider2D other); // 0x0000000181B22740-0x0000000181B227B0
		private void OnCollisionEnter(); // 0x0000000181B22540-0x0000000181B22560
		private void OnCollisionExit(); // 0x0000000181B22580-0x0000000181B225A0
		private void OnCollisionEnter2D(); // 0x0000000181B22520-0x0000000181B22540
		private void OnCollisionExit2D(); // 0x0000000181B22560-0x0000000181B22580
		private void OnMouseEnter(); // 0x0000000181B22600-0x0000000181B22620
		private void OnMouseExit(); // 0x0000000181B22620-0x0000000181B22640
		private void OnMouseDown(); // 0x0000000181B225E0-0x0000000181B22600
		private void OnMouseUp(); // 0x0000000181B22640-0x0000000181B22660
		protected abstract void HandleGameEvent(EmitterGameEvent gameEvent);
	}
}
