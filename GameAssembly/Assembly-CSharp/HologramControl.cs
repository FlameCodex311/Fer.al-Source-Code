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

public class HologramControl : ManagedBehaviour // TypeDefIndex: 11925
{
	// Fields
	private Shader _hologramShader; // 0x50
	private List<Material> _hologramMaterials; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _waitForActorBase; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _splitMaterials; // 0x61
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _autoRotate; // 0x62
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _removeTexture; // 0x63
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _castShadows; // 0x64
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _receiveShadows; // 0x65
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _setColor; // 0x66
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _rotateTorque; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _glitchChance; // 0x6C
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _rndMin; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _rndMax; // 0x74
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _rndGlowIntensityMin; // 0x78
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _rndGlowIntensityMax; // 0x7C
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _rndGlitchIntensityMin; // 0x80
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _rndGlitchIntensityMax; // 0x84
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _glitchLoopWait; // 0x88
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _hologramColor; // 0x8C
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Texture _alphaMask; // 0xA0
	private WaitForSeconds _glitchWait; // 0xA8

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Init>d__21 : IEnumerator<object> // TypeDefIndex: 11926
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public HologramControl <>4__this; // 0x20
		private ActorBase <cActorBase>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Init>d__21(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018062F2F0-0x000000018062FB80
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018062FB80-0x000000018062FBD0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Glitch>d__23 : IEnumerator<object> // TypeDefIndex: 11927
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public HologramControl <>4__this; // 0x20
		public Material inMaterial; // 0x28
		private float <fOriginalGlowIntensity>5__2; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Glitch>d__23(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018062F060-0x000000018062F2A0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018062F2A0-0x000000018062F2F0
	}

	// Constructors
	public HologramControl(); // 0x000000018061F6B0-0x000000018061F7D0

	// Methods
	public override void MStart(); // 0x000000018061F640-0x000000018061F6B0
	[IteratorStateMachine] // 0x00000001801E45C0-0x00000001801E4610
	private IEnumerator Init(); // 0x000000018061F5E0-0x000000018061F640
	[IteratorStateMachine] // 0x00000001801E4AA0-0x00000001801E4AF0
	private IEnumerator Glitch(Material inMaterial); // 0x000000018061F570-0x000000018061F5E0
}

