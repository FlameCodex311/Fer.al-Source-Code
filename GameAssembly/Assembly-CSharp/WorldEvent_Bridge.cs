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

public class WorldEvent_Bridge : WorldEvent // TypeDefIndex: 13760
{
	// Fields
	public float bridgeFxDelay; // 0x58
	public GameObject bridgeFx; // 0x60
	private Animation _animation; // 0x68

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <PlayBridgeFx>d__7 : IEnumerator<object> // TypeDefIndex: 13761
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public WorldEvent_Bridge <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <PlayBridgeFx>d__7(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180FF51C0-0x0000000180FF52C0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180FF52C0-0x0000000180FF5B90
	}

	// Constructors
	public WorldEvent_Bridge(); // 0x0000000180FFFBB0-0x0000000180FFFC10

	// Methods
	public override void MStart(); // 0x0000000180FFF730-0x0000000180FFF810
	protected override void OnWorldEvent(WorldEventMessage inWorldEventMessage); // 0x0000000180FFF810-0x0000000180FFFB20
	private void ActivateBridge(); // 0x0000000180FFF5C0-0x0000000180FFF690
	private void DeactivateBridge(); // 0x0000000180FFF690-0x0000000180FFF730
	[IteratorStateMachine] // 0x00000001801070A0-0x00000001801070F0
	private IEnumerator PlayBridgeFx(); // 0x0000000180FFFB20-0x0000000180FFFB80
	private void StopBridgeFx(); // 0x0000000180FFFB80-0x0000000180FFFBB0
}

