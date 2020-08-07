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

public class CoreLevelManager : CoreManagerBase<CoreLevelManager> // TypeDefIndex: 11122
{
	// Fields
	public static string startScene; // 0x00
	private Coroutine _progressBarRoutine; // 0x60
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <IsLevelFinishedLoading>k__BackingField; // 0x68
	private LevelDefComponent _currentLevelDef; // 0x70
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string <PreviousLevelID>k__BackingField; // 0x78

	// Properties
	public bool IsLevelFinishedLoading { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018037D390-0x000000018037D3A0 0x000000018039EC50-0x000000018039EC60
	public LevelDefComponent CurrentLevelDef { get; set; } // 0x0000000180418980-0x0000000180418990 0x00000001804C61A0-0x00000001804C61B0
	public string CurrentLevelID { get; private set; } // 0x0000000180A6CFC0-0x0000000180A6D010 0x0000000180A6D0C0-0x0000000180A6D130
	public string PreviousLevelID { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180418A40-0x0000000180418A50 0x00000001804B47D0-0x00000001804B47E0
	public LevelDefComponent PreviousLevelDef { get; private set; } // 0x0000000180A6D010-0x0000000180A6D0C0 0x0000000180A6D130-0x0000000180A6D190

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <FakeLoadCurrentLevel>d__24 : IEnumerator<object> // TypeDefIndex: 11123
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <FakeLoadCurrentLevel>d__24(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180A771F0-0x0000000180A77320
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180A77320-0x0000000180A77370
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <LoadLevel>d__25 : IEnumerator<object> // TypeDefIndex: 11124
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <LoadLevel>d__25(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180A7AAF0-0x0000000180A7B260
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180A7B260-0x0000000180A7B2B0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <DownloadProgress>d__26 : IEnumerator<object> // TypeDefIndex: 11125
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ManifestDef inManifestDef; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <DownloadProgress>d__26(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180A76EE0-0x0000000180A771A0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180A771A0-0x0000000180A771F0
	}

	// Constructors
	public CoreLevelManager(); // 0x0000000180A6CF80-0x0000000180A6CFC0
	static CoreLevelManager(); // 0x0000000180A6CF40-0x0000000180A6CF80

	// Methods
	public static void LoadLevelSingle(string inLevelName); // 0x00000001804AE140-0x00000001804AE150
	public static void LoadLevelAdditive(string inLevelName); // 0x00000001804AE130-0x00000001804AE140
	public static AsyncOperation LoadLevelAdditiveAsync(string inLevelName); // 0x0000000180A6CD70-0x0000000180A6CD80
	public override void MStart(); // 0x0000000180A6CE00-0x0000000180A6CF40
	[IteratorStateMachine] // 0x00000001802407D0-0x0000000180240820
	public static IEnumerator FakeLoadCurrentLevel(); // 0x0000000180A6CD20-0x0000000180A6CD70
	[IteratorStateMachine] // 0x0000000180240AF0-0x0000000180240B40
	public IEnumerator LoadLevel(string inDefID, bool inFakeLoad = false /* Metadata: 0x0077C7ED */); // 0x0000000180A6CD80-0x0000000180A6CE00
	[IteratorStateMachine] // 0x0000000180240D10-0x0000000180240D60
	private IEnumerator DownloadProgress(ManifestDef inManifestDef); // 0x0000000180A6CCC0-0x0000000180A6CD20
	public virtual void InitCurrentLevel(); // 0x00000001803774A0-0x00000001803774B0
	public virtual bool WaitBeforeFadeOut(); // 0x0000000180380950-0x0000000180380960
	public virtual void OnFinishLoading(); // 0x00000001803774A0-0x00000001803774B0
}

