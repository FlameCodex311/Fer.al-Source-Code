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

public class HologramControl : ManagedBehaviour // TypeDefIndex: 10448
{
	// Fields
	private Shader _hologramShader; // 0x50
	private List<Material> _hologramMaterials; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _waitForActorBase; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _splitMaterials; // 0x61
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _autoRotate; // 0x62
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _removeTexture; // 0x63
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _castShadows; // 0x64
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _receiveShadows; // 0x65
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _setColor; // 0x66
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _rotateTorque; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _glitchChance; // 0x6C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _rndMin; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _rndMax; // 0x74
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _rndGlowIntensityMin; // 0x78
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _rndGlowIntensityMax; // 0x7C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _rndGlitchIntensityMin; // 0x80
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _rndGlitchIntensityMax; // 0x84
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _glitchLoopWait; // 0x88
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _hologramColor; // 0x8C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Texture _alphaMask; // 0xA0
	private WaitForSeconds _glitchWait; // 0xA8

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Init>d__21 : IEnumerator<object> // TypeDefIndex: 10449
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public HologramControl <>4__this; // 0x20
		private ActorBase <cActorBase>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Init>d__21(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180F6E1A0-0x0000000180F6EA70
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180F6EA70-0x0000000180F6EAC0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Glitch>d__23 : IEnumerator<object> // TypeDefIndex: 10450
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public HologramControl <>4__this; // 0x20
		public Material inMaterial; // 0x28
		private float <fOriginalGlowIntensity>5__2; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Glitch>d__23(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180F6DF00-0x0000000180F6E150
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180F6E150-0x0000000180F6E1A0
	}

	// Constructors
	public HologramControl(); // 0x0000000180F551F0-0x0000000180F55310

	// Methods
	public override void MStart(); // 0x0000000180F55180-0x0000000180F551F0
	[IteratorStateMachine] // 0x0000000180119F90-0x0000000180119FE0
	private IEnumerator Init(); // 0x0000000180F55120-0x0000000180F55180
	[IteratorStateMachine] // 0x000000018011A170-0x000000018011A1C0
	private IEnumerator Glitch(Material inMaterial); // 0x0000000180F550B0-0x0000000180F55120
}

