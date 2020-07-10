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
	public class PlatformRotator : UnityEngine.MonoBehaviour // TypeDefIndex: 9550
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
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <SwitchRotation>d__14 : IEnumerator<object> // TypeDefIndex: 9551
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public PlatformRotator <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <SwitchRotation>d__14(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018183F180-0x000000018183F310
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018183F310-0x000000018183F360
		}
	
		// Constructors
		public PlatformRotator(); // 0x000000018183B220-0x000000018183B250
	
		// Methods
		private void Start(); // 0x000000018183B040-0x000000018183B1C0
		private void FixedUpdate(); // 0x000000018183AB50-0x000000018183AE70
		[IteratorStateMachine] // 0x00000001800DF4E0-0x00000001800DF530
		private IEnumerator SwitchRotation(); // 0x000000018183B1C0-0x000000018183B220
		private void OnCollisionEnter(Collision collision); // 0x000000018183AE70-0x000000018183AF60
		private void OnCollisionExit(Collision collision); // 0x000000018183AF60-0x000000018183B040
	}
}
