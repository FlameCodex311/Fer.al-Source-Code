/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.FinalIK
{
	public abstract class OffsetModifierVRIK : UnityEngine.MonoBehaviour // TypeDefIndex: 9478
	{
		// Fields
		[Tooltip] // 0x00000001800C2D70-0x00000001800C2DA0
		public float weight; // 0x18
		[Tooltip] // 0x00000001800C62D0-0x00000001800C6300
		public VRIK ik; // 0x20
		private float lastTime; // 0x28
	
		// Properties
		protected float deltaTime { get; } // 0x0000000181B0A6A0-0x0000000181B0A6C0 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Initiate>d__7 : IEnumerator<object> // TypeDefIndex: 9479
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public OffsetModifierVRIK <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Initiate>d__7(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181B14C60-0x0000000181B14DD0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181B14DD0-0x0000000181B14E20
		}
	
		// Constructors
		protected OffsetModifierVRIK(); // 0x000000018183B940-0x000000018183B950
	
		// Methods
		protected abstract void OnModifyOffset();
		protected virtual void Start(); // 0x0000000181B0A630-0x0000000181B0A6A0
		[IteratorStateMachine] // 0x00000001800C63D0-0x00000001800C6420
		private IEnumerator Initiate(); // 0x0000000181B0A3C0-0x0000000181B0A420
		private void ModifyOffset(); // 0x0000000181B0A420-0x0000000181B0A530
		protected virtual void OnDestroy(); // 0x0000000181B0A530-0x0000000181B0A630
	}
}
