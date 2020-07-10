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

public class CoreLevelManager : CoreManagerBase<CoreLevelManager> // TypeDefIndex: 13451
{
	// Fields
	public static string startScene; // 0x00
	private Coroutine _progressBarRoutine; // 0x60
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <IsLevelFinishedLoading>k__BackingField; // 0x68
	private LevelDefComponent _currentLevelDef; // 0x70
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private string <PreviousLevelID>k__BackingField; // 0x78

	// Properties
	public bool IsLevelFinishedLoading { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180622650-0x0000000180622660 0x00000001804638B0-0x00000001804638C0
	public LevelDefComponent CurrentLevelDef { get; set; } // 0x0000000180369B50-0x0000000180369B60 0x00000001803C87F0-0x00000001803C8800
	public string CurrentLevelID { get; private set; } // 0x0000000181312A10-0x0000000181312A60 0x0000000181312B10-0x0000000181312B80
	public string PreviousLevelID { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369C70-0x0000000180369C80 0x00000001803D8EF0-0x00000001803D8F00
	public LevelDefComponent PreviousLevelDef { get; private set; } // 0x0000000181312A60-0x0000000181312B10 0x0000000181312B80-0x0000000181312BE0

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <FakeLoadCurrentLevel>d__24 : IEnumerator<object> // TypeDefIndex: 13452
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <FakeLoadCurrentLevel>d__24(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181327CD0-0x0000000181327E00
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181327E00-0x0000000181327E50
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <LoadLevel>d__25 : IEnumerator<object> // TypeDefIndex: 13453
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public CoreLevelManager <>4__this; // 0x20
		public string inDefID; // 0x28
		public bool inFakeLoad; // 0x30
		private LevelDefComponent <levelDef>5__2; // 0x38
		private int <ii>5__3; // 0x40

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <LoadLevel>d__25(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181328FA0-0x0000000181329740
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181329740-0x0000000181329790
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <DownloadProgress>d__26 : IEnumerator<object> // TypeDefIndex: 13454
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ManifestDef inManifestDef; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <DownloadProgress>d__26(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181327570-0x0000000181327830
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181327830-0x0000000181327880
	}

	// Constructors
	public CoreLevelManager(); // 0x00000001813129D0-0x0000000181312A10
	static CoreLevelManager(); // 0x0000000181312990-0x00000001813129D0

	// Methods
	public static void LoadLevelSingle(string inLevelName); // 0x0000000180FCCD60-0x0000000180FCCD70
	public static void LoadLevelAdditive(string inLevelName); // 0x0000000180FCCD50-0x0000000180FCCD60
	public static AsyncOperation LoadLevelAdditiveAsync(string inLevelName); // 0x00000001813127C0-0x00000001813127D0
	public override void MStart(); // 0x0000000181312850-0x0000000181312990
	[IteratorStateMachine] // 0x000000018015F1F0-0x000000018015F240
	public static IEnumerator FakeLoadCurrentLevel(); // 0x0000000181312770-0x00000001813127C0
	[IteratorStateMachine] // 0x000000018015F4E0-0x000000018015F530
	public IEnumerator LoadLevel(string inDefID, bool inFakeLoad = false /* Metadata: 0x00783D2E */); // 0x00000001813127D0-0x0000000181312850
	[IteratorStateMachine] // 0x0000000180160A00-0x0000000180160A50
	private IEnumerator DownloadProgress(ManifestDef inManifestDef); // 0x0000000181312710-0x0000000181312770
	public virtual void InitCurrentLevel(); // 0x00000001803581E0-0x00000001803581F0
	public virtual bool WaitBeforeFadeOut(); // 0x00000001803C28F0-0x00000001803C2900
	public virtual void OnFinishLoading(); // 0x00000001803581E0-0x00000001803581F0
}

