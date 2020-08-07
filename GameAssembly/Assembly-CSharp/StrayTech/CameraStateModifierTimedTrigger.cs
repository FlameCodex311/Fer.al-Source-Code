/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace StrayTech
{
	public class CameraStateModifierTimedTrigger : CameraSystemTriggerBase // TypeDefIndex: 14583
	{
		// Fields
		[SerializeField] // 0x000000018027B4A0-0x000000018027B4E0
		[Tooltip] // 0x000000018027B4A0-0x000000018027B4E0
		private CameraStateModifierBase _cameraStateModifierTarget; // 0x70
		[SerializeField] // 0x000000018027B6C0-0x000000018027B700
		[Tooltip] // 0x000000018027B6C0-0x000000018027B700
		private float _enabledDuration; // 0x78
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <DoTimedDisable>d__4 : IEnumerator<object> // TypeDefIndex: 14584
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CameraStateModifierTimedTrigger <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <DoTimedDisable>d__4(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180CBD730-0x0000000180CBD830
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180CBD830-0x0000000180CBD880
		}
	
		// Constructors
		public CameraStateModifierTimedTrigger(); // 0x0000000180CA9750-0x0000000180CA97D0
	
		// Methods
		protected override void TriggerEntered(); // 0x0000000180CA96C0-0x0000000180CA9750
		protected override void TriggerExited(); // 0x00000001803774A0-0x00000001803774B0
		[IteratorStateMachine] // 0x000000018027B8C0-0x000000018027B910
		private IEnumerator DoTimedDisable(); // 0x0000000180CA9660-0x0000000180CA96C0
	}
}
