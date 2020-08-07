/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class TempLoadScene : ManagedBehaviour // TypeDefIndex: 11416
{
	// Fields
	public SceneInfo[] sceneInfos; // 0x50

	// Nested types
	[Serializable]
	public class SceneInfo // TypeDefIndex: 11417
	{
		// Fields
		[RootSelector] // 0x00000001801D97C0-0x00000001801D9820
		public string levelAdditiveDefId; // 0x10

		// Constructors
		public SceneInfo(); // 0x0000000180373240-0x0000000180373250
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <LoadLevelAdditiveRoutine>d__3 : IEnumerator<object> // TypeDefIndex: 11418
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public LevelOverrideDefComponent inLevelAdditiveDef; // 0x20
		private string <sPath>5__2; // 0x28
		private int <ii>5__3; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <LoadLevelAdditiveRoutine>d__3(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180961000-0x0000000180961210
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180961210-0x0000000180961260
	}

	// Constructors
	public TempLoadScene(); // 0x0000000180959C50-0x0000000180959CB0

	// Methods
	public override void MStart(); // 0x0000000180959BE0-0x0000000180959C50
	[IteratorStateMachine] // 0x00000001801D95A0-0x00000001801D95F0
	private IEnumerator LoadLevelAdditiveRoutine(LevelOverrideDefComponent inLevelAdditiveDef); // 0x0000000180959B80-0x0000000180959BE0
}

