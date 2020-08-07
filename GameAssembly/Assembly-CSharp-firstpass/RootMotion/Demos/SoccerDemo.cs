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
	[RequireComponent] // 0x0000000180216B50-0x0000000180216BA0
	public class SoccerDemo : UnityEngine.MonoBehaviour // TypeDefIndex: 9829
	{
		// Fields
		private Animator animator; // 0x18
		private Vector3 defaultPosition; // 0x20
		private Quaternion defaultRotation; // 0x2C
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ResetDelayed>d__4 : IEnumerator<object> // TypeDefIndex: 9830
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public SoccerDemo <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ResetDelayed>d__4(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x000000018143FFA0-0x0000000181440100
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181440100-0x0000000181440150
		}
	
		// Constructors
		public SoccerDemo(); // 0x0000000180568C50-0x0000000180569020
	
		// Methods
		private void Start(); // 0x000000018143E9A0-0x000000018143EAA0
		[IteratorStateMachine] // 0x00000001802170E0-0x0000000180217130
		private IEnumerator ResetDelayed(); // 0x000000018143E940-0x000000018143E9A0
	}
}
