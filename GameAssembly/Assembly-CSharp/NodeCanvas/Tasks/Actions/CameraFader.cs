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

namespace NodeCanvas.Tasks.Actions
{
	public class CameraFader : MonoBehaviour // TypeDefIndex: 14249
	{
		// Fields
		private static CameraFader _current; // 0x00
		private float alpha; // 0x20
		private Texture2D _blackTexture; // 0x28
	
		// Properties
		private Texture2D blackTexture { get; } // 0x000000018174ACD0-0x000000018174ADC0 
		public static CameraFader current { get; } // 0x000000018174ADC0-0x000000018174AF10 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <CoroutineFadeIn>d__9 : IEnumerator<object> // TypeDefIndex: 14250
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CameraFader <>4__this; // 0x20
			public float time; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <CoroutineFadeIn>d__9(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181760930-0x0000000181760A00
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181760A00-0x0000000181760A50
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <CoroutineFadeOut>d__10 : IEnumerator<object> // TypeDefIndex: 14251
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CameraFader <>4__this; // 0x20
			public float time; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <CoroutineFadeOut>d__10(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181760A50-0x0000000181760B30
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181760B30-0x0000000181760B80
		}
	
		// Constructors
		public CameraFader(); // 0x0000000180E095D0-0x0000000180E095E0
	
		// Methods
		public void FadeIn(float time); // 0x000000018174A9C0-0x000000018174AA40
		public void FadeOut(float time); // 0x000000018174AA40-0x000000018174AAC0
		[IteratorStateMachine] // 0x00000001800F1FD0-0x00000001800F2020
		private IEnumerator CoroutineFadeIn(float time); // 0x000000018174A8E0-0x000000018174A950
		[IteratorStateMachine] // 0x00000001800F2230-0x00000001800F2280
		private IEnumerator CoroutineFadeOut(float time); // 0x000000018174A950-0x000000018174A9C0
		private void OnGUI(); // 0x000000018174AAC0-0x000000018174ACD0
	}
}
