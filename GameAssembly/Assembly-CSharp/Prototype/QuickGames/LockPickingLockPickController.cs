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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype.QuickGames
{
	public class LockPickingLockPickController : MonoBehaviour // TypeDefIndex: 14893
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
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <DoBreakPickFx>d__16 : IEnumerator<object> // TypeDefIndex: 14894
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public float inDelay; // 0x20
			public LockPickingLockPickController <>4__this; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <DoBreakPickFx>d__16(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180991C40-0x0000000180991FA0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180991FA0-0x0000000180991FF0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Reset>d__18 : IEnumerator<object> // TypeDefIndex: 14895
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public LockPickingLockPickController <>4__this; // 0x20
			public int numRingsInLevel; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Reset>d__18(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180993520-0x0000000180993650
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180993650-0x00000001809936A0
		}
	
		// Constructors
		public LockPickingLockPickController(); // 0x0000000180988DD0-0x0000000180988DE0
	
		// Methods
		public void Setup(LockPickingController parent); // 0x0000000180988C50-0x0000000180988C90
		private void SetPickPosition(float inPosX); // 0x0000000180988BC0-0x0000000180988C50
		public bool CanMove(); // 0x0000000180988A00-0x0000000180988A20
		public void Move(bool forward = true /* Metadata: 0x007BB01E */); // 0x0000000180988A90-0x0000000180988B50
		public void BreakPick(float inDelay); // 0x0000000180988980-0x0000000180988A00
		[IteratorStateMachine] // 0x000000018024C6B0-0x000000018024C700
		private IEnumerator DoBreakPickFx(float inDelay); // 0x0000000180988A20-0x0000000180988A90
		private void Update(); // 0x0000000180988C90-0x0000000180988DD0
		[IteratorStateMachine] // 0x000000018024C900-0x000000018024C950
		public IEnumerator Reset(int numRingsInLevel); // 0x0000000180988B50-0x0000000180988BC0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <Reset>b__18_0(); // 0x0000000180379EC0-0x0000000180379ED0
	}
}
