/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using WW.Debug;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class WindowManager : CoreWindowManager // TypeDefIndex: 11851
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<string> _fontBundlePaths; // 0x98
	[SetInstance] // 0x00000001801CEA70-0x00000001801CEA80
	public static WindowManager instance; // 0x00

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <FinishCoroutine>d__4 : IEnumerator<object> // TypeDefIndex: 11852
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public WindowManager <>4__this; // 0x20
		private List<string> <>7__wrap1; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <FinishCoroutine>d__4(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001805DC150-0x00000001805DC1F0
		private bool MoveNext(); // 0x00000001805DBF50-0x00000001805DC100
		private void <>m__Finally1(); // 0x00000001805DC1F0-0x00000001805DC230
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001805DC100-0x00000001805DC150
	}

	// Constructors
	public WindowManager(); // 0x00000001805E6310-0x00000001805E6390

	// Methods
	public override void Init(); // 0x00000001805E6020-0x00000001805E6080
	public override bool HasFinishCoroutine(); // 0x0000000180380B60-0x0000000180380B70
	[IteratorStateMachine] // 0x00000001802898E0-0x0000000180289930
	public override IEnumerator FinishCoroutine(); // 0x00000001805E5FC0-0x00000001805E6020
	public override void Deinit(); // 0x00000001805E5F60-0x00000001805E5FC0
	[ConsoleCommand] // 0x0000000180289BC0-0x0000000180289C10
	public static string ListWindows(); // 0x00000001805E6080-0x00000001805E62B0
	[ConsoleCommand] // 0x0000000180289D00-0x0000000180289D50
	public static string CloseWindow(string inWindowID); // 0x00000001805E5EF0-0x00000001805E5F60
	[ConsoleCommand] // 0x000000018028A080-0x000000018028A0D0
	public static void OpenWindow(string inWindowID); // 0x00000001805E62B0-0x00000001805E6310
}

