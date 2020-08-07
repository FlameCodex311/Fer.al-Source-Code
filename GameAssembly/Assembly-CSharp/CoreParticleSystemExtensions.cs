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

public static class CoreParticleSystemExtensions // TypeDefIndex: 11079
{
	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <SetEmissionByRange>d__0 : IEnumerator<object> // TypeDefIndex: 11080
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Transform inPlayerTransform; // 0x20
		public ParticleSystem ps; // 0x28
		public float inRangeForEnable; // 0x30
		public float inCheckTimeSeconds; // 0x34
		private ParticleSystem.EmissionModule <em>5__2; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <SetEmissionByRange>d__0(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180AAFA30-0x0000000180AAFC90
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180AAFC90-0x0000000180AB0110
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <EmitBurstCycle>d__4 : IEnumerator<object> // TypeDefIndex: 11081
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ParticleSystem ps; // 0x20
		private float <timer>5__2; // 0x28
		private int <burstCount>5__3; // 0x2C
		private Vector3 <emitPosition>5__4; // 0x30
		private ParticleSystem.Burst[] <bursts>5__5; // 0x40
		private int <burstsTriggered>5__6; // 0x48

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <EmitBurstCycle>d__4(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180AADD40-0x0000000180AAE130
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180AAE130-0x0000000180AAE180
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <DoBurstEmit>d__6 : IEnumerator<object> // TypeDefIndex: 11082
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ParticleSystem.Burst inBurst; // 0x20
		public ParticleSystem ps; // 0x58
		private int <i>5__2; // 0x60

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <DoBurstEmit>d__6(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180AAC660-0x0000000180AAC7E0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180AAC7E0-0x0000000180AAC830
	}

	// Methods
	[IteratorStateMachine] // 0x0000000180226600-0x0000000180226650
	private static IEnumerator DoBurstEmit(ParticleSystem ps, ParticleSystem.Burst inBurst); // 0x0000000180A97D60-0x0000000180A97DF0

	// Extension methods
	[IteratorStateMachine] // 0x0000000180225870-0x00000001802258E0
	public static IEnumerator SetEmissionByRange(this ParticleSystem ps, Transform inPlayerTransform, float inRangeForEnable = 50f /* Metadata: 0x0077C754 */, float inCheckTimeSeconds = 1f /* Metadata: 0x0077C758 */); // 0x0000000180A981B0-0x0000000180A98240
	public static void SetEmissionEnabled(this ParticleSystem ps, bool inEnabled); // 0x0000000180A98240-0x0000000180A982E0
	public static float GetEmissionRate(this ParticleSystem ps); // 0x0000000180A98040-0x0000000180A980B0
	public static void SetEmissionRate(this ParticleSystem ps, float inRate); // 0x0000000180A982E0-0x0000000180A98370
	[IteratorStateMachine] // 0x0000000180226280-0x00000001802262F0
	public static IEnumerator EmitBurstCycle(this ParticleSystem ps); // 0x0000000180A97DF0-0x0000000180A97E50
	public static void EmitBursts(this ParticleSystem ps, MonoBehaviour inCoroutineObject); // 0x0000000180A97E50-0x0000000180A98040
	public static void SetStartColor(this ParticleSystem ps, Color inColor); // 0x0000000180A98370-0x0000000180A98400
	public static Color GetStartColor(this ParticleSystem ps); // 0x0000000180A980B0-0x0000000180A98160
	public static void SetDuration(this ParticleSystem ps, float inDuration); // 0x0000000180A98160-0x0000000180A981B0
	public static void SetStartSpeed(this ParticleSystem ps, float inSpeed); // 0x0000000180A98480-0x0000000180A98500
	public static void SetStartSize(this ParticleSystem ps, float inSize); // 0x0000000180A98400-0x0000000180A98480
}

