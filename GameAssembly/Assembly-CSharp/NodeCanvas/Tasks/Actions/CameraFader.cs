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

namespace NodeCanvas.Tasks.Actions
{
	public class CameraFader : ManagedBehaviour // TypeDefIndex: 15349
	{
		// Fields
		private static CameraFader _current; // 0x00
		private float alpha; // 0x50
		private Texture2D _blackTexture; // 0x58
	
		// Properties
		private Texture2D blackTexture { get; } // 0x0000000180CBFC00-0x0000000180CBFCF0 
		public static CameraFader current { get; } // 0x0000000180CBFCF0-0x0000000180CBFE30 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <CoroutineFadeIn>d__9 : IEnumerator<object> // TypeDefIndex: 15350
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CameraFader <>4__this; // 0x20
			public float time; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <CoroutineFadeIn>d__9(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180CD0F50-0x0000000180CD1020
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180CD1020-0x0000000180CD1070
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <CoroutineFadeOut>d__10 : IEnumerator<object> // TypeDefIndex: 15351
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CameraFader <>4__this; // 0x20
			public float time; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <CoroutineFadeOut>d__10(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180CD1070-0x0000000180CD1140
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180CD1140-0x0000000180CD1190
		}
	
		// Constructors
		public CameraFader(); // 0x0000000180CBFBA0-0x0000000180CBFC00
	
		// Methods
		public void FadeIn(float time); // 0x0000000180CBF890-0x0000000180CBF910
		public void FadeOut(float time); // 0x0000000180CBF910-0x0000000180CBF990
		[IteratorStateMachine] // 0x0000000180255490-0x00000001802554E0
		private IEnumerator CoroutineFadeIn(float time); // 0x0000000180CBF7B0-0x0000000180CBF820
		[IteratorStateMachine] // 0x0000000180255710-0x0000000180255760
		private IEnumerator CoroutineFadeOut(float time); // 0x0000000180CBF820-0x0000000180CBF890
		private void OnGUI(); // 0x0000000180CBF990-0x0000000180CBFBA0
	}
}
