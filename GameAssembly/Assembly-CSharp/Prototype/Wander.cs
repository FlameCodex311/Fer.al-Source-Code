/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.AI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype
{
	public class Wander : ManagedBehaviour // TypeDefIndex: 14827
	{
		// Fields
		private NavMeshAgent _agent; // 0x50
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Navigate>d__2 : IEnumerator<object> // TypeDefIndex: 14828
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Wander <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Navigate>d__2(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A3F670-0x0000000180A3F880
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A3F880-0x0000000180A3F8D0
		}
	
		// Constructors
		public Wander(); // 0x0000000180A44C10-0x0000000180A44C70
	
		// Methods
		public override void MStart(); // 0x0000000180A44AB0-0x0000000180A44BB0
		[IteratorStateMachine] // 0x0000000180220910-0x0000000180220960
		private IEnumerator Navigate(); // 0x0000000180A44BB0-0x0000000180A44C10
	}
}
