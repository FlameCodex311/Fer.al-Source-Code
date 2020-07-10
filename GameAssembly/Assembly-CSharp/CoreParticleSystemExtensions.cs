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

public static class CoreParticleSystemExtensions // TypeDefIndex: 13408
{
	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <SetEmissionByRange>d__0 : IEnumerator<object> // TypeDefIndex: 13409
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <SetEmissionByRange>d__0(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181329FB0-0x000000018132A220
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018132A220-0x000000018132A270
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <EmitBurstCycle>d__4 : IEnumerator<object> // TypeDefIndex: 13410
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <EmitBurstCycle>d__4(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181327880-0x0000000181327C80
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181327C80-0x0000000181327CD0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <DoBurstEmit>d__6 : IEnumerator<object> // TypeDefIndex: 13411
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ParticleSystem.Burst inBurst; // 0x20
		public ParticleSystem ps; // 0x58
		private int <i>5__2; // 0x60

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <DoBurstEmit>d__6(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181324BE0-0x0000000181324D60
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181324D60-0x0000000181324DB0
	}

	// Methods
	[IteratorStateMachine] // 0x0000000180142E30-0x0000000180142E80
	private static IEnumerator DoBurstEmit(ParticleSystem ps, ParticleSystem.Burst inBurst); // 0x00000001813197D0-0x0000000181319860

	// Extension methods
	[IteratorStateMachine] // 0x0000000180140CE0-0x0000000180140D50
	public static IEnumerator SetEmissionByRange(this ParticleSystem ps, Transform inPlayerTransform, float inRangeForEnable = 50f /* Metadata: 0x00783C99 */, float inCheckTimeSeconds = 1f /* Metadata: 0x00783C9D */); // 0x0000000181319C20-0x0000000181319CB0
	public static void SetEmissionEnabled(this ParticleSystem ps, bool inEnabled); // 0x0000000181319CB0-0x0000000181319D50
	public static float GetEmissionRate(this ParticleSystem ps); // 0x0000000181319AB0-0x0000000181319B20
	public static void SetEmissionRate(this ParticleSystem ps, float inRate); // 0x0000000181319D50-0x0000000181319DE0
	[IteratorStateMachine] // 0x0000000180142670-0x00000001801426E0
	public static IEnumerator EmitBurstCycle(this ParticleSystem ps); // 0x0000000181319860-0x00000001813198C0
	public static void EmitBursts(this ParticleSystem ps, MonoBehaviour inCoroutineObject); // 0x00000001813198C0-0x0000000181319AB0
	public static void SetStartColor(this ParticleSystem ps, Color inColor); // 0x0000000181319DE0-0x0000000181319E70
	public static Color GetStartColor(this ParticleSystem ps); // 0x0000000181319B20-0x0000000181319BD0
	public static void SetDuration(this ParticleSystem ps, float inDuration); // 0x0000000181319BD0-0x0000000181319C20
	public static void SetStartSpeed(this ParticleSystem ps, float inSpeed); // 0x0000000181319EF0-0x0000000181319F70
	public static void SetStartSize(this ParticleSystem ps, float inSize); // 0x0000000181319E70-0x0000000181319EF0
}

