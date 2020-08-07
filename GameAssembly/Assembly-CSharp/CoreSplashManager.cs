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

public class CoreSplashManager : CoreManagerBase<CoreSplashManager> // TypeDefIndex: 11168
{
	// Fields
	private static List<GameObject> _doNotDestroyOnLoadList; // 0x00
	protected string _currentVersion; // 0x60
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <internetConnected>k__BackingField; // 0x68

	// Properties
	public string currentVersion { get; } // 0x0000000180418970-0x0000000180418980 
	protected string CurrentStoreVersion { get; } // 0x0000000180AA2630-0x0000000180AA26A0 
	protected string PreviousStoreVersion { get; set; } // 0x0000000180AA2720-0x0000000180AA2760 0x0000000180AA2760-0x0000000180AA27A0
	public bool internetConnected { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ protected set; } // 0x000000018037D390-0x000000018037D3A0 0x000000018039EC50-0x000000018039EC60
	public bool IsSupported { get; } // 0x0000000180AA26A0-0x0000000180AA2720 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <InitCoroutine>d__14 : IEnumerator<object> // TypeDefIndex: 11169
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public CoreSplashManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <InitCoroutine>d__14(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180AAE180-0x0000000180AAEA50
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180AAEA50-0x0000000180AAEAA0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <DestroySceneObjects>d__20 : IEnumerator<object> // TypeDefIndex: 11170
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <DestroySceneObjects>d__20(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180AAC320-0x0000000180AAC610
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180AAC610-0x0000000180AAC660
	}

	// Constructors
	public CoreSplashManager(); // 0x0000000180AA25F0-0x0000000180AA2630
	static CoreSplashManager(); // 0x0000000180AA2590-0x0000000180AA25F0

	// Methods
	public override bool HasInitCoroutine(); // 0x0000000180380B60-0x0000000180380B70
	[IteratorStateMachine] // 0x000000018024F080-0x000000018024F0D0
	public override IEnumerator InitCoroutine(); // 0x0000000180AA2350-0x0000000180AA23B0
	public override void MOnDestroy(); // 0x0000000180AA23B0-0x0000000180AA23F0
	public static void RegisterDoNotDestroyOnLoadObject(GameObject inObj); // 0x0000000180AA23F0-0x0000000180AA24C0
	public static void UnregisterDoNotDestroyOnLoadObject(GameObject inObj); // 0x0000000180AA24C0-0x0000000180AA2590
	[IteratorStateMachine] // 0x000000018024F3A0-0x000000018024F3F0
	protected IEnumerator DestroySceneObjects(); // 0x0000000180AA2300-0x0000000180AA2350
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <InitCoroutine>b__14_0(bool connected); // 0x000000018039EC50-0x000000018039EC60
}

