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

public class BundledParticleSystemTexture : ManagedBehaviour // TypeDefIndex: 13416
{
	// Fields
	public string bundledTexturePath; // 0x50

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass2_0 // TypeDefIndex: 13417
	{
		// Fields
		public Texture texture; // 0x10

		// Constructors
		public <>c__DisplayClass2_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <LoadParticleTexture>b__0(Texture loadedAsset); // 0x000000018036B1E0-0x000000018036B1F0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <LoadParticleTexture>d__2 : IEnumerator<object> // TypeDefIndex: 13418
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BundledParticleSystemTexture <>4__this; // 0x20
		private <>c__DisplayClass2_0 <>8__1; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <LoadParticleTexture>d__2(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001813DE9A0-0x00000001813DEEB0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001813DEEB0-0x00000001813DEF00
	}

	// Constructors
	public BundledParticleSystemTexture(); // 0x00000001813DDD20-0x00000001813DDD80

	// Methods
	public override void MAwake(); // 0x000000018036B6C0-0x000000018036B6D0
	[IteratorStateMachine] // 0x000000018014CD90-0x000000018014CDE0
	private IEnumerator LoadParticleTexture(); // 0x00000001813DDCC0-0x00000001813DDD20
}

