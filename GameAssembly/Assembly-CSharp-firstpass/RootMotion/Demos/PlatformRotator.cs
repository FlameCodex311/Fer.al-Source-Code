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
	public class PlatformRotator : UnityEngine.MonoBehaviour // TypeDefIndex: 9837
	{
		// Fields
		public float maxAngle; // 0x18
		public float switchRotationTime; // 0x1C
		public float random; // 0x20
		public float rotationSpeed; // 0x24
		public Vector3 movePosition; // 0x28
		public float moveSpeed; // 0x34
		public int characterLayer; // 0x38
		private Quaternion defaultRotation; // 0x3C
		private Quaternion targetRotation; // 0x4C
		private Vector3 targetPosition; // 0x5C
		private Vector3 velocity; // 0x68
		private Rigidbody r; // 0x78
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <SwitchRotation>d__14 : IEnumerator<object> // TypeDefIndex: 9838
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public PlatformRotator <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <SwitchRotation>d__14(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000181383AD0-0x0000000181383C60
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181383C60-0x0000000181384250
		}
	
		// Constructors
		public PlatformRotator(); // 0x0000000181381A00-0x0000000181381A30
	
		// Methods
		private void Start(); // 0x0000000181381820-0x00000001813819A0
		private void FixedUpdate(); // 0x0000000181381350-0x0000000181381660
		[IteratorStateMachine] // 0x00000001802187A0-0x00000001802187F0
		private IEnumerator SwitchRotation(); // 0x00000001813819A0-0x0000000181381A00
		private void OnCollisionEnter(Collision collision); // 0x0000000181381660-0x0000000181381740
		private void OnCollisionExit(Collision collision); // 0x0000000181381740-0x0000000181381820
	}
}
