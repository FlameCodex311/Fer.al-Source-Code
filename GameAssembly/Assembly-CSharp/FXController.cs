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

public class FXController : MonoBehaviour // TypeDefIndex: 13724
{
	// Fields
	public FXInfo[] fxList; // 0x20
	private Dictionary<Transform, FXInfo> _fxDictionay; // 0x28

	// Nested types
	public enum FXType // TypeDefIndex: 13725
	{
		NONE = 0,
		SWIRL = 1
	}

	[Serializable]
	public class FXInfo // TypeDefIndex: 13726
	{
		// Fields
		public FXType type; // 0x10
		public FXObject prefab; // 0x18

		// Constructors
		public FXInfo(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 13727
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__5_0; // 0x08

		// Constructors
		static <>c(); // 0x000000018119DAF0-0x000000018119DB50
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <SpawnFXToPlayer>b__5_0(); // 0x000000018119D130-0x000000018119D1A0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <SpawnFXToPlayer>d__5 : IEnumerator<object> // TypeDefIndex: 13728
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FXController <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <SpawnFXToPlayer>d__5(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018119CA30-0x000000018119CBA0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018119CBA0-0x000000018119CBF0
	}

	// Constructors
	public FXController(); // 0x0000000181194B10-0x0000000181194B70

	// Methods
	private void Start(); // 0x0000000181194AA0-0x0000000181194B10
	[IteratorStateMachine] // 0x00000001800FE530-0x00000001800FE580
	private IEnumerator SpawnFXToPlayer(FXType inType); // 0x0000000181194A40-0x0000000181194AA0
	public void SetFXToObject(FXType inType, Transform target); // 0x00000001811946C0-0x0000000181194850
	private void SpawnFXObject(FXInfo inFXInfo, Transform inTransform); // 0x0000000181194850-0x0000000181194A40
}

