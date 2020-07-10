/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia
{
	public class Growth : UnityEngine.MonoBehaviour // TypeDefIndex: 9104
	{
		// Fields
		[Range] // 0x00000001800F1CB0-0x00000001800F1D00
		[Tooltip] // 0x00000001800F1CB0-0x00000001800F1D00
		public float m_startScale; // 0x18
		[Range] // 0x00000001800F1E60-0x00000001800F1EB0
		[Tooltip] // 0x00000001800F1E60-0x00000001800F1EB0
		public float m_endScale; // 0x1C
		[Range] // 0x00000001800F2180-0x00000001800F21D0
		[Tooltip] // 0x00000001800F2180-0x00000001800F21D0
		public float m_scaleVariance; // 0x20
		[Range] // 0x00000001800F2410-0x00000001800F2460
		[Tooltip] // 0x00000001800F2410-0x00000001800F2460
		public float m_growthTime; // 0x24
		private float m_actualEndScale; // 0x28
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Grow>d__7 : IEnumerator<object> // TypeDefIndex: 9105
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Growth <>4__this; // 0x20
			private float <deltaScale>5__2; // 0x28
			private float <finishTime>5__3; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Grow>d__7(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001817AAE40-0x00000001817AAFF0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001817AAFF0-0x00000001817AB040
		}
	
		// Constructors
		public Growth(); // 0x0000000181785210-0x0000000181785240
	
		// Methods
		private void Start(); // 0x0000000180B2D770-0x0000000180B2D790
		public virtual void Initialise(); // 0x0000000181785180-0x0000000181785210
		[IteratorStateMachine] // 0x00000001800F25F0-0x00000001800F2640
		private IEnumerator Grow(); // 0x0000000181785120-0x0000000181785180
		public virtual void Die(); // 0x00000001817850B0-0x0000000181785120
	}
}
