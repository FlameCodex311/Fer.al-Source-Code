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

namespace RootMotion.FinalIK
{
	public abstract class OffsetModifierVRIK : UnityEngine.MonoBehaviour // TypeDefIndex: 10012
	{
		// Fields
		[Tooltip] // 0x000000018020DFA0-0x000000018020DFD0
		public float weight; // 0x18
		[Tooltip] // 0x00000001802864F0-0x0000000180286520
		public VRIK ik; // 0x20
		private float lastTime; // 0x28
	
		// Properties
		protected float deltaTime { get; } // 0x000000018163B440-0x000000018163B460 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Initiate>d__7 : IEnumerator<object> // TypeDefIndex: 10013
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public OffsetModifierVRIK <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Initiate>d__7(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000181648A90-0x0000000181648C00
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181648C00-0x0000000181648C50
		}
	
		// Constructors
		protected OffsetModifierVRIK(); // 0x0000000181381DA0-0x0000000181381DB0
	
		// Methods
		protected abstract void OnModifyOffset();
		protected virtual void Start(); // 0x000000018163B3D0-0x000000018163B440
		[IteratorStateMachine] // 0x00000001802866C0-0x0000000180286710
		private IEnumerator Initiate(); // 0x000000018163B160-0x000000018163B1C0
		private void ModifyOffset(); // 0x000000018163B1C0-0x000000018163B2D0
		protected virtual void OnDestroy(); // 0x000000018163B2D0-0x000000018163B3D0
	}
}
