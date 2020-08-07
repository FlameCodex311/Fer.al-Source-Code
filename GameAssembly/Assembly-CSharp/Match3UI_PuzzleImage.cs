/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class Match3UI_PuzzleImage : MonoBehaviour // TypeDefIndex: 10676
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Image _puzzleGraphic; // 0x20
	private Material _puzzleMat; // 0x28
	private Match3AchievementPuzzle _puzzle; // 0x30
	private float[] _puzzlePieceStates; // 0x38
	private bool _isDirty; // 0x40
	private int _puzzleIndex; // 0x44

	// Properties
	private Match3AchievementRewardController RewardController { get; } // 0x00000001807E6670-0x00000001807E66D0 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass9_0 // TypeDefIndex: 10677
	{
		// Fields
		public Match3UI_PuzzleImage <>4__this; // 0x10
		public int inPuzzlePieceIndex; // 0x18

		// Constructors
		public <>c__DisplayClass9_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal float <AtomEvent_OnPuzzlePieceRedeemed>b__0(); // 0x00000001807F1310-0x00000001807F1360
		internal void <AtomEvent_OnPuzzlePieceRedeemed>b__1(float state); // 0x00000001807F1360-0x00000001807F13B0
		internal void <AtomEvent_OnPuzzlePieceRedeemed>b__2(); // 0x00000001807F13B0-0x00000001807F13D0
	}

	// Constructors
	public Match3UI_PuzzleImage(); // 0x00000001807E6620-0x00000001807E6670

	// Methods
	public void Setup(Match3AchievementPuzzle inPuzzle, int inPuzzleIndex); // 0x00000001807E6300-0x00000001807E6490
	public void AtomEvent_OnPuzzlePieceRedeemed(int inPuzzleIndex, int inPuzzlePieceIndex); // 0x00000001807E5F00-0x00000001807E6070
	private void RefreshAllPieces(); // 0x00000001807E6070-0x00000001807E6300
	private void Update(); // 0x00000001807E65C0-0x00000001807E6620
	private void UpdateMaterial(); // 0x00000001807E6490-0x00000001807E65C0
}

