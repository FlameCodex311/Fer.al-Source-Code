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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class WindowManager : CoreWindowManager // TypeDefIndex: 10360
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<string> _fontBundlePaths; // 0x98
	[SetInstance] // 0x00000001800BDB50-0x00000001800BDB60
	public static WindowManager instance; // 0x00

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 10361
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<Material> <>9__4_0; // 0x08
		public static Action<Material> <>9__4_1; // 0x10

		// Constructors
		static <>c(); // 0x0000000180FF6A10-0x0000000180FF6A70
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <FinishCoroutine>b__4_0(Material loadedObject); // 0x00000001803581E0-0x00000001803581F0
		internal void <FinishCoroutine>b__4_1(Material loadedObject); // 0x00000001803581E0-0x00000001803581F0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <FinishCoroutine>d__4 : IEnumerator<object> // TypeDefIndex: 10362
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public WindowManager <>4__this; // 0x20
		private List<string> <>7__wrap1; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <FinishCoroutine>d__4(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x0000000180FF4B00-0x0000000180FF4BB0
		private bool MoveNext(); // 0x0000000180FF46D0-0x0000000180FF4AB0
		private void <>m__Finally1(); // 0x0000000180FF4BB0-0x0000000180FF4BF0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180FF4AB0-0x0000000180FF4B00
	}

	// Constructors
	public WindowManager(); // 0x0000000180FFF040-0x0000000180FFF0C0

	// Methods
	public override void Init(); // 0x0000000180FFED40-0x0000000180FFEDA0
	public override bool HasFinishCoroutine(); // 0x00000001803C29F0-0x00000001803C2A00
	[IteratorStateMachine] // 0x00000001800F2A40-0x00000001800F2A90
	public override IEnumerator FinishCoroutine(); // 0x0000000180FFECE0-0x0000000180FFED40
	public override void Deinit(); // 0x0000000180FFEC80-0x0000000180FFECE0
	[ConsoleCommand] // 0x00000001800F2CC0-0x00000001800F2D10
	public static string ListWindows(); // 0x0000000180FFEDA0-0x0000000180FFEFE0
	[ConsoleCommand] // 0x00000001800F2ED0-0x00000001800F2F20
	public static string CloseWindow(string inWindowID); // 0x0000000180FFEC10-0x0000000180FFEC80
	[ConsoleCommand] // 0x00000001800F30B0-0x00000001800F3100
	public static void OpenWindow(string inWindowID); // 0x0000000180FFEFE0-0x0000000180FFF040
}

