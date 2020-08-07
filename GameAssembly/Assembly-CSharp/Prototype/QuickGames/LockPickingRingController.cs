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

namespace Prototype.QuickGames
{
	public class LockPickingRingController : MonoBehaviour // TypeDefIndex: 14896
	{
		// Fields
		public List<GameObject> ringModelPrefabs; // 0x20
		private LockPickingController parentController; // 0x28
		private float rotationSpeed; // 0x30
		private bool moving; // 0x34
		private GameObject ringModel; // 0x38
		private LockPickingRingModelController ringModelController; // 0x40
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float <FadeTime>k__BackingField; // 0x48
	
		// Properties
		public float FadeTime { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001804D5810-0x00000001804D5820 0x00000001809892C0-0x00000001809892D0
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <FadeOut>d__17 : IEnumerator<object> // TypeDefIndex: 14897
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public LockPickingRingController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <FadeOut>d__17(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001809921C0-0x00000001809923B0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001809923B0-0x0000000180992400
		}
	
		// Constructors
		public LockPickingRingController(); // 0x00000001803743C0-0x00000001803743D0
	
		// Methods
		public void Setup(int ringIndex, QGEChestSettings.RingInfo inRingInfo, float inDirection, int levelTypeIndex, LockPickingController lockPickingController); // 0x0000000180988FA0-0x0000000180989170
		public void EnteredByPick(); // 0x0000000180988F00-0x0000000180988F30
		public bool CanPickEnterRing(); // 0x0000000180988DE0-0x0000000180988F00
		public void Unlock(); // 0x00000001809891B0-0x00000001809891E0
		public void Freeze(); // 0x0000000180988F90-0x0000000180988FA0
		public void UnFreeze(); // 0x00000001809891A0-0x00000001809891B0
		private void Update(); // 0x00000001809891E0-0x00000001809892C0
		[IteratorStateMachine] // 0x000000018024E550-0x000000018024E5A0
		public IEnumerator FadeOut(); // 0x0000000180988F30-0x0000000180988F90
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <Setup>b__6_0(); // 0x0000000180989170-0x00000001809891A0
	}
}
