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

[RequireComponent] // 0x00000001800F2920-0x00000001800F2970
public class CFX_AutoDestructShuriken : MonoBehaviour // TypeDefIndex: 13684
{
	// Fields
	public bool OnlyDeactivate; // 0x20

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <CheckIfAlive>d__2 : IEnumerator<object> // TypeDefIndex: 13685
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public CFX_AutoDestructShuriken <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <CheckIfAlive>d__2(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181030450-0x0000000181030590
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181030590-0x00000001810314C0
	}

	// Constructors
	public CFX_AutoDestructShuriken(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void OnEnable(); // 0x0000000181020860-0x00000001810208A0
	[IteratorStateMachine] // 0x00000001800F2C10-0x00000001800F2C60
	private IEnumerator CheckIfAlive(); // 0x0000000181020800-0x0000000181020860
}

