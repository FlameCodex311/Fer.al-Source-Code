/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype.QuickGames
{
	public class LockPickingUIController : MonoBehaviour // TypeDefIndex: 14901
	{
		// Fields
		public List<Image> pickImages; // 0x20
		private int currentPick; // 0x28
		private int numPicks; // 0x2C
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <AnimatePickFadeOut>d__5 : IEnumerator<object> // TypeDefIndex: 14902
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public LockPickingUIController <>4__this; // 0x20
			public int pickIndex; // 0x28
			public float fadeTime; // 0x2C
			private Image <fadingImage>5__2; // 0x30
			private Color <colorA>5__3; // 0x38
			private Color <colorB>5__4; // 0x48
			private float <elapsedTime>5__5; // 0x58
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <AnimatePickFadeOut>d__5(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180990E90-0x0000000180991060
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180991060-0x00000001809910B0
		}
	
		// Constructors
		public LockPickingUIController(); // 0x00000001803743C0-0x00000001803743D0
	
		// Methods
		public void Setup(int numPicks); // 0x0000000180989BD0-0x0000000180989CF0
		public int BreakPick(); // 0x0000000180989B30-0x0000000180989BD0
		[IteratorStateMachine] // 0x0000000180251540-0x0000000180251590
		private IEnumerator AnimatePickFadeOut(int pickIndex, float fadeTime = 0.5f /* Metadata: 0x007BB021 */); // 0x0000000180989AB0-0x0000000180989B30
	}
}
