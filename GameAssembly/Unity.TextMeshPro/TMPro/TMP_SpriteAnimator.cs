/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 70: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8742-8901

namespace TMPro
{
	[DisallowMultipleComponent] // 0x00000001800B36B0-0x00000001800B36C0
	public class TMP_SpriteAnimator : UnityEngine.MonoBehaviour // TypeDefIndex: 8841
	{
		// Fields
		private Dictionary<int, bool> m_animations; // 0x18
		private TMP_Text m_TextComponent; // 0x20
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <DoSpriteAnimationInternal>d__7 : IEnumerator<object> // TypeDefIndex: 8842
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <DoSpriteAnimationInternal>d__7(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001811C8C50-0x00000001811C9A30
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001811C9A30-0x00000001811C9A80
		}
	
		// Constructors
		public TMP_SpriteAnimator(); // 0x00000001811A6670-0x00000001811A66E0
	
		// Methods
		private void Awake(); // 0x00000001811A6430-0x00000001811A6470
		private void OnEnable(); // 0x00000001803581E0-0x00000001803581F0
		private void OnDisable(); // 0x00000001803581E0-0x00000001803581F0
		public void StopAllAnimations(); // 0x00000001811A6620-0x00000001811A6670
		public void DoSpriteAnimation(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate); // 0x00000001811A6510-0x00000001811A6620
		[IteratorStateMachine] // 0x00000001801595C0-0x0000000180159610
		private IEnumerator DoSpriteAnimationInternal(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate); // 0x00000001811A6470-0x00000001811A6510
	}
}
