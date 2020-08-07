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
	public class CameraStateModifierTrigger : CameraSystemTriggerBase // TypeDefIndex: 14585
	{
		// Fields
		[SerializeField] // 0x000000018027B4A0-0x000000018027B4E0
		[Tooltip] // 0x000000018027B4A0-0x000000018027B4E0
		private CameraStateModifierBase _cameraStateModifierTarget; // 0x70
		[SerializeField] // 0x000000018027C4E0-0x000000018027C520
		[Tooltip] // 0x000000018027C4E0-0x000000018027C520
		private bool _ignoreTriggerExit; // 0x78
		private bool _inTrigger; // 0x79
		private bool _selfieCamActive; // 0x7A
	
		// Properties
		private bool InTrigger { get; set; } // 0x0000000180968EF0-0x0000000180968F00 0x0000000180CA9B90-0x0000000180CA9C00
		private bool SelfieCamActive { get; set; } // 0x000000018098AFB0-0x000000018098AFC0 0x0000000180CA9C00-0x0000000180CA9C60
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <InternalSetMod>d__17 : IEnumerator<object> // TypeDefIndex: 14586
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public bool inEnabled; // 0x20
			public CameraStateModifierTrigger <>4__this; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <InternalSetMod>d__17(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180CBDC50-0x0000000180CBDD40
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180CBDD40-0x0000000180CBDFA0
		}
	
		// Constructors
		public CameraStateModifierTrigger(); // 0x0000000180CA9B20-0x0000000180CA9B90
	
		// Methods
		private void OnEnable(); // 0x0000000180CA99B0-0x0000000180CA9A40
		private new void OnDestroy(); // 0x0000000180CA9920-0x0000000180CA99B0
		protected override void TriggerEntered(); // 0x0000000180CA9AB0-0x0000000180CA9AE0
		protected override void TriggerExited(); // 0x0000000180CA9AE0-0x0000000180CA9B20
		private void OnPlayerCameraChanged(PlayerCameraMessage inMessage); // 0x0000000180CA9A40-0x0000000180CA9AB0
		private void EnableMod(); // 0x0000000180CA9840-0x0000000180CA98B0
		private void DisableMod(); // 0x0000000180CA97D0-0x0000000180CA9840
		[IteratorStateMachine] // 0x000000018027C730-0x000000018027C780
		private IEnumerator InternalSetMod(bool inEnabled); // 0x0000000180CA98B0-0x0000000180CA9920
	}
}
