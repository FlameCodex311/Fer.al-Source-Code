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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames
{
	public class LockPickingUIController : MonoBehaviour // TypeDefIndex: 16159
	{
		// Fields
		public List<Image> pickImages; // 0x20
		private int currentPick; // 0x28
		private int numPicks; // 0x2C
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <AnimatePickFadeOut>d__5 : IEnumerator<object> // TypeDefIndex: 16160
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <AnimatePickFadeOut>d__5(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813F9B70-0x00000001813F9D50
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813F9D50-0x00000001813F9DA0
		}
	
		// Constructors
		public LockPickingUIController(); // 0x0000000180E095D0-0x0000000180E095E0
	
		// Methods
		public void Setup(int numPicks); // 0x00000001813F27A0-0x00000001813F28D0
		public int BreakPick(); // 0x00000001813F2700-0x00000001813F27A0
		[IteratorStateMachine] // 0x00000001801316D0-0x0000000180131720
		private IEnumerator AnimatePickFadeOut(int pickIndex, float fadeTime = 0.5f /* Metadata: 0x0078542F */); // 0x00000001813F2680-0x00000001813F2700
	}
}
