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

public class TwoQueensCastleCutscene : Cutscene // TypeDefIndex: 10389
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector3 _cameraFirstShotPosition; // 0xE0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector3 _cameraFirstShotRotation; // 0xEC
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector3 _playerEndPoint; // 0xF8
	private bool _isPlayerAtTarget; // 0x104

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Play>d__5 : IEnumerator<object> // TypeDefIndex: 10390
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public TwoQueensCastleCutscene <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Play>d__5(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180FB0620-0x0000000180FB07D0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180FB07D0-0x0000000180FB1790
	}

	// Constructors
	public TwoQueensCastleCutscene(); // 0x0000000180FA83E0-0x0000000180FA83F0

	// Methods
	protected override void PrePlay(); // 0x0000000180FAF200-0x0000000180FAF2D0
	[IteratorStateMachine] // 0x00000001801069A0-0x00000001801069F0
	protected override IEnumerator Play(); // 0x0000000180FAF1A0-0x0000000180FAF200
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <PrePlay>b__4_0(); // 0x0000000180FAF2D0-0x0000000180FAF2E0
	[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
	[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
	private IEnumerator <>n__0(); // 0x0000000180FAF2E0-0x0000000180FB0340
}

