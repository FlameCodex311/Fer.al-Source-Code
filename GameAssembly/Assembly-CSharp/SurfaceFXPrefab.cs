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

public class SurfaceFXPrefab : ManagedBehaviour // TypeDefIndex: 11932
{
	// Fields
	public bool destroyWhenFinished; // 0x50
	private List<ParticleSystem> _particleSystems; // 0x58
	private Color? _startingColor; // 0x60
	private Color? _color; // 0x74
	private List<FX_ColorizePerSurface> _colorizePerSurfaces; // 0x88

	// Properties
	private List<ParticleSystem> ParticleSystems { get; } // 0x0000000180CBB2F0-0x0000000180CBB370 
	private List<FX_ColorizePerSurface> colorizePerSurfaces { get; } // 0x0000000180CBB370-0x0000000180CBB400 
	public bool IsPlaying { get; } // 0x0000000180CBB2B0-0x0000000180CBB2F0 
	private bool IsAnyParticleSystemEmitting { get; } // 0x0000000180CBB0F0-0x0000000180CBB2B0 
	private bool IsAnyParticleSystemActive { get; } // 0x0000000180CBAF30-0x0000000180CBB0F0 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <UpdateRoutine>d__19 : IEnumerator<object> // TypeDefIndex: 11933
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SurfaceFXPrefab <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <UpdateRoutine>d__19(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180CBE230-0x0000000180CBE370
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180CBE370-0x0000000180CBE3C0
	}

	// Constructors
	public SurfaceFXPrefab(); // 0x0000000180CBAED0-0x0000000180CBAF30

	// Methods
	public void ColorizeParticles(Color? inColor = default); // 0x0000000180CBA5B0-0x0000000180CBA7D0
	public void SetLoop(bool inLoop); // 0x0000000180CBAA90-0x0000000180CBACA0
	public void Play(bool inIncludeChildren = true /* Metadata: 0x007B9380 */); // 0x0000000180CBA890-0x0000000180CBAA90
	public void Stop(bool inIncludeChildren = true /* Metadata: 0x007B9381 */); // 0x0000000180CBACA0-0x0000000180CBAE70
	[IteratorStateMachine] // 0x00000001801E77D0-0x00000001801E7820
	private IEnumerator UpdateRoutine(); // 0x0000000180CBAE70-0x0000000180CBAED0
	public override void MOnEnable(); // 0x0000000180CBA810-0x0000000180CBA890
	public override void MOnDisable(); // 0x0000000180CBA7D0-0x0000000180CBA810
}

