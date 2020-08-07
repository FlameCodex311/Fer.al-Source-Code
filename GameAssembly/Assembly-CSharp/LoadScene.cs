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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class LoadScene : ManagedBehaviour // TypeDefIndex: 13398
{
	// Fields
	private string _loadingScene; // 0x50
	public string activeSceneName; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private SceneDetails[] _sceneDetails; // 0x60
	public string[] unloadedScenes; // 0x68

	// Nested types
	[Serializable]
	public class SceneDetails // TypeDefIndex: 13399
	{
		// Fields
		public string loadScene; // 0x10
		public LoadSceneMode loadSceneMode; // 0x18

		// Constructors
		public SceneDetails(); // 0x0000000180373240-0x0000000180373250
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <LoadScenes>d__6 : IEnumerator<object> // TypeDefIndex: 13400
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public LoadScene <>4__this; // 0x20
		private int <ii>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <LoadScenes>d__6(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180C5AF00-0x0000000180C5B110
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180C5B110-0x0000000180C5B160
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <LoadSingles>d__7 : IEnumerator<object> // TypeDefIndex: 13401
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SceneDetails inSceneDetails; // 0x20
		public LoadScene <>4__this; // 0x28
		private float <fTimer>5__2; // 0x30
		private AsyncOperation <cAsyncOperation>5__3; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <LoadSingles>d__7(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180C5B160-0x0000000180C5B2C0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180C5B2C0-0x0000000180C5C7A0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <LoadAdditives>d__8 : IEnumerator<object> // TypeDefIndex: 13402
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SceneDetails inSceneDetails; // 0x20
		private float <fTimer>5__2; // 0x28
		private AsyncOperation <cAsyncOperation>5__3; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <LoadAdditives>d__8(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180C5ADF0-0x0000000180C5AEB0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180C5AEB0-0x0000000180C5AF00
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <DestroyScenes>d__9 : IEnumerator<object> // TypeDefIndex: 13403
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public LoadScene <>4__this; // 0x20
		private float <fTimer>5__2; // 0x28
		private AsyncOperation <cAsyncOperation>5__3; // 0x30
		private int <ii>5__4; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <DestroyScenes>d__9(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180C5AC10-0x0000000180C5ADA0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180C5ADA0-0x0000000180C5ADF0
	}

	// Constructors
	public LoadScene(); // 0x0000000180C58EB0-0x0000000180C58F10

	// Methods
	public void StartLoad(); // 0x0000000180C58E40-0x0000000180C58EB0
	[IteratorStateMachine] // 0x0000000180228DC0-0x0000000180228E10
	private IEnumerator LoadScenes(); // 0x0000000180C58D70-0x0000000180C58DD0
	[IteratorStateMachine] // 0x00000001802291D0-0x0000000180229220
	private IEnumerator LoadSingles(SceneDetails inSceneDetails); // 0x0000000180C58DD0-0x0000000180C58E40
	[IteratorStateMachine] // 0x00000001802294F0-0x0000000180229540
	private IEnumerator LoadAdditives(SceneDetails inSceneDetails); // 0x0000000180C58D10-0x0000000180C58D70
	[IteratorStateMachine] // 0x0000000180229800-0x0000000180229850
	private IEnumerator DestroyScenes(); // 0x0000000180C58CB0-0x0000000180C58D10
}

