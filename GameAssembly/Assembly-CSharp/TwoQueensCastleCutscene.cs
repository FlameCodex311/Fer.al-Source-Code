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

public class TwoQueensCastleCutscene : Cutscene // TypeDefIndex: 11880
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector3 _cameraFirstShotPosition; // 0xE0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector3 _cameraFirstShotRotation; // 0xEC
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector3 _playerEndPoint; // 0xF8
	private bool _isPlayerAtTarget; // 0x104

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Play>d__5 : IEnumerator<object> // TypeDefIndex: 11881
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public TwoQueensCastleCutscene <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Play>d__5(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180515680-0x0000000180515820
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180515820-0x00000001805167A0
	}

	// Constructors
	public TwoQueensCastleCutscene(); // 0x000000018050D8F0-0x000000018050D900

	// Methods
	protected override void PrePlay(); // 0x0000000180514570-0x0000000180514640
	[IteratorStateMachine] // 0x00000001801D7CD0-0x00000001801D7D20
	protected override IEnumerator Play(); // 0x0000000180514510-0x0000000180514570
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <PrePlay>b__4_0(); // 0x0000000180514640-0x0000000180514650
	[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
	[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
	private IEnumerator <>n__0(); // 0x0000000180514650-0x0000000180515680
}

