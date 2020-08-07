/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 71: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8908-9067

namespace TMPro
{
	[DisallowMultipleComponent] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class TMP_SpriteAnimator : UnityEngine.MonoBehaviour // TypeDefIndex: 9003
	{
		// Fields
		private Dictionary<int, bool> m_animations; // 0x18
		private TMP_Text m_TextComponent; // 0x20
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <DoSpriteAnimationInternal>d__7 : IEnumerator<object> // TypeDefIndex: 9004
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TMP_SpriteAnimator <>4__this; // 0x20
			public int start; // 0x28
			public int end; // 0x2C
			public TMP_SpriteAsset spriteAsset; // 0x30
			public int currentCharacter; // 0x38
			public int framerate; // 0x3C
			private int <currentFrame>5__2; // 0x40
			private TMP_CharacterInfo <charInfo>5__3; // 0x48
			private int <materialIndex>5__4; // 0x1A0
			private int <vertexIndex>5__5; // 0x1A4
			private TMP_MeshInfo <meshInfo>5__6; // 0x1A8
			private float <elapsedTime>5__7; // 0x1F0
			private float <targetTime>5__8; // 0x1F4
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <DoSpriteAnimationInternal>d__7(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001805CD950-0x00000001805CE6D0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001805CE6D0-0x00000001805CE720
		}
	
		// Constructors
		public TMP_SpriteAnimator(); // 0x00000001805AB940-0x00000001805AB9B0
	
		// Methods
		private void Awake(); // 0x00000001805AB700-0x00000001805AB740
		private void OnEnable(); // 0x00000001803774A0-0x00000001803774B0
		private void OnDisable(); // 0x00000001803774A0-0x00000001803774B0
		public void StopAllAnimations(); // 0x00000001805AB8F0-0x00000001805AB940
		public void DoSpriteAnimation(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate); // 0x00000001805AB7E0-0x00000001805AB8F0
		[IteratorStateMachine] // 0x00000001801F0D50-0x00000001801F0DA0
		private IEnumerator DoSpriteAnimationInternal(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate); // 0x00000001805AB740-0x00000001805AB7E0
	}
}
