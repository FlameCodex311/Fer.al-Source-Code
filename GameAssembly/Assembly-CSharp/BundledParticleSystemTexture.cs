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

public class BundledParticleSystemTexture : ManagedBehaviour // TypeDefIndex: 11087
{
	// Fields
	public string bundledTexturePath; // 0x50

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass2_0 // TypeDefIndex: 11088
	{
		// Fields
		public Texture texture; // 0x10

		// Constructors
		public <>c__DisplayClass2_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <LoadParticleTexture>b__0(Texture loadedAsset); // 0x0000000180379F20-0x0000000180379F30
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <LoadParticleTexture>d__2 : IEnumerator<object> // TypeDefIndex: 11089
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BundledParticleSystemTexture <>4__this; // 0x20
		private <>c__DisplayClass2_0 <>8__1; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <LoadParticleTexture>d__2(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001804A8010-0x00000001804A84F0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001804A84F0-0x00000001804A8540
	}

	// Constructors
	public BundledParticleSystemTexture(); // 0x00000001804962C0-0x0000000180496320

	// Methods
	public override void MAwake(); // 0x0000000180373240-0x0000000180373250
	[IteratorStateMachine] // 0x0000000180231190-0x00000001802311E0
	private IEnumerator LoadParticleTexture(); // 0x0000000180496260-0x00000001804962C0
}

