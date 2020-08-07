/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia
{
	public class Growth : UnityEngine.MonoBehaviour // TypeDefIndex: 9270
	{
		// Fields
		[Range] // 0x0000000180251210-0x0000000180251260
		[Tooltip] // 0x0000000180251210-0x0000000180251260
		public float m_startScale; // 0x18
		[Range] // 0x0000000180251490-0x00000001802514E0
		[Tooltip] // 0x0000000180251490-0x00000001802514E0
		public float m_endScale; // 0x1C
		[Range] // 0x00000001802518A0-0x00000001802518F0
		[Tooltip] // 0x00000001802518A0-0x00000001802518F0
		public float m_scaleVariance; // 0x20
		[Range] // 0x0000000180251C20-0x0000000180251C70
		[Tooltip] // 0x0000000180251C20-0x0000000180251C70
		public float m_growthTime; // 0x24
		private float m_actualEndScale; // 0x28
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Grow>d__7 : IEnumerator<object> // TypeDefIndex: 9271
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Growth <>4__this; // 0x20
			private float <deltaScale>5__2; // 0x28
			private float <finishTime>5__3; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Grow>d__7(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001819A46D0-0x00000001819A4870
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001819A4870-0x00000001819A48C0
		}
	
		// Constructors
		public Growth(); // 0x0000000181999E40-0x0000000181999E70
	
		// Methods
		private void Start(); // 0x0000000181423DB0-0x0000000181423DD0
		public virtual void Initialise(); // 0x0000000181999DB0-0x0000000181999E40
		[IteratorStateMachine] // 0x0000000180251EA0-0x0000000180251EF0
		private IEnumerator Grow(); // 0x0000000181999D50-0x0000000181999DB0
		public virtual void Die(); // 0x0000000181999CE0-0x0000000181999D50
	}
}
