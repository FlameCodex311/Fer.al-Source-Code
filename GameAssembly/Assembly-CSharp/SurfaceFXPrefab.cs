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

public class SurfaceFXPrefab : ManagedBehaviour // TypeDefIndex: 10455
{
	// Fields
	public bool destroyWhenFinished; // 0x50
	private List<ParticleSystem> _particleSystems; // 0x58
	private Color? _startingColor; // 0x60
	private Color? _color; // 0x74
	private List<FX_ColorizePerSurface> _colorizePerSurfaces; // 0x88

	// Properties
	private List<ParticleSystem> ParticleSystems { get; } // 0x0000000181205A80-0x0000000181205B00 
	private List<FX_ColorizePerSurface> colorizePerSurfaces { get; } // 0x0000000181205B00-0x0000000181205B90 
	public bool IsPlaying { get; } // 0x0000000181205A30-0x0000000181205A80 
	private bool IsAnyParticleSystemEmitting { get; } // 0x0000000181205860-0x0000000181205A30 
	private bool IsAnyParticleSystemActive { get; } // 0x00000001812056A0-0x0000000181205860 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <UpdateRoutine>d__19 : IEnumerator<object> // TypeDefIndex: 10456
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SurfaceFXPrefab <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <UpdateRoutine>d__19(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181213390-0x00000001812134D0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812134D0-0x0000000181213520
	}

	// Constructors
	public SurfaceFXPrefab(); // 0x0000000181205640-0x00000001812056A0

	// Methods
	public void ColorizeParticles(Color? inColor = default); // 0x0000000181204D00-0x0000000181204F20
	public void SetLoop(bool inLoop); // 0x00000001812051F0-0x0000000181205400
	public void Play(bool inIncludeChildren = true /* Metadata: 0x00781CDD */); // 0x0000000181204FE0-0x00000001812051F0
	public void Stop(bool inIncludeChildren = true /* Metadata: 0x00781CDE */); // 0x0000000181205400-0x00000001812055E0
	[IteratorStateMachine] // 0x000000018011D030-0x000000018011D080
	private IEnumerator UpdateRoutine(); // 0x00000001812055E0-0x0000000181205640
	public override void MOnEnable(); // 0x0000000181204F60-0x0000000181204FE0
	public override void MOnDisable(); // 0x0000000181204F20-0x0000000181204F60
}

