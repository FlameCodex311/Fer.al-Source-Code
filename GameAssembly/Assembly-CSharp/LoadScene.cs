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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class LoadScene : ManagedBehaviour // TypeDefIndex: 11862
{
	// Fields
	private string _loadingScene; // 0x50
	public string activeSceneName; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private SceneDetails[] _sceneDetails; // 0x60
	public string[] unloadedScenes; // 0x68

	// Nested types
	[Serializable]
	public class SceneDetails // TypeDefIndex: 11863
	{
		// Fields
		public string loadScene; // 0x10
		public LoadSceneMode loadSceneMode; // 0x18

		// Constructors
		public SceneDetails(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <LoadScenes>d__6 : IEnumerator<object> // TypeDefIndex: 11864
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public LoadScene <>4__this; // 0x20
		private int <ii>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <LoadScenes>d__6(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001811F1C20-0x00000001811F1E40
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001811F1E40-0x00000001811F1E90
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <LoadSingles>d__7 : IEnumerator<object> // TypeDefIndex: 11865
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SceneDetails inSceneDetails; // 0x20
		public LoadScene <>4__this; // 0x28
		private float <fTimer>5__2; // 0x30
		private AsyncOperation <cAsyncOperation>5__3; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <LoadSingles>d__7(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001811F1E90-0x00000001811F2000
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001811F2000-0x00000001811F3280
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <LoadAdditives>d__8 : IEnumerator<object> // TypeDefIndex: 11866
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SceneDetails inSceneDetails; // 0x20
		private float <fTimer>5__2; // 0x28
		private AsyncOperation <cAsyncOperation>5__3; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <LoadAdditives>d__8(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001811F1B10-0x00000001811F1BD0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001811F1BD0-0x00000001811F1C20
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <DestroyScenes>d__9 : IEnumerator<object> // TypeDefIndex: 11867
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public LoadScene <>4__this; // 0x20
		private float <fTimer>5__2; // 0x28
		private AsyncOperation <cAsyncOperation>5__3; // 0x30
		private int <ii>5__4; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <DestroyScenes>d__9(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001811F0BA0-0x00000001811F0D40
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001811F0D40-0x00000001811F1620
	}

	// Constructors
	public LoadScene(); // 0x00000001811E5600-0x00000001811E5660

	// Methods
	public void StartLoad(); // 0x00000001811E5590-0x00000001811E5600
	[IteratorStateMachine] // 0x000000018013FF50-0x000000018013FFA0
	private IEnumerator LoadScenes(); // 0x00000001811E54C0-0x00000001811E5520
	[IteratorStateMachine] // 0x0000000180140160-0x00000001801401B0
	private IEnumerator LoadSingles(SceneDetails inSceneDetails); // 0x00000001811E5520-0x00000001811E5590
	[IteratorStateMachine] // 0x00000001801403C0-0x0000000180140410
	private IEnumerator LoadAdditives(SceneDetails inSceneDetails); // 0x00000001811E5460-0x00000001811E54C0
	[IteratorStateMachine] // 0x00000001801406B0-0x0000000180140700
	private IEnumerator DestroyScenes(); // 0x00000001811E5400-0x00000001811E5460
}

