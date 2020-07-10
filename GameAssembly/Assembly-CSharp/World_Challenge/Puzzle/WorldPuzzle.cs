/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace World_Challenge.Puzzle
{
	public class WorldPuzzle : ManagedBehaviour // TypeDefIndex: 15527
	{
		// Fields
		public CinemachineVirtualCamera virtualCam; // 0x50
		public GameObject encounterHUD; // 0x58
		internal EPuzzleState puzzleState; // 0x60
		internal StartPuzzle actionTask_inGame; // 0x68
	
		// Nested types
		internal enum EPuzzleState // TypeDefIndex: 15528
		{
			PLAYING = 0,
			WIN = 1,
			LOSE = 2
		}
	
		// Constructors
		public WorldPuzzle(); // 0x0000000181F3BE40-0x0000000181F3BEA0
	
		// Methods
		public override void MStart(); // 0x0000000181F3BCB0-0x0000000181F3BD80
		public override void MUpdate(); // 0x000000018036B6C0-0x000000018036B6D0
		internal virtual void InitializePuzzle(); // 0x0000000181F3B9A0-0x0000000181F3BBE0
		internal virtual void StartPuzzle(); // 0x0000000181F3BE10-0x0000000181F3BE40
		internal void QuitPuzzle(); // 0x0000000181F32300-0x0000000181F32340
		internal virtual void ResetPuzzle(); // 0x00000001803581E0-0x00000001803581F0
		internal virtual void CompletePuzzle(); // 0x0000000181F3B800-0x0000000181F3B820
		internal virtual void FailPuzzle(); // 0x0000000181F3B860-0x0000000181F3B880
		internal virtual void EndPuzzle(); // 0x0000000181F3B820-0x0000000181F3B860
		protected virtual void ClosePuzzle(); // 0x0000000181F3B5A0-0x0000000181F3B6E0
	}
}
