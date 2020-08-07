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

public class CoreReset : MonoBehaviour // TypeDefIndex: 11047
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private static CoreReset <instance>k__BackingField; // 0x00

	// Properties
	public static CoreReset instance { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180A9C6F0-0x0000000180A9C730 0x0000000180A9C730-0x0000000180A9C770
	protected virtual string _name { get; } // 0x0000000180A9C6C0-0x0000000180A9C6F0 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <ResetCoroutine>d__7 : IEnumerator<object> // TypeDefIndex: 11048
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <ResetCoroutine>d__7(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180AAF970-0x0000000180AAF9E0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180AAF9E0-0x0000000180AAFA30
	}

	// Constructors
	public CoreReset(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Awake(); // 0x0000000180A9BB90-0x0000000180A9BF50
	[IteratorStateMachine] // 0x00000001802144E0-0x0000000180214530
	protected virtual IEnumerator ResetCoroutine(); // 0x0000000180A9C670-0x0000000180A9C6C0
	protected void Delete(UnityEngine.Object[] inObjects); // 0x0000000180A9C0B0-0x0000000180A9C3E0
	protected List<T> GetDeleteList<T>(T[] inList)
		where T : class;
	protected void DeleteMaterial(Material inMaterial); // 0x0000000180A9BF50-0x0000000180A9C0B0
	protected void HandleCoreResetTargets(); // 0x0000000180A9C3E0-0x0000000180A9C670
}

