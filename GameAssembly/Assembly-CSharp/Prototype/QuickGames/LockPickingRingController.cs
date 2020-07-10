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

namespace Prototype.QuickGames
{
	public class LockPickingRingController : MonoBehaviour // TypeDefIndex: 16154
	{
		// Fields
		public List<GameObject> ringModelPrefabs; // 0x20
		private LockPickingController parentController; // 0x28
		private float rotationSpeed; // 0x30
		private bool moving; // 0x34
		private GameObject ringModel; // 0x38
		private LockPickingRingModelController ringModelController; // 0x40
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private float <FadeTime>k__BackingField; // 0x48
	
		// Properties
		public float FadeTime { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180487CC0-0x0000000180487CD0 0x0000000180DD2D70-0x0000000180DD2D80
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <FadeOut>d__17 : IEnumerator<object> // TypeDefIndex: 16155
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public LockPickingRingController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <FadeOut>d__17(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813FAF00-0x00000001813FB0F0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813FB0F0-0x00000001813FB140
		}
	
		// Constructors
		public LockPickingRingController(); // 0x0000000180E095D0-0x0000000180E095E0
	
		// Methods
		public void Setup(int ringIndex, QGEChestSettings.RingInfo inRingInfo, float inDirection, int levelTypeIndex, LockPickingController lockPickingController); // 0x00000001813F1B60-0x00000001813F1D30
		public void EnteredByPick(); // 0x00000001813F1AB0-0x00000001813F1AF0
		public bool CanPickEnterRing(); // 0x00000001813F1990-0x00000001813F1AB0
		public void Unlock(); // 0x00000001813F1D70-0x00000001813F1DA0
		public void Freeze(); // 0x00000001813F1B50-0x00000001813F1B60
		public void UnFreeze(); // 0x00000001813F1D60-0x00000001813F1D70
		private void Update(); // 0x00000001813F1DA0-0x00000001813F1E80
		[IteratorStateMachine] // 0x000000018012FD60-0x000000018012FDB0
		public IEnumerator FadeOut(); // 0x00000001813F1AF0-0x00000001813F1B50
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <Setup>b__6_0(); // 0x00000001813F1D30-0x00000001813F1D60
	}
}
