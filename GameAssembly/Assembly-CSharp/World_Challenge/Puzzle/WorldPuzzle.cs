/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace World_Challenge.Puzzle
{
	public class WorldPuzzle : ManagedBehaviour // TypeDefIndex: 14682
	{
		// Fields
		public CinemachineVirtualCamera virtualCam; // 0x50
		public GameObject encounterHUD; // 0x58
		internal EPuzzleState puzzleState; // 0x60
		internal StartPuzzle actionTask_inGame; // 0x68
	
		// Nested types
		internal enum EPuzzleState // TypeDefIndex: 14683
		{
			PLAYING = 0,
			WIN = 1,
			LOSE = 2
		}
	
		// Constructors
		public WorldPuzzle(); // 0x0000000181989130-0x0000000181989190
	
		// Methods
		public override void MStart(); // 0x0000000181988FA0-0x0000000181989070
		public override void MUpdate(); // 0x0000000180373240-0x0000000180373250
		internal virtual void InitializePuzzle(); // 0x0000000181988CA0-0x0000000181988ED0
		internal virtual void StartPuzzle(); // 0x0000000181989100-0x0000000181989130
		internal void QuitPuzzle(); // 0x000000018197E200-0x000000018197E240
		internal virtual void ResetPuzzle(); // 0x00000001803774A0-0x00000001803774B0
		internal virtual void CompletePuzzle(); // 0x0000000181988B00-0x0000000181988B20
		internal virtual void FailPuzzle(); // 0x0000000181988B60-0x0000000181988B80
		internal virtual void EndPuzzle(); // 0x0000000181988B20-0x0000000181988B60
		protected virtual void ClosePuzzle(); // 0x00000001819888A0-0x00000001819889E0
	}
}
