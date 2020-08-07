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
	public class LockPickingRingModelController : MonoBehaviour // TypeDefIndex: 14898
	{
		// Fields
		public List<RingInfo> ringVariatons; // 0x20
		private RingInfo _currentRing; // 0x28
		private float elapsedTime; // 0x30
		private float fadeTime; // 0x34
		private Color colorA; // 0x38
		private Color colorB; // 0x48
	
		// Properties
		public bool IsRingBetweenAngles { get; } // 0x00000001809899A0-0x0000000180989AB0 
	
		// Nested types
		[Serializable]
		public class RingInfo // TypeDefIndex: 14899
		{
			// Fields
			public Image ringImage; // 0x10
			public float minAngle; // 0x18
			public float maxAngle; // 0x1C
			public List<Sprite> ringLevelSprites; // 0x20
	
			// Constructors
			public RingInfo(); // 0x0000000180373240-0x0000000180373250
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <FadeOut>d__14 : IEnumerator<object> // TypeDefIndex: 14900
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public LockPickingRingModelController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <FadeOut>d__14(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180991FF0-0x0000000180992170
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180992170-0x00000001809921C0
		}
	
		// Constructors
		public LockPickingRingModelController(); // 0x00000001803743C0-0x00000001803743D0
	
		// Methods
		public void Setup(int inRingVariantIndex, int inLevelIndex, LockPickingRingController inParent); // 0x0000000180989490-0x0000000180989770
		public void Rotate(float amount); // 0x0000000180989330-0x0000000180989390
		public void Unlock(bool fadeImmediate = false /* Metadata: 0x007BB01F */); // 0x0000000180989990-0x00000001809899A0
		public void SetUpFadeOut(float time); // 0x0000000180989390-0x0000000180989490
		public void UnlockFade(bool immediate = false /* Metadata: 0x007BB020 */); // 0x0000000180989770-0x0000000180989990
		[IteratorStateMachine] // 0x000000018024F300-0x000000018024F350
		public IEnumerator FadeOut(); // 0x00000001809892D0-0x0000000180989330
	}
}
