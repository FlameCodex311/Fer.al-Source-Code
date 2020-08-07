/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.Demos
{
	public class ResetInteractionObject : UnityEngine.MonoBehaviour // TypeDefIndex: 9827
	{
		// Fields
		public float resetDelay; // 0x18
		private Vector3 defaultPosition; // 0x1C
		private Quaternion defaultRotation; // 0x28
		private Transform defaultParent; // 0x38
		private Rigidbody r; // 0x40
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ResetObject>d__7 : IEnumerator<object> // TypeDefIndex: 9828
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public float resetTime; // 0x20
			public ResetInteractionObject <>4__this; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ResetObject>d__7(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001813832D0-0x00000001813834D0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001813834D0-0x0000000181383520
		}
	
		// Constructors
		public ResetInteractionObject(); // 0x0000000181381DA0-0x0000000181381DB0
	
		// Methods
		private void Start(); // 0x0000000181381EC0-0x0000000181381F80
		private void OnPickUp(Transform t); // 0x0000000181381DB0-0x0000000181381E50
		[IteratorStateMachine] // 0x0000000180215F30-0x0000000180215F80
		private IEnumerator ResetObject(float resetTime); // 0x0000000181381E50-0x0000000181381EC0
	}
}
