/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.AI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype
{
	public class Wander : ManagedBehaviour // TypeDefIndex: 16088
	{
		// Fields
		private NavMeshAgent _agent; // 0x50
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Navigate>d__2 : IEnumerator<object> // TypeDefIndex: 16089
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Wander <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Navigate>d__2(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181602BD0-0x0000000181602DF0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181602DF0-0x0000000181602E40
		}
	
		// Constructors
		public Wander(); // 0x00000001816087D0-0x0000000181608830
	
		// Methods
		public override void MStart(); // 0x0000000181608670-0x0000000181608770
		[IteratorStateMachine] // 0x0000000180104210-0x0000000180104260
		private IEnumerator Navigate(); // 0x0000000181608770-0x00000001816087D0
	}
}
