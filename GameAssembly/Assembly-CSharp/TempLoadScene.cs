/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class TempLoadScene : ManagedBehaviour // TypeDefIndex: 13743
{
	// Fields
	public SceneInfo[] sceneInfos; // 0x50

	// Nested types
	[Serializable]
	public class SceneInfo // TypeDefIndex: 13744
	{
		// Fields
		[RootSelector] // 0x0000000180102A10-0x0000000180102A70
		public string levelAdditiveDefId; // 0x10

		// Constructors
		public SceneInfo(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <LoadLevelAdditiveRoutine>d__3 : IEnumerator<object> // TypeDefIndex: 13745
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public LevelOverrideDefComponent inLevelAdditiveDef; // 0x20
		private string <sPath>5__2; // 0x28
		private int <ii>5__3; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <LoadLevelAdditiveRoutine>d__3(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181211D80-0x0000000181211F90
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181211F90-0x0000000181211FE0
	}

	// Constructors
	public TempLoadScene(); // 0x0000000181209960-0x00000001812099C0

	// Methods
	public override void MStart(); // 0x00000001812098F0-0x0000000181209960
	[IteratorStateMachine] // 0x00000001801027C0-0x0000000180102810
	private IEnumerator LoadLevelAdditiveRoutine(LevelOverrideDefComponent inLevelAdditiveDef); // 0x0000000181209890-0x00000001812098F0
}

