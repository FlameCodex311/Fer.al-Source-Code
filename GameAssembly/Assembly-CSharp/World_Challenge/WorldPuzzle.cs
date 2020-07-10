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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace World_Challenge
{
	public class WorldPuzzle : ManagedBehaviour // TypeDefIndex: 15519
	{
		// Fields
		public CinemachineVirtualCamera virtualCam; // 0x50
		public GameObject encounterHUD; // 0x58
		public float showHUDDelay; // 0x60
		internal EPuzzleState puzzleState; // 0x64
		internal StartPuzzle actionTask_inGame; // 0x68
	
		// Nested types
		internal enum EPuzzleState // TypeDefIndex: 15520
		{
			PLAYING = 0,
			WIN = 1,
			LOSE = 2
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowHud>d__9 : IEnumerator<object> // TypeDefIndex: 15521
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public WorldPuzzle <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowHud>d__9(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181F38EA0-0x0000000181F39070
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181F39070-0x0000000181F390C0
		}
	
		// Constructors
		public WorldPuzzle(); // 0x0000000181F3BEA0-0x0000000181F3BF00
	
		// Methods
		public override void MStart(); // 0x0000000181F3BBE0-0x0000000181F3BCB0
		internal void EndPuzzle(); // 0x000000018059F550-0x000000018059F570
		internal virtual void InitializePuzzle(); // 0x0000000181F3B8A0-0x0000000181F3B9A0
		[IteratorStateMachine] // 0x0000000180105080-0x00000001801050D0
		private IEnumerator ShowHud(); // 0x0000000181F3BD80-0x0000000181F3BDE0
		internal virtual void StartPuzzle(bool inEndPan = false /* Metadata: 0x00784C51 */); // 0x0000000181F3BDE0-0x0000000181F3BE10
		internal virtual void CompletePuzzle(); // 0x0000000181F3B7E0-0x0000000181F3B800
		internal void QuitPuzzle(); // 0x0000000181F3B880-0x0000000181F3B8A0
		internal virtual void FailPuzzle(); // 0x0000000181F3B880-0x0000000181F3B8A0
		protected virtual void ClosePuzzle(); // 0x0000000181F3B6E0-0x0000000181F3B7E0
		internal virtual void ResetPuzzle(); // 0x00000001803581E0-0x00000001803581F0
	}
}
