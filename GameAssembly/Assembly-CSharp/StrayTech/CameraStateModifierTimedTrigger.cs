/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace StrayTech
{
	public class CameraStateModifierTimedTrigger : CameraSystemTriggerBase // TypeDefIndex: 13916
	{
		// Fields
		[SerializeField] // 0x000000018014CEF0-0x000000018014CF30
		[Tooltip] // 0x000000018014CEF0-0x000000018014CF30
		private CameraStateModifierBase _cameraStateModifierTarget; // 0x70
		[SerializeField] // 0x000000018014D090-0x000000018014D0D0
		[Tooltip] // 0x000000018014D090-0x000000018014D0D0
		private float _enabledDuration; // 0x78
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <DoTimedDisable>d__4 : IEnumerator<object> // TypeDefIndex: 13917
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CameraStateModifierTimedTrigger <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <DoTimedDisable>d__4(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018135EB20-0x000000018135EC20
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018135EC20-0x000000018135EC70
		}
	
		// Constructors
		public CameraStateModifierTimedTrigger(); // 0x000000018134AE10-0x000000018134AE90
	
		// Methods
		protected override void TriggerEntered(); // 0x000000018134AD80-0x000000018134AE10
		protected override void TriggerExited(); // 0x00000001803581E0-0x00000001803581F0
		[IteratorStateMachine] // 0x000000018014D2A0-0x000000018014D2F0
		private IEnumerator DoTimedDisable(); // 0x000000018134AD20-0x000000018134AD80
	}
}
