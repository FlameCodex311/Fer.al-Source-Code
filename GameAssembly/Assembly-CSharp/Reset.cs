/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using WW.Debug;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Reset : CoreReset // TypeDefIndex: 10284
{
	// Fields
	private bool _clearScriptableObjects; // 0x20
	private bool _clearMaterials; // 0x21
	private bool _clearRenderTextures; // 0x22
	private bool _clearTextures; // 0x23
	private bool _clearRuntimeAnimatorControllers; // 0x24
	private bool _clearAnimationClips; // 0x25
	private bool _clearFonts; // 0x26
	private bool _clearTextAssets; // 0x27
	private bool _clearParticleSystemRenderers; // 0x28
	private bool _clearParticleSystems; // 0x29
	private bool _clearMeshes; // 0x2A
	private bool _clearAudioMixers; // 0x2B
	private bool _clearAudioMixerGroups; // 0x2C
	private bool _clearAudioClips; // 0x2D
	private bool _clearActorBases; // 0x2E
	private bool _clearTransforms; // 0x2F
	private bool _clearGameObjects; // 0x30
	private bool _clearMonoBehaviours; // 0x31

	// Properties
	protected override string _name { get; } // 0x0000000180FC9980-0x0000000180FC99B0 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <LoadLoadingScene>d__7 : IEnumerator<object> // TypeDefIndex: 10285
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Action<bool> callback; // 0x20
		private string <sLoadingScene>5__2; // 0x28
		private Scene <cScene>5__3; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <LoadLoadingScene>d__7(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180FE1EA0-0x0000000180FE1FF0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180FE1FF0-0x0000000180FE2450
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass8_0 // TypeDefIndex: 10286
	{
		// Fields
		public bool bLoadingHasLoaded; // 0x10

		// Constructors
		public <>c__DisplayClass8_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <ResetCoroutine>b__0(bool bLoaded); // 0x00000001803930B0-0x00000001803930C0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <ResetCoroutine>d__8 : IEnumerator<object> // TypeDefIndex: 10287
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Reset <>4__this; // 0x20
		private <>c__DisplayClass8_0 <>8__1; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <ResetCoroutine>d__8(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180FE2450-0x0000000180FE3210
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180FE3210-0x0000000180FE3970
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <ClearObjects>d__27 : IEnumerator<object> // TypeDefIndex: 10288
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Reset <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <ClearObjects>d__27(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180FDF580-0x0000000180FDFDC0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180FDFDC0-0x0000000180FE0170
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Delay>d__28 : IEnumerator<object> // TypeDefIndex: 10289
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Delay>d__28(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180FE0170-0x0000000180FE01D0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180FE01D0-0x0000000180FE0AE0
	}

	// Constructors
	public Reset(); // 0x0000000180FC9950-0x0000000180FC9980

	// Methods
	[RuntimeInitializeOnLoadMethod] // 0x00000001800C1A80-0x00000001800C1AA0
	public static void FastPlayModeReset(); // 0x0000000180FC95C0-0x0000000180FC9750
	[DebugButton] // 0x00000001800C7870-0x00000001800C78D0
	public static void DoCoreReset(); // 0x0000000180FC9530-0x0000000180FC95C0
	[DebugButton] // 0x00000001800C7C40-0x00000001800C7CA0
	public static void DoCoreResetWithErrorCode(string arguments); // 0x0000000180FC92E0-0x0000000180FC9530
	[DebugButton] // 0x00000001800C7D70-0x00000001800C7DD0
	public static void ShowSplashErrorNames(); // 0x0000000180FC9890-0x0000000180FC9950
	[DebugButton] // 0x00000001800C81B0-0x00000001800C8210
	public static void ShowErrorCodes(); // 0x0000000180FC9810-0x0000000180FC9890
	[IteratorStateMachine] // 0x00000001800C84F0-0x00000001800C8540
	private IEnumerator LoadLoadingScene(Action<bool> callback); // 0x0000000180FC9750-0x0000000180FC97B0
	[IteratorStateMachine] // 0x00000001800C8910-0x00000001800C8960
	protected override IEnumerator ResetCoroutine(); // 0x0000000180FC97B0-0x0000000180FC9810
	[IteratorStateMachine] // 0x00000001800C8C60-0x00000001800C8CB0
	private IEnumerator ClearObjects(); // 0x0000000180FC9230-0x0000000180FC9290
	[IteratorStateMachine] // 0x00000001800C91A0-0x00000001800C91F0
	private IEnumerator Delay(); // 0x0000000180FC9290-0x0000000180FC92E0
}

