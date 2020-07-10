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
	public class LockPickingRingModelController : MonoBehaviour // TypeDefIndex: 16156
	{
		// Fields
		public List<RingInfo> ringVariatons; // 0x20
		private RingInfo _currentRing; // 0x28
		private float elapsedTime; // 0x30
		private float fadeTime; // 0x34
		private Color colorA; // 0x38
		private Color colorB; // 0x48
	
		// Properties
		public bool IsRingBetweenAngles { get; } // 0x00000001813F2570-0x00000001813F2680 
	
		// Nested types
		[Serializable]
		public class RingInfo // TypeDefIndex: 16157
		{
			// Fields
			public Image ringImage; // 0x10
			public float minAngle; // 0x18
			public float maxAngle; // 0x1C
			public List<Sprite> ringLevelSprites; // 0x20
	
			// Constructors
			public RingInfo(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <FadeOut>d__14 : IEnumerator<object> // TypeDefIndex: 16158
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public LockPickingRingModelController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <FadeOut>d__14(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813FAD20-0x00000001813FAEB0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813FAEB0-0x00000001813FAF00
		}
	
		// Constructors
		public LockPickingRingModelController(); // 0x0000000180E095D0-0x0000000180E095E0
	
		// Methods
		public void Setup(int inRingVariantIndex, int inLevelIndex, LockPickingRingController inParent); // 0x00000001813F2050-0x00000001813F2340
		public void Rotate(float amount); // 0x00000001813F1EE0-0x00000001813F1F40
		public void Unlock(bool fadeImmediate = false /* Metadata: 0x0078542D */); // 0x00000001813F2560-0x00000001813F2570
		public void SetUpFadeOut(float time); // 0x00000001813F1F40-0x00000001813F2050
		public void UnlockFade(bool immediate = false /* Metadata: 0x0078542E */); // 0x00000001813F2340-0x00000001813F2560
		[IteratorStateMachine] // 0x0000000180130CE0-0x0000000180130D30
		public IEnumerator FadeOut(); // 0x00000001813F1E80-0x00000001813F1EE0
	}
}
