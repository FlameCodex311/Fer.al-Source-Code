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

namespace FIMSpace.Basics
{
	public class FBasic_Shared_PanelAnimations : UnityEngine.MonoBehaviour // TypeDefIndex: 10349
	{
		// Fields
		[Tooltip] // 0x00000001801E58A0-0x00000001801E58D0
		public float AnimationTime; // 0x18
		[Tooltip] // 0x00000001801E5A30-0x00000001801E5A60
		public float EaseExtraValue; // 0x1C
		private Transform buttonTransform; // 0x20
		private Vector3 buttonInitPosition; // 0x28
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ClickAniamtion>d__6 : IEnumerator<object> // TypeDefIndex: 10350
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public FBasic_Shared_PanelAnimations <>4__this; // 0x20
			private float <time>5__2; // 0x28
			private Vector3 <currentPos>5__3; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ClickAniamtion>d__6(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x000000018108CCF0-0x000000018108D0D0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x000000018108D0D0-0x000000018108D120
		}
	
		// Constructors
		public FBasic_Shared_PanelAnimations(); // 0x0000000181081310-0x0000000181081330
	
		// Methods
		protected virtual void Start(); // 0x0000000181081290-0x0000000181081310
		public virtual void Click(); // 0x0000000181081220-0x0000000181081290
		[IteratorStateMachine] // 0x00000001801E5C20-0x00000001801E5C70
		private IEnumerator ClickAniamtion(); // 0x00000001810811C0-0x0000000181081220
	}
}
