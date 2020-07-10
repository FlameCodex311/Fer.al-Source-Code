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

public class CoreReset : MonoBehaviour // TypeDefIndex: 13372
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private static CoreReset <instance>k__BackingField; // 0x00

	// Properties
	public static CoreReset instance { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018131DD70-0x000000018131DDB0 0x000000018131DDB0-0x000000018131DDF0
	protected virtual string _name { get; } // 0x000000018131DD40-0x000000018131DD70 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <ResetCoroutine>d__7 : IEnumerator<object> // TypeDefIndex: 13373
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <ResetCoroutine>d__7(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181329EF0-0x0000000181329F60
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181329F60-0x0000000181329FB0
	}

	// Constructors
	public CoreReset(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Awake(); // 0x000000018131D1F0-0x000000018131D5B0
	[IteratorStateMachine] // 0x00000001801321B0-0x0000000180132200
	protected virtual IEnumerator ResetCoroutine(); // 0x000000018131DCF0-0x000000018131DD40
	protected void Delete(UnityEngine.Object[] inObjects); // 0x000000018131D710-0x000000018131DA50
	protected List<T> GetDeleteList<T>(T[] inList)
		where T : class;
	protected void DeleteMaterial(Material inMaterial); // 0x000000018131D5B0-0x000000018131D710
	protected void HandleCoreResetTargets(); // 0x000000018131DA50-0x000000018131DCF0
}

