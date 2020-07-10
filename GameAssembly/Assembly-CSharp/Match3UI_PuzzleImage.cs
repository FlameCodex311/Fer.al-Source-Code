/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Match3UI_PuzzleImage : MonoBehaviour // TypeDefIndex: 13011
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Image _puzzleGraphic; // 0x20
	private Material _puzzleMat; // 0x28
	private Match3AchievementPuzzle _puzzle; // 0x30
	private float[] _puzzlePieceStates; // 0x38
	private bool _isDirty; // 0x40
	private int _puzzleIndex; // 0x44

	// Properties
	private Match3AchievementRewardController RewardController { get; } // 0x00000001810A9EB0-0x00000001810A9F10 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass9_0 // TypeDefIndex: 13012
	{
		// Fields
		public Match3UI_PuzzleImage <>4__this; // 0x10
		public int inPuzzlePieceIndex; // 0x18

		// Constructors
		public <>c__DisplayClass9_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal float <AtomEvent_OnPuzzlePieceRedeemed>b__0(); // 0x00000001810BD8F0-0x00000001810BD940
		internal void <AtomEvent_OnPuzzlePieceRedeemed>b__1(float state); // 0x00000001810BD940-0x00000001810BD990
		internal void <AtomEvent_OnPuzzlePieceRedeemed>b__2(); // 0x00000001810BD990-0x00000001810BD9B0
	}

	// Constructors
	public Match3UI_PuzzleImage(); // 0x00000001810A9E60-0x00000001810A9EB0

	// Methods
	public void Setup(Match3AchievementPuzzle inPuzzle, int inPuzzleIndex); // 0x00000001810A9B30-0x00000001810A9CD0
	public void AtomEvent_OnPuzzlePieceRedeemed(int inPuzzleIndex, int inPuzzlePieceIndex); // 0x00000001810A9720-0x00000001810A9890
	private void RefreshAllPieces(); // 0x00000001810A9890-0x00000001810A9B30
	private void Update(); // 0x00000001810A9E00-0x00000001810A9E60
	private void UpdateMaterial(); // 0x00000001810A9CD0-0x00000001810A9E00
}

