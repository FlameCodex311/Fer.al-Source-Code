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

public class CoreSplashManager : CoreManagerBase<CoreSplashManager> // TypeDefIndex: 13497
{
	// Fields
	private static List<GameObject> _doNotDestroyOnLoadList; // 0x00
	protected string _currentVersion; // 0x60
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <internetConnected>k__BackingField; // 0x68

	// Properties
	public string currentVersion { get; } // 0x0000000180369B40-0x0000000180369B50 
	protected string CurrentStoreVersion { get; } // 0x0000000180F358D0-0x0000000180F35940 
	protected string PreviousStoreVersion { get; set; } // 0x0000000180F35990-0x0000000180F359D0 0x0000000180F359D0-0x0000000180F35A10
	public bool internetConnected { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ protected set; } // 0x0000000180622650-0x0000000180622660 0x00000001804638B0-0x00000001804638C0
	public bool IsSupported { get; } // 0x0000000180F35940-0x0000000180F35990 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <InitCoroutine>d__14 : IEnumerator<object> // TypeDefIndex: 13498
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public CoreSplashManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <InitCoroutine>d__14(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180F4F020-0x0000000180F4F8E0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180F4F8E0-0x0000000180F4F930
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <DestroySceneObjects>d__20 : IEnumerator<object> // TypeDefIndex: 13499
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <DestroySceneObjects>d__20(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180F4D240-0x0000000180F4D530
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180F4D530-0x0000000180F4D580
	}

	// Constructors
	public CoreSplashManager(); // 0x0000000180F35890-0x0000000180F358D0
	static CoreSplashManager(); // 0x0000000180F35830-0x0000000180F35890

	// Methods
	public override bool HasInitCoroutine(); // 0x00000001803C29F0-0x00000001803C2A00
	[IteratorStateMachine] // 0x0000000180171B00-0x0000000180171B50
	public override IEnumerator InitCoroutine(); // 0x0000000180F355F0-0x0000000180F35650
	public override void MOnDestroy(); // 0x0000000180F35650-0x0000000180F35690
	public static void RegisterDoNotDestroyOnLoadObject(GameObject inObj); // 0x0000000180F35690-0x0000000180F35760
	public static void UnregisterDoNotDestroyOnLoadObject(GameObject inObj); // 0x0000000180F35760-0x0000000180F35830
	[IteratorStateMachine] // 0x0000000180171E30-0x0000000180171E80
	protected IEnumerator DestroySceneObjects(); // 0x0000000180F355A0-0x0000000180F355F0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <InitCoroutine>b__14_0(bool connected); // 0x00000001804638B0-0x00000001804638C0
}

