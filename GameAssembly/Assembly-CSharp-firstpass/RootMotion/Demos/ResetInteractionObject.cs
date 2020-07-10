/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.Demos
{
	public class ResetInteractionObject : UnityEngine.MonoBehaviour // TypeDefIndex: 9540
	{
		// Fields
		public float resetDelay; // 0x18
		private Vector3 defaultPosition; // 0x1C
		private Quaternion defaultRotation; // 0x28
		private Transform defaultParent; // 0x38
		private Rigidbody r; // 0x40
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ResetObject>d__7 : IEnumerator<object> // TypeDefIndex: 9541
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public float resetTime; // 0x20
			public ResetInteractionObject <>4__this; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ResetObject>d__7(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018183E960-0x000000018183EB70
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018183EB70-0x000000018183EBC0
		}
	
		// Constructors
		public ResetInteractionObject(); // 0x000000018183B940-0x000000018183B950
	
		// Methods
		private void Start(); // 0x000000018183BA60-0x000000018183BB30
		private void OnPickUp(Transform t); // 0x000000018183B950-0x000000018183B9F0
		[IteratorStateMachine] // 0x00000001800DC460-0x00000001800DC4B0
		private IEnumerator ResetObject(float resetTime); // 0x000000018183B9F0-0x000000018183BA60
	}
}
