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
	public abstract class OffsetModifier : UnityEngine.MonoBehaviour // TypeDefIndex: 9475
	{
		// Fields
		[Tooltip] // 0x00000001800C2D70-0x00000001800C2DA0
		public float weight; // 0x18
		[Tooltip] // 0x00000001800C2E50-0x00000001800C2E80
		public FullBodyBipedIK ik; // 0x20
		protected float lastTime; // 0x28
	
		// Properties
		protected float deltaTime { get; } // 0x0000000181B0A6A0-0x0000000181B0A6C0 
	
		// Nested types
		[Serializable]
		public class OffsetLimits // TypeDefIndex: 9476
		{
			// Fields
			[Tooltip] // 0x00000001800C3410-0x00000001800C3440
			public FullBodyBipedEffector effector; // 0x10
			[Tooltip] // 0x00000001800C35A0-0x00000001800C35D0
			public float spring; // 0x14
			[Tooltip] // 0x00000001800C36D0-0x00000001800C3700
			public bool x; // 0x18
			[Tooltip] // 0x00000001800C36D0-0x00000001800C3700
			public bool y; // 0x19
			[Tooltip] // 0x00000001800C36D0-0x00000001800C3700
			public bool z; // 0x1A
			[Tooltip] // 0x00000001800C3AD0-0x00000001800C3B00
			public float minX; // 0x1C
			[Tooltip] // 0x00000001800C3AD0-0x00000001800C3B00
			public float maxX; // 0x20
			[Tooltip] // 0x00000001800C3AD0-0x00000001800C3B00
			public float minY; // 0x24
			[Tooltip] // 0x00000001800C3AD0-0x00000001800C3B00
			public float maxY; // 0x28
			[Tooltip] // 0x00000001800C3AD0-0x00000001800C3B00
			public float minZ; // 0x2C
			[Tooltip] // 0x00000001800C3AD0-0x00000001800C3B00
			public float maxZ; // 0x30
	
			// Constructors
			public OffsetLimits(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			public void Apply(IKEffector e, Quaternion rootRotation); // 0x0000000181B09EE0-0x0000000181B0A190
			private float SpringAxis(float value, float min, float max); // 0x0000000181B0A190-0x0000000181B0A2D0
			private float Spring(float value, float limit, bool negative); // 0x0000000181B0A2D0-0x0000000181B0A3C0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Initiate>d__8 : IEnumerator<object> // TypeDefIndex: 9477
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public OffsetModifier <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Initiate>d__8(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181B14E20-0x0000000181B14F90
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181B14F90-0x0000000181B14FE0
		}
	
		// Constructors
		protected OffsetModifier(); // 0x000000018183B940-0x000000018183B950
	
		// Methods
		protected abstract void OnModifyOffset();
		protected virtual void Start(); // 0x0000000181B0AA40-0x0000000181B0AAB0
		[IteratorStateMachine] // 0x00000001800C31D0-0x00000001800C3220
		private IEnumerator Initiate(); // 0x0000000181B0A7D0-0x0000000181B0A830
		private void ModifyOffset(); // 0x0000000181B0A830-0x0000000181B0A940
		protected void ApplyLimits(OffsetLimits[] limits); // 0x0000000181B0A6C0-0x0000000181B0A7D0
		protected virtual void OnDestroy(); // 0x0000000181B0A940-0x0000000181B0AA40
	}
}
