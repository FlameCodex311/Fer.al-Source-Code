/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace World_Challenge
{
	public class WorldPuzzle : ManagedBehaviour // TypeDefIndex: 14674
	{
		// Fields
		public CinemachineVirtualCamera virtualCam; // 0x50
		public GameObject encounterHUD; // 0x58
		public float showHUDDelay; // 0x60
		internal EPuzzleState puzzleState; // 0x64
		internal StartPuzzle actionTask_inGame; // 0x68
	
		// Nested types
		internal enum EPuzzleState // TypeDefIndex: 14675
		{
			PLAYING = 0,
			WIN = 1,
			LOSE = 2
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowHud>d__9 : IEnumerator<object> // TypeDefIndex: 14676
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public WorldPuzzle <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowHud>d__9(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000181985C30-0x0000000181985DF0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181985DF0-0x0000000181985E40
		}
	
		// Constructors
		public WorldPuzzle(); // 0x0000000181989190-0x00000001819891F0
	
		// Methods
		public override void MStart(); // 0x0000000181988ED0-0x0000000181988FA0
		internal void EndPuzzle(); // 0x00000001808B3AF0-0x00000001808B3B10
		internal virtual void InitializePuzzle(); // 0x0000000181988BA0-0x0000000181988CA0
		[IteratorStateMachine] // 0x00000001802890E0-0x0000000180289130
		private IEnumerator ShowHud(); // 0x0000000181989070-0x00000001819890D0
		internal virtual void StartPuzzle(bool inEndPan = false /* Metadata: 0x007BAE5A */); // 0x00000001819890D0-0x0000000181989100
		internal virtual void CompletePuzzle(); // 0x0000000181988AE0-0x0000000181988B00
		internal void QuitPuzzle(); // 0x0000000181988B80-0x0000000181988BA0
		internal virtual void FailPuzzle(); // 0x0000000181988B80-0x0000000181988BA0
		protected virtual void ClosePuzzle(); // 0x00000001819889E0-0x0000000181988AE0
		internal virtual void ResetPuzzle(); // 0x00000001803774A0-0x00000001803774B0
	}
}
