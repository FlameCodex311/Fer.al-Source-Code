/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.FinalIK
{
	public abstract class OffsetModifier : UnityEngine.MonoBehaviour // TypeDefIndex: 10009
	{
		// Fields
		[Tooltip] // 0x000000018020DFA0-0x000000018020DFD0
		public float weight; // 0x18
		[Tooltip] // 0x00000001802837F0-0x0000000180283820
		public FullBodyBipedIK ik; // 0x20
		protected float lastTime; // 0x28
	
		// Properties
		protected float deltaTime { get; } // 0x000000018163B440-0x000000018163B460 
	
		// Nested types
		[Serializable]
		public class OffsetLimits // TypeDefIndex: 10010
		{
			// Fields
			[Tooltip] // 0x0000000180283AF0-0x0000000180283B20
			public FullBodyBipedEffector effector; // 0x10
			[Tooltip] // 0x0000000180283C20-0x0000000180283C50
			public float spring; // 0x14
			[Tooltip] // 0x0000000180283D90-0x0000000180283DC0
			public bool x; // 0x18
			[Tooltip] // 0x0000000180283D90-0x0000000180283DC0
			public bool y; // 0x19
			[Tooltip] // 0x0000000180283D90-0x0000000180283DC0
			public bool z; // 0x1A
			[Tooltip] // 0x0000000180284100-0x0000000180284130
			public float minX; // 0x1C
			[Tooltip] // 0x0000000180284100-0x0000000180284130
			public float maxX; // 0x20
			[Tooltip] // 0x0000000180284100-0x0000000180284130
			public float minY; // 0x24
			[Tooltip] // 0x0000000180284100-0x0000000180284130
			public float maxY; // 0x28
			[Tooltip] // 0x0000000180284100-0x0000000180284130
			public float minZ; // 0x2C
			[Tooltip] // 0x0000000180284100-0x0000000180284130
			public float maxZ; // 0x30
	
			// Constructors
			public OffsetLimits(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			public void Apply(IKEffector e, Quaternion rootRotation); // 0x000000018163AC80-0x000000018163AF30
			private float SpringAxis(float value, float min, float max); // 0x000000018163AF30-0x000000018163B070
			private float Spring(float value, float limit, bool negative); // 0x000000018163B070-0x000000018163B160
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Initiate>d__8 : IEnumerator<object> // TypeDefIndex: 10011
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public OffsetModifier <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Initiate>d__8(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000181648C50-0x0000000181648DC0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181648DC0-0x0000000181648E10
		}
	
		// Constructors
		protected OffsetModifier(); // 0x0000000181381DA0-0x0000000181381DB0
	
		// Methods
		protected abstract void OnModifyOffset();
		protected virtual void Start(); // 0x000000018163B7D0-0x000000018163B840
		[IteratorStateMachine] // 0x0000000180283970-0x00000001802839C0
		private IEnumerator Initiate(); // 0x000000018163B560-0x000000018163B5C0
		private void ModifyOffset(); // 0x000000018163B5C0-0x000000018163B6D0
		protected void ApplyLimits(OffsetLimits[] limits); // 0x000000018163B460-0x000000018163B560
		protected virtual void OnDestroy(); // 0x000000018163B6D0-0x000000018163B7D0
	}
}
