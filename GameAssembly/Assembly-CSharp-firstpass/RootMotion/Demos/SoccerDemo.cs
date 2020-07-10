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
	[RequireComponent] // 0x00000001800DD1E0-0x00000001800DD230
	public class SoccerDemo : UnityEngine.MonoBehaviour // TypeDefIndex: 9542
	{
		// Fields
		private Animator animator; // 0x18
		private Vector3 defaultPosition; // 0x20
		private Quaternion defaultRotation; // 0x2C
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ResetDelayed>d__4 : IEnumerator<object> // TypeDefIndex: 9543
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public SoccerDemo <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ResetDelayed>d__4(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018183E7A0-0x000000018183E910
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018183E910-0x000000018183E960
		}
	
		// Constructors
		public SoccerDemo(); // 0x0000000180407560-0x0000000180407570
	
		// Methods
		private void Start(); // 0x000000018183D180-0x000000018183D280
		[IteratorStateMachine] // 0x00000001800DD650-0x00000001800DD6A0
		private IEnumerator ResetDelayed(); // 0x000000018183D120-0x000000018183D180
	}
}
