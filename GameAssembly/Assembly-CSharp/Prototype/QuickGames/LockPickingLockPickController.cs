/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames
{
	public class LockPickingLockPickController : MonoBehaviour // TypeDefIndex: 16151
	{
		// Fields
		public List<int> lockpickRingPositions; // 0x20
		public int lockpickOffscreenPosition; // 0x28
		public int lockpickSuccessPosition; // 0x2C
		public float lockPickSpeed; // 0x30
		public Image pickImage; // 0x38
		public GameObject brokenPick; // 0x40
		private int _currentRingIndex; // 0x48
		private float _targetPosition; // 0x4C
		private bool _moving; // 0x50
		private LockPickingController parentController; // 0x58
		private bool _pickBreakWaiting; // 0x60
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <DoBreakPickFx>d__16 : IEnumerator<object> // TypeDefIndex: 16152
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public float inDelay; // 0x20
			public LockPickingLockPickController <>4__this; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <DoBreakPickFx>d__16(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813FA960-0x00000001813FACD0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813FACD0-0x00000001813FAD20
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Reset>d__18 : IEnumerator<object> // TypeDefIndex: 16153
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public LockPickingLockPickController <>4__this; // 0x20
			public int numRingsInLevel; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Reset>d__18(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813FC590-0x00000001813FC6C0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813FC6C0-0x00000001813FC710
		}
	
		// Constructors
		public LockPickingLockPickController(); // 0x00000001813F1980-0x00000001813F1990
	
		// Methods
		public void Setup(LockPickingController parent); // 0x00000001813F1800-0x00000001813F1840
		private void SetPickPosition(float inPosX); // 0x00000001813F1760-0x00000001813F1800
		public bool CanMove(); // 0x00000001813F15A0-0x00000001813F15C0
		public void Move(bool forward = true /* Metadata: 0x0078542C */); // 0x00000001813F1630-0x00000001813F16F0
		public void BreakPick(float inDelay); // 0x00000001813F1520-0x00000001813F15A0
		[IteratorStateMachine] // 0x000000018012E000-0x000000018012E050
		private IEnumerator DoBreakPickFx(float inDelay); // 0x00000001813F15C0-0x00000001813F1630
		private void Update(); // 0x00000001813F1840-0x00000001813F1980
		[IteratorStateMachine] // 0x000000018012E290-0x000000018012E2E0
		public IEnumerator Reset(int numRingsInLevel); // 0x00000001813F16F0-0x00000001813F1760
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <Reset>b__18_0(); // 0x0000000180619B50-0x0000000180619B60
	}
}
