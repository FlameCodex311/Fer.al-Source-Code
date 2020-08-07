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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class Reset : CoreReset // TypeDefIndex: 11774
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
	protected override string _name { get; } // 0x00000001804AADD0-0x00000001804AAE00 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <LoadLoadingScene>d__7 : IEnumerator<object> // TypeDefIndex: 11775
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Action<bool> callback; // 0x20
		private string <sLoadingScene>5__2; // 0x28
		private Scene <cScene>5__3; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <LoadLoadingScene>d__7(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001804B93F0-0x00000001804B9540
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001804B9540-0x00000001804BAA20
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass8_0 // TypeDefIndex: 11776
	{
		// Fields
		public bool bLoadingHasLoaded; // 0x10

		// Constructors
		public <>c__DisplayClass8_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <ResetCoroutine>b__0(bool bLoaded); // 0x00000001803FD630-0x00000001803FD640
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <ResetCoroutine>d__8 : IEnumerator<object> // TypeDefIndex: 11777
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Reset <>4__this; // 0x20
		private <>c__DisplayClass8_0 <>8__1; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <ResetCoroutine>d__8(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001804BAA20-0x00000001804BB7D0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001804BB7D0-0x00000001804BC350
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <ClearObjects>d__27 : IEnumerator<object> // TypeDefIndex: 11778
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Reset <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <ClearObjects>d__27(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001804B5BB0-0x00000001804B63D0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001804B63D0-0x00000001804B6770
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Delay>d__28 : IEnumerator<object> // TypeDefIndex: 11779
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Delay>d__28(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001804B6770-0x00000001804B67D0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001804B67D0-0x00000001804B7080
	}

	// Constructors
	public Reset(); // 0x00000001804AADA0-0x00000001804AADD0

	// Methods
	[RuntimeInitializeOnLoadMethod] // 0x0000000180238AA0-0x0000000180238AC0
	public static void FastPlayModeReset(); // 0x00000001804AAA10-0x00000001804AABA0
	[DebugButton] // 0x0000000180259CF0-0x0000000180259D50
	public static void DoCoreReset(); // 0x00000001804AA980-0x00000001804AAA10
	[DebugButton] // 0x0000000180259ED0-0x0000000180259F30
	public static void DoCoreResetWithErrorCode(string arguments); // 0x00000001804AA740-0x00000001804AA980
	[DebugButton] // 0x000000018025A030-0x000000018025A090
	public static void ShowSplashErrorNames(); // 0x00000001804AACE0-0x00000001804AADA0
	[DebugButton] // 0x000000018025A290-0x000000018025A2F0
	public static void ShowErrorCodes(); // 0x00000001804AAC60-0x00000001804AACE0
	[IteratorStateMachine] // 0x000000018025A450-0x000000018025A4A0
	private IEnumerator LoadLoadingScene(Action<bool> callback); // 0x00000001804AABA0-0x00000001804AAC00
	[IteratorStateMachine] // 0x000000018025A750-0x000000018025A7A0
	protected override IEnumerator ResetCoroutine(); // 0x00000001804AAC00-0x00000001804AAC60
	[IteratorStateMachine] // 0x000000018025BC30-0x000000018025BC80
	private IEnumerator ClearObjects(); // 0x00000001804AA690-0x00000001804AA6F0
	[IteratorStateMachine] // 0x000000018025BDC0-0x000000018025BE10
	private IEnumerator Delay(); // 0x00000001804AA6F0-0x00000001804AA740
}

